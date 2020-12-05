
namespace MailTo
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tabList = new System.Windows.Forms.TabPage();
            this.lst = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.btnMailEnviar = new System.Windows.Forms.ToolStripButton();
            this.tabServers = new System.Windows.Forms.TabPage();
            this.lstServidores = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnServidorAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnServidorEditar = new System.Windows.Forms.ToolStripButton();
            this.btnServidorPrueba = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnServidorEliminar = new System.Windows.Forms.ToolStripButton();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConfigMailPrueba = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConfigMailRespuesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfigNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnConfiguracionGuardar = new System.Windows.Forms.ToolStripButton();
            this.cron = new System.Windows.Forms.Timer(this.components);
            this.pb = new System.Windows.Forms.ToolStripProgressBar();
            this.btnMailPausar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMailDetener = new System.Windows.Forms.ToolStripButton();
            this.btnMailLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.tabContainer.SuspendLayout();
            this.tabList.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.tabServers.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(96, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pb,
            this.lblStatus});
            this.statusbar.Location = new System.Drawing.Point(0, 428);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(800, 22);
            this.statusbar.SizingGrip = false;
            this.statusbar.TabIndex = 1;
            this.statusbar.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.tabList);
            this.tabContainer.Controls.Add(this.tabServers);
            this.tabContainer.Controls.Add(this.tabConfig);
            this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainer.Location = new System.Drawing.Point(0, 24);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(800, 404);
            this.tabContainer.TabIndex = 3;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.lst);
            this.tabList.Controls.Add(this.toolbar);
            this.tabList.Location = new System.Drawing.Point(4, 22);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(792, 378);
            this.tabList.TabIndex = 0;
            this.tabList.Text = "Lista envío";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // lst
            // 
            this.lst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10});
            this.lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst.FullRowSelect = true;
            this.lst.GridLines = true;
            this.lst.HideSelection = false;
            this.lst.Location = new System.Drawing.Point(3, 28);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(786, 347);
            this.lst.TabIndex = 0;
            this.lst.UseCompatibleStateImageBehavior = false;
            this.lst.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Estado";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adjunto";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Destinatario";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 299;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Enviado desde";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 283;
            // 
            // toolbar
            // 
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMailEnviar,
            this.toolStripSeparator3,
            this.btnMailPausar,
            this.btnMailDetener,
            this.toolStripSeparator2,
            this.btnMailLimpiar});
            this.toolbar.Location = new System.Drawing.Point(3, 3);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(786, 25);
            this.toolbar.TabIndex = 3;
            this.toolbar.Text = "toolStrip1";
            // 
            // btnMailEnviar
            // 
            this.btnMailEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnMailEnviar.Image")));
            this.btnMailEnviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMailEnviar.Name = "btnMailEnviar";
            this.btnMailEnviar.Size = new System.Drawing.Size(59, 22);
            this.btnMailEnviar.Text = "Enviar";
            this.btnMailEnviar.Click += new System.EventHandler(this.btnMailEnviar_Click);
            // 
            // tabServers
            // 
            this.tabServers.Controls.Add(this.lstServidores);
            this.tabServers.Controls.Add(this.toolStrip1);
            this.tabServers.Location = new System.Drawing.Point(4, 22);
            this.tabServers.Name = "tabServers";
            this.tabServers.Padding = new System.Windows.Forms.Padding(3);
            this.tabServers.Size = new System.Drawing.Size(792, 378);
            this.tabServers.TabIndex = 1;
            this.tabServers.Text = "Servidores SMTP";
            this.tabServers.UseVisualStyleBackColor = true;
            // 
            // lstServidores
            // 
            this.lstServidores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstServidores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstServidores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstServidores.FullRowSelect = true;
            this.lstServidores.HideSelection = false;
            this.lstServidores.Location = new System.Drawing.Point(3, 28);
            this.lstServidores.Name = "lstServidores";
            this.lstServidores.Size = new System.Drawing.Size(786, 347);
            this.lstServidores.TabIndex = 3;
            this.lstServidores.UseCompatibleStateImageBehavior = false;
            this.lstServidores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tipo";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 360;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SMTP";
            this.columnHeader7.Width = 216;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Puerto";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "SSL";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnServidorAgregar,
            this.btnServidorEditar,
            this.btnServidorPrueba,
            this.toolStripSeparator1,
            this.btnServidorEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnServidorAgregar
            // 
            this.btnServidorAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnServidorAgregar.Image")));
            this.btnServidorAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnServidorAgregar.Name = "btnServidorAgregar";
            this.btnServidorAgregar.Size = new System.Drawing.Size(69, 22);
            this.btnServidorAgregar.Text = "Agregar";
            this.btnServidorAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnServidorEditar
            // 
            this.btnServidorEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnServidorEditar.Image")));
            this.btnServidorEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnServidorEditar.Name = "btnServidorEditar";
            this.btnServidorEditar.Size = new System.Drawing.Size(57, 22);
            this.btnServidorEditar.Text = "Editar";
            this.btnServidorEditar.Click += new System.EventHandler(this.btnServidorEditar_Click);
            // 
            // btnServidorPrueba
            // 
            this.btnServidorPrueba.Image = ((System.Drawing.Image)(resources.GetObject("btnServidorPrueba.Image")));
            this.btnServidorPrueba.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnServidorPrueba.Name = "btnServidorPrueba";
            this.btnServidorPrueba.Size = new System.Drawing.Size(127, 22);
            this.btnServidorPrueba.Text = "Mensaje de prueba";
            this.btnServidorPrueba.ToolTipText = "Enviar un mensaje de prueba desde el servidor seleccionado";
            this.btnServidorPrueba.Click += new System.EventHandler(this.btnServidorPrueba_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnServidorEliminar
            // 
            this.btnServidorEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnServidorEliminar.Image")));
            this.btnServidorEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnServidorEliminar.Name = "btnServidorEliminar";
            this.btnServidorEliminar.Size = new System.Drawing.Size(142, 22);
            this.btnServidorEliminar.Text = "Eliminar seleccionado";
            this.btnServidorEliminar.Click += new System.EventHandler(this.btnServidorEliminar_Click);
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.groupBox2);
            this.tabConfig.Controls.Add(this.groupBox1);
            this.tabConfig.Controls.Add(this.toolStrip2);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(792, 378);
            this.tabConfig.TabIndex = 2;
            this.tabConfig.Text = "Configuración";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConfigMailPrueba);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 172);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistema";
            // 
            // txtConfigMailPrueba
            // 
            this.txtConfigMailPrueba.Location = new System.Drawing.Point(141, 31);
            this.txtConfigMailPrueba.Name = "txtConfigMailPrueba";
            this.txtConfigMailPrueba.Size = new System.Drawing.Size(582, 20);
            this.txtConfigMailPrueba.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección de prueba";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConfigMailRespuesta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtConfigNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración de remitente";
            // 
            // txtConfigMailRespuesta
            // 
            this.txtConfigMailRespuesta.Location = new System.Drawing.Point(141, 70);
            this.txtConfigMailRespuesta.Name = "txtConfigMailRespuesta";
            this.txtConfigMailRespuesta.Size = new System.Drawing.Size(582, 20);
            this.txtConfigMailRespuesta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dirección de respuesta";
            // 
            // txtConfigNombre
            // 
            this.txtConfigNombre.Location = new System.Drawing.Point(141, 35);
            this.txtConfigNombre.Name = "txtConfigNombre";
            this.txtConfigNombre.Size = new System.Drawing.Size(582, 20);
            this.txtConfigNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Su nombre";
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfiguracionGuardar});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(786, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnConfiguracionGuardar
            // 
            this.btnConfiguracionGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracionGuardar.Image")));
            this.btnConfiguracionGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfiguracionGuardar.Name = "btnConfiguracionGuardar";
            this.btnConfiguracionGuardar.Size = new System.Drawing.Size(146, 22);
            this.btnConfiguracionGuardar.Text = "Guardar configuración";
            this.btnConfiguracionGuardar.Click += new System.EventHandler(this.btnConfiguracionGuardar_Click);
            // 
            // pb
            // 
            this.pb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pb.MarqueeAnimationSpeed = 150;
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(100, 16);
            this.pb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb.Visible = false;
            // 
            // btnMailPausar
            // 
            this.btnMailPausar.Image = ((System.Drawing.Image)(resources.GetObject("btnMailPausar.Image")));
            this.btnMailPausar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMailPausar.Name = "btnMailPausar";
            this.btnMailPausar.Size = new System.Drawing.Size(62, 22);
            this.btnMailPausar.Text = "Pausar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMailDetener
            // 
            this.btnMailDetener.Image = ((System.Drawing.Image)(resources.GetObject("btnMailDetener.Image")));
            this.btnMailDetener.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMailDetener.Name = "btnMailDetener";
            this.btnMailDetener.Size = new System.Drawing.Size(68, 22);
            this.btnMailDetener.Text = "Detener";
            // 
            // btnMailLimpiar
            // 
            this.btnMailLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnMailLimpiar.Image")));
            this.btnMailLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMailLimpiar.Name = "btnMailLimpiar";
            this.btnMailLimpiar.Size = new System.Drawing.Size(159, 22);
            this.btnMailLimpiar.Text = "Eliminar la lista de envíos";
            this.btnMailLimpiar.Click += new System.EventHandler(this.btnMailLimpiar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabContainer);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailTo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.tabContainer.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            this.tabList.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.tabServers.ResumeLayout(false);
            this.tabServers.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.ListView lst;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabServers;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton btnMailEnviar;
        private System.Windows.Forms.ListView lstServidores;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnServidorAgregar;
        private System.Windows.Forms.ToolStripButton btnServidorEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnServidorEliminar;
        private System.Windows.Forms.TextBox txtConfigMailPrueba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnConfiguracionGuardar;
        private System.Windows.Forms.ToolStripButton btnServidorPrueba;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConfigMailRespuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfigNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        public System.Windows.Forms.Timer cron;
        private System.Windows.Forms.ToolStripProgressBar pb;
        private System.Windows.Forms.ToolStripButton btnMailPausar;
        private System.Windows.Forms.ToolStripButton btnMailDetener;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnMailLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

