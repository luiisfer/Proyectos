namespace Seguridad
{
    partial class frmCambioPassUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambioPassUser));
            this.mnMenuSistema = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbUsuarioSeleccionado = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.lblApellidoUsuario = new System.Windows.Forms.Label();
            this.dgvBusquedaUsuario = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.mnMenuSistema.SuspendLayout();
            this.gbUsuarioSeleccionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // mnMenuSistema
            // 
            this.mnMenuSistema.BackColor = System.Drawing.SystemColors.Control;
            this.mnMenuSistema.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnMenuSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnMenuSistema.Location = new System.Drawing.Point(0, 0);
            this.mnMenuSistema.Name = "mnMenuSistema";
            this.mnMenuSistema.Size = new System.Drawing.Size(499, 24);
            this.mnMenuSistema.TabIndex = 2;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.catalogosToolStripMenuItem.Text = "Catálogos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // gbUsuarioSeleccionado
            // 
            this.gbUsuarioSeleccionado.Controls.Add(this.lblApellidoUsuario);
            this.gbUsuarioSeleccionado.Controls.Add(this.txtApellidoUsuario);
            this.gbUsuarioSeleccionado.Controls.Add(this.btnbuscar);
            this.gbUsuarioSeleccionado.Controls.Add(this.txtUsuario);
            this.gbUsuarioSeleccionado.Controls.Add(this.lblusuario);
            this.gbUsuarioSeleccionado.Controls.Add(this.lblNombreUsuario);
            this.gbUsuarioSeleccionado.Controls.Add(this.txtNombreUsuario);
            this.gbUsuarioSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuarioSeleccionado.Location = new System.Drawing.Point(12, 37);
            this.gbUsuarioSeleccionado.Name = "gbUsuarioSeleccionado";
            this.gbUsuarioSeleccionado.Size = new System.Drawing.Size(465, 159);
            this.gbUsuarioSeleccionado.TabIndex = 8;
            this.gbUsuarioSeleccionado.TabStop = false;
            this.gbUsuarioSeleccionado.Text = "Usuario Seleccionado";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(72, 55);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(110, 27);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(95, 32);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(62, 16);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(258, 32);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(121, 16);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(192, 55);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(259, 27);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoUsuario.Location = new System.Drawing.Point(98, 112);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(259, 27);
            this.txtApellidoUsuario.TabIndex = 5;
            // 
            // lblApellidoUsuario
            // 
            this.lblApellidoUsuario.AutoSize = true;
            this.lblApellidoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoUsuario.Location = new System.Drawing.Point(171, 93);
            this.lblApellidoUsuario.Name = "lblApellidoUsuario";
            this.lblApellidoUsuario.Size = new System.Drawing.Size(124, 16);
            this.lblApellidoUsuario.TabIndex = 6;
            this.lblApellidoUsuario.Text = "Apellido Usuario";
            // 
            // dgvBusquedaUsuario
            // 
            this.dgvBusquedaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaUsuario.Location = new System.Drawing.Point(12, 221);
            this.dgvBusquedaUsuario.Name = "dgvBusquedaUsuario";
            this.dgvBusquedaUsuario.Size = new System.Drawing.Size(465, 205);
            this.dgvBusquedaUsuario.TabIndex = 9;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::Seguridad.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(19, 32);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // frmCambioPassUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 456);
            this.Controls.Add(this.dgvBusquedaUsuario);
            this.Controls.Add(this.gbUsuarioSeleccionado);
            this.Controls.Add(this.mnMenuSistema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambioPassUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Usuario o Contraseña";
            this.mnMenuSistema.ResumeLayout(false);
            this.mnMenuSistema.PerformLayout();
            this.gbUsuarioSeleccionado.ResumeLayout(false);
            this.gbUsuarioSeleccionado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMenuSistema;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbUsuarioSeleccionado;
        private System.Windows.Forms.Label lblApellidoUsuario;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.DataGridView dgvBusquedaUsuario;
    }
}