namespace admin
{
    partial class frmingresarPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmingresarPelicula));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpfechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblfinal = new System.Windows.Forms.Label();
            this.dtpfechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblinicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlinkVideoPeli = new System.Windows.Forms.TextBox();
            this.lbllinkvideo = new System.Windows.Forms.Label();
            this.bcancelar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.beditar = new System.Windows.Forms.Button();
            this.ccategoriaPelicula = new System.Windows.Forms.ComboBox();
            this.txtpuntosBonificacion = new System.Windows.Forms.TextBox();
            this.lpuntosBonificacion = new System.Windows.Forms.Label();
            this.txtelencoPelicula = new System.Windows.Forms.TextBox();
            this.lelencoPelicula = new System.Windows.Forms.Label();
            this.lcategoriaPelicula = new System.Windows.Forms.Label();
            this.bseleccionarImagen = new System.Windows.Forms.Button();
            this.txtrutaImagen = new System.Windows.Forms.TextBox();
            this.pimagenPelicula = new System.Windows.Forms.PictureBox();
            this.bguardar = new System.Windows.Forms.Button();
            this.csubtitulo = new System.Windows.Forms.ComboBox();
            this.cidioma = new System.Windows.Forms.ComboBox();
            this.cclasificacionContenidos = new System.Windows.Forms.ComboBox();
            this.csalasCine = new System.Windows.Forms.ComboBox();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.lsubtitulo = new System.Windows.Forms.Label();
            this.lidioma = new System.Windows.Forms.Label();
            this.lclasificacion = new System.Windows.Forms.Label();
            this.lsalasCine = new System.Windows.Forms.Label();
            this.ldescuento = new System.Windows.Forms.Label();
            this.lcosto = new System.Windows.Forms.Label();
            this.lnombre = new System.Windows.Forms.Label();
            this.txtidPelicula = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimagenPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpfechaFinal);
            this.groupBox1.Controls.Add(this.lblfinal);
            this.groupBox1.Controls.Add(this.dtpfechaInicio);
            this.groupBox1.Controls.Add(this.lblinicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtlinkVideoPeli);
            this.groupBox1.Controls.Add(this.lbllinkvideo);
            this.groupBox1.Controls.Add(this.bcancelar);
            this.groupBox1.Controls.Add(this.beliminar);
            this.groupBox1.Controls.Add(this.beditar);
            this.groupBox1.Controls.Add(this.ccategoriaPelicula);
            this.groupBox1.Controls.Add(this.txtpuntosBonificacion);
            this.groupBox1.Controls.Add(this.lpuntosBonificacion);
            this.groupBox1.Controls.Add(this.txtelencoPelicula);
            this.groupBox1.Controls.Add(this.lelencoPelicula);
            this.groupBox1.Controls.Add(this.lcategoriaPelicula);
            this.groupBox1.Controls.Add(this.bseleccionarImagen);
            this.groupBox1.Controls.Add(this.txtrutaImagen);
            this.groupBox1.Controls.Add(this.pimagenPelicula);
            this.groupBox1.Controls.Add(this.bguardar);
            this.groupBox1.Controls.Add(this.csubtitulo);
            this.groupBox1.Controls.Add(this.cidioma);
            this.groupBox1.Controls.Add(this.cclasificacionContenidos);
            this.groupBox1.Controls.Add(this.csalasCine);
            this.groupBox1.Controls.Add(this.txtdescuento);
            this.groupBox1.Controls.Add(this.txtcosto);
            this.groupBox1.Controls.Add(this.txttitulo);
            this.groupBox1.Controls.Add(this.lsubtitulo);
            this.groupBox1.Controls.Add(this.lidioma);
            this.groupBox1.Controls.Add(this.lclasificacion);
            this.groupBox1.Controls.Add(this.lsalasCine);
            this.groupBox1.Controls.Add(this.ldescuento);
            this.groupBox1.Controls.Add(this.lcosto);
            this.groupBox1.Controls.Add(this.lnombre);
            this.groupBox1.Controls.Add(this.txtidPelicula);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 534);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles Pelicula";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpfechaFinal
            // 
            this.dtpfechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaFinal.Location = new System.Drawing.Point(342, 419);
            this.dtpfechaFinal.Name = "dtpfechaFinal";
            this.dtpfechaFinal.Size = new System.Drawing.Size(99, 27);
            this.dtpfechaFinal.TabIndex = 50;
            this.dtpfechaFinal.ValueChanged += new System.EventHandler(this.dtpfechaFinal_ValueChanged);
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(292, 425);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(44, 19);
            this.lblfinal.TabIndex = 49;
            this.lblfinal.Text = "Final:";
            // 
            // dtpfechaInicio
            // 
            this.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaInicio.Location = new System.Drawing.Point(193, 419);
            this.dtpfechaInicio.Name = "dtpfechaInicio";
            this.dtpfechaInicio.Size = new System.Drawing.Size(101, 27);
            this.dtpfechaInicio.TabIndex = 47;
            this.dtpfechaInicio.Value = new System.DateTime(2015, 9, 4, 0, 0, 0, 0);
            this.dtpfechaInicio.ValueChanged += new System.EventHandler(this.dtpfechaInicio_ValueChanged);
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Location = new System.Drawing.Point(140, 425);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(48, 19);
            this.lblinicio.TabIndex = 46;
            this.lblinicio.Text = "Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Asignacion de Fecha:";
            // 
            // txtlinkVideoPeli
            // 
            this.txtlinkVideoPeli.Location = new System.Drawing.Point(192, 363);
            this.txtlinkVideoPeli.Name = "txtlinkVideoPeli";
            this.txtlinkVideoPeli.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtlinkVideoPeli.Size = new System.Drawing.Size(236, 27);
            this.txtlinkVideoPeli.TabIndex = 43;
            // 
            // lbllinkvideo
            // 
            this.lbllinkvideo.AutoSize = true;
            this.lbllinkvideo.Location = new System.Drawing.Point(104, 366);
            this.lbllinkvideo.Name = "lbllinkvideo";
            this.lbllinkvideo.Size = new System.Drawing.Size(80, 19);
            this.lbllinkvideo.TabIndex = 44;
            this.lbllinkvideo.Text = "Link Video:";
            // 
            // bcancelar
            // 
            this.bcancelar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcancelar.Image = global::admin.Properties.Resources.cancelar;
            this.bcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bcancelar.Location = new System.Drawing.Point(404, 468);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(110, 50);
            this.bcancelar.TabIndex = 41;
            this.bcancelar.Text = "          Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // beliminar
            // 
            this.beliminar.Enabled = false;
            this.beliminar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.Image = global::admin.Properties.Resources.eliminar;
            this.beliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beliminar.Location = new System.Drawing.Point(288, 468);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(110, 50);
            this.beliminar.TabIndex = 40;
            this.beliminar.Text = "          Eliminar";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // beditar
            // 
            this.beditar.Enabled = false;
            this.beditar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beditar.Image = global::admin.Properties.Resources.editar1;
            this.beditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beditar.Location = new System.Drawing.Point(172, 468);
            this.beditar.Name = "beditar";
            this.beditar.Size = new System.Drawing.Size(110, 50);
            this.beditar.TabIndex = 39;
            this.beditar.Text = "          Editar";
            this.beditar.UseVisualStyleBackColor = true;
            this.beditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ccategoriaPelicula
            // 
            this.ccategoriaPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccategoriaPelicula.FormattingEnabled = true;
            this.ccategoriaPelicula.Items.AddRange(new object[] {
            "Animación",
            "Terror",
            "Drama",
            "Comedia",
            "Romance",
            "Thriller"});
            this.ccategoriaPelicula.Location = new System.Drawing.Point(193, 199);
            this.ccategoriaPelicula.Name = "ccategoriaPelicula";
            this.ccategoriaPelicula.Size = new System.Drawing.Size(236, 27);
            this.ccategoriaPelicula.TabIndex = 18;
            // 
            // txtpuntosBonificacion
            // 
            this.txtpuntosBonificacion.Location = new System.Drawing.Point(193, 331);
            this.txtpuntosBonificacion.Name = "txtpuntosBonificacion";
            this.txtpuntosBonificacion.Size = new System.Drawing.Size(236, 27);
            this.txtpuntosBonificacion.TabIndex = 24;
            // 
            // lpuntosBonificacion
            // 
            this.lpuntosBonificacion.AutoSize = true;
            this.lpuntosBonificacion.Location = new System.Drawing.Point(25, 331);
            this.lpuntosBonificacion.Name = "lpuntosBonificacion";
            this.lpuntosBonificacion.Size = new System.Drawing.Size(160, 19);
            this.lpuntosBonificacion.TabIndex = 35;
            this.lpuntosBonificacion.Text = "Puntos de Bonificación:";
            // 
            // txtelencoPelicula
            // 
            this.txtelencoPelicula.Location = new System.Drawing.Point(193, 232);
            this.txtelencoPelicula.Name = "txtelencoPelicula";
            this.txtelencoPelicula.Size = new System.Drawing.Size(236, 27);
            this.txtelencoPelicula.TabIndex = 19;
            // 
            // lelencoPelicula
            // 
            this.lelencoPelicula.AutoSize = true;
            this.lelencoPelicula.Location = new System.Drawing.Point(129, 240);
            this.lelencoPelicula.Name = "lelencoPelicula";
            this.lelencoPelicula.Size = new System.Drawing.Size(56, 19);
            this.lelencoPelicula.TabIndex = 29;
            this.lelencoPelicula.Text = "Elenco:";
            // 
            // lcategoriaPelicula
            // 
            this.lcategoriaPelicula.AutoSize = true;
            this.lcategoriaPelicula.Location = new System.Drawing.Point(109, 202);
            this.lcategoriaPelicula.Name = "lcategoriaPelicula";
            this.lcategoriaPelicula.Size = new System.Drawing.Size(76, 19);
            this.lcategoriaPelicula.TabIndex = 27;
            this.lcategoriaPelicula.Text = "Categoría:";
            // 
            // bseleccionarImagen
            // 
            this.bseleccionarImagen.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bseleccionarImagen.Image = global::admin.Properties.Resources.upload_icon;
            this.bseleccionarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bseleccionarImagen.Location = new System.Drawing.Point(574, 305);
            this.bseleccionarImagen.Name = "bseleccionarImagen";
            this.bseleccionarImagen.Size = new System.Drawing.Size(110, 50);
            this.bseleccionarImagen.TabIndex = 25;
            this.bseleccionarImagen.Text = "Seleccion Imagen";
            this.bseleccionarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bseleccionarImagen.UseVisualStyleBackColor = true;
            this.bseleccionarImagen.Click += new System.EventHandler(this.bseleccionarImagen_Click);
            // 
            // txtrutaImagen
            // 
            this.txtrutaImagen.Location = new System.Drawing.Point(486, 272);
            this.txtrutaImagen.Name = "txtrutaImagen";
            this.txtrutaImagen.Size = new System.Drawing.Size(285, 27);
            this.txtrutaImagen.TabIndex = 25;
            this.txtrutaImagen.Visible = false;
            // 
            // pimagenPelicula
            // 
            this.pimagenPelicula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pimagenPelicula.Location = new System.Drawing.Point(514, 27);
            this.pimagenPelicula.Name = "pimagenPelicula";
            this.pimagenPelicula.Size = new System.Drawing.Size(220, 231);
            this.pimagenPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pimagenPelicula.TabIndex = 24;
            this.pimagenPelicula.TabStop = false;
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Image = global::admin.Properties.Resources.save;
            this.bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bguardar.Location = new System.Drawing.Point(56, 468);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(110, 50);
            this.bguardar.TabIndex = 26;
            this.bguardar.Text = "          Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // csubtitulo
            // 
            this.csubtitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.csubtitulo.FormattingEnabled = true;
            this.csubtitulo.Items.AddRange(new object[] {
            "Español",
            "Ingles",
            "Sin Subtitulos"});
            this.csubtitulo.Location = new System.Drawing.Point(193, 298);
            this.csubtitulo.Name = "csubtitulo";
            this.csubtitulo.Size = new System.Drawing.Size(236, 27);
            this.csubtitulo.TabIndex = 23;
            // 
            // cidioma
            // 
            this.cidioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cidioma.FormattingEnabled = true;
            this.cidioma.Items.AddRange(new object[] {
            "Español",
            "Ingles",
            "Portugues",
            "Frances",
            "Italiano",
            "Aleman",
            "Ruso",
            "Chino",
            "Japones"});
            this.cidioma.Location = new System.Drawing.Point(193, 265);
            this.cidioma.Name = "cidioma";
            this.cidioma.Size = new System.Drawing.Size(236, 27);
            this.cidioma.TabIndex = 22;
            // 
            // cclasificacionContenidos
            // 
            this.cclasificacionContenidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cclasificacionContenidos.FormattingEnabled = true;
            this.cclasificacionContenidos.Items.AddRange(new object[] {
            "AA(Apto para todo público, en especial para niños)",
            "A (Apto para todo público)",
            "B (Apto para mayores de 12 años)",
            "B- para mayores de o 15 años si es para el cine con 11 años esta bien )",
            "C (Mayores de 18 años)",
            "D (Mayores de 21 años)"});
            this.cclasificacionContenidos.Location = new System.Drawing.Point(193, 166);
            this.cclasificacionContenidos.Name = "cclasificacionContenidos";
            this.cclasificacionContenidos.Size = new System.Drawing.Size(285, 27);
            this.cclasificacionContenidos.TabIndex = 17;
            // 
            // csalasCine
            // 
            this.csalasCine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.csalasCine.FormattingEnabled = true;
            this.csalasCine.Location = new System.Drawing.Point(193, 133);
            this.csalasCine.Name = "csalasCine";
            this.csalasCine.Size = new System.Drawing.Size(285, 27);
            this.csalasCine.TabIndex = 16;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(193, 99);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(119, 27);
            this.txtdescuento.TabIndex = 13;
            this.txtdescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescuento_KeyPress);
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(193, 66);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(119, 27);
            this.txtcosto.TabIndex = 12;
            this.txtcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcosto_KeyPress);
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(193, 24);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(285, 27);
            this.txttitulo.TabIndex = 11;
            // 
            // lsubtitulo
            // 
            this.lsubtitulo.AutoSize = true;
            this.lsubtitulo.Location = new System.Drawing.Point(98, 301);
            this.lsubtitulo.Name = "lsubtitulo";
            this.lsubtitulo.Size = new System.Drawing.Size(86, 19);
            this.lsubtitulo.TabIndex = 10;
            this.lsubtitulo.Text = "Subtitulado:";
            // 
            // lidioma
            // 
            this.lidioma.AutoSize = true;
            this.lidioma.Location = new System.Drawing.Point(128, 273);
            this.lidioma.Name = "lidioma";
            this.lidioma.Size = new System.Drawing.Size(57, 19);
            this.lidioma.TabIndex = 9;
            this.lidioma.Text = "Idioma:";
            // 
            // lclasificacion
            // 
            this.lclasificacion.AutoSize = true;
            this.lclasificacion.Location = new System.Drawing.Point(2, 169);
            this.lclasificacion.Name = "lclasificacion";
            this.lclasificacion.Size = new System.Drawing.Size(185, 19);
            this.lclasificacion.TabIndex = 6;
            this.lclasificacion.Text = "Clasificacion de Contenido:";
            // 
            // lsalasCine
            // 
            this.lsalasCine.AutoSize = true;
            this.lsalasCine.Location = new System.Drawing.Point(84, 136);
            this.lsalasCine.Name = "lsalasCine";
            this.lsalasCine.Size = new System.Drawing.Size(100, 19);
            this.lsalasCine.TabIndex = 5;
            this.lsalasCine.Text = "Salas de Cine:";
            // 
            // ldescuento
            // 
            this.ldescuento.AutoSize = true;
            this.ldescuento.Location = new System.Drawing.Point(71, 102);
            this.ldescuento.Name = "ldescuento";
            this.ldescuento.Size = new System.Drawing.Size(113, 19);
            this.ldescuento.TabIndex = 2;
            this.ldescuento.Text = "Descuento:    Q.";
            // 
            // lcosto
            // 
            this.lcosto.AutoSize = true;
            this.lcosto.Location = new System.Drawing.Point(103, 69);
            this.lcosto.Name = "lcosto";
            this.lcosto.Size = new System.Drawing.Size(81, 19);
            this.lcosto.TabIndex = 1;
            this.lcosto.Text = "Costo:    Q.";
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Location = new System.Drawing.Point(129, 27);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(50, 19);
            this.lnombre.TabIndex = 0;
            this.lnombre.Text = "Título:";
            // 
            // txtidPelicula
            // 
            this.txtidPelicula.Location = new System.Drawing.Point(684, 135);
            this.txtidPelicula.Name = "txtidPelicula";
            this.txtidPelicula.Size = new System.Drawing.Size(50, 27);
            this.txtidPelicula.TabIndex = 42;
            this.txtidPelicula.Visible = false;
            // 
            // frmingresarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(843, 573);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmingresarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Registro de Pelicula";
            this.Load += new System.EventHandler(this.frmingresarPelicula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimagenPelicula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lsubtitulo;
        private System.Windows.Forms.Label lidioma;
        private System.Windows.Forms.Label lclasificacion;
        private System.Windows.Forms.Label ldescuento;
        private System.Windows.Forms.Label lcosto;
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.TextBox txtrutaImagen;
        private System.Windows.Forms.Label lelencoPelicula;
        private System.Windows.Forms.Label lcategoriaPelicula;
        private System.Windows.Forms.Label lpuntosBonificacion;
        public System.Windows.Forms.TextBox txttitulo;
        public System.Windows.Forms.ComboBox csubtitulo;
        public System.Windows.Forms.ComboBox cidioma;
        public System.Windows.Forms.ComboBox cclasificacionContenidos;
        public System.Windows.Forms.TextBox txtdescuento;
        public System.Windows.Forms.TextBox txtcosto;
        public System.Windows.Forms.TextBox txtelencoPelicula;
        public System.Windows.Forms.TextBox txtpuntosBonificacion;
        public System.Windows.Forms.ComboBox ccategoriaPelicula;
        public System.Windows.Forms.TextBox txtidPelicula;
        public System.Windows.Forms.Button bguardar;
        public System.Windows.Forms.Button bseleccionarImagen;
        public System.Windows.Forms.Button beditar;
        public System.Windows.Forms.Button bcancelar;
        public System.Windows.Forms.Button beliminar;
        public System.Windows.Forms.ComboBox csalasCine;
        private System.Windows.Forms.Label lsalasCine;
        public System.Windows.Forms.PictureBox pimagenPelicula;
        public System.Windows.Forms.TextBox txtlinkVideoPeli;
        private System.Windows.Forms.Label lbllinkvideo;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpfechaInicio;
        public System.Windows.Forms.DateTimePicker dtpfechaFinal;
    }
}