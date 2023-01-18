using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml;

namespace adpbank
{
    public partial class AdminPassword : Form
    {
        public AdminPassword(string un_admin, string un_id, string cl_id)
        {
            InitializeComponent();
            // client username
            cidLabel.Text = cl_id;
            userLabel.Text = un_admin;
            acnTB.PasswordChar = '*';
            acnTB.MaxLength = 24;
            unTB.PasswordChar = '*';
            unTB.MaxLength = 24;
            cfmTB.PasswordChar = '*';
            cfmTB.MaxLength = 24;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (acnTB.Text == "" || unTB.Text == "" || cfmTB.Text == "")
            {
                MessageBox.Show("Informations can not be blank.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (unTB.Text != cfmTB.Text)
            {
                MessageBox.Show("New Password and Confirm Password should be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (unTB.Text.Length < 8)
            {
                MessageBox.Show("Password should atleast be 8 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string client = adminID.Text;
            string clientUsername = userLabel.Text;

            try
            {
                // db initialized
                string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
                MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

                //account balance update
                dbConn.Open();
                string query = "UPDATE accounts SET password = '" + unTB.Text + "' " +
                                "WHERE id = '" + cidLabel.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                cmd.ExecuteNonQuery();
                dbConn.Close();

                this.Hide();
                var AdminPassword = new AdminAccounts(userLabel.Text, adminID.Text);
                AdminPassword.Closed += (s, args) => this.Close();
                AdminPassword.Show();
                MessageBox.Show("Password Update Successful.", "Account Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void backNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminAccounts = new AdminAccounts2(userLabel.Text, adminID.Text);
            adminAccounts.Closed += (s, args) => this.Close();
            adminAccounts.Show();

        }

        private void fundsTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void passNav_Click(object sender, EventArgs e)
        {

        }

        private void backNav_Click_1(object sender, EventArgs e)
        {

        }

        private void w(object sender, EventArgs e)
        {

        }
    }
}
