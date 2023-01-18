using MySql.Data.MySqlClient;
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
    public partial class ClerkAccountsEdit : Form
    {
        public ClerkAccountsEdit(string un_admin, string un_id, string cl_id)
        {
            InitializeComponent();
            // client username
            userLabel.Text = un_admin;
            cidLabel.Text = cl_id;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            string clientInfo = cidLabel.Text;

            // db initialized
            string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;sslmode=none";
            MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

            string query0 = "SELECT count(*) FROM accounts_client WHERE id = '" + clientInfo + "' ";
            MySqlDataAdapter sda = new MySqlDataAdapter(query0, dbConn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            //provided an id
            if (dt.Rows[0][0].ToString() == "1")
            {
                try
                {

                    // client_info
                    string query = "SELECT *" +
                                    "FROM accounts_client INNER JOIN info_client ON accounts_client.client_info = info_client.id " +
                                    "where accounts_client.id = '" + clientInfo + "' ";
                    MySqlCommand cmd = new MySqlCommand(query, dbConn);

                    dbConn.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        unTB.Text = reader.GetString("username");
                        acnTB.Text = reader.GetString("account_number");
                        fundsTB.Text = reader.GetString("total_amount");
                        fnTB.Text = reader.GetString("first_name");
                        lnTB.Text = reader.GetString("last_name");
                        bdTB.Text = reader.GetString("birthdate");
                        cnTB.Text = reader.GetString("contact");
                        eaTB.Text = reader.GetString("email");
                        ocTB.Text = reader.GetString("occupation");
                        addTB.Text = reader.GetString("address");

                        cnidLabel.Text = reader.GetString("client_info");
                    }
                    dbConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //provided a username
            else 
            {
                try
                {
                    // client_info
                    string query = "SELECT *" +
                                    "FROM accounts_client INNER JOIN info_client ON accounts_client.client_info = info_client.id " +
                                    "where accounts_client.account_number = '" + clientInfo + "' ";
                    MySqlCommand cmd = new MySqlCommand(query, dbConn);

                    dbConn.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        unTB.Text = reader.GetString("username");
                        acnTB.Text = reader.GetString("account_number");
                        fundsTB.Text = reader.GetString("total_amount");
                        fnTB.Text = reader.GetString("first_name");
                        lnTB.Text = reader.GetString("last_name");
                        bdTB.Text = reader.GetString("birthdate");
                        cnTB.Text = reader.GetString("contact");
                        eaTB.Text = reader.GetString("email");
                        ocTB.Text = reader.GetString("occupation");
                        addTB.Text = reader.GetString("address");

                        cnidLabel.Text = reader.GetString("client_info");
                    }
                    dbConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // db initialized
            string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
            MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

            // validations
            if (acnTB.Text == "" || unTB.Text == "" || fundsTB.Text == "" || fnTB.Text == "" || lnTB.Text == "" || cnTB.Text == "" || eaTB.Text == "" || addTB.Text == "" || bdTB.Text == "" || ocTB.Text == "")
            {
                MessageBox.Show("Please fill in all informations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            try
                {
                    // update client info
                    dbConn.Open();
                    string query = "UPDATE info_client SET first_name = '" + fnTB.Text + "', last_name = '" + lnTB.Text + "', contact = '" + cnTB.Text + "', " +
                                    "email= '" + eaTB.Text + "', occupation = '" + ocTB.Text + "', address = '" + addTB.Text + "' " +
                                    "WHERE id = '" + cnidLabel.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(query, dbConn);

                    cmd.ExecuteNonQuery();
                    dbConn.Close();

                    this.Hide();
                    var clerkHome = new ClerkHome(userLabel.Text, adminID.Text);
                    clerkHome.Closed += (s, args) => this.Close();
                    clerkHome.Show();

                    MessageBox.Show("Client Information Update Successful.", "Information Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void backNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var clerkHome = new ClerkHome(userLabel.Text, adminID.Text);
            clerkHome.Closed += (s, args) => this.Close();
            clerkHome.Show();

        }

        private void fundsTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void passNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var clerkPassword = new ClerkPassword(userLabel.Text, adminID.Text, cnidLabel.Text);
            clerkPassword.Closed += (s, args) => this.Close();
            clerkPassword.Show();
        }
    }
}
