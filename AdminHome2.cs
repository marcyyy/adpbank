using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace adpbank
{
    public partial class AdminHome2 : Form
    {
        public AdminHome2(string un_admin, string un_id)
        {
            InitializeComponent();
            // client username
            userLabel.Text = un_admin;
        }

        private void logoutNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();

            MessageBox.Show("Logout Successful", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ncBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminHome = new AdminHome(userLabel.Text, adminID.Text);
            adminHome.Closed += (s, args) => this.Close();
            adminHome.Show();
        }

        private void dpBtn_Click(object sender, EventArgs e)
        {

        }

        private void wdBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminHome3 = new AdminHome3(userLabel.Text, adminID.Text);
            adminHome3.Closed += (s, args) => this.Close();
            adminHome3.Show();
        }

        private void tfBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminHome4 = new AdminHome4(userLabel.Text, adminID.Text);
            adminHome4.Closed += (s, args) => this.Close();
            adminHome4.Show();
        }

        private void homeNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminHome = new AdminHome(userLabel.Text, adminID.Text);
            adminHome.Closed += (s, args) => this.Close();
            adminHome.Show();
        }

        private void transferNav_Click(object sender, EventArgs e)
        {

            this.Hide();
            var adminTransaction = new AdminTransaction(userLabel.Text, adminID.Text);
            adminTransaction.Closed += (s, args) => this.Close();
            adminTransaction.Show();
        }

        private void accNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminAccounts = new AdminAccounts(userLabel.Text, adminID.Text);
            adminAccounts.Closed += (s, args) => this.Close();
            adminAccounts.Show();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            todayLabel.Text = DateTime.Now.ToShortDateString();
            string adminUsername = userLabel.Text;

            try
            {
                // db initialized
                string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
                MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

                // admin info
                string query = "SELECT *" +
                                "FROM accounts INNER JOIN info_employee ON accounts.info_id = info_employee.id " +
                                "where accounts.username = '" + adminUsername + "' and accounts.active = '1' ";
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                dbConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nameLabel.Text = reader.GetString("first_name");
                    adminID.Text = reader.GetString("id");
                }
                dbConn.Close();

                // table
                string query1 = "select *, DATE_FORMAT(tr_dt, '%Y-%m-%d') AS 'Date Created' from transaction INNER JOIN info_client ON transaction.client_id = info_client.id where DATE_FORMAT(tr_dt, '%Y-%m-%d') = CURDATE() and transaction.active = '1' and transaction_type = 'Deposit' ORDER BY transaction.id DESC ";
                MySqlDataAdapter sda = new MySqlDataAdapter(query1, dbConn);

                dbConn.Open();
                DataSet ds = new DataSet();
                sda.Fill(ds, "deposit");
                ncTable.DataSource = ds.Tables["deposit"];
                dbConn.Close();


                //dashboard (accounts)
                string query2 = "select COUNT(*) as accountsNew, DATE_FORMAT(creation, '%Y-%m-%d') from accounts_client where DATE_FORMAT(creation, '%Y-%m-%d') = CURDATE() and active = '1' ";
                MySqlCommand cmd2 = new MySqlCommand(query2, dbConn);

                dbConn.Open();
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read())
                {
                    ncLabel.Text = reader2.GetString("accountsNew");
                }
                dbConn.Close();


                //dashboard (deposit)
                string query3 = "select COALESCE(SUM(tr_amount),0) as dpTot, DATE_FORMAT(tr_dt, '%Y-%m-%d') from transaction where DATE_FORMAT(tr_dt, '%Y-%m-%d') = CURDATE() and active = '1' and transaction_type = 'Deposit' ";
                MySqlCommand cmd3 = new MySqlCommand(query3, dbConn);

                dbConn.Open();
                MySqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader3.Read())
                {
                    dpLabel.Text = "₱" + reader3.GetString("dpTot");
                }
                dbConn.Close();


                //dashboard (withdraw)
                string query4 = "select COALESCE(SUM(tr_amount),0) as wdTot, DATE_FORMAT(tr_dt, '%Y-%m-%d') from transaction where DATE_FORMAT(tr_dt, '%Y-%m-%d') = CURDATE() and active = '1' and transaction_type = 'Withdraw' ";
                MySqlCommand cmd4 = new MySqlCommand(query4, dbConn);

                dbConn.Open();
                MySqlDataReader reader4 = cmd4.ExecuteReader();

                while (reader4.Read())
                {
                    wdLabel.Text = "₱" + reader4.GetString("wdTot");
                }
                dbConn.Close();


                //dashboard (transfer)
                string query5 = "select COALESCE(SUM(amount),0) as tfTot, DATE_FORMAT(tf_dt, '%Y-%m-%d') from transfer where DATE_FORMAT(tf_dt, '%Y-%m-%d') = CURDATE() and active = '1' ";
                MySqlCommand cmd5 = new MySqlCommand(query5, dbConn);

                dbConn.Open();
                MySqlDataReader reader5 = cmd5.ExecuteReader();

                while (reader5.Read())
                {
                    tfLabel.Text = "₱" + reader5.GetString("tfTot");
                }
                dbConn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
