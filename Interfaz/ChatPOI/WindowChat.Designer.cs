namespace ChatPOI
{
    partial class WindowChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowChat));
            this.richTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.groupBoxEmoticons = new System.Windows.Forms.GroupBox();
            this.buttonEmoti16 = new System.Windows.Forms.Button();
            this.buttonEmoti15 = new System.Windows.Forms.Button();
            this.buttonEmoti13 = new System.Windows.Forms.Button();
            this.buttonEmoti14 = new System.Windows.Forms.Button();
            this.buttonEmoti12 = new System.Windows.Forms.Button();
            this.buttonEmoti11 = new System.Windows.Forms.Button();
            this.buttonEmoti2 = new System.Windows.Forms.Button();
            this.buttonEmoti3 = new System.Windows.Forms.Button();
            this.buttonEmoti4 = new System.Windows.Forms.Button();
            this.buttonEmoti5 = new System.Windows.Forms.Button();
            this.buttonEmoti6 = new System.Windows.Forms.Button();
            this.buttonEmoti7 = new System.Windows.Forms.Button();
            this.buttonEmoti8 = new System.Windows.Forms.Button();
            this.buttonEmoti9 = new System.Windows.Forms.Button();
            this.buttonEmoti10 = new System.Windows.Forms.Button();
            this.buttonEmoti1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelClientReceiver = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxContact = new System.Windows.Forms.PictureBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonCall = new System.Windows.Forms.Button();
            this.buttonCamera = new System.Windows.Forms.Button();
            this.buttonBuzz = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonEmoticon = new System.Windows.Forms.Button();
            this.groupBoxEmoticons.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxChat
            // 
            this.richTextBoxChat.BackColor = System.Drawing.Color.White;
            this.richTextBoxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxChat.Location = new System.Drawing.Point(168, 2);
            this.richTextBoxChat.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxChat.Name = "richTextBoxChat";
            this.richTextBoxChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxChat.Size = new System.Drawing.Size(488, 314);
            this.richTextBoxChat.TabIndex = 3;
            this.richTextBoxChat.TabStop = false;
            this.richTextBoxChat.Text = "";
            this.richTextBoxChat.Enter += new System.EventHandler(this.richTextBoxChat_Click);
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessage.Location = new System.Drawing.Point(168, 335);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(328, 84);
            this.richTextBoxMessage.TabIndex = 0;
            this.richTextBoxMessage.Text = "";
            this.richTextBoxMessage.TextChanged += new System.EventHandler(this.richTextBoxMessage_TextChanged);
            this.richTextBoxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxMessage_KeyPress);
            // 
            // groupBoxEmoticons
            // 
            this.groupBoxEmoticons.BackColor = System.Drawing.Color.White;
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti16);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti15);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti13);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti14);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti12);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti11);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti2);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti3);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti4);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti5);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti6);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti7);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti8);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti9);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti10);
            this.groupBoxEmoticons.Controls.Add(this.buttonEmoti1);
            this.groupBoxEmoticons.Location = new System.Drawing.Point(360, 183);
            this.groupBoxEmoticons.Name = "groupBoxEmoticons";
            this.groupBoxEmoticons.Size = new System.Drawing.Size(151, 162);
            this.groupBoxEmoticons.TabIndex = 13;
            this.groupBoxEmoticons.TabStop = false;
            this.groupBoxEmoticons.Text = "Emoticons";
            this.groupBoxEmoticons.Leave += new System.EventHandler(this.groupBoxEmoticons_Leave);
            // 
            // buttonEmoti16
            // 
            this.buttonEmoti16.Image = global::ChatPOI.Properties.Resources.emoticons16;
            this.buttonEmoti16.Location = new System.Drawing.Point(114, 126);
            this.buttonEmoti16.Name = "buttonEmoti16";
            this.buttonEmoti16.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti16.TabIndex = 15;
            this.buttonEmoti16.UseVisualStyleBackColor = true;
            this.buttonEmoti16.Click += new System.EventHandler(this.buttonEmoti16_Click);
            // 
            // buttonEmoti15
            // 
            this.buttonEmoti15.Image = global::ChatPOI.Properties.Resources.emoticons15;
            this.buttonEmoti15.Location = new System.Drawing.Point(78, 126);
            this.buttonEmoti15.Name = "buttonEmoti15";
            this.buttonEmoti15.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti15.TabIndex = 14;
            this.buttonEmoti15.UseVisualStyleBackColor = true;
            this.buttonEmoti15.Click += new System.EventHandler(this.buttonEmoti15_Click);
            // 
            // buttonEmoti13
            // 
            this.buttonEmoti13.Image = global::ChatPOI.Properties.Resources.emoticons13;
            this.buttonEmoti13.Location = new System.Drawing.Point(6, 126);
            this.buttonEmoti13.Name = "buttonEmoti13";
            this.buttonEmoti13.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti13.TabIndex = 13;
            this.buttonEmoti13.UseVisualStyleBackColor = true;
            this.buttonEmoti13.Click += new System.EventHandler(this.buttonEmoti13_Click);
            // 
            // buttonEmoti14
            // 
            this.buttonEmoti14.Image = global::ChatPOI.Properties.Resources.emoticons14;
            this.buttonEmoti14.Location = new System.Drawing.Point(42, 126);
            this.buttonEmoti14.Name = "buttonEmoti14";
            this.buttonEmoti14.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti14.TabIndex = 12;
            this.buttonEmoti14.UseVisualStyleBackColor = true;
            this.buttonEmoti14.Click += new System.EventHandler(this.buttonEmoti14_Click);
            // 
            // buttonEmoti12
            // 
            this.buttonEmoti12.Image = global::ChatPOI.Properties.Resources.emoticons12;
            this.buttonEmoti12.Location = new System.Drawing.Point(114, 91);
            this.buttonEmoti12.Name = "buttonEmoti12";
            this.buttonEmoti12.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti12.TabIndex = 11;
            this.buttonEmoti12.UseVisualStyleBackColor = true;
            this.buttonEmoti12.Click += new System.EventHandler(this.buttonEmoti12_Click);
            // 
            // buttonEmoti11
            // 
            this.buttonEmoti11.Image = global::ChatPOI.Properties.Resources.emoticons11;
            this.buttonEmoti11.Location = new System.Drawing.Point(78, 91);
            this.buttonEmoti11.Name = "buttonEmoti11";
            this.buttonEmoti11.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti11.TabIndex = 10;
            this.buttonEmoti11.UseVisualStyleBackColor = true;
            this.buttonEmoti11.Click += new System.EventHandler(this.buttonEmoti11_Click);
            // 
            // buttonEmoti2
            // 
            this.buttonEmoti2.Image = global::ChatPOI.Properties.Resources.emoticons02;
            this.buttonEmoti2.Location = new System.Drawing.Point(42, 19);
            this.buttonEmoti2.Name = "buttonEmoti2";
            this.buttonEmoti2.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti2.TabIndex = 9;
            this.buttonEmoti2.UseVisualStyleBackColor = true;
            this.buttonEmoti2.Click += new System.EventHandler(this.buttonEmoti2_Click);
            // 
            // buttonEmoti3
            // 
            this.buttonEmoti3.Image = global::ChatPOI.Properties.Resources.emoticons03;
            this.buttonEmoti3.Location = new System.Drawing.Point(78, 19);
            this.buttonEmoti3.Name = "buttonEmoti3";
            this.buttonEmoti3.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti3.TabIndex = 8;
            this.buttonEmoti3.UseVisualStyleBackColor = true;
            this.buttonEmoti3.Click += new System.EventHandler(this.buttonEmoti3_Click);
            // 
            // buttonEmoti4
            // 
            this.buttonEmoti4.Image = global::ChatPOI.Properties.Resources.emoticons04;
            this.buttonEmoti4.Location = new System.Drawing.Point(114, 19);
            this.buttonEmoti4.Name = "buttonEmoti4";
            this.buttonEmoti4.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti4.TabIndex = 7;
            this.buttonEmoti4.UseVisualStyleBackColor = true;
            this.buttonEmoti4.Click += new System.EventHandler(this.buttonEmoti4_Click);
            // 
            // buttonEmoti5
            // 
            this.buttonEmoti5.Image = global::ChatPOI.Properties.Resources.emoticons05;
            this.buttonEmoti5.Location = new System.Drawing.Point(6, 55);
            this.buttonEmoti5.Name = "buttonEmoti5";
            this.buttonEmoti5.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti5.TabIndex = 6;
            this.buttonEmoti5.UseVisualStyleBackColor = true;
            this.buttonEmoti5.Click += new System.EventHandler(this.buttonEmoti5_Click);
            // 
            // buttonEmoti6
            // 
            this.buttonEmoti6.Image = global::ChatPOI.Properties.Resources.emoticons06;
            this.buttonEmoti6.Location = new System.Drawing.Point(42, 55);
            this.buttonEmoti6.Name = "buttonEmoti6";
            this.buttonEmoti6.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti6.TabIndex = 5;
            this.buttonEmoti6.UseVisualStyleBackColor = true;
            this.buttonEmoti6.Click += new System.EventHandler(this.buttonEmoti6_Click);
            // 
            // buttonEmoti7
            // 
            this.buttonEmoti7.Image = global::ChatPOI.Properties.Resources.emoticons07;
            this.buttonEmoti7.Location = new System.Drawing.Point(78, 55);
            this.buttonEmoti7.Name = "buttonEmoti7";
            this.buttonEmoti7.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti7.TabIndex = 4;
            this.buttonEmoti7.UseVisualStyleBackColor = true;
            this.buttonEmoti7.Click += new System.EventHandler(this.buttonEmoti7_Click);
            // 
            // buttonEmoti8
            // 
            this.buttonEmoti8.Image = global::ChatPOI.Properties.Resources.emoticons08;
            this.buttonEmoti8.Location = new System.Drawing.Point(114, 55);
            this.buttonEmoti8.Name = "buttonEmoti8";
            this.buttonEmoti8.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti8.TabIndex = 3;
            this.buttonEmoti8.UseVisualStyleBackColor = true;
            this.buttonEmoti8.Click += new System.EventHandler(this.buttonEmoti8_Click);
            // 
            // buttonEmoti9
            // 
            this.buttonEmoti9.Image = global::ChatPOI.Properties.Resources.emoticons09;
            this.buttonEmoti9.Location = new System.Drawing.Point(6, 91);
            this.buttonEmoti9.Name = "buttonEmoti9";
            this.buttonEmoti9.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti9.TabIndex = 2;
            this.buttonEmoti9.UseVisualStyleBackColor = true;
            this.buttonEmoti9.Click += new System.EventHandler(this.buttonEmoti9_Click);
            // 
            // buttonEmoti10
            // 
            this.buttonEmoti10.Image = global::ChatPOI.Properties.Resources.emoticons10;
            this.buttonEmoti10.Location = new System.Drawing.Point(42, 91);
            this.buttonEmoti10.Name = "buttonEmoti10";
            this.buttonEmoti10.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti10.TabIndex = 1;
            this.buttonEmoti10.UseVisualStyleBackColor = true;
            this.buttonEmoti10.Click += new System.EventHandler(this.buttonEmoti10_Click);
            // 
            // buttonEmoti1
            // 
            this.buttonEmoti1.Image = global::ChatPOI.Properties.Resources.emoticons01;
            this.buttonEmoti1.Location = new System.Drawing.Point(6, 19);
            this.buttonEmoti1.Name = "buttonEmoti1";
            this.buttonEmoti1.Size = new System.Drawing.Size(30, 30);
            this.buttonEmoti1.TabIndex = 0;
            this.buttonEmoti1.UseVisualStyleBackColor = true;
            this.buttonEmoti1.Click += new System.EventHandler(this.buttonEmoti1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelClientReceiver
            // 
            this.labelClientReceiver.AutoSize = true;
            this.labelClientReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientReceiver.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelClientReceiver.Location = new System.Drawing.Point(15, 133);
            this.labelClientReceiver.Name = "labelClientReceiver";
            this.labelClientReceiver.Size = new System.Drawing.Size(118, 15);
            this.labelClientReceiver.TabIndex = 1;
            this.labelClientReceiver.Text = "Nombre de contacto";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelUserName.Location = new System.Drawing.Point(15, 416);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(113, 15);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "Nombre de usuario";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.labelUserName);
            this.panelLeft.Controls.Add(this.labelClientReceiver);
            this.panelLeft.Controls.Add(this.buttonJugar);
            this.panelLeft.Controls.Add(this.pictureBoxUser);
            this.panelLeft.Controls.Add(this.pictureBoxContact);
            this.panelLeft.Controls.Add(this.buttonFile);
            this.panelLeft.Controls.Add(this.buttonCall);
            this.panelLeft.Controls.Add(this.buttonCamera);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(162, 438);
            this.panelLeft.TabIndex = 11;
            // 
            // buttonJugar
            // 
            this.buttonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJugar.Image = ((System.Drawing.Image)(resources.GetObject("buttonJugar.Image")));
            this.buttonJugar.Location = new System.Drawing.Point(18, 227);
            this.buttonJugar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(45, 45);
            this.buttonJugar.TabIndex = 13;
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Location = new System.Drawing.Point(18, 294);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(110, 120);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // pictureBoxContact
            // 
            this.pictureBoxContact.Location = new System.Drawing.Point(18, 11);
            this.pictureBoxContact.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxContact.Name = "pictureBoxContact";
            this.pictureBoxContact.Size = new System.Drawing.Size(110, 120);
            this.pictureBoxContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContact.TabIndex = 0;
            this.pictureBoxContact.TabStop = false;
            // 
            // buttonFile
            // 
            this.buttonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonFile.Image")));
            this.buttonFile.Location = new System.Drawing.Point(18, 157);
            this.buttonFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(45, 45);
            this.buttonFile.TabIndex = 5;
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonCall
            // 
            this.buttonCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCall.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCall.Image = ((System.Drawing.Image)(resources.GetObject("buttonCall.Image")));
            this.buttonCall.Location = new System.Drawing.Point(83, 157);
            this.buttonCall.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(45, 45);
            this.buttonCall.TabIndex = 7;
            this.buttonCall.Text = "Llamar";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // buttonCamera
            // 
            this.buttonCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCamera.Image = ((System.Drawing.Image)(resources.GetObject("buttonCamera.Image")));
            this.buttonCamera.Location = new System.Drawing.Point(83, 227);
            this.buttonCamera.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCamera.Name = "buttonCamera";
            this.buttonCamera.Size = new System.Drawing.Size(45, 45);
            this.buttonCamera.TabIndex = 6;
            this.buttonCamera.Text = "Video";
            this.buttonCamera.UseVisualStyleBackColor = true;
            this.buttonCamera.Click += new System.EventHandler(this.buttonCamera_Click);
            // 
            // buttonBuzz
            // 
            this.buttonBuzz.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuzz.Image")));
            this.buttonBuzz.Location = new System.Drawing.Point(501, 379);
            this.buttonBuzz.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuzz.Name = "buttonBuzz";
            this.buttonBuzz.Size = new System.Drawing.Size(40, 40);
            this.buttonBuzz.TabIndex = 3;
            this.buttonBuzz.UseVisualStyleBackColor = true;
            this.buttonBuzz.Click += new System.EventHandler(this.buttonBuzz_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.AutoSize = true;
            this.buttonSend.ForeColor = System.Drawing.Color.LightBlue;
            this.buttonSend.Image = ((System.Drawing.Image)(resources.GetObject("buttonSend.Image")));
            this.buttonSend.Location = new System.Drawing.Point(545, 335);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(118, 91);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonEmoticon
            // 
            this.buttonEmoticon.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmoticon.Image")));
            this.buttonEmoticon.Location = new System.Drawing.Point(501, 335);
            this.buttonEmoticon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEmoticon.Name = "buttonEmoticon";
            this.buttonEmoticon.Size = new System.Drawing.Size(40, 40);
            this.buttonEmoticon.TabIndex = 4;
            this.buttonEmoticon.UseVisualStyleBackColor = true;
            this.buttonEmoticon.Click += new System.EventHandler(this.buttonEmoticon_Click);
            // 
            // WindowChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(667, 438);
            this.Controls.Add(this.buttonBuzz);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonEmoticon);
            this.Controls.Add(this.groupBoxEmoticons);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.richTextBoxChat);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WindowChat";
            this.Text = "Usuario";
            this.groupBoxEmoticons.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxChat;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonEmoticon;
        private System.Windows.Forms.Button buttonBuzz;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.GroupBox groupBoxEmoticons;
        private System.Windows.Forms.Button buttonEmoti1;
        private System.Windows.Forms.Button buttonEmoti2;
        private System.Windows.Forms.Button buttonEmoti3;
        private System.Windows.Forms.Button buttonEmoti4;
        private System.Windows.Forms.Button buttonEmoti5;
        private System.Windows.Forms.Button buttonEmoti6;
        private System.Windows.Forms.Button buttonEmoti7;
        private System.Windows.Forms.Button buttonEmoti8;
        private System.Windows.Forms.Button buttonEmoti9;
        private System.Windows.Forms.Button buttonEmoti10;
        private System.Windows.Forms.Button buttonEmoti16;
        private System.Windows.Forms.Button buttonEmoti15;
        private System.Windows.Forms.Button buttonEmoti13;
        private System.Windows.Forms.Button buttonEmoti14;
        private System.Windows.Forms.Button buttonEmoti12;
        private System.Windows.Forms.Button buttonEmoti11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonCamera;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.PictureBox pictureBoxContact;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Label labelClientReceiver;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Panel panelLeft;
    }
}