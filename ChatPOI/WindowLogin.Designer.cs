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
            this.pictureBoxInicio = new System.Windows.Forms.PictureBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.linkLabelEnter = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInicio
            // 
            this.pictureBoxInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxInicio.Image = global::ChatPOI.Properties.Resources.cheetah1;
            this.pictureBoxInicio.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInicio.Name = "pictureBoxInicio";
            this.pictureBoxInicio.Size = new System.Drawing.Size(194, 150);
            this.pictureBoxInicio.TabIndex = 0;
            this.pictureBoxInicio.TabStop = false;
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
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPass.Location = new System.Drawing.Point(23, 196);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(150, 20);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.Text = "Contraseña";
            // 
            // linkLabelEnter
            // 
            this.linkLabelEnter.AutoSize = true;
            this.linkLabelEnter.Location = new System.Drawing.Point(83, 219);
            this.linkLabelEnter.Name = "linkLabelEnter";
            this.linkLabelEnter.Size = new System.Drawing.Size(35, 13);
            this.linkLabelEnter.TabIndex = 6;
            this.linkLabelEnter.TabStop = true;
            this.linkLabelEnter.Text = "Entrar";
            // 
            // WindowLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(194, 322);
            this.Controls.Add(this.linkLabelEnter);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBoxInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WindowLogin";
            this.Text = "Cheet-A-Chat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInicio;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.LinkLabel linkLabelEnter;
    }
}

