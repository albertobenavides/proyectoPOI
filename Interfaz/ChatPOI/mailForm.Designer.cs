namespace ChatPOI
{
    partial class MailForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonAttachFile = new System.Windows.Forms.Button();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonAttachFile
            // 
            this.buttonAttachFile.Location = new System.Drawing.Point(12, 38);
            this.buttonAttachFile.Name = "buttonAttachFile";
            this.buttonAttachFile.Size = new System.Drawing.Size(187, 23);
            this.buttonAttachFile.TabIndex = 0;
            this.buttonAttachFile.Text = "Anexar archivo";
            this.buttonAttachFile.UseVisualStyleBackColor = true;
            this.buttonAttachFile.Click += new System.EventHandler(this.buttonAttachFile_Click);
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.Location = new System.Drawing.Point(205, 38);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(75, 23);
            this.buttonSendMail.TabIndex = 1;
            this.buttonSendMail.Text = "Enviar";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 2;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(22, 15);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(32, 13);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "Para:";
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 71);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSendMail);
            this.Controls.Add(this.buttonAttachFile);
            this.Name = "MailForm";
            this.Text = "mailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonAttachFile;
        private System.Windows.Forms.Button buttonSendMail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTo;
    }
}