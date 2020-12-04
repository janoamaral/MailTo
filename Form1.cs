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
            ListViewItem itm = new ListViewItem();
            itm.Text = arguments[0];
            lst.Items.Add(itm);
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
            }
        }
    }
}
