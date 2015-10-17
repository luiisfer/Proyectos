namespace WindowsFormsApplication1
{
    partial class frmInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacion));
            this.pbMostrarPelicula = new System.Windows.Forms.PictureBox();
            this.TituloPeli = new System.Windows.Forms.Label();
            this.NmbPeli = new System.Windows.Forms.Label();
            this.MstCategoria = new System.Windows.Forms.Label();
            this.Catego = new System.Windows.Forms.Label();
            this.MstIdioma = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.cmbBxHora = new System.Windows.Forms.ComboBox();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.MstSubtitu = new System.Windows.Forms.Label();
            this.Subtitu = new System.Windows.Forms.Label();
            this.MstCosto = new System.Windows.Forms.Label();
            this.Costo = new System.Windows.Forms.Label();
            this.grbVideo = new System.Windows.Forms.GroupBox();
            this.lblVideo = new System.Windows.Forms.Label();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.lblclasificacion = new System.Windows.Forms.Label();
            this.lblClasi = new System.Windows.Forms.Label();
            this.msbarra = new System.Windows.Forms.MenuStrip();
            this.tsmiAtras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnreservarPelicula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarPelicula)).BeginInit();
            this.grbInfo.SuspendLayout();
            this.grbVideo.SuspendLayout();
            this.msbarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMostrarPelicula
            // 
            this.pbMostrarPelicula.Location = new System.Drawing.Point(40, 109);
            this.pbMostrarPelicula.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pbMostrarPelicula.Name = "pbMostrarPelicula";
            this.pbMostrarPelicula.Size = new System.Drawing.Size(256, 383);
            this.pbMostrarPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMostrarPelicula.TabIndex = 11;
            this.pbMostrarPelicula.TabStop = false;
            // 
            // TituloPeli
            // 
            this.TituloPeli.AutoSize = true;
            this.TituloPeli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloPeli.Location = new System.Drawing.Point(27, 23);
            this.TituloPeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloPeli.Name = "TituloPeli";
            this.TituloPeli.Size = new System.Drawing.Size(53, 19);
            this.TituloPeli.TabIndex = 12;
            this.TituloPeli.Text = "Titulo:";
           
            // 
            // NmbPeli
            // 
            this.NmbPeli.AutoSize = true;
            this.NmbPeli.Location = new System.Drawing.Point(27, 65);
            this.NmbPeli.Name = "NmbPeli";
            this.NmbPeli.Size = new System.Drawing.Size(58, 19);
            this.NmbPeli.TabIndex = 13;
            this.NmbPeli.Text = "NPelicu";
            // 
            // MstCategoria
            // 
            this.MstCategoria.AutoSize = true;
            this.MstCategoria.Location = new System.Drawing.Point(27, 171);
            this.MstCategoria.Name = "MstCategoria";
            this.MstCategoria.Size = new System.Drawing.Size(90, 19);
            this.MstCategoria.TabIndex = 15;
            this.MstCategoria.Text = "CatePelicula";
            // 
            // Catego
            // 
            this.Catego.AutoSize = true;
            this.Catego.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catego.Location = new System.Drawing.Point(27, 129);
            this.Catego.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Catego.Name = "Catego";
            this.Catego.Size = new System.Drawing.Size(78, 19);
            this.Catego.TabIndex = 14;
            this.Catego.Text = "Categoria:";
            // 
            // MstIdioma
            // 
            this.MstIdioma.AutoSize = true;
            this.MstIdioma.Location = new System.Drawing.Point(31, 269);
            this.MstIdioma.Name = "MstIdioma";
            this.MstIdioma.Size = new System.Drawing.Size(76, 19);
            this.MstIdioma.TabIndex = 17;
            this.MstIdioma.Text = "IdiPelicula";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(31, 227);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(60, 19);
            this.lblIdioma.TabIndex = 16;
            this.lblIdioma.Text = "Idioma:";
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.cmbBxHora);
            this.grbInfo.Controls.Add(this.lblHoraFinal);
            this.grbInfo.Controls.Add(this.lblHoraInicio);
            this.grbInfo.Controls.Add(this.MstSubtitu);
            this.grbInfo.Controls.Add(this.Subtitu);
            this.grbInfo.Controls.Add(this.MstCosto);
            this.grbInfo.Controls.Add(this.Costo);
            this.grbInfo.Controls.Add(this.TituloPeli);
            this.grbInfo.Controls.Add(this.MstIdioma);
            this.grbInfo.Controls.Add(this.NmbPeli);
            this.grbInfo.Controls.Add(this.lblIdioma);
            this.grbInfo.Controls.Add(this.Catego);
            this.grbInfo.Controls.Add(this.MstCategoria);
            this.grbInfo.Location = new System.Drawing.Point(383, 130);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(380, 395);
            this.grbInfo.TabIndex = 18;
            this.grbInfo.TabStop = false;
            // 
            // cmbBxHora
            // 
            this.cmbBxHora.FormattingEnabled = true;
            this.cmbBxHora.Location = new System.Drawing.Point(39, 357);
            this.cmbBxHora.Name = "cmbBxHora";
            this.cmbBxHora.Size = new System.Drawing.Size(240, 27);
            this.cmbBxHora.TabIndex = 26;
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFinal.Location = new System.Drawing.Point(206, 322);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(82, 19);
            this.lblHoraFinal.TabIndex = 23;
            this.lblHoraFinal.Text = "Hora Final:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(35, 322);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(87, 19);
            this.lblHoraInicio.TabIndex = 22;
            this.lblHoraInicio.Text = "Hora Inicio:";
            // 
            // MstSubtitu
            // 
            this.MstSubtitu.AutoSize = true;
            this.MstSubtitu.Location = new System.Drawing.Point(206, 274);
            this.MstSubtitu.Name = "MstSubtitu";
            this.MstSubtitu.Size = new System.Drawing.Size(13, 19);
            this.MstSubtitu.TabIndex = 21;
            this.MstSubtitu.Text = "l";
            // 
            // Subtitu
            // 
            this.Subtitu.AutoSize = true;
            this.Subtitu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitu.Location = new System.Drawing.Point(202, 227);
            this.Subtitu.Name = "Subtitu";
            this.Subtitu.Size = new System.Drawing.Size(82, 19);
            this.Subtitu.TabIndex = 20;
            this.Subtitu.Text = "Subtitulos:";
            // 
            // MstCosto
            // 
            this.MstCosto.AutoSize = true;
            this.MstCosto.Location = new System.Drawing.Point(265, 27);
            this.MstCosto.Name = "MstCosto";
            this.MstCosto.Size = new System.Drawing.Size(29, 19);
            this.MstCosto.TabIndex = 19;
            this.MstCosto.Text = "lab";
            // 
            // Costo
            // 
            this.Costo.AutoSize = true;
            this.Costo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Costo.Location = new System.Drawing.Point(209, 27);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(51, 19);
            this.Costo.TabIndex = 18;
            this.Costo.Text = "Costo:";
            // 
            // grbVideo
            // 
            this.grbVideo.Controls.Add(this.lblVideo);
            this.grbVideo.Location = new System.Drawing.Point(820, 130);
            this.grbVideo.Name = "grbVideo";
            this.grbVideo.Size = new System.Drawing.Size(424, 365);
            this.grbVideo.TabIndex = 19;
            this.grbVideo.TabStop = false;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Location = new System.Drawing.Point(174, 142);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(51, 19);
            this.lblVideo.TabIndex = 0;
            this.lblVideo.Text = "VIDEO";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(46, 24);
            // 
            // lblclasificacion
            // 
            this.lblclasificacion.AutoSize = true;
            this.lblclasificacion.Location = new System.Drawing.Point(507, 81);
            this.lblclasificacion.Name = "lblclasificacion";
            this.lblclasificacion.Size = new System.Drawing.Size(13, 19);
            this.lblclasificacion.TabIndex = 22;
            this.lblclasificacion.Text = "l";
            // 
            // lblClasi
            // 
            this.lblClasi.AutoSize = true;
            this.lblClasi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasi.Location = new System.Drawing.Point(394, 81);
            this.lblClasi.Name = "lblClasi";
            this.lblClasi.Size = new System.Drawing.Size(92, 19);
            this.lblClasi.TabIndex = 24;
            this.lblClasi.Text = "Clasificacion";
            // 
            // msbarra
            // 
            this.msbarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAtras,
            this.tsmiMenuPrincipal,
            this.tsmiSalir});
            this.msbarra.Location = new System.Drawing.Point(0, 0);
            this.msbarra.Name = "msbarra";
            this.msbarra.Size = new System.Drawing.Size(1362, 31);
            this.msbarra.TabIndex = 26;
            // 
            // tsmiAtras
            // 
            this.tsmiAtras.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAtras.Image = global::WindowsFormsApplication1.Properties.Resources.atras;
            this.tsmiAtras.Name = "tsmiAtras";
            this.tsmiAtras.Size = new System.Drawing.Size(80, 27);
            this.tsmiAtras.Text = "Atras";
            // 
            // tsmiMenuPrincipal
            // 
            this.tsmiMenuPrincipal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiMenuPrincipal.Image = global::WindowsFormsApplication1.Properties.Resources.menu_principal;
            this.tsmiMenuPrincipal.Name = "tsmiMenuPrincipal";
            this.tsmiMenuPrincipal.Size = new System.Drawing.Size(158, 27);
            this.tsmiMenuPrincipal.Text = "Menu Principal";
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiSalir.Image = global::WindowsFormsApplication1.Properties.Resources.salir;
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(73, 27);
            this.tsmiSalir.Text = "Salir";
            // 
            // btnreservarPelicula
            // 
            this.btnreservarPelicula.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservarPelicula.Image = global::WindowsFormsApplication1.Properties.Resources.flecha_derecha;
            this.btnreservarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreservarPelicula.Location = new System.Drawing.Point(492, 531);
            this.btnreservarPelicula.Name = "btnreservarPelicula";
            this.btnreservarPelicula.Size = new System.Drawing.Size(110, 50);
            this.btnreservarPelicula.TabIndex = 51;
            this.btnreservarPelicula.Text = "Reservar Pelicula";
            this.btnreservarPelicula.UseVisualStyleBackColor = true;
            this.btnreservarPelicula.Click += new System.EventHandler(this.breservarPelicula_Click);
            // 
            // frmInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btnreservarPelicula);
            this.Controls.Add(this.msbarra);
            this.Controls.Add(this.lblClasi);
            this.Controls.Add(this.lblclasificacion);
            this.Controls.Add(this.grbVideo);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.pbMostrarPelicula);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "informacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.informacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarPelicula)).EndInit();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.grbVideo.ResumeLayout(false);
            this.grbVideo.PerformLayout();
            this.msbarra.ResumeLayout(false);
            this.msbarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbMostrarPelicula;
        private System.Windows.Forms.Label TituloPeli;
        private System.Windows.Forms.Label NmbPeli;
        private System.Windows.Forms.Label MstCategoria;
        private System.Windows.Forms.Label Catego;
        private System.Windows.Forms.Label MstIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.GroupBox grbVideo;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Label lblclasificacion;
        private System.Windows.Forms.Label MstCosto;
        private System.Windows.Forms.Label Costo;
        private System.Windows.Forms.Label MstSubtitu;
        private System.Windows.Forms.Label Subtitu;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblClasi;
        private System.Windows.Forms.ComboBox cmbBxHora;
        private System.Windows.Forms.MenuStrip msbarra;
        private System.Windows.Forms.ToolStripMenuItem tsmiAtras;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.Button btnreservarPelicula;
    }
}