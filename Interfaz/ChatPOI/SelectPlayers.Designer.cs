﻿namespace ChatPOI
{
    partial class SelectPlayers
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
            this.contactList = new System.Windows.Forms.CheckedListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contactList
            // 
            this.contactList.FormattingEnabled = true;
            this.contactList.Location = new System.Drawing.Point(12, 12);
            this.contactList.Name = "contactList";
            this.contactList.Size = new System.Drawing.Size(166, 364);
            this.contactList.TabIndex = 18;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(223, 353);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 19;
            this.buttonStart.Text = "Empezar";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // SelectPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 387);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.contactList);
            this.Name = "SelectPlayers";
            this.Text = "SelectPlayers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox contactList;
        private System.Windows.Forms.Button buttonStart;
    }
}