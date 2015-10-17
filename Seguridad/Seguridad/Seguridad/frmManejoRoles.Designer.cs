namespace Seguridad
{
    partial class frmManejoRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejoRoles));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblPerfilesDispo = new System.Windows.Forms.Label();
            this.txtPerfilesDisponibles = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAppDisponibles = new System.Windows.Forms.Label();
            this.txtAppDisponibles = new System.Windows.Forms.TextBox();
            this.lblAsignar = new System.Windows.Forms.Label();
            this.lblQuitar = new System.Windows.Forms.Label();
            this.lblAppAsignadas = new System.Windows.Forms.Label();
            this.txtAppAsignadas = new System.Windows.Forms.TextBox();
            this.lblEditar = new System.Windows.Forms.Label();
            this.rbPerfiles = new System.Windows.Forms.RadioButton();
            this.rbAplicaciones = new System.Windows.Forms.RadioButton();
            this.btnLimpiarUsuario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnQuitarSimple = new System.Windows.Forms.Button();
            this.lblQuitarMuchos = new System.Windows.Forms.Button();
            this.btnAsignarMuchos = new System.Windows.Forms.Button();
            this.btnAsignarSimple = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(115, 55);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(110, 27);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(137, 32);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(62, 16);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(270, 55);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(259, 27);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(330, 32);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(121, 16);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblPerfilesDispo
            // 
            this.lblPerfilesDispo.AutoSize = true;
            this.lblPerfilesDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilesDispo.Location = new System.Drawing.Point(65, 122);
            this.lblPerfilesDispo.Name = "lblPerfilesDispo";
            this.lblPerfilesDispo.Size = new System.Drawing.Size(148, 16);
            this.lblPerfilesDispo.TabIndex = 5;
            this.lblPerfilesDispo.Text = "Perfiles Disponibles";
            // 
            // txtPerfilesDisponibles
            // 
            this.txtPerfilesDisponibles.Location = new System.Drawing.Point(7, 150);
            this.txtPerfilesDisponibles.Multiline = true;
            this.txtPerfilesDisponibles.Name = "txtPerfilesDisponibles";
            this.txtPerfilesDisponibles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPerfilesDisponibles.Size = new System.Drawing.Size(273, 160);
            this.txtPerfilesDisponibles.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.lblNombreUsuario);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario Seleccionado";
            // 
            // lblAppDisponibles
            // 
            this.lblAppDisponibles.AutoSize = true;
            this.lblAppDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDisponibles.Location = new System.Drawing.Point(45, 328);
            this.lblAppDisponibles.Name = "lblAppDisponibles";
            this.lblAppDisponibles.Size = new System.Drawing.Size(185, 16);
            this.lblAppDisponibles.TabIndex = 8;
            this.lblAppDisponibles.Text = "Aplicaciones Disponibles";
            // 
            // txtAppDisponibles
            // 
            this.txtAppDisponibles.Location = new System.Drawing.Point(7, 357);
            this.txtAppDisponibles.Multiline = true;
            this.txtAppDisponibles.Name = "txtAppDisponibles";
            this.txtAppDisponibles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAppDisponibles.Size = new System.Drawing.Size(273, 160);
            this.txtAppDisponibles.TabIndex = 9;
            // 
            // lblAsignar
            // 
            this.lblAsignar.AutoSize = true;
            this.lblAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignar.Location = new System.Drawing.Point(289, 124);
            this.lblAsignar.Name = "lblAsignar";
            this.lblAsignar.Size = new System.Drawing.Size(61, 16);
            this.lblAsignar.TabIndex = 10;
            this.lblAsignar.Text = "Asignar";
            // 
            // lblQuitar
            // 
            this.lblQuitar.AutoSize = true;
            this.lblQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitar.Location = new System.Drawing.Point(294, 296);
            this.lblQuitar.Name = "lblQuitar";
            this.lblQuitar.Size = new System.Drawing.Size(49, 16);
            this.lblQuitar.TabIndex = 13;
            this.lblQuitar.Text = "Quitar";
            // 
            // lblAppAsignadas
            // 
            this.lblAppAsignadas.AutoSize = true;
            this.lblAppAsignadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppAsignadas.Location = new System.Drawing.Point(394, 122);
            this.lblAppAsignadas.Name = "lblAppAsignadas";
            this.lblAppAsignadas.Size = new System.Drawing.Size(176, 16);
            this.lblAppAsignadas.TabIndex = 16;
            this.lblAppAsignadas.Text = "Aplicaciones Asignadas";
            // 
            // txtAppAsignadas
            // 
            this.txtAppAsignadas.Location = new System.Drawing.Point(360, 150);
            this.txtAppAsignadas.Multiline = true;
            this.txtAppAsignadas.Name = "txtAppAsignadas";
            this.txtAppAsignadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAppAsignadas.Size = new System.Drawing.Size(273, 367);
            this.txtAppAsignadas.TabIndex = 17;
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.Location = new System.Drawing.Point(294, 448);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(49, 16);
            this.lblEditar.TabIndex = 19;
            this.lblEditar.Text = "Editar";
            // 
            // rbPerfiles
            // 
            this.rbPerfiles.AutoSize = true;
            this.rbPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerfiles.Location = new System.Drawing.Point(26, 523);
            this.rbPerfiles.Name = "rbPerfiles";
            this.rbPerfiles.Size = new System.Drawing.Size(74, 19);
            this.rbPerfiles.TabIndex = 20;
            this.rbPerfiles.TabStop = true;
            this.rbPerfiles.Text = "Perfiles";
            this.rbPerfiles.UseVisualStyleBackColor = true;
            // 
            // rbAplicaciones
            // 
            this.rbAplicaciones.AutoSize = true;
            this.rbAplicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAplicaciones.Location = new System.Drawing.Point(116, 523);
            this.rbAplicaciones.Name = "rbAplicaciones";
            this.rbAplicaciones.Size = new System.Drawing.Size(106, 19);
            this.rbAplicaciones.TabIndex = 21;
            this.rbAplicaciones.TabStop = true;
            this.rbAplicaciones.Text = "Aplicaciones";
            this.rbAplicaciones.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarUsuario
            // 
            this.btnLimpiarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarUsuario.Location = new System.Drawing.Point(412, 533);
            this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            this.btnLimpiarUsuario.Size = new System.Drawing.Size(107, 34);
            this.btnLimpiarUsuario.TabIndex = 22;
            this.btnLimpiarUsuario.Text = "Limpiar Usuario";
            this.btnLimpiarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(535, 533);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 34);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Seguridad.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(295, 467);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 50);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarSimple
            // 
            this.btnQuitarSimple.Image = global::Seguridad.Properties.Resources.asignar4;
            this.btnQuitarSimple.Location = new System.Drawing.Point(296, 386);
            this.btnQuitarSimple.Name = "btnQuitarSimple";
            this.btnQuitarSimple.Size = new System.Drawing.Size(47, 50);
            this.btnQuitarSimple.TabIndex = 15;
            this.btnQuitarSimple.UseVisualStyleBackColor = true;
            // 
            // lblQuitarMuchos
            // 
            this.lblQuitarMuchos.Image = global::Seguridad.Properties.Resources.asignar3;
            this.lblQuitarMuchos.Location = new System.Drawing.Point(296, 330);
            this.lblQuitarMuchos.Name = "lblQuitarMuchos";
            this.lblQuitarMuchos.Size = new System.Drawing.Size(47, 50);
            this.lblQuitarMuchos.TabIndex = 14;
            this.lblQuitarMuchos.UseVisualStyleBackColor = true;
            // 
            // btnAsignarMuchos
            // 
            this.btnAsignarMuchos.Image = global::Seguridad.Properties.Resources.asignar2;
            this.btnAsignarMuchos.Location = new System.Drawing.Point(296, 208);
            this.btnAsignarMuchos.Name = "btnAsignarMuchos";
            this.btnAsignarMuchos.Size = new System.Drawing.Size(47, 50);
            this.btnAsignarMuchos.TabIndex = 12;
            this.btnAsignarMuchos.UseVisualStyleBackColor = true;
            // 
            // btnAsignarSimple
            // 
            this.btnAsignarSimple.Image = global::Seguridad.Properties.Resources.asginar;
            this.btnAsignarSimple.Location = new System.Drawing.Point(295, 152);
            this.btnAsignarSimple.Name = "btnAsignarSimple";
            this.btnAsignarSimple.Size = new System.Drawing.Size(47, 50);
            this.btnAsignarSimple.TabIndex = 11;
            this.btnAsignarSimple.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::Seguridad.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(51, 32);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // frmManejoRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 584);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarUsuario);
            this.Controls.Add(this.rbAplicaciones);
            this.Controls.Add(this.rbPerfiles);
            this.Controls.Add(this.lblEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtAppAsignadas);
            this.Controls.Add(this.lblAppAsignadas);
            this.Controls.Add(this.btnQuitarSimple);
            this.Controls.Add(this.lblQuitarMuchos);
            this.Controls.Add(this.lblQuitar);
            this.Controls.Add(this.btnAsignarMuchos);
            this.Controls.Add(this.btnAsignarSimple);
            this.Controls.Add(this.lblAsignar);
            this.Controls.Add(this.txtAppDisponibles);
            this.Controls.Add(this.lblAppDisponibles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPerfilesDisponibles);
            this.Controls.Add(this.lblPerfilesDispo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManejoRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Roles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblPerfilesDispo;
        private System.Windows.Forms.TextBox txtPerfilesDisponibles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAppDisponibles;
        private System.Windows.Forms.TextBox txtAppDisponibles;
        private System.Windows.Forms.Label lblAsignar;
        private System.Windows.Forms.Button btnAsignarSimple;
        private System.Windows.Forms.Button btnAsignarMuchos;
        private System.Windows.Forms.Label lblQuitar;
        private System.Windows.Forms.Button btnQuitarSimple;
        private System.Windows.Forms.Button lblQuitarMuchos;
        private System.Windows.Forms.Label lblAppAsignadas;
        private System.Windows.Forms.TextBox txtAppAsignadas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.RadioButton rbPerfiles;
        private System.Windows.Forms.RadioButton rbAplicaciones;
        private System.Windows.Forms.Button btnLimpiarUsuario;
        private System.Windows.Forms.Button btnSalir;
    }
}