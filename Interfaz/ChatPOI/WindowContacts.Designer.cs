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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowContacts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.comboBoxUserStatus = new System.Windows.Forms.ComboBox();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelAddContact = new System.Windows.Forms.FlowLayoutPanel();
            this.labelServerMessage = new System.Windows.Forms.Label();
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelUserInfo.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.flowLayoutPanelAddContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(100, 120);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Location = new System.Drawing.Point(109, 82);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 13);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.Text = "Nombre de Usuario";
            // 
            // comboBoxUserStatus
            // 
            this.comboBoxUserStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUserStatus.FormattingEnabled = true;
            this.comboBoxUserStatus.Items.AddRange(new object[] {
            "Disponible",
            "Ausente",
            "Ocupado",
            "Invisible"});
            this.comboBoxUserStatus.Location = new System.Drawing.Point(109, 101);
            this.comboBoxUserStatus.Name = "comboBoxUserStatus";
            this.comboBoxUserStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUserStatus.TabIndex = 2;
            this.comboBoxUserStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserStatus_SelectionChangeCommitted);
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.pictureBoxUser);
            this.panelUserInfo.Controls.Add(this.textBoxUserName);
            this.panelUserInfo.Controls.Add(this.comboBoxUserStatus);
            this.panelUserInfo.Controls.Add(this.panelLogout);
            this.panelUserInfo.Controls.Add(this.textBoxSearch);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 0);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(453, 144);
            this.panelUserInfo.TabIndex = 8;
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.linkLabelLogout);
            this.panelLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogout.Location = new System.Drawing.Point(379, 0);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(74, 124);
            this.panelLogout.TabIndex = 3;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(3, 3);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(68, 13);
            this.linkLabelLogout.TabIndex = 8;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Cerrar sesión";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxSearch.Location = new System.Drawing.Point(0, 124);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(453, 20);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.Text = "Buscar contacto...";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // flowLayoutPanelAddContact
            // 
            this.flowLayoutPanelAddContact.AutoSize = true;
            this.flowLayoutPanelAddContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelAddContact.Controls.Add(this.labelServerMessage);
            this.flowLayoutPanelAddContact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelAddContact.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelAddContact.Location = new System.Drawing.Point(0, 396);
            this.flowLayoutPanelAddContact.Name = "flowLayoutPanelAddContact";
            this.flowLayoutPanelAddContact.Size = new System.Drawing.Size(453, 13);
            this.flowLayoutPanelAddContact.TabIndex = 9;
            // 
            // labelServerMessage
            // 
            this.labelServerMessage.AutoSize = true;
            this.labelServerMessage.Location = new System.Drawing.Point(365, 0);
            this.labelServerMessage.Name = "labelServerMessage";
            this.labelServerMessage.Size = new System.Drawing.Size(85, 13);
            this.labelServerMessage.TabIndex = 2;
            this.labelServerMessage.Text = "Añadir contacto:";
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.AllowUserToAddRows = false;
            this.dataGridViewContacts.AllowUserToDeleteRows = false;
            this.dataGridViewContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewContacts.BackgroundColor = System.Drawing.Color.White;
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
            this.dataGridViewContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContacts.EnableHeadersVisualStyles = false;
            this.dataGridViewContacts.Location = new System.Drawing.Point(0, 144);
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.ReadOnly = true;
            this.dataGridViewContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewContacts.RowHeadersVisible = false;
            this.dataGridViewContacts.Size = new System.Drawing.Size(453, 252);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WindowContacts
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 409);
            this.Controls.Add(this.dataGridViewContacts);
            this.Controls.Add(this.panelUserInfo);
            this.Controls.Add(this.flowLayoutPanelAddContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WindowContacts";
            this.Text = "Cheet-A-Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WindowContacts_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.panelLogout.ResumeLayout(false);
            this.panelLogout.PerformLayout();
            this.flowLayoutPanelAddContact.ResumeLayout(false);
            this.flowLayoutPanelAddContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.ComboBox comboBoxUserStatus;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAddContact;
        private System.Windows.Forms.Label labelServerMessage;
        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMessage;
        private System.Windows.Forms.Timer timer1;
    }
}