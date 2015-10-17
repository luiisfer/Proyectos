namespace Modulo_Seguridad
{
    partial class Login
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
            this.ucLogin1 = new Seguridad.ucLogin();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucLogin1
            // 
            this.ucLogin1.Location = new System.Drawing.Point(2, 12);
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(550, 243);
            this.ucLogin1.TabIndex = 0;
            this.ucLogin1.Load += new System.EventHandler(this.ucLogin1_Load);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(338, 186);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(136, 51);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 270);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.ucLogin1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Seguridad.ucLogin ucLogin1;
        private System.Windows.Forms.Button btnlogin;
    }
}

