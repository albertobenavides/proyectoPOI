namespace ChatPOI
{
    partial class FormInicio
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
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInicio
            // 
            this.pictureBoxInicio.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxInicio.Name = "pictureBoxInicio";
            this.pictureBoxInicio.Size = new System.Drawing.Size(152, 141);
            this.pictureBoxInicio.TabIndex = 0;
            this.pictureBoxInicio.TabStop = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(244, 56);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 1;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(244, 82);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 2;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(203, 59);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(32, 13);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "User:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(203, 85);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(33, 13);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "Pass:";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 163);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBoxInicio);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInicio;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
    }
}

