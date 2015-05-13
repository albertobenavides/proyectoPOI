namespace ChatPOI
{
    partial class WindowContacts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowContacts));
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.comboBoxUserStatus = new System.Windows.Forms.ComboBox();
            this.groupChatButton = new System.Windows.Forms.Button();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelAddContact = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxUserName.Location = new System.Drawing.Point(164, 65);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(164, 19);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.Text = "Nombre de Usuario";
            // 
            // comboBoxUserStatus
            // 
            this.comboBoxUserStatus.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxUserStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUserStatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.comboBoxUserStatus.FormattingEnabled = true;
            this.comboBoxUserStatus.Items.AddRange(new object[] {
            "Disponible",
            "Ausente",
            "Ocupado",
            "Desconectado"});
            this.comboBoxUserStatus.Location = new System.Drawing.Point(219, 102);
            this.comboBoxUserStatus.Name = "comboBoxUserStatus";
            this.comboBoxUserStatus.Size = new System.Drawing.Size(109, 21);
            this.comboBoxUserStatus.TabIndex = 2;
            this.comboBoxUserStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserStatus_SelectionChangeCommitted);
            // 
            // groupChatButton
            // 
            this.groupChatButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupChatButton.FlatAppearance.BorderSize = 0;
            this.groupChatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupChatButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupChatButton.Location = new System.Drawing.Point(334, 172);
            this.groupChatButton.Name = "groupChatButton";
            this.groupChatButton.Size = new System.Drawing.Size(103, 24);
            this.groupChatButton.TabIndex = 4;
            this.groupChatButton.Text = "Chat grupal";
            this.groupChatButton.UseVisualStyleBackColor = false;
            this.groupChatButton.Click += new System.EventHandler(this.groupChatButton_Click);
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabelLogout.Location = new System.Drawing.Point(257, 137);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(71, 13);
            this.linkLabelLogout.TabIndex = 8;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Cerrar sesión";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // flowLayoutPanelAddContact
            // 
            this.flowLayoutPanelAddContact.AutoSize = true;
            this.flowLayoutPanelAddContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelAddContact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelAddContact.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelAddContact.Location = new System.Drawing.Point(0, 408);
            this.flowLayoutPanelAddContact.Name = "flowLayoutPanelAddContact";
            this.flowLayoutPanelAddContact.Size = new System.Drawing.Size(449, 0);
            this.flowLayoutPanelAddContact.TabIndex = 9;
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.AllowUserToAddRows = false;
            this.dataGridViewContacts.AllowUserToDeleteRows = false;
            this.dataGridViewContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewContacts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStatus,
            this.ColumnContactName,
            this.ColumnMessage});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewContacts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContacts.EnableHeadersVisualStyles = false;
            this.dataGridViewContacts.GridColor = System.Drawing.Color.White;
            this.dataGridViewContacts.Location = new System.Drawing.Point(12, 211);
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.ReadOnly = true;
            this.dataGridViewContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewContacts.RowHeadersVisible = false;
            this.dataGridViewContacts.Size = new System.Drawing.Size(425, 185);
            this.dataGridViewContacts.TabIndex = 5;
            this.dataGridViewContacts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContacts_CellDoubleClick);
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnStatus.HeaderText = "Estado";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnStatus.Width = 120;
            // 
            // ColumnContactName
            // 
            this.ColumnContactName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnContactName.HeaderText = "Nombre";
            this.ColumnContactName.Name = "ColumnContactName";
            this.ColumnContactName.ReadOnly = true;
            // 
            // ColumnMessage
            // 
            this.ColumnMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnMessage.HeaderText = "Mensaje";
            this.ColumnMessage.Name = "ColumnMessage";
            this.ColumnMessage.ReadOnly = true;
            this.ColumnMessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnMessage.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(161, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(12, 17);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(119, 133);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            this.pictureBoxUser.Click += new System.EventHandler(this.pictureBoxUser_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.LightSlateGray;
            this.textBoxSearch.Location = new System.Drawing.Point(12, 172);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(316, 24);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.Text = "Buscar contacto...";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // WindowContacts
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(449, 408);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.groupChatButton);
            this.Controls.Add(this.comboBoxUserStatus);
            this.Controls.Add(this.dataGridViewContacts);
            this.Controls.Add(this.flowLayoutPanelAddContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WindowContacts";
            this.Text = "Cheet-A-Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowContacts_FormClosing);
            this.Load += new System.EventHandler(this.WindowContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.ComboBox comboBoxUserStatus;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAddContact;
        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMessage;
        private System.Windows.Forms.Button groupChatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}