﻿namespace WindowsFormsApplication1
{
    partial class cartelera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cartelera));
            this.msBarra = new System.Windows.Forms.MenuStrip();
            this.tsmiAtras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.flpCartelera = new System.Windows.Forms.FlowLayoutPanel();
            this.lblsucursal = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblSubti = new System.Windows.Forms.Label();
            this.cmbSubti = new System.Windows.Forms.ComboBox();
            this.lbltipoSala = new System.Windows.Forms.Label();
            this.cmbtipoSala = new System.Windows.Forms.ComboBox();
            this.btnBusq = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.msBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // msBarra
            // 
            this.msBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAtras,
            this.tsmiMenuPrincipal,
            this.tsmiSalir});
            this.msBarra.Location = new System.Drawing.Point(0, 0);
            this.msBarra.Name = "msBarra";
            this.msBarra.Size = new System.Drawing.Size(1304, 31);
            this.msBarra.TabIndex = 9;
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
            this.tsmiSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // flpCartelera
            // 
            this.flpCartelera.AutoScroll = true;
            this.flpCartelera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCartelera.Location = new System.Drawing.Point(0, 31);
            this.flpCartelera.Name = "flpCartelera";
            this.flpCartelera.Size = new System.Drawing.Size(1304, 698);
            this.flpCartelera.TabIndex = 10;
            // 
            // lblsucursal
            // 
            this.lblsucursal.AutoSize = true;
            this.lblsucursal.Location = new System.Drawing.Point(86, 77);
            this.lblsucursal.Name = "lblsucursal";
            this.lblsucursal.Size = new System.Drawing.Size(49, 19);
            this.lblsucursal.TabIndex = 0;
            this.lblsucursal.Text = "label1";
            this.lblsucursal.Visible = false;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(458, 0);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(102, 27);
            this.cmbIdioma.TabIndex = 11;
            this.cmbIdioma.DropDownClosed += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(395, 3);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(57, 19);
            this.lblIdioma.TabIndex = 12;
            this.lblIdioma.Text = "Idioma:";
            // 
            // lblSubti
            // 
            this.lblSubti.AutoSize = true;
            this.lblSubti.Location = new System.Drawing.Point(566, 3);
            this.lblSubti.Name = "lblSubti";
            this.lblSubti.Size = new System.Drawing.Size(77, 19);
            this.lblSubti.TabIndex = 13;
            this.lblSubti.Text = "Subtitulos:";
            // 
            // cmbSubti
            // 
            this.cmbSubti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubti.FormattingEnabled = true;
            this.cmbSubti.Location = new System.Drawing.Point(649, 0);
            this.cmbSubti.Name = "cmbSubti";
            this.cmbSubti.Size = new System.Drawing.Size(111, 27);
            this.cmbSubti.TabIndex = 14;
            this.cmbSubti.DropDownClosed += new System.EventHandler(this.cmbSubti_SelectedIndexChanged);
            // 
            // lbltipoSala
            // 
            this.lbltipoSala.AutoSize = true;
            this.lbltipoSala.Location = new System.Drawing.Point(766, 3);
            this.lbltipoSala.Name = "lbltipoSala";
            this.lbltipoSala.Size = new System.Drawing.Size(72, 19);
            this.lbltipoSala.TabIndex = 15;
            this.lbltipoSala.Text = "Tipo Sala:";
            // 
            // cmbtipoSala
            // 
            this.cmbtipoSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipoSala.FormattingEnabled = true;
            this.cmbtipoSala.Location = new System.Drawing.Point(844, 0);
            this.cmbtipoSala.Name = "cmbtipoSala";
            this.cmbtipoSala.Size = new System.Drawing.Size(81, 27);
            this.cmbtipoSala.TabIndex = 16;
            this.cmbtipoSala.DropDownClosed += new System.EventHandler(this.cmbtipoSala_SelectedIndexChanged);
            // 
            // btnBusq
            // 
            this.btnBusq.Location = new System.Drawing.Point(1166, -3);
            this.btnBusq.Name = "btnBusq";
            this.btnBusq.Size = new System.Drawing.Size(84, 31);
            this.btnBusq.TabIndex = 17;
            this.btnBusq.Text = "Busqueda";
            this.btnBusq.UseVisualStyleBackColor = true;
            this.btnBusq.Click += new System.EventHandler(this.btnBusq_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(931, 3);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(61, 19);
            this.lblHora.TabIndex = 18;
            this.lblHora.Text = "Horario:";
            // 
            // cmbHora
            // 
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(999, 0);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(161, 27);
            this.cmbHora.TabIndex = 19;
            this.cmbHora.DropDownClosed += new System.EventHandler(this.cmbHora_SelectedIndexChanged);
            // 
            // cartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 729);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnBusq);
            this.Controls.Add(this.cmbtipoSala);
            this.Controls.Add(this.lbltipoSala);
            this.Controls.Add(this.cmbSubti);
            this.Controls.Add(this.lblSubti);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblsucursal);
            this.Controls.Add(this.flpCartelera);
            this.Controls.Add(this.msBarra);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msBarra;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cartelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cartelera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cartelera_FormClosed);
            this.Load += new System.EventHandler(this.cartelera_Load);
            this.msBarra.ResumeLayout(false);
            this.msBarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msBarra;
        private System.Windows.Forms.ToolStripMenuItem tsmiAtras;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.FlowLayoutPanel flpCartelera;
        public System.Windows.Forms.Label lblsucursal;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblSubti;
        private System.Windows.Forms.ComboBox cmbSubti;
        private System.Windows.Forms.Label lbltipoSala;
        private System.Windows.Forms.ComboBox cmbtipoSala;
        private System.Windows.Forms.Button btnBusq;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cmbHora;

    }
}