namespace ClienteApp
{
    partial class cClient
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
            this.textBoxToSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxToSend
            // 
            this.textBoxToSend.Location = new System.Drawing.Point(13, 230);
            this.textBoxToSend.Name = "textBoxToSend";
            this.textBoxToSend.Size = new System.Drawing.Size(178, 20);
            this.textBoxToSend.TabIndex = 1;
            this.textBoxToSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxToSend_KeyPress);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(197, 227);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Enviar";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxChat
            // 
            this.textBoxChat.Location = new System.Drawing.Point(13, 14);
            this.textBoxChat.Multiline = true;
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.ReadOnly = true;
            this.textBoxChat.Size = new System.Drawing.Size(258, 203);
            this.textBoxChat.TabIndex = 0;
            this.textBoxChat.TabStop = false;
            // 
            // cClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxChat);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxToSend);
            this.Name = "cClient";
            this.Text = "cClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cClient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxToSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxChat;
    }
}