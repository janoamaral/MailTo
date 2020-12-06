using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailTo.SRC;

namespace MailTo
{
    public partial class frmMain : Form
    {
        State state = new State();
        public frmMain()
        {
            InitializeComponent();
            NuevoMensaje(Environment.GetCommandLineArgs());

            if (Properties.Settings.Default.Servers == null)
            {
                Properties.Settings.Default.Servers = new System.Collections.Specialized.StringCollection();
            }

            if (Properties.Settings.Default.MailList == null)
            {
                Properties.Settings.Default.MailList = new System.Collections.Specialized.StringCollection();
            }
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmServerData frmServerData = new frmServerData();
            frmServerData.ResetServerForm();
            if (frmServerData.ShowDialog(this) == DialogResult.OK)
            {
                ListViewItem itm = new ListViewItem();
                itm.Text = frmServerData.serverConfig.ProveedorNombre;
                itm.SubItems.Add(frmServerData.serverConfig.Email);
                itm.SubItems.Add(frmServerData.serverConfig.SmtpHost);
                itm.SubItems.Add(frmServerData.serverConfig.Puerto.ToString());
                itm.SubItems.Add(frmServerData.serverConfig.SSL ? "SI" : "NO");
                itm.Tag = frmServerData.serverConfig;


                lstServidores.Items.Add(itm);
                state.AddServer(frmServerData.serverConfig);
                GuardarServidores();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadServidores();
            LoadMails();
            LoadSettings();
        }

        private void btnServidorEliminar_Click(object sender, EventArgs e)
        {
            if (lstServidores.SelectedItems.Count == 1)
            {
                lstServidores.Items.Remove(lstServidores.SelectedItems[0]);
            } else {
                MessageBox.Show("Debe seleccionar un servidor primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            GuardarServidores();
        }

        private void btnServidorEditar_Click(object sender, EventArgs e)
        {
            if (lstServidores.SelectedItems.Count == 1)
            {
                frmServerData frmServerData = new frmServerData();

                SmtpConfig serverConfig = new SmtpConfig();
                serverConfig = (SmtpConfig)lstServidores.SelectedItems[0].Tag;

                frmServerData.PutData(serverConfig);

                if (frmServerData.ShowDialog(this) == DialogResult.OK)
                {
                    lstServidores.SelectedItems[0].Text = frmServerData.serverConfig.ProveedorNombre;
                    lstServidores.SelectedItems[0].SubItems[1].Text =frmServerData.serverConfig.Email;
                    lstServidores.SelectedItems[0].SubItems[2].Text = frmServerData.serverConfig.SmtpHost;
                    lstServidores.SelectedItems[0].SubItems[3].Text = frmServerData.serverConfig.Puerto.ToString();
                    lstServidores.SelectedItems[0].SubItems[4].Text = frmServerData.serverConfig.SSL ? "SI" : "NO";
                    lstServidores.SelectedItems[0].Tag = frmServerData.serverConfig;

                    GuardarServidores();
                }
            } else
            {
                MessageBox.Show("Debe seleccionar un servidor primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConfiguracionGuardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EmailPrueba = txtConfigMailPrueba.Text;
            Properties.Settings.Default.Nombre = txtConfigNombre.Text;
            Properties.Settings.Default.DireccionRespuesta = txtConfigMailRespuesta.Text;
            Properties.Settings.Default.Save();
        }

        private void btnServidorPrueba_Click(object sender, EventArgs e)
        {
            if (lstServidores.SelectedItems.Count == 1 && txtConfigMailPrueba.Text.Length > 0)
            {
                Sender mail = new Sender((SmtpConfig)lstServidores.SelectedItems[0].Tag);
                mail.From = txtConfigNombre.Text;
                mail.Subject = "Prueba de recepción";
                mail.To = txtConfigMailPrueba.Text;
                mail.ReplyTo = txtConfigMailRespuesta.Text;
                mail.Body = "Esto es un mail de <b>PRUEBA</b>.";

                mail.Send();
            } else {
                MessageBox.Show("Debe seleccionar un servidor y tener cargada la dirección de prueba.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnMailEnviar_Click(object sender, EventArgs e)
        {
            if (lstServidores.Items.Count > 0 && lst.Items.Count > 0)
            {
                if (!state.QueueLoaded)
                {
                    ReQueueMessages();
                }
                cron.Enabled = true;
                lblStatus.Text = "Enviando...";
                pb.Visible = true;
            } else
            {
                MessageBox.Show("Debe cargar servidores SMTP y/o mails antes de enviar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnMailLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Va a eliminar toda la lista de correos. ¿Continuar?.", "MailTo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                lst.Items.Clear();
                Properties.Settings.Default.MailList.Clear();
                Properties.Settings.Default.Save();

            }
        }

        private void cron_Tick(object sender, EventArgs e)
        {
            state.SendNextMessage();
            if (state.Estado == 1)
            {
                Random random = new Random();
                // Enviar al azar entre 5 y 15 segundos de separación
                int proximoEnvio = random.Next(5000, 15000);
                cron.Interval = proximoEnvio;
                cron.Enabled = true;
                lblStatus.Text = "Enviando...";
                pb.Visible = true;
            } else
            {
                cron.Enabled = false;
                lblStatus.Text = "Detenido";
                pb.Visible = false;
            }
            
        }

        private void btnMailPausar_Click(object sender, EventArgs e)
        {
            cron.Enabled = false;
            state.Estado = 2;
            lblStatus.Text = "Pausado";
            pb.Visible = false;
        }




        /// <summary>
        /// Carga un mensaje a la lista desde la línea de comandos
        /// </summary>
        /// <param name="args">Argumentos de la línea de comandos</param>
        public void NuevoMensaje(string[] args)
        {
            if (args.Length > 0)
            {
                ArgParser argumentos = new ArgParser(args);
                Sender sender = new Sender();
                if (argumentos.Parse(ref sender) == 0)
                {
                    ListViewItem itm = new ListViewItem();
                    itm.Text = (lst.Items.Count + 1).ToString();
                    itm.SubItems.Add("BANDEJA SALIDA");
                    itm.SubItems.Add(sender.Attachment.Length > 0 ? "🔗" : "-");
                    itm.SubItems.Add(sender.To);
                    itm.SubItems.Add("N/A");
                    itm.Tag = sender;

                    sender.MessageID = lst.Items.Count;
                    GuardarMail(sender.Sent? 1 : 0, argumentos.RawCompose);

                    lst.Items.Add(itm);

                    state.AddMessage(sender);
                }
            }
        }

        /// <summary>
        /// Guarda el email en la configuración del programa.
        /// </summary>
        /// <param name="MessageID"></param>
        /// <param name="Message"></param>
        private void GuardarMail(int Sent, string Message)
        {
            Properties.Settings.Default.MailList.Add($"{Sent};{Message}");
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Carga la lista de email en la lista y prepara el envío
        /// </summary>
        private void LoadMails()
        {
            if (Properties.Settings.Default.MailList != null)
            {
                int i = 0;
                foreach (string mail in Properties.Settings.Default.MailList)
                {
                    ArgParser argumentos = new ArgParser();
                    Sender sender = new Sender();
                    if (argumentos.Parse(ref sender, mail.Substring(mail.IndexOf(';') >= 0 ? mail.IndexOf(';') : 0 )) == 0)
                    {
                        ListViewItem itm = new ListViewItem();
                        itm.Text = (lst.Items.Count + 1).ToString();
                        itm.SubItems.Add(mail.Substring(0,1) == "0"? "ENVIADO" : "BANDEJA SALIDA");
                        itm.SubItems.Add(sender.Attachment.Length > 0 ? "🔗" : "-");
                        itm.SubItems.Add(sender.To);
                        itm.SubItems.Add("N/A");
                        itm.Tag = sender;

                        sender.MessageID = i;
                        sender.Sent = mail.Substring(0, 1) == "0" ? true : false;

                        lst.Items.Add(itm);

                        if (mail.Substring(0,1) == "1") state.AddMessage(sender);
                        i++;
                    }
                }
            }
        }

        /// <summary>
        /// Guarda la configuración de los servidores
        /// </summary>
        private void GuardarServidores()
        {
            Properties.Settings.Default.Servers.Clear();
            state.ClearServers();
            foreach (ListViewItem itm in lstServidores.Items)
            {
                SmtpConfig serverConfig = new SmtpConfig();
                serverConfig = (SmtpConfig)itm.Tag;
                Properties.Settings.Default.Servers.Add(serverConfig.ToString());
                state.AddServer(serverConfig);
            }
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Carga los servidores a la lista
        /// </summary>
        private void LoadServidores()
        {
            if (Properties.Settings.Default.Servers != null)
            {
                foreach (string server in Properties.Settings.Default.Servers)
                {
                    SmtpConfig serverConfig = new SmtpConfig(server);
                    ListViewItem itm = new ListViewItem();
                    itm.Text = serverConfig.ProveedorNombre;
                    itm.SubItems.Add(serverConfig.Email);
                    itm.SubItems.Add(serverConfig.SmtpHost);
                    itm.SubItems.Add(serverConfig.Puerto.ToString());
                    itm.SubItems.Add(serverConfig.SSL ? "SI" : "NO");
                    itm.Tag = serverConfig;

                    lstServidores.Items.Add(itm);

                    state.AddServer(serverConfig);
                }
            }
        }

        /// <summary>
        /// Carga las configuraciones en los cuadros de texto.
        /// </summary>
        private void LoadSettings()
        {
            txtConfigMailPrueba.Text = Properties.Settings.Default.EmailPrueba;
            txtConfigMailRespuesta.Text = Properties.Settings.Default.DireccionRespuesta;
            txtConfigNombre.Text = Properties.Settings.Default.Nombre;
        }

        /// <summary>
        /// Actualiza el estado del mensaje.
        /// </summary>
        /// <param name="messageID">Index del ListViewItem del mensaje</param>
        /// <param name="status">Estado del envío</param>
        /// <param name="sendFrom">De que servidor se envío</param>
        public void ActualizarMensaje(int messageID, int status, string sendFrom)
        {
            lst.Items[messageID].SubItems[1].Text = status == 0 ? "ENVIADO" : "FALLO";
            lst.Items[messageID].SubItems[4].Text = sendFrom;
            Sender s = (Sender)lst.Items[messageID].Tag;
            s.Sent = status == 0 ? true : false;
           
            lst.Items[messageID].Tag = s;

            string raw = Properties.Settings.Default.MailList[messageID];
            Properties.Settings.Default.MailList[messageID] = $"{status};{raw.Substring(raw.IndexOf(';'))}";
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Vuelve a cargar los mensajes que no se enviaron en la lista para enviar
        /// </summary>
        private void ReQueueMessages()
        {
            foreach (ListViewItem itm in lst.Items)
            {
                Sender s = (Sender)itm.Tag;
                if (!s.Sent) state.AddMessage(s);
            }
        }

        /// <summary>
        /// Actualiza el texto del barra de estado.
        /// </summary>
        /// <param name="status"></param>
        public void ActualizarStatus(string status)
        {
            lblStatus.Text = status;
        }
    }
}
