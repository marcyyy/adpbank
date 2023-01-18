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
    public partial class ClientHome2: Form
    {
        public ClientHome2(string un_client, string un_id)
        {
            InitializeComponent();
            // client username
            userLabel.Text = un_client;

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

        private void ClientHome_Load(object sender, EventArgs e)
        {
                string clientUsername = userLabel.Text;

                try
                {
                    // db initialized
                    string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
                    MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

                    string query = "SELECT *" +
                                    "FROM accounts_client INNER JOIN info_client ON accounts_client.client_info = info_client.id " +
                                    "where accounts_client.username = '" + clientUsername + "' and accounts_client.active = '1' "; 
                    MySqlCommand cmd = new MySqlCommand(query, dbConn);

                    // client info
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

                    // table
                    string query1 = "select * from transfer where client_id = '" + clientID.Text + "' ORDER BY transfer.id DESC ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query1, dbConn);

                    dbConn.Open();
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "transfer");
                        clientView1.DataSource = ds.Tables["transfer"];
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
            var clientHome = new ClientHome(userLabel.Text, clientID.Text);
            clientHome.Closed += (s, args) => this.Close();
            clientHome.Show();
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
