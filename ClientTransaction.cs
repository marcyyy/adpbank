using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.CodeDom;
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
    public partial class ClientTransaction: Form
    {
        public ClientTransaction(string un_client, string un_id)
        {
            InitializeComponent();
            // client username
            userLabel.Text = un_client;

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

        private void nextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var clientTransaction2 = new ClientTransaction2(userLabel.Text, clientID.Text);
            clientTransaction2.Closed += (s, args) => this.Close();
            clientTransaction2.Show();

        }

        private void amountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Confirm Transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                double og_amount = Common.ConvertToDouble(fundsLabel.Text.ToString());
                double tr_amount = Common.ConvertToDouble(amountTB.Text.ToString());

                if (og_amount <= 0)
                {
                    MessageBox.Show("You do not have enough balance to withdraw.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tr_amount > og_amount)
                {
                    MessageBox.Show("You can not withdraw more than your remaining balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string client = clientID.Text;
                    string clientUsername = userLabel.Text;

                    //transaction id generate
                    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    var stringChars = new char[8];
                    var random = new Random();

                    for (int i = 0; i < stringChars.Length; i++)
                    {
                        stringChars[i] = chars[random.Next(chars.Length)];
                    }

                    var finalString = new String(stringChars);
                    string transactionID = "WD" + client + "-" + finalString;

                    //compute withdraw
                    double new_amount = og_amount - tr_amount;


                    try
                    {
                        // db initialized
                        string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
                        MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

                        // withdraw function
                        dbConn.Open();
                        string query = "INSERT INTO transaction (transaction_type, client_id, og_amount, tr_amount, new_amount, tr_id)" +
                            "VALUES ('Withdraw', '" + client + "', '" + og_amount + "', '" + tr_amount + "', '" + new_amount + "', '" + transactionID + "')";
                        MySqlCommand cmd = new MySqlCommand(query, dbConn);

                        cmd.ExecuteNonQuery();
                        dbConn.Close();

                        //account balance update
                        dbConn.Open();
                        string query1 = "UPDATE accounts_client SET total_amount = '" + new_amount + "' WHERE id='" + client + "'";
                        MySqlCommand cmd1 = new MySqlCommand(query1, dbConn);

                        cmd1.ExecuteNonQuery();
                        dbConn.Close();

                        this.Hide();
                        var clientTransaction = new ClientTransaction(userLabel.Text, clientID.Text);
                        clientTransaction.Closed += (s, args) => this.Close();
                        clientTransaction.Show();
                        MessageBox.Show("Withdraw Successful", "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void accNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var clientAccount = new ClientAccount(userLabel.Text, clientID.Text);
            clientAccount.Closed += (s, args) => this.Close();
            clientAccount.Show();
        }
    }
}
