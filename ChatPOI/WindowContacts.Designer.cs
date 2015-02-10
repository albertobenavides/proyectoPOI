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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowContacts));
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.comboBoxUserStatus = new System.Windows.Forms.ComboBox();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.flowLayoutPanelAddContact = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.textBoxAddContact = new System.Windows.Forms.TextBox();
            this.labelAddContact = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelUserInfo.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.flowLayoutPanelAddContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.textBoxUserName.TabStop = false;
            this.textBoxUserName.Text = "Nombre de Usuario";
            // 
            // comboBoxUserStatus
            // 
            this.comboBoxUserStatus.FormattingEnabled = true;
            this.comboBoxUserStatus.Items.AddRange(new object[] {
            "Disponible",
            "Ocupado",
            "Ausente",
            "Invisible"});
            this.comboBoxUserStatus.Location = new System.Drawing.Point(109, 101);
            this.comboBoxUserStatus.Name = "comboBoxUserStatus";
            this.comboBoxUserStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUserStatus.TabIndex = 2;
            this.comboBoxUserStatus.Text = "Disponible";
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.textBoxSearch);
            this.panelUserInfo.Controls.Add(this.pictureBoxUser);
            this.panelUserInfo.Controls.Add(this.textBoxUserName);
            this.panelUserInfo.Controls.Add(this.comboBoxUserStatus);
            this.panelUserInfo.Controls.Add(this.panelLogout);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 0);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(453, 144);
            this.panelUserInfo.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxSearch.Location = new System.Drawing.Point(0, 124);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(379, 20);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.Text = "Buscar contacto...";
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.linkLabelLogout);
            this.panelLogout.Controls.Add(this.buttonSearch);
            this.panelLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogout.Location = new System.Drawing.Point(379, 0);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(74, 144);
            this.panelLogout.TabIndex = 3;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(3, 3);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(68, 13);
            this.linkLabelLogout.TabIndex = 0;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Cerrar sesión";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSearch.Location = new System.Drawing.Point(0, 121);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(74, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelAddContact
            // 
            this.flowLayoutPanelAddContact.AutoSize = true;
            this.flowLayoutPanelAddContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelAddContact.Controls.Add(this.buttonAddContact);
            this.flowLayoutPanelAddContact.Controls.Add(this.textBoxAddContact);
            this.flowLayoutPanelAddContact.Controls.Add(this.labelAddContact);
            this.flowLayoutPanelAddContact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelAddContact.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelAddContact.Location = new System.Drawing.Point(0, 380);
            this.flowLayoutPanelAddContact.Name = "flowLayoutPanelAddContact";
            this.flowLayoutPanelAddContact.Size = new System.Drawing.Size(453, 29);
            this.flowLayoutPanelAddContact.TabIndex = 9;
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Location = new System.Drawing.Point(425, 3);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(25, 23);
            this.buttonAddContact.TabIndex = 0;
            this.buttonAddContact.Text = "+";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            // 
            // textBoxAddContact
            // 
            this.textBoxAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddContact.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxAddContact.Location = new System.Drawing.Point(303, 3);
            this.textBoxAddContact.Name = "textBoxAddContact";
            this.textBoxAddContact.Size = new System.Drawing.Size(116, 20);
            this.textBoxAddContact.TabIndex = 1;
            this.textBoxAddContact.Text = "Nombre de usuario";
            // 
            // labelAddContact
            // 
            this.labelAddContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAddContact.AutoSize = true;
            this.labelAddContact.Location = new System.Drawing.Point(212, 8);
            this.labelAddContact.Name = "labelAddContact";
            this.labelAddContact.Size = new System.Drawing.Size(85, 13);
            this.labelAddContact.TabIndex = 2;
            this.labelAddContact.Text = "Añadir contacto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStatus,
            this.ColumnContact,
            this.ColumnMessage});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(453, 236);
            this.dataGridView1.TabIndex = 10;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Estado";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnContact
            // 
            this.ColumnContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnContact.HeaderText = "Contacto";
            this.ColumnContact.Name = "ColumnContact";
            this.ColumnContact.ReadOnly = true;
            this.ColumnContact.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnContact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnMessage
            // 
            this.ColumnMessage.HeaderText = "Mensaje";
            this.ColumnMessage.Name = "ColumnMessage";
            this.ColumnMessage.ReadOnly = true;
            this.ColumnMessage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnMessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WindowContacts
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 409);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelUserInfo);
            this.Controls.Add(this.flowLayoutPanelAddContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WindowContacts";
            this.Text = "Cheet-A-Chat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.panelLogout.ResumeLayout(false);
            this.panelLogout.PerformLayout();
            this.flowLayoutPanelAddContact.ResumeLayout(false);
            this.flowLayoutPanelAddContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAddContact;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMessage;
        private System.Windows.Forms.TextBox textBoxAddContact;
        private System.Windows.Forms.Label labelAddContact;
    }
}