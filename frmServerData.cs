using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailTo
{
    public partial class frmServerData : Form
    {
        public frmServerData()
        {
            InitializeComponent();
        }

        private void cmbTipoServidor_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbTipoServidor.SelectedIndex)
            {
                case 0:
                    SetGmailForm();
                    break;
                case 1:
                    ResetServerForm();
                    break;
            }
        }

        public void ResetServerForm()
        {
            txtEmail.Clear();
            txtServer.Clear();
            nmPuerto.Value = 465;
            chkSSL.Checked = false;
            txtUsername.Clear();
            txtPassword.Clear();
            cmbTipoServidor.SelectedIndex = 1;
            lnkActivarEnvio.Visible = false;
            lblDebe.Visible = false;
        }

        private void SetGmailForm()
        {
            txtServer.Text = "smtp.gmail.com";
            txtEmail.Text = "@gmail.com";
            nmPuerto.Value = 465;
            chkSSL.Checked = true;
            txtUsername.Clear();
            txtPassword.Clear();
            lblDebe.Visible = true;
            lnkActivarEnvio.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtServer.Text.Length > 0 && txtPassword.Text.Length > 0 && txtUsername.Text.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lnkActivarEnvio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://myaccount.google.com/lesssecureapps");
        }
    }
}
