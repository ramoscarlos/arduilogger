namespace Arduino_Logger
{
    partial class frmArduiLogger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArduiLogger));
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConectar = new System.Windows.Forms.ToolStripMenuItem();
            this.mss1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuControl = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPausar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDetener = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.sta = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsm = new System.Windows.Forms.ToolStrip();
            this.tsbConectar = new System.Windows.Forms.ToolStripButton();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbPausa = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pnlConfiguracion = new System.Windows.Forms.Panel();
            this.cboPuerto = new System.Windows.Forms.ComboBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.cboBaudios = new System.Windows.Forms.ComboBox();
            this.lblBaudios = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.mnu.SuspendLayout();
            this.sta.SuspendLayout();
            this.tsm.SuspendLayout();
            this.pnlConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuControl,
            this.mnuAyuda});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(294, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConectar,
            this.mss1,
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(55, 20);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mnuConectar
            // 
            this.mnuConectar.Image = ((System.Drawing.Image)(resources.GetObject("mnuConectar.Image")));
            this.mnuConectar.Name = "mnuConectar";
            this.mnuConectar.Size = new System.Drawing.Size(152, 22);
            this.mnuConectar.Text = "Conectar";
            this.mnuConectar.Click += new System.EventHandler(this.mnuConectar_Click);
            // 
            // mss1
            // 
            this.mss1.Name = "mss1";
            this.mss1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Image = ((System.Drawing.Image)(resources.GetObject("mnuSalir.Image")));
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(152, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuControl
            // 
            this.mnuControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIniciar,
            this.mnuPausar,
            this.mnuDetener});
            this.mnuControl.Name = "mnuControl";
            this.mnuControl.Size = new System.Drawing.Size(54, 20);
            this.mnuControl.Text = "Control";
            // 
            // mnuIniciar
            // 
            this.mnuIniciar.Image = ((System.Drawing.Image)(resources.GetObject("mnuIniciar.Image")));
            this.mnuIniciar.Name = "mnuIniciar";
            this.mnuIniciar.Size = new System.Drawing.Size(176, 22);
            this.mnuIniciar.Text = "Iniciar";
            this.mnuIniciar.Click += new System.EventHandler(this.mnuIniciar_Click);
            // 
            // mnuPausar
            // 
            this.mnuPausar.Image = ((System.Drawing.Image)(resources.GetObject("mnuPausar.Image")));
            this.mnuPausar.Name = "mnuPausar";
            this.mnuPausar.Size = new System.Drawing.Size(176, 22);
            this.mnuPausar.Text = "Pausar";
            this.mnuPausar.Click += new System.EventHandler(this.mnuPausar_Click);
            // 
            // mnuDetener
            // 
            this.mnuDetener.Image = ((System.Drawing.Image)(resources.GetObject("mnuDetener.Image")));
            this.mnuDetener.Name = "mnuDetener";
            this.mnuDetener.Size = new System.Drawing.Size(176, 22);
            this.mnuDetener.Text = "Detener/desconectar";
            this.mnuDetener.Click += new System.EventHandler(this.mnuDetener_Click);
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcercaDe});
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(50, 20);
            this.mnuAyuda.Text = "Ayuda";
            // 
            // mnuAcercaDe
            // 
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Size = new System.Drawing.Size(152, 22);
            this.mnuAcercaDe.Text = "Acerca de";
            this.mnuAcercaDe.Click += new System.EventHandler(this.mnuAcercaDe_Click);
            // 
            // sta
            // 
            this.sta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.sta.Location = new System.Drawing.Point(0, 253);
            this.sta.Name = "sta";
            this.sta.Size = new System.Drawing.Size(294, 22);
            this.sta.SizingGrip = false;
            this.sta.TabIndex = 1;
            this.sta.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 17);
            this.lblEstado.Text = "Estado";
            // 
            // tsm
            // 
            this.tsm.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConectar,
            this.tss1,
            this.tsbLimpiar,
            this.tsbGuardar,
            this.toolStripSeparator1,
            this.tsbPlay,
            this.tsbPausa,
            this.tsbStop,
            this.tsbSalir});
            this.tsm.Location = new System.Drawing.Point(0, 24);
            this.tsm.Name = "tsm";
            this.tsm.Size = new System.Drawing.Size(294, 25);
            this.tsm.TabIndex = 2;
            this.tsm.Text = "toolStrip1";
            // 
            // tsbConectar
            // 
            this.tsbConectar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConectar.Image = ((System.Drawing.Image)(resources.GetObject("tsbConectar.Image")));
            this.tsbConectar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConectar.Name = "tsbConectar";
            this.tsbConectar.Size = new System.Drawing.Size(23, 22);
            this.tsbConectar.Text = "Conectar con Arduino";
            this.tsbConectar.Click += new System.EventHandler(this.tsbConectar_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLimpiar
            // 
            this.tsbLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tsbLimpiar.Image")));
            this.tsbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLimpiar.Name = "tsbLimpiar";
            this.tsbLimpiar.Size = new System.Drawing.Size(23, 22);
            this.tsbLimpiar.Text = "Limpiar registro";
            this.tsbLimpiar.Click += new System.EventHandler(this.tsbLimpiar_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Text = "Guardar registro";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = ((System.Drawing.Image)(resources.GetObject("tsbPlay.Image")));
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(23, 22);
            this.tsbPlay.Text = "Comenzar registro";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // tsbPausa
            // 
            this.tsbPausa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPausa.Image = ((System.Drawing.Image)(resources.GetObject("tsbPausa.Image")));
            this.tsbPausa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPausa.Name = "tsbPausa";
            this.tsbPausa.Size = new System.Drawing.Size(23, 22);
            this.tsbPausa.Text = "Pausar registro";
            this.tsbPausa.Click += new System.EventHandler(this.tsbPausa_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbStop.Image")));
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(23, 22);
            this.tsbStop.Text = "Detener registro / Desconectar";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(23, 22);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtLog.Location = new System.Drawing.Point(0, 49);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(294, 204);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "Algún texto de prueba.";
            // 
            // pnlConfiguracion
            // 
            this.pnlConfiguracion.Controls.Add(this.cboPuerto);
            this.pnlConfiguracion.Controls.Add(this.lblPuerto);
            this.pnlConfiguracion.Controls.Add(this.cboBaudios);
            this.pnlConfiguracion.Controls.Add(this.lblBaudios);
            this.pnlConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfiguracion.Location = new System.Drawing.Point(0, 49);
            this.pnlConfiguracion.Name = "pnlConfiguracion";
            this.pnlConfiguracion.Size = new System.Drawing.Size(294, 204);
            this.pnlConfiguracion.TabIndex = 4;
            // 
            // cboPuerto
            // 
            this.cboPuerto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPuerto.FormattingEnabled = true;
            this.cboPuerto.Location = new System.Drawing.Point(144, 118);
            this.cboPuerto.Name = "cboPuerto";
            this.cboPuerto.Size = new System.Drawing.Size(135, 27);
            this.cboPuerto.TabIndex = 3;
            // 
            // lblPuerto
            // 
            this.lblPuerto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuerto.Location = new System.Drawing.Point(6, 88);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(274, 27);
            this.lblPuerto.TabIndex = 2;
            this.lblPuerto.Text = "Puerto:";
            // 
            // cboBaudios
            // 
            this.cboBaudios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBaudios.FormattingEnabled = true;
            this.cboBaudios.Location = new System.Drawing.Point(144, 48);
            this.cboBaudios.Name = "cboBaudios";
            this.cboBaudios.Size = new System.Drawing.Size(137, 27);
            this.cboBaudios.TabIndex = 1;
            // 
            // lblBaudios
            // 
            this.lblBaudios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaudios.Location = new System.Drawing.Point(6, 18);
            this.lblBaudios.Name = "lblBaudios";
            this.lblBaudios.Size = new System.Drawing.Size(273, 27);
            this.lblBaudios.TabIndex = 0;
            this.lblBaudios.Text = "Velocidad de transmisión:";
            this.lblBaudios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sfd
            // 
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_FileOk);
            // 
            // frmArduinoLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 275);
            this.Controls.Add(this.pnlConfiguracion);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.tsm);
            this.Controls.Add(this.sta);
            this.Controls.Add(this.mnu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu;
            this.Name = "frmArduinoLogger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Logger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArduinoLogger_FormClosing);
            this.Load += new System.EventHandler(this.frmArduinoLogger_Load);
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.sta.ResumeLayout(false);
            this.sta.PerformLayout();
            this.tsm.ResumeLayout(false);
            this.tsm.PerformLayout();
            this.pnlConfiguracion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.StatusStrip sta;
        private System.Windows.Forms.ToolStrip tsm;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDe;
        private System.Windows.Forms.ToolStripSeparator mss1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripButton tsbPausa;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuConectar;
        private System.Windows.Forms.ToolStripButton tsbConectar;
        private System.Windows.Forms.Panel pnlConfiguracion;
        private System.Windows.Forms.ComboBox cboBaudios;
        private System.Windows.Forms.Label lblBaudios;
        private System.Windows.Forms.ComboBox cboPuerto;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.ToolStripMenuItem mnuControl;
        private System.Windows.Forms.ToolStripMenuItem mnuIniciar;
        private System.Windows.Forms.ToolStripMenuItem mnuPausar;
        private System.Windows.Forms.ToolStripMenuItem mnuDetener;
        private System.Windows.Forms.ToolStripButton tsbLimpiar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

