namespace adpbank
{
    partial class ClientTransaction2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientTransaction2));
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
            this.accTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clientID = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adpLogo)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).BeginInit();
            this.scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(1072, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Balance (₱)";
            // 
            // fundsLabel
            // 
            this.fundsLabel.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundsLabel.Location = new System.Drawing.Point(922, 86);
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
            this.scrollPanel.Controls.Add(this.accTB);
            this.scrollPanel.Controls.Add(this.label5);
            this.scrollPanel.Controls.Add(this.backBtn);
            this.scrollPanel.Controls.Add(this.confirmBtn);
            this.scrollPanel.Controls.Add(this.amountTB);
            this.scrollPanel.Controls.Add(this.label4);
            this.scrollPanel.Controls.Add(this.clientID);
            this.scrollPanel.Controls.Add(this.userLabel);
            this.scrollPanel.Controls.Add(this.label3);
            this.scrollPanel.Controls.Add(this.trLabel);
            this.scrollPanel.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrollPanel.Location = new System.Drawing.Point(0, 406);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(1500, 543);
            this.scrollPanel.TabIndex = 2;
            // 
            // accTB
            // 
            this.accTB.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accTB.Location = new System.Drawing.Point(101, 181);
            this.accTB.Name = "accTB";
            this.accTB.Size = new System.Drawing.Size(700, 66);
            this.accTB.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 145);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(346, 33);
            this.label5.TabIndex = 19;
            this.label5.Text = "Recipient Account Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Location = new System.Drawing.Point(101, 26);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(40, 40);
            this.backBtn.TabIndex = 21;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmBtn.Location = new System.Drawing.Point(1164, 395);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(200, 60);
            this.confirmBtn.TabIndex = 16;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // amountTB
            // 
            this.amountTB.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTB.Location = new System.Drawing.Point(864, 181);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(500, 66);
            this.amountTB.TabIndex = 15;
            this.amountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(864, 145);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(195, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount (Peso)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.label3.Location = new System.Drawing.Point(1230, 66);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Transaction";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trLabel
            // 
            this.trLabel.AutoSize = true;
            this.trLabel.Font = new System.Drawing.Font("Montserrat", 36F);
            this.trLabel.Location = new System.Drawing.Point(1168, 0);
            this.trLabel.Name = "trLabel";
            this.trLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trLabel.Size = new System.Drawing.Size(222, 66);
            this.trLabel.TabIndex = 10;
            this.trLabel.Text = "Transfer";
            // 
            // ClientTransaction2
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
            this.Name = "ClientTransaction2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ClientTransaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adpLogo)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).EndInit();
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
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
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label trLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label clientID;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accTB;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox backBtn;
    }
}