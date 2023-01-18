namespace adpbank
{
    partial class TellerAccountNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TellerAccountNumber));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.adpLabel = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            this.adpLogo = new System.Windows.Forms.PictureBox();
            this.backNav = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.adminID = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.acnCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adpLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.adpLabel);
            this.panel1.Controls.Add(this.bankLabel);
            this.panel1.Controls.Add(this.adpLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 116);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(266, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1236, 764);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(160, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1147, 10);
            this.label2.TabIndex = 12;
            // 
            // adpLabel
            // 
            this.adpLabel.AutoSize = true;
            this.adpLabel.BackColor = System.Drawing.Color.Transparent;
            this.adpLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.adpLabel.ForeColor = System.Drawing.Color.White;
            this.adpLabel.Location = new System.Drawing.Point(106, 23);
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
            this.bankLabel.Location = new System.Drawing.Point(106, 62);
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
            this.adpLogo.Location = new System.Drawing.Point(38, 23);
            this.adpLogo.Margin = new System.Windows.Forms.Padding(0);
            this.adpLogo.Name = "adpLogo";
            this.adpLogo.Size = new System.Drawing.Size(65, 65);
            this.adpLogo.TabIndex = 1;
            this.adpLogo.TabStop = false;
            // 
            // backNav
            // 
            this.backNav.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.backNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backNav.FlatAppearance.BorderSize = 0;
            this.backNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backNav.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backNav.ForeColor = System.Drawing.Color.White;
            this.backNav.Location = new System.Drawing.Point(38, 252);
            this.backNav.Name = "backNav";
            this.backNav.Size = new System.Drawing.Size(160, 50);
            this.backNav.TabIndex = 6;
            this.backNav.Text = "Back";
            this.backNav.UseVisualStyleBackColor = false;
            this.backNav.Click += new System.EventHandler(this.backNav_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Montserrat", 12F);
            this.userLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userLabel.Location = new System.Drawing.Point(324, 134);
            this.userLabel.Name = "userLabel";
            this.userLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userLabel.Size = new System.Drawing.Size(92, 22);
            this.userLabel.TabIndex = 25;
            this.userLabel.Text = "username";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // adminID
            // 
            this.adminID.AutoSize = true;
            this.adminID.Font = new System.Drawing.Font("Montserrat", 12F);
            this.adminID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminID.Location = new System.Drawing.Point(324, 156);
            this.adminID.Name = "adminID";
            this.adminID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.adminID.Size = new System.Drawing.Size(85, 22);
            this.adminID.TabIndex = 26;
            this.adminID.Text = "admin_id";
            this.adminID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.confirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(262, 252);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(160, 50);
            this.confirmBtn.TabIndex = 27;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Montserrat", 14F);
            this.label19.Location = new System.Drawing.Point(33, 148);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(240, 26);
            this.label19.TabIndex = 64;
            this.label19.Text = "Client Account Number";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // acnCB
            // 
            this.acnCB.Font = new System.Drawing.Font("Montserrat", 28F);
            this.acnCB.FormattingEnabled = true;
            this.acnCB.Location = new System.Drawing.Point(38, 177);
            this.acnCB.Name = "acnCB";
            this.acnCB.Size = new System.Drawing.Size(384, 59);
            this.acnCB.TabIndex = 65;
            // 
            // TellerAccountNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(461, 345);
            this.Controls.Add(this.acnCB);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.backNav);
            this.Controls.Add(this.adminID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TellerAccountNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adpLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox adpLogo;
        private System.Windows.Forms.Label adpLabel;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Button backNav;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label adminID;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox acnCB;
    }
}