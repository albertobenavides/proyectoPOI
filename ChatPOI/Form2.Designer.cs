namespace ChatPOI
{
    partial class FormChat
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
            this.tabPageChat = new System.Windows.Forms.TabPage();
            this.tabControlChatManager = new System.Windows.Forms.TabControl();
            this.tabControlChatManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageChat
            // 
            this.tabPageChat.Location = new System.Drawing.Point(4, 25);
            this.tabPageChat.Name = "tabPageChat";
            this.tabPageChat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChat.Size = new System.Drawing.Size(501, 510);
            this.tabPageChat.TabIndex = 0;
            this.tabPageChat.Text = "tabPage1";
            this.tabPageChat.UseVisualStyleBackColor = true;
            // 
            // tabControlChatManager
            // 
            this.tabControlChatManager.Controls.Add(this.tabPageChat);
            this.tabControlChatManager.Location = new System.Drawing.Point(12, 12);
            this.tabControlChatManager.Name = "tabControlChatManager";
            this.tabControlChatManager.SelectedIndex = 0;
            this.tabControlChatManager.Size = new System.Drawing.Size(509, 539);
            this.tabControlChatManager.TabIndex = 0;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 563);
            this.Controls.Add(this.tabControlChatManager);
            this.Name = "FormChat";
            this.Text = "FormChat";
            this.tabControlChatManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageChat;
        private System.Windows.Forms.TabControl tabControlChatManager;
    }
}