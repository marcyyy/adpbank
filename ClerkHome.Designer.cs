namespace adpbank
{
    partial class ClerkHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClerkHome));
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ncTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.adminID = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.editBtn = new System.Windows.Forms.PictureBox();
            this.addBtn = new System.Windows.Forms.PictureBox();
            this.delBtn = new System.Windows.Forms.PictureBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.editTB = new System.Windows.Forms.TextBox();
            this.reloadBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutNav = new System.Windows.Forms.Button();
            this.adpLabel = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            this.adpLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reloadBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adpLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Montserrat Medium", 14F);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameLabel.Location = new System.Drawing.Point(136, 801);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(160, 40);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(90, 801);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ncTable
            // 
            this.ncTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ncTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ncTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.account_number,
            this.total_amount,
            this.first_name,
            this.last_name,
            this.contact,
            this.email,
            this.address,
            this.birthdate,
            this.occupation,
            this.username,
            this.password,
            this.client_info,
            this.creation,
            this.active,
            this.id1,
            this.active1});
            this.ncTable.Location = new System.Drawing.Point(61, 200);
            this.ncTable.Name = "ncTable";
            this.ncTable.Size = new System.Drawing.Size(1177, 571);
            this.ncTable.TabIndex = 14;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // account_number
            // 
            this.account_number.DataPropertyName = "account_number";
            this.account_number.HeaderText = "Account Number";
            this.account_number.Name = "account_number";
            // 
            // total_amount
            // 
            this.total_amount.DataPropertyName = "total_amount";
            this.total_amount.HeaderText = "Funds Balance";
            this.total_amount.Name = "total_amount";
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "First Name";
            this.first_name.Name = "first_name";
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Last Name";
            this.last_name.Name = "last_name";
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "Contact";
            this.contact.Name = "contact";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // birthdate
            // 
            this.birthdate.DataPropertyName = "birthdate";
            this.birthdate.HeaderText = "Birthday";
            this.birthdate.Name = "birthdate";
            this.birthdate.Visible = false;
            // 
            // occupation
            // 
            this.occupation.DataPropertyName = "occupation";
            this.occupation.HeaderText = "Occupation";
            this.occupation.Name = "occupation";
            this.occupation.Visible = false;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.Visible = false;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.Visible = false;
            // 
            // client_info
            // 
            this.client_info.DataPropertyName = "client_info";
            this.client_info.HeaderText = "Client Information ID";
            this.client_info.Name = "client_info";
            this.client_info.Visible = false;
            // 
            // creation
            // 
            this.creation.DataPropertyName = "creation";
            this.creation.HeaderText = "Date Created";
            this.creation.Name = "creation";
            this.creation.Visible = false;
            // 
            // active
            // 
            this.active.DataPropertyName = "active";
            this.active.HeaderText = "Active";
            this.active.Name = "active";
            this.active.Visible = false;
            // 
            // id1
            // 
            this.id1.DataPropertyName = "id1";
            this.id1.HeaderText = "ID2";
            this.id1.Name = "id1";
            this.id1.Visible = false;
            // 
            // active1
            // 
            this.active1.DataPropertyName = "active1";
            this.active1.HeaderText = "Active2";
            this.active1.Name = "active1";
            this.active1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.label6.Location = new System.Drawing.Point(82, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 48);
            this.label6.TabIndex = 7;
            this.label6.Text = "Client List";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminID
            // 
            this.adminID.AutoSize = true;
            this.adminID.Font = new System.Drawing.Font("Montserrat", 12F);
            this.adminID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminID.Location = new System.Drawing.Point(567, 823);
            this.adminID.Name = "adminID";
            this.adminID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.adminID.Size = new System.Drawing.Size(85, 22);
            this.adminID.TabIndex = 26;
            this.adminID.Text = "admin_id";
            this.adminID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Montserrat", 12F);
            this.userLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userLabel.Location = new System.Drawing.Point(570, 801);
            this.userLabel.Name = "userLabel";
            this.userLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userLabel.Size = new System.Drawing.Size(92, 22);
            this.userLabel.TabIndex = 25;
            this.userLabel.Text = "username";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchBtn
            // 
            this.searchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBtn.BackgroundImage")));
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Location = new System.Drawing.Point(1103, 140);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(40, 40);
            this.searchBtn.TabIndex = 27;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editBtn.BackgroundImage")));
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Location = new System.Drawing.Point(1103, 802);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(40, 40);
            this.editBtn.TabIndex = 28;
            this.editBtn.TabStop = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBtn.BackgroundImage")));
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Location = new System.Drawing.Point(1149, 139);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(40, 40);
            this.addBtn.TabIndex = 29;
            this.addBtn.TabStop = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delBtn.BackgroundImage")));
            this.delBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.Location = new System.Drawing.Point(1149, 802);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(40, 40);
            this.delBtn.TabIndex = 31;
            this.delBtn.TabStop = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(781, 139);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(315, 43);
            this.searchTB.TabIndex = 32;
            // 
            // editTB
            // 
            this.editTB.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTB.Location = new System.Drawing.Point(781, 801);
            this.editTB.Name = "editTB";
            this.editTB.Size = new System.Drawing.Size(315, 43);
            this.editTB.TabIndex = 33;
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reloadBtn.BackgroundImage")));
            this.reloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadBtn.Location = new System.Drawing.Point(734, 141);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(40, 40);
            this.reloadBtn.TabIndex = 34;
            this.reloadBtn.TabStop = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.logoutNav);
            this.panel1.Controls.Add(this.adpLabel);
            this.panel1.Controls.Add(this.bankLabel);
            this.panel1.Controls.Add(this.adpLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 100);
            this.panel1.TabIndex = 35;
            // 
            // logoutNav
            // 
            this.logoutNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutNav.FlatAppearance.BorderSize = 0;
            this.logoutNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutNav.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.logoutNav.Location = new System.Drawing.Point(1088, 22);
            this.logoutNav.Name = "logoutNav";
            this.logoutNav.Size = new System.Drawing.Size(150, 50);
            this.logoutNav.TabIndex = 6;
            this.logoutNav.Text = "Logout";
            this.logoutNav.UseVisualStyleBackColor = true;
            this.logoutNav.Click += new System.EventHandler(this.logoutNav_Click);
            // 
            // adpLabel
            // 
            this.adpLabel.AutoSize = true;
            this.adpLabel.BackColor = System.Drawing.Color.Transparent;
            this.adpLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.adpLabel.ForeColor = System.Drawing.Color.White;
            this.adpLabel.Location = new System.Drawing.Point(129, 17);
            this.adpLabel.Name = "adpLabel";
            this.adpLabel.Size = new System.Drawing.Size(66, 44);
            this.adpLabel.TabIndex = 2;
            this.adpLabel.Text = "AC";
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.BackColor = System.Drawing.Color.Transparent;
            this.bankLabel.Font = new System.Drawing.Font("Montserrat", 14F);
            this.bankLabel.ForeColor = System.Drawing.Color.White;
            this.bankLabel.Location = new System.Drawing.Point(129, 56);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(100, 26);
            this.bankLabel.TabIndex = 3;
            this.bankLabel.Text = "Bank Inc.";
            // 
            // adpLogo
            // 
            this.adpLogo.BackColor = System.Drawing.Color.Transparent;
            this.adpLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adpLogo.BackgroundImage")));
            this.adpLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adpLogo.Location = new System.Drawing.Point(61, 17);
            this.adpLogo.Margin = new System.Windows.Forms.Padding(0);
            this.adpLogo.Name = "adpLogo";
            this.adpLogo.Size = new System.Drawing.Size(65, 65);
            this.adpLogo.TabIndex = 1;
            this.adpLogo.TabStop = false;
            // 
            // ClerkHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1296, 877);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.editTB);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.adminID);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ncTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClerkHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reloadBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adpLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView ncTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label adminID;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn creation;
        private System.Windows.Forms.DataGridViewTextBoxColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn active1;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.PictureBox editBtn;
        private System.Windows.Forms.PictureBox addBtn;
        private System.Windows.Forms.PictureBox delBtn;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.TextBox editTB;
        private System.Windows.Forms.PictureBox reloadBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutNav;
        private System.Windows.Forms.Label adpLabel;
        private System.Windows.Forms.Label bankLabel;
        public System.Windows.Forms.PictureBox adpLogo;
    }
}