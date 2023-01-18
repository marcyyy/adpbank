using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static adpbank.LoginClientForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace adpbank
{
    public partial class ClientAccount2: Form
    {
        public ClientAccount2(string un_client, string un_id)
        {
            InitializeComponent();
            // client username
            userLabel.Text = un_client;
            opTB.PasswordChar = '*';
            opTB.MaxLength = 24;
            npTB.PasswordChar = '*';
            npTB.MaxLength = 24;
            cpTB.PasswordChar = '*';
            cpTB.MaxLength = 24;

        }

        public static class Common
        {
            public static double ConvertToDouble(string Value)
            {
                if (Value == null)
                {
                    return 0;
                }
                else
                {
                    double OutVal;
                    double.TryParse(Value, out OutVal);

                    if (double.IsNaN(OutVal) || double.IsInfinity(OutVal))
                    {
                        return 0;
                    }
                    return OutVal;
                }
            }
        }

        private void transferNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var clientTransaction = new ClientTransaction(userLabel.Text, clientID.Text);
            clientTransaction.Closed += (s, args) => this.Close();
            clientTransaction.Show();

        }

        private void homeNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var clientHome = new ClientHome(userLabel.Text, clientID.Text);
            clientHome.Closed += (s, args) => this.Close();
            clientHome.Show();
        }

        private void logoutNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginClient = new LoginClientForm();
            loginClient.Closed += (s, args) => this.Close();
            loginClient.Show();

            MessageBox.Show("Logout Successful", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClientTransaction_Load(object sender, EventArgs e)
        {
                string clientUsername = userLabel.Text;

                try
                {
                    // db initialized
                    string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
                    MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

                    // client_info
                    string query = "SELECT *" +
                                    "FROM accounts_client INNER JOIN info_client ON accounts_client.client_info = info_client.id " +
                                    "where accounts_client.username = '" + clientUsername + "' and accounts_client.active = '1' "; 
                    MySqlCommand cmd = new MySqlCommand(query, dbConn);

                    dbConn.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            fundsLabel.Text = reader.GetString("total_amount");
                            accLabel.Text = reader.GetString("account_number");
                            nameLabel.Text = reader.GetString("first_name") + " " + reader.GetString("last_name");
                            clientID.Text = reader.GetString("id");
                    }
                    dbConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


        }

        private void amountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (opTB.Text == "" || npTB.Text == "" || cpTB.Text == "")
            {
                MessageBox.Show("Informations can not be blank.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (npTB.Text != cpTB.Text)
            {
                MessageBox.Show("New Password and Confirm Password should be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string client = clientID.Text;
            string clientUsername = userLabel.Text;

            try
            {
                // db initialized
                string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
                MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

                //account balance update
                dbConn.Open();
                string query = "UPDATE accounts_client SET password = '" + npTB.Text + "' " +
                                "WHERE id = '" + client + "'";
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                cmd.ExecuteNonQuery();
                dbConn.Close();

                this.Hide();
                var clientAccount2 = new ClientAccount2(userLabel.Text, clientID.Text);
                clientAccount2.Closed += (s, args) => this.Close();
                clientAccount2.Show();
                MessageBox.Show("Password Update Successful.", "Account Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var clientAccount = new ClientAccount(userLabel.Text, clientID.Text);
            clientAccount.Closed += (s, args) => this.Close();
            clientAccount.Show();
        }
    }
}
