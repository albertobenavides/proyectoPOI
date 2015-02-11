namespace ChatPOI
{
    partial class WindowLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowLogin));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.linkLabelCreateAccount = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(194, 150);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxUser.Location = new System.Drawing.Point(23, 170);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(150, 20);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.Text = "Nombre de usuario";
            this.textBoxUser.Enter += new System.EventHandler(this.textBoxUser_Enter);
            this.textBoxUser.Leave += new System.EventHandler(this.textBoxUser_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPassword.Location = new System.Drawing.Point(23, 196);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Contraseña";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPass_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Location = new System.Drawing.Point(63, 219);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(68, 13);
            this.linkLabelLogin.TabIndex = 6;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Iniciar sesión";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEnter_LinkClicked);
            // 
            // linkLabelCreateAccount
            // 
            this.linkLabelCreateAccount.AutoSize = true;
            this.linkLabelCreateAccount.Location = new System.Drawing.Point(45, 244);
            this.linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            this.linkLabelCreateAccount.Size = new System.Drawing.Size(101, 13);
            this.linkLabelCreateAccount.TabIndex = 7;
            this.linkLabelCreateAccount.TabStop = true;
            this.linkLabelCreateAccount.Text = "Crear nueva cuenta";
            // 
            // WindowLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(194, 306);
            this.Controls.Add(this.linkLabelCreateAccount);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WindowLogin";
            this.Text = "Cheet-A-Chat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.LinkLabel linkLabelCreateAccount;
    }
}

