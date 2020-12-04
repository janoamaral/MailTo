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
    public partial class frmServerData : Form
    {
        public SmtpConfig serverConfig = new SmtpConfig();

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
            if (txtEmail.Text.Length > 0 && txtServer.Text.Length > 0 && txtPassword.Text.Length > 0 && txtUsername.Text.Length > 0)
            {
                serverConfig.ProveedorId = cmbTipoServidor.SelectedIndex;
                serverConfig.ProveedorNombre = cmbTipoServidor.GetItemText(cmbTipoServidor.SelectedItem);
                serverConfig.Email = txtEmail.Text;
                serverConfig.SmtpHost = txtServer.Text;
                serverConfig.Puerto = Convert.ToInt16(nmPuerto.Value);
                serverConfig.SSL = chkSSL.Checked;
                serverConfig.Username = txtUsername.Text;
                serverConfig.Password = txtPassword.Text;


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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (cmbTipoServidor.SelectedIndex != 1)
            {
                txtUsername.Text = txtEmail.Text;
            }
        }

        public void PutData(SmtpConfig smtpConfig)
        {
            cmbTipoServidor.SelectedIndex = smtpConfig.ProveedorId;
            txtEmail.Text = smtpConfig.Email;
            txtServer.Text = smtpConfig.SmtpHost;
            nmPuerto.Value = smtpConfig.Puerto;
            chkSSL.Checked = smtpConfig.SSL;
            txtUsername.Text = smtpConfig.Username;
            txtPassword.Text = smtpConfig.Password;
        }
    }
}
