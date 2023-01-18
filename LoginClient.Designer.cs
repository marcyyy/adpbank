namespace adpbank
{
    partial class LoginClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginClientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientBtn = new System.Windows.Forms.Button();
            this.empBtn = new System.Windows.Forms.Button();
            this.bankLabel = new System.Windows.Forms.Label();
            this.adpLabel = new System.Windows.Forms.Label();
            this.adpLogo = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adpLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.clientBtn);
            this.panel1.Controls.Add(this.empBtn);
            this.panel1.Controls.Add(this.bankLabel);
            this.panel1.Controls.Add(this.adpLabel);
            this.panel1.Controls.Add(this.adpLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 600);
            this.panel1.TabIndex = 0;
            // 
            // clientBtn
            // 
            this.clientBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clientBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientBtn.Location = new System.Drawing.Point(88, 472);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(271, 44);
            this.clientBtn.TabIndex = 4;
            this.clientBtn.Text = "Client";
            this.clientBtn.UseVisualStyleBackColor = true;
            // 
            // empBtn
            // 
            this.empBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.empBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empBtn.Location = new System.Drawing.Point(88, 411);
            this.empBtn.Name = "empBtn";
            this.empBtn.Size = new System.Drawing.Size(271, 44);
            this.empBtn.TabIndex = 3;
            this.empBtn.Text = "Employee";
            this.empBtn.UseVisualStyleBackColor = true;
            this.empBtn.Click += new System.EventHandler(this.empBtn_Click);
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankLabel.ForeColor = System.Drawing.Color.White;
            this.bankLabel.Location = new System.Drawing.Point(206, 180);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(169, 44);
            this.bankLabel.TabIndex = 2;
            this.bankLabel.Text = "Bank Inc.";
            // 
            // adpLabel
            // 
            this.adpLabel.AutoSize = true;
            this.adpLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adpLabel.ForeColor = System.Drawing.Color.White;
            this.adpLabel.Location = new System.Drawing.Point(203, 127);
            this.adpLabel.Name = "adpLabel";
            this.adpLabel.Size = new System.Drawing.Size(99, 66);
            this.adpLabel.TabIndex = 1;
            this.adpLabel.Text = "AC";
            // 
            // adpLogo
            // 
            this.adpLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adpLogo.BackgroundImage")));
            this.adpLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adpLogo.Location = new System.Drawing.Point(70, 94);
            this.adpLogo.Margin = new System.Windows.Forms.Padding(0);
            this.adpLogo.Name = "adpLogo";
            this.adpLogo.Size = new System.Drawing.Size(130, 130);
            this.adpLogo.TabIndex = 0;
            this.adpLogo.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.loginLabel.Location = new System.Drawing.Point(505, 94);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(165, 66);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(511, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client";
            // 
            // userTB
            // 
            this.userTB.Font = new System.Drawing.Font("Montserrat", 14F);
            this.userTB.ForeColor = System.Drawing.Color.Gray;
            this.userTB.Location = new System.Drawing.Point(516, 286);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(323, 30);
            this.userTB.TabIndex = 6;
            // 
            // passTB
            // 
            this.passTB.Font = new System.Drawing.Font("Montserrat", 14F);
            this.passTB.ForeColor = System.Drawing.Color.Gray;
            this.passTB.Location = new System.Drawing.Point(516, 359);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(323, 30);
            this.passTB.TabIndex = 7;
            // 
            // loginBtn
            // 
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loginBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(712, 472);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(127, 44);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(512, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(512, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // LoginClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.userTB);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adpLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox adpLogo;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Label adpLabel;
        private System.Windows.Forms.Button clientBtn;
        private System.Windows.Forms.Button empBtn;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

