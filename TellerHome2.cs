using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace adpbank
{
    public partial class TellerHome2 : Form
    {
        public TellerHome2(string un_admin, string un_id)
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
            var tellerHome = new TellerHome(userLabel.Text, adminID.Text);
            tellerHome.Closed += (s, args) => this.Close();
            tellerHome.Show();
        }

        private void dpBtn_Click(object sender, EventArgs e)
        {

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
                string query1 = "select *, DATE_FORMAT(tF_dt, '%Y-%m-%d') AS 'Date Created' from transfer INNER JOIN accounts_client ON transfer.client_id = accounts_client.id where accounts_client.active = '1' ORDER BY transfer.id DESC ";
                MySqlDataAdapter sda = new MySqlDataAdapter(query1, dbConn);

                dbConn.Open();
                DataSet ds = new DataSet();
                sda.Fill(ds, "transfer");
                ncTable.DataSource = ds.Tables["transfer"];
                dbConn.Close();

                //dashboard (deposit)
                string query3 = "select COALESCE(SUM(tr_amount),0) as dpTot, DATE_FORMAT(tr_dt, '%Y-%m-%d') from transaction where active = '1' and transaction_type = 'Deposit' ";
                MySqlCommand cmd3 = new MySqlCommand(query3, dbConn);

                dbConn.Open();
                MySqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader3.Read())
                {
                    dpLabel.Text = "₱" + reader3.GetString("dpTot");
                }
                dbConn.Close();


                //dashboard (withdraw)
                string query4 = "select COALESCE(SUM(tr_amount),0) as wdTot, DATE_FORMAT(tr_dt, '%Y-%m-%d') from transaction where active = '1' and transaction_type = 'Withdraw' ";
                MySqlCommand cmd4 = new MySqlCommand(query4, dbConn);

                dbConn.Open();
                MySqlDataReader reader4 = cmd4.ExecuteReader();

                while (reader4.Read())
                {
                    wdLabel.Text = "₱" + reader4.GetString("wdTot");
                }
                dbConn.Close();


                //dashboard (transfer)
                string query5 = "select COALESCE(SUM(amount),0) as tfTot, DATE_FORMAT(tf_dt, '%Y-%m-%d') from transfer where active = '1' ";
                MySqlCommand cmd5 = new MySqlCommand(query5, dbConn);

                dbConn.Open();
                MySqlDataReader reader5 = cmd5.ExecuteReader();

                while (reader5.Read())
                {
                    tfLabel.Text = "₱" + reader5.GetString("tfTot");
                }
                dbConn.Close();

                //dashboard (total)
                string query6 = "select sum(tbl.EachTableCount) as totCount from (select count(*) as EachTableCount from transaction UNION ALL select count(*) as EachTableCount from transfer)tbl";
                MySqlCommand cmd6 = new MySqlCommand(query6, dbConn);

                dbConn.Open();
                MySqlDataReader reader6 = cmd6.ExecuteReader();

                while (reader6.Read())
                {
                    totLabel.Text = reader6.GetString("totCount");
                }
                dbConn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchAN = searchTB.Text;

            // db initialized
            string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
            MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

            string query1 = "select *, DATE_FORMAT(tf_dt, '%Y-%m-%d') AS 'Date Created' from transfer INNER JOIN accounts_client ON transfer.client_id = accounts_client.id where accounts_client.active = '1' and accounts_client.account_number = '" + searchAN + "' or transfer.tf_id = '" + searchAN + "' ";
            MySqlDataAdapter sda = new MySqlDataAdapter(query1, dbConn);

            dbConn.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds, "transfer");
            ncTable.DataSource = ds.Tables["transfer"];
            dbConn.Close();

            if (ncTable == null || ncTable.Rows.Count == 1)
            {
                MessageBox.Show("Please search for an existing Sender Account Number/Transaction ID.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tellerHome2 = new TellerHome2(userLabel.Text, adminID.Text);
            tellerHome2.Closed += (s, args) => this.Close();
            tellerHome2.Show();
        }

        private void trBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tellerAccNum = new TellerAccountNumber(userLabel.Text, adminID.Text);
            tellerAccNum.Closed += (s, args) => this.Close();
            tellerAccNum.Show();
        }
    }
}
