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
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonEmoticon = new System.Windows.Forms.Button();
            this.buttonBuzz = new System.Windows.Forms.Button();
            this.buttonCall = new System.Windows.Forms.Button();
            this.buttonCamera = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.richTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.pictureBoxContact = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panelContact = new System.Windows.Forms.Panel();
            this.labelContactName = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanelComunication = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelContact.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.flowLayoutPanelComunication.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Location = new System.Drawing.Point(23, 252);
            this.buttonAddContact.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(56, 19);
            this.buttonAddContact.TabIndex = 8;
            this.buttonAddContact.Text = "Add ";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.AutoSize = true;
            this.buttonSend.Location = new System.Drawing.Point(487, 2);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(56, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Enviar";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonEmoticon
            // 
            this.buttonEmoticon.Location = new System.Drawing.Point(427, 2);
            this.buttonEmoticon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEmoticon.Name = "buttonEmoticon";
            this.buttonEmoticon.Size = new System.Drawing.Size(56, 23);
            this.buttonEmoticon.TabIndex = 4;
            this.buttonEmoticon.Text = "Emoticon";
            this.buttonEmoticon.UseVisualStyleBackColor = true;
            // 
            // buttonBuzz
            // 
            this.buttonBuzz.Location = new System.Drawing.Point(367, 2);
            this.buttonBuzz.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuzz.Name = "buttonBuzz";
            this.buttonBuzz.Size = new System.Drawing.Size(56, 23);
            this.buttonBuzz.TabIndex = 3;
            this.buttonBuzz.Text = "Buzz";
            this.buttonBuzz.UseVisualStyleBackColor = true;
            // 
            // buttonCall
            // 
            this.buttonCall.Location = new System.Drawing.Point(23, 228);
            this.buttonCall.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(56, 19);
            this.buttonCall.TabIndex = 7;
            this.buttonCall.Text = "Call";
            this.buttonCall.UseVisualStyleBackColor = true;
            // 
            // buttonCamera
            // 
            this.buttonCamera.Location = new System.Drawing.Point(23, 206);
            this.buttonCamera.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCamera.Name = "buttonCamera";
            this.buttonCamera.Size = new System.Drawing.Size(56, 19);
            this.buttonCamera.TabIndex = 6;
            this.buttonCamera.Text = "Cam";
            this.buttonCamera.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(23, 183);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(56, 19);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // richTextBoxChat
            // 
            this.richTextBoxChat.BackColor = System.Drawing.Color.White;
            this.richTextBoxChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxChat.Location = new System.Drawing.Point(122, 0);
            this.richTextBoxChat.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxChat.Name = "richTextBoxChat";
            this.richTextBoxChat.ReadOnly = true;
            this.richTextBoxChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxChat.Size = new System.Drawing.Size(545, 324);
            this.richTextBoxChat.TabIndex = 3;
            this.richTextBoxChat.TabStop = false;
            this.richTextBoxChat.Text = "";
            // 
            // pictureBoxContact
            // 
            this.pictureBoxContact.Location = new System.Drawing.Point(11, 11);
            this.pictureBoxContact.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxContact.Name = "pictureBoxContact";
            this.pictureBoxContact.Size = new System.Drawing.Size(100, 120);
            this.pictureBoxContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxContact.TabIndex = 0;
            this.pictureBoxContact.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelUser);
            this.panelLeft.Controls.Add(this.panelContact);
            this.panelLeft.Controls.Add(this.buttonAddContact);
            this.panelLeft.Controls.Add(this.buttonPlay);
            this.panelLeft.Controls.Add(this.buttonCall);
            this.panelLeft.Controls.Add(this.buttonCamera);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(122, 438);
            this.panelLeft.TabIndex = 11;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.labelUserName);
            this.panelUser.Controls.Add(this.pictureBoxUser);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUser.Location = new System.Drawing.Point(0, 288);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(122, 150);
            this.panelUser.TabIndex = 12;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(11, 133);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(96, 13);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "Nombre de usuario";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Location = new System.Drawing.Point(11, 11);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(100, 120);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // panelContact
            // 
            this.panelContact.Controls.Add(this.labelContactName);
            this.panelContact.Controls.Add(this.pictureBoxContact);
            this.panelContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContact.Location = new System.Drawing.Point(0, 0);
            this.panelContact.Name = "panelContact";
            this.panelContact.Size = new System.Drawing.Size(122, 150);
            this.panelContact.TabIndex = 11;
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Location = new System.Drawing.Point(11, 133);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(104, 13);
            this.labelContactName.TabIndex = 1;
            this.labelContactName.Text = "Nombre de contacto";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.richTextBoxMessage);
            this.panelBottom.Controls.Add(this.flowLayoutPanelComunication);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(122, 324);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(545, 114);
            this.panelBottom.TabIndex = 12;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxMessage.Location = new System.Drawing.Point(0, 3);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(545, 84);
            this.richTextBoxMessage.TabIndex = 1;
            this.richTextBoxMessage.Text = "";
            this.richTextBoxMessage.TextChanged += new System.EventHandler(this.richTextBoxMessage_TextChanged);
            // 
            // flowLayoutPanelComunication
            // 
            this.flowLayoutPanelComunication.AutoSize = true;
            this.flowLayoutPanelComunication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelComunication.Controls.Add(this.buttonSend);
            this.flowLayoutPanelComunication.Controls.Add(this.buttonEmoticon);
            this.flowLayoutPanelComunication.Controls.Add(this.buttonBuzz);
            this.flowLayoutPanelComunication.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelComunication.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelComunication.Location = new System.Drawing.Point(0, 87);
            this.flowLayoutPanelComunication.Name = "flowLayoutPanelComunication";
            this.flowLayoutPanelComunication.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelComunication.Size = new System.Drawing.Size(545, 27);
            this.flowLayoutPanelComunication.TabIndex = 11;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 438);
            this.Controls.Add(this.richTextBoxChat);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormChat";
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelContact.ResumeLayout(false);
            this.panelContact.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.flowLayoutPanelComunication.ResumeLayout(false);
            this.flowLayoutPanelComunication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxContact;
        private System.Windows.Forms.RichTextBox richTextBoxChat;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonEmoticon;
        private System.Windows.Forms.Button buttonBuzz;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Button buttonCamera;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelContact;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelComunication;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
    }
}