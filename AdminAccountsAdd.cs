﻿using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml;

namespace adpbank
{
    public partial class AdminAccountsAdd2 : Form
    {
        public AdminAccountsAdd2(string un_admin, string un_id)
        {
            InitializeComponent();
            // client username
            userLabel.Text = un_admin;
            passTB.PasswordChar = '*';
            passTB.MaxLength = 24;
            cpassTB.PasswordChar = '*';
            cpassTB.MaxLength = 24;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            this.monthCB.DropDownStyle = ComboBoxStyle.DropDownList;
            this.dayCB.DropDownStyle = ComboBoxStyle.DropDownList;
            this.yearCB.DropDownStyle = ComboBoxStyle.DropDownList;

            //transaction id generate
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            acnTB.Text = "CLNT" + "-" + finalString;

            //month
            for (int i = 1; i < 13; i++)
            {
                monthCB.Items.Add(i.ToString());
            }

            //day
            for (int i = 1; i < 32; i++)
            {
                dayCB.Items.Add(i.ToString());
            }

            //year
            for (int i = 1900; i < 2101; i++)
            {
                yearCB.Items.Add(i.ToString());
            }

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            //birthday
            string month = monthCB.Text;
            string day = dayCB.Text;
            string year = yearCB.Text;

            string bdate = month + "/" + day + "/" + year;

            // db initialized
            string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
            MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

            // validations
            if (acnTB.Text == "" || unTB.Text == "" || passTB.Text == "" || cpassTB.Text == "" || fundsTB.Text == "" || fnTB.Text == "" || lnTB.Text == "" || cnTB.Text == "" || eaTB.Text == "" || addTB.Text == "" ||  ocTB.Text == "" || monthCB.Text == "" || dayCB.Text == "" || yearCB.Text == "")
            {
                MessageBox.Show("Please fill in all informations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passTB.Text != cpassTB.Text)
            {
                MessageBox.Show("Password and Confirm Password should be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passTB.Text.Length < 8)
            {
                MessageBox.Show("Password should atleast be 8 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (monthCB.Text == "2" && dayCB.Text == "30" || dayCB.Text == "31")
            {
                MessageBox.Show("Invalid Date of Birth for February.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cnTB.Text.Length != 11)
            {
                MessageBox.Show("Contact Number should be 11 digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = eaTB.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
            
            }
            else
            {
                MessageBox.Show("Email Format is Invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // username not exist
            string query0 = "SELECT count(*) FROM accounts_client WHERE username = '" + unTB.Text + "' ";
            MySqlDataAdapter sda = new MySqlDataAdapter(query0, dbConn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Username already existed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // add client info
                    dbConn.Open();
                    string query = "INSERT INTO info_client (first_name, last_name, contact, email, address, birthdate, occupation)" +
                        "VALUES ('" + fnTB.Text + "', '" + lnTB.Text + "', '" + cnTB.Text + "', '" + eaTB.Text + "', '" + addTB.Text + "', '" + bdate + "', '" + ocTB.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, dbConn);

                    cmd.ExecuteNonQuery();
                    long infoID = cmd.LastInsertedId;
                    dbConn.Close();

                    // add account
                    dbConn.Open();
                    string query1 = "INSERT INTO accounts_client (username, password, client_info, total_amount, account_number)" +
                        "VALUES ('" + unTB.Text + "', '" + passTB.Text + "', '" + infoID + "', '" + fundsTB.Text + "', '" + acnTB.Text + "')";
                    MySqlCommand cmd1 = new MySqlCommand(query1, dbConn);

                    cmd1.ExecuteNonQuery();
                    dbConn.Close();

                    this.Hide();
                    var adminAccounts = new AdminAccounts(userLabel.Text, adminID.Text);
                    adminAccounts.Closed += (s, args) => this.Close();
                    adminAccounts.Show();

                    MessageBox.Show("Client Account Creation Successful.", "Account Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void backNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminAccounts = new AdminAccounts(userLabel.Text, adminID.Text);
            adminAccounts.Closed += (s, args) => this.Close();
            adminAccounts.Show();

        }

        private void fundsTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cnTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
