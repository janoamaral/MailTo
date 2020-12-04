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
        public frmMain()
        {
            InitializeComponent();

           
            string[] arguments = Environment.GetCommandLineArgs();
            if (arguments.Length > 1)
            {
                // TODO: Procesar mailto
                ListViewItem itm = new ListViewItem();
                itm.Text = arguments[0];
                lst.Items.Add(itm);
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

        public void NuevoMensaje(string[] args)
        {
            if (args.Length > 0)
            {
                ListViewItem itm = new ListViewItem();
                itm.Text = args[0];
                lst.Items.Add(itm);
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

                GuardarServidores();
            }
        }

        /// <summary>
        /// Guarda la configuración de los servidores
        /// </summary>
        private void GuardarServidores()
        {
            Properties.Settings.Default.Servers.Clear();
            foreach (ListViewItem itm in lstServidores.Items)
            {
                SmtpConfig serverConfig = new SmtpConfig();
                serverConfig = (SmtpConfig)itm.Tag;
                Properties.Settings.Default.Servers.Add(serverConfig.ToString());
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
                }
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadServidores();
        }

        private void btnServidorEliminar_Click(object sender, EventArgs e)
        {
            if (lstServidores.SelectedItems.Count == 1)
            {
                lstServidores.Items.Remove(lstServidores.SelectedItems[0]);
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
            }
        }

        private void btnConfiguracionGuardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EmailPrueba = txtConfigMailPrueba.Text;
            Properties.Settings.Default.Save();
        }
    }
}
