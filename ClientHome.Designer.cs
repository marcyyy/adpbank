namespace adpbank
{
    partial class ClientHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutNav = new System.Windows.Forms.Button();
            this.adpLabel = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            this.transactionNav = new System.Windows.Forms.Button();
            this.adpLogo = new System.Windows.Forms.PictureBox();
            this.homeNav = new System.Windows.Forms.Button();
            this.accNav = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.accLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fundsLabel = new System.Windows.Forms.Label();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.clientID = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.PictureBox();
            this.trLabel = new System.Windows.Forms.Label();
            this.clientView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.og_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tr_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tr_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adpLogo)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).BeginInit();
            this.scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.logoutNav);
            this.panel1.Controls.Add(this.adpLabel);
            this.panel1.Controls.Add(this.bankLabel);
            this.panel1.Controls.Add(this.transactionNav);
            this.panel1.Controls.Add(this.adpLogo);
            this.panel1.Controls.Add(this.homeNav);
            this.panel1.Controls.Add(this.accNav);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 100);
            this.panel1.TabIndex = 0;
            // 
            // logoutNav
            // 
            this.logoutNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutNav.FlatAppearance.BorderSize = 0;
            this.logoutNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutNav.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.logoutNav.Location = new System.Drawing.Point(1310, 21);
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
            // transactionNav
            // 
            this.transactionNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.transactionNav.FlatAppearance.BorderSize = 0;
            this.transactionNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionNav.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.transactionNav.Location = new System.Drawing.Point(998, 21);
            this.transactionNav.Name = "transactionNav";
            this.transactionNav.Size = new System.Drawing.Size(150, 50);
            this.transactionNav.TabIndex = 4;
            this.transactionNav.Text = "Transaction";
            this.transactionNav.UseVisualStyleBackColor = true;
            this.transactionNav.Click += new System.EventHandler(this.transferNav_Click);
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
            // homeNav
            // 
            this.homeNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeNav.FlatAppearance.BorderSize = 0;
            this.homeNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeNav.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.homeNav.Location = new System.Drawing.Point(842, 21);
            this.homeNav.Name = "homeNav";
            this.homeNav.Size = new System.Drawing.Size(150, 50);
            this.homeNav.TabIndex = 0;
            this.homeNav.Text = "Home";
            this.homeNav.UseVisualStyleBackColor = true;
            this.homeNav.Click += new System.EventHandler(this.homeNav_Click);
            // 
            // accNav
            // 
            this.accNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accNav.FlatAppearance.BorderSize = 0;
            this.accNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accNav.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.accNav.Location = new System.Drawing.Point(1154, 21);
            this.accNav.Name = "accNav";
            this.accNav.Size = new System.Drawing.Size(150, 50);
            this.accNav.TabIndex = 5;
            this.accNav.Text = "Account";
            this.accNav.UseVisualStyleBackColor = true;
            this.accNav.Click += new System.EventHandler(this.accNav_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.splitter1);
            this.infoPanel.Controls.Add(this.accLabel);
            this.infoPanel.Controls.Add(this.nameLabel);
            this.infoPanel.Controls.Add(this.userLogo);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this.fundsLabel);
            this.infoPanel.Location = new System.Drawing.Point(0, 98);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1488, 304);
            this.infoPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(59, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1378, 10);
            this.label2.TabIndex = 11;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 300);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // accLabel
            // 
            this.accLabel.Font = new System.Drawing.Font("Montserrat", 18F);
            this.accLabel.Location = new System.Drawing.Point(254, 171);
            this.accLabel.Name = "accLabel";
            this.accLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.accLabel.Size = new System.Drawing.Size(600, 33);
            this.accLabel.TabIndex = 9;
            this.accLabel.Text = "Account Number";
            this.accLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(249, 132);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLabel.Size = new System.Drawing.Size(600, 44);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Client Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // userLogo
            // 
            this.userLogo.BackColor = System.Drawing.Color.Transparent;
            this.userLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userLogo.BackgroundImage")));
            this.userLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userLogo.Location = new System.Drawing.Point(86, 70);
            this.userLogo.Margin = new System.Windows.Forms.Padding(0);
            this.userLogo.Name = "userLogo";
            this.userLogo.Size = new System.Drawing.Size(150, 150);
            this.userLogo.TabIndex = 7;
            this.userLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16F);
            this.label1.Location = new System.Drawing.Point(1073, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Balance (₱)";
            // 
            // fundsLabel
            // 
            this.fundsLabel.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundsLabel.Location = new System.Drawing.Point(919, 88);
            this.fundsLabel.Name = "fundsLabel";
            this.fundsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fundsLabel.Size = new System.Drawing.Size(500, 88);
            this.fundsLabel.TabIndex = 0;
            this.fundsLabel.Text = "0";
            this.fundsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.clientID);
            this.scrollPanel.Controls.Add(this.userLabel);
            this.scrollPanel.Controls.Add(this.label3);
            this.scrollPanel.Controls.Add(this.nextBtn);
            this.scrollPanel.Controls.Add(this.trLabel);
            this.scrollPanel.Controls.Add(this.clientView1);
            this.scrollPanel.Location = new System.Drawing.Point(0, 399);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(1500, 550);
            this.scrollPanel.TabIndex = 2;
            // 
            // clientID
            // 
            this.clientID.AutoSize = true;
            this.clientID.Font = new System.Drawing.Font("Montserrat", 12F);
            this.clientID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clientID.Location = new System.Drawing.Point(186, 507);
            this.clientID.Name = "clientID";
            this.clientID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientID.Size = new System.Drawing.Size(79, 22);
            this.clientID.TabIndex = 13;
            this.clientID.Text = "client_id";
            this.clientID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Montserrat", 12F);
            this.userLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userLabel.Location = new System.Drawing.Point(88, 507);
            this.userLabel.Name = "userLabel";
            this.userLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userLabel.Size = new System.Drawing.Size(92, 22);
            this.userLabel.TabIndex = 12;
            this.userLabel.Text = "username";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 62);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(255, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Withdraw and Deposit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextBtn.BackgroundImage")));
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Location = new System.Drawing.Point(1352, 32);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(0);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(40, 40);
            this.nextBtn.TabIndex = 12;
            this.nextBtn.TabStop = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // trLabel
            // 
            this.trLabel.AutoSize = true;
            this.trLabel.Font = new System.Drawing.Font("Montserrat", 36F);
            this.trLabel.Location = new System.Drawing.Point(78, 6);
            this.trLabel.Name = "trLabel";
            this.trLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trLabel.Size = new System.Drawing.Size(331, 66);
            this.trLabel.TabIndex = 10;
            this.trLabel.Text = "Transactions";
            // 
            // clientView1
            // 
            this.clientView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.transaction_type,
            this.tr_id,
            this.og_amount,
            this.tr_amount,
            this.new_amount,
            this.tr_dt,
            this.client_id,
            this.active});
            this.clientView1.Location = new System.Drawing.Point(88, 104);
            this.clientView1.Name = "clientView1";
            this.clientView1.Size = new System.Drawing.Size(1329, 383);
            this.clientView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 110;
            // 
            // transaction_type
            // 
            this.transaction_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.transaction_type.DataPropertyName = "transaction_type";
            this.transaction_type.Frozen = true;
            this.transaction_type.HeaderText = "Transaction Type";
            this.transaction_type.Name = "transaction_type";
            this.transaction_type.Width = 220;
            // 
            // tr_id
            // 
            this.tr_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tr_id.DataPropertyName = "tr_id";
            this.tr_id.Frozen = true;
            this.tr_id.HeaderText = "Transaction ID";
            this.tr_id.Name = "tr_id";
            this.tr_id.Width = 280;
            // 
            // og_amount
            // 
            this.og_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.og_amount.DataPropertyName = "og_amount";
            this.og_amount.Frozen = true;
            this.og_amount.HeaderText = "Previous Amount";
            this.og_amount.Name = "og_amount";
            this.og_amount.Width = 180;
            // 
            // tr_amount
            // 
            this.tr_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tr_amount.DataPropertyName = "tr_amount";
            this.tr_amount.Frozen = true;
            this.tr_amount.HeaderText = "Transaction Amount";
            this.tr_amount.Name = "tr_amount";
            this.tr_amount.Width = 180;
            // 
            // new_amount
            // 
            this.new_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.new_amount.DataPropertyName = "new_amount";
            this.new_amount.Frozen = true;
            this.new_amount.HeaderText = "New Amount";
            this.new_amount.Name = "new_amount";
            this.new_amount.Width = 215;
            // 
            // tr_dt
            // 
            this.tr_dt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tr_dt.DataPropertyName = "tr_dt";
            this.tr_dt.Frozen = true;
            this.tr_dt.HeaderText = "Transaction Date";
            this.tr_dt.Name = "tr_dt";
            this.tr_dt.Width = 214;
            // 
            // client_id
            // 
            this.client_id.Frozen = true;
            this.client_id.HeaderText = "Client ID";
            this.client_id.Name = "client_id";
            this.client_id.Visible = false;
            // 
            // active
            // 
            this.active.Frozen = true;
            this.active.HeaderText = "Active";
            this.active.Name = "active";
            this.active.Visible = false;
            // 
            // ClientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1500, 950);
            this.Controls.Add(this.scrollPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ClientHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adpLogo)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).EndInit();
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homeNav;
        public System.Windows.Forms.PictureBox adpLogo;
        private System.Windows.Forms.Label adpLabel;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Button transactionNav;
        private System.Windows.Forms.Button logoutNav;
        private System.Windows.Forms.Button accNav;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label accLabel;
        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.PictureBox userLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fundsLabel;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.DataGridView clientView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label trLabel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox nextBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label clientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn tr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn og_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tr_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tr_dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn active;
    }
}