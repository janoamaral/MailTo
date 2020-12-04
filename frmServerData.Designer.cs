
namespace MailTo
{
    partial class frmServerData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.cmbTipoServidor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmPuerto = new System.Windows.Forms.NumericUpDown();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lnkActivarEnvio = new System.Windows.Forms.LinkLabel();
            this.lblDebe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmPuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(232, 283);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 36);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSSL.Location = new System.Drawing.Point(262, 135);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(92, 17);
            this.chkSSL.TabIndex = 3;
            this.chkSSL.Text = "Requiere SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // cmbTipoServidor
            // 
            this.cmbTipoServidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoServidor.FormattingEnabled = true;
            this.cmbTipoServidor.Items.AddRange(new object[] {
            "Gmail",
            "Servidor propio"});
            this.cmbTipoServidor.Location = new System.Drawing.Point(97, 24);
            this.cmbTipoServidor.Name = "cmbTipoServidor";
            this.cmbTipoServidor.Size = new System.Drawing.Size(257, 21);
            this.cmbTipoServidor.TabIndex = 0;
            this.cmbTipoServidor.SelectedIndexChanged += new System.EventHandler(this.cmbTipoServidor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipo";
            // 
            // nmPuerto
            // 
            this.nmPuerto.Location = new System.Drawing.Point(97, 135);
            this.nmPuerto.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmPuerto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmPuerto.Name = "nmPuerto";
            this.nmPuerto.Size = new System.Drawing.Size(120, 20);
            this.nmPuerto.TabIndex = 2;
            this.nmPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmPuerto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(97, 211);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(257, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(97, 174);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(257, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña *";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(97, 97);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(257, 20);
            this.txtServer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usuario *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Puerto *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Servidor *";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(105, 296);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email *";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lnkActivarEnvio
            // 
            this.lnkActivarEnvio.AutoSize = true;
            this.lnkActivarEnvio.Location = new System.Drawing.Point(124, 250);
            this.lnkActivarEnvio.Name = "lnkActivarEnvio";
            this.lnkActivarEnvio.Size = new System.Drawing.Size(234, 13);
            this.lnkActivarEnvio.TabIndex = 16;
            this.lnkActivarEnvio.TabStop = true;
            this.lnkActivarEnvio.Text = "Permitir el acceso de aplicaciones poco seguras";
            this.lnkActivarEnvio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkActivarEnvio_LinkClicked);
            // 
            // lblDebe
            // 
            this.lblDebe.AutoSize = true;
            this.lblDebe.Location = new System.Drawing.Point(12, 250);
            this.lblDebe.Name = "lblDebe";
            this.lblDebe.Size = new System.Drawing.Size(114, 13);
            this.lblDebe.TabIndex = 7;
            this.lblDebe.Text = "Debe activar la opción";
            // 
            // frmServerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 334);
            this.Controls.Add(this.lnkActivarEnvio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkSSL);
            this.Controls.Add(this.cmbTipoServidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmPuerto);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblDebe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServerData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos del servidor";
            ((System.ComponentModel.ISupportInitialize)(this.nmPuerto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.ComboBox cmbTipoServidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmPuerto;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.LinkLabel lnkActivarEnvio;
        private System.Windows.Forms.Label lblDebe;
    }
}