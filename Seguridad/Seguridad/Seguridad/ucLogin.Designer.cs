namespace Seguridad
{
    partial class ucLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.pBImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(335, 138);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(198, 26);
            this.txtpassword.TabIndex = 12;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(219, 144);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(102, 20);
            this.lblpassword.TabIndex = 11;
            this.lblpassword.Text = "Contraseña";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(335, 83);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(198, 26);
            this.txtusuario.TabIndex = 10;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(250, 89);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(71, 20);
            this.lblusuario.TabIndex = 9;
            this.lblusuario.Text = "Usuario";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(282, 12);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(171, 25);
            this.lblnombre.TabIndex = 8;
            this.lblnombre.Text = "La Colchoneria";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Image = global::Seguridad.Properties.Resources.loggin;
            this.btnIniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesion.Location = new System.Drawing.Point(335, 175);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(136, 50);
            this.btnIniciarSesion.TabIndex = 13;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // pBImagen
            // 
            this.pBImagen.Image = global::Seguridad.Properties.Resources._10458014_1169466299737502_7053640794978873582_n;
            this.pBImagen.Location = new System.Drawing.Point(7, 12);
            this.pBImagen.Name = "pBImagen";
            this.pBImagen.Size = new System.Drawing.Size(210, 213);
            this.pBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBImagen.TabIndex = 7;
            this.pBImagen.TabStop = false;
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.pBImagen);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(550, 243);
            ((System.ComponentModel.ISupportInitialize)(this.pBImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.PictureBox pBImagen;
    }
}
