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
            this.components = new System.ComponentModel.Container();
            this.tabPageChat = new System.Windows.Forms.TabPage();
            this.tabControlChatManager = new System.Windows.Forms.TabControl();
            this.pictureBoxReceptorUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.richTextBoxInputUser = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonCam = new System.Windows.Forms.Button();
            this.buttonCall = new System.Windows.Forms.Button();
            this.buttonBuzz = new System.Windows.Forms.Button();
            this.buttonEmoticon = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.tabPageChat.SuspendLayout();
            this.tabControlChatManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceptorUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageChat
            // 
            this.tabPageChat.Controls.Add(this.buttonAddContact);
            this.tabPageChat.Controls.Add(this.buttonSend);
            this.tabPageChat.Controls.Add(this.buttonEmoticon);
            this.tabPageChat.Controls.Add(this.buttonBuzz);
            this.tabPageChat.Controls.Add(this.buttonCall);
            this.tabPageChat.Controls.Add(this.buttonCam);
            this.tabPageChat.Controls.Add(this.buttonPlay);
            this.tabPageChat.Controls.Add(this.richTextBoxChat);
            this.tabPageChat.Controls.Add(this.richTextBoxInputUser);
            this.tabPageChat.Controls.Add(this.pictureBoxUser);
            this.tabPageChat.Controls.Add(this.pictureBoxReceptorUser);
            this.tabPageChat.Location = new System.Drawing.Point(4, 25);
            this.tabPageChat.Name = "tabPageChat";
            this.tabPageChat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChat.Size = new System.Drawing.Size(474, 510);
            this.tabPageChat.TabIndex = 0;
            this.tabPageChat.Text = "ChatOne";
            this.tabPageChat.UseVisualStyleBackColor = true;
            // 
            // tabControlChatManager
            // 
            this.tabControlChatManager.Controls.Add(this.tabPageChat);
            this.tabControlChatManager.Location = new System.Drawing.Point(12, 12);
            this.tabControlChatManager.Name = "tabControlChatManager";
            this.tabControlChatManager.SelectedIndex = 0;
            this.tabControlChatManager.Size = new System.Drawing.Size(482, 539);
            this.tabControlChatManager.TabIndex = 0;
            // 
            // pictureBoxReceptorUser
            // 
            this.pictureBoxReceptorUser.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxReceptorUser.Name = "pictureBoxReceptorUser";
            this.pictureBoxReceptorUser.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxReceptorUser.TabIndex = 0;
            this.pictureBoxReceptorUser.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Location = new System.Drawing.Point(6, 404);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            // 
            // richTextBoxInputUser
            // 
            this.richTextBoxInputUser.Location = new System.Drawing.Point(112, 404);
            this.richTextBoxInputUser.Name = "richTextBoxInputUser";
            this.richTextBoxInputUser.Size = new System.Drawing.Size(355, 66);
            this.richTextBoxInputUser.TabIndex = 2;
            this.richTextBoxInputUser.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBoxChat
            // 
            this.richTextBoxChat.Location = new System.Drawing.Point(112, 6);
            this.richTextBoxChat.Name = "richTextBoxChat";
            this.richTextBoxChat.Size = new System.Drawing.Size(355, 392);
            this.richTextBoxChat.TabIndex = 3;
            this.richTextBoxChat.Text = "";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(18, 125);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // buttonCam
            // 
            this.buttonCam.Location = new System.Drawing.Point(18, 154);
            this.buttonCam.Name = "buttonCam";
            this.buttonCam.Size = new System.Drawing.Size(75, 23);
            this.buttonCam.TabIndex = 5;
            this.buttonCam.Text = "Cam";
            this.buttonCam.UseVisualStyleBackColor = true;
            // 
            // buttonCall
            // 
            this.buttonCall.Location = new System.Drawing.Point(18, 181);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(75, 23);
            this.buttonCall.TabIndex = 6;
            this.buttonCall.Text = "Call";
            this.buttonCall.UseVisualStyleBackColor = true;
            // 
            // buttonBuzz
            // 
            this.buttonBuzz.Location = new System.Drawing.Point(230, 476);
            this.buttonBuzz.Name = "buttonBuzz";
            this.buttonBuzz.Size = new System.Drawing.Size(75, 28);
            this.buttonBuzz.TabIndex = 7;
            this.buttonBuzz.Text = "Buzz";
            this.buttonBuzz.UseVisualStyleBackColor = true;
            // 
            // buttonEmoticon
            // 
            this.buttonEmoticon.Location = new System.Drawing.Point(311, 476);
            this.buttonEmoticon.Name = "buttonEmoticon";
            this.buttonEmoticon.Size = new System.Drawing.Size(75, 28);
            this.buttonEmoticon.TabIndex = 8;
            this.buttonEmoticon.Text = "Emoticon";
            this.buttonEmoticon.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(392, 476);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 28);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Location = new System.Drawing.Point(18, 210);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(75, 23);
            this.buttonAddContact.TabIndex = 10;
            this.buttonAddContact.Text = "Add ";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 563);
            this.Controls.Add(this.tabControlChatManager);
            this.Name = "FormChat";
            this.Text = "FormChat";
            this.tabPageChat.ResumeLayout(false);
            this.tabControlChatManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceptorUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageChat;
        private System.Windows.Forms.TabControl tabControlChatManager;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxReceptorUser;
        private System.Windows.Forms.RichTextBox richTextBoxChat;
        private System.Windows.Forms.RichTextBox richTextBoxInputUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonEmoticon;
        private System.Windows.Forms.Button buttonBuzz;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Button buttonCam;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonAddContact;
    }
}