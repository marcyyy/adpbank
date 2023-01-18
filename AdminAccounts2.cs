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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace adpbank
{
    public partial class AdminAccounts2 : Form
    {
        public AdminAccounts2(string un_admin, string un_id)
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
            var adminAccounts = new AdminAccounts(userLabel.Text, adminID.Text);
            adminAccounts.Closed += (s, args) => this.Close();
            adminAccounts.Show();

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
                string query1 = "select *, DATE_FORMAT(creation, '%Y-%m-%d') AS 'Date Created' from accounts INNER JOIN info_employee ON accounts.info_id = info_employee.id where accounts.active = '1' ORDER BY accounts.id ASC ";
                MySqlDataAdapter sda = new MySqlDataAdapter(query1, dbConn);

                dbConn.Open();
                DataSet ds = new DataSet();
                sda.Fill(ds, "accounts");
                ncTable.DataSource = ds.Tables["accounts"];
                dbConn.Close();


                //dashboard (clients)
                string query2 = "select COUNT(*) as accountsNew from accounts_client where active = '1' ";
                MySqlCommand cmd2 = new MySqlCommand(query2, dbConn);

                dbConn.Open();
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read())
                {
                    ncLabel.Text = reader2.GetString("accountsNew");
                }
                dbConn.Close();


                //dashboard (clerk)
                string query3 = "select COUNT(*) as clerkTot from accounts where active = '1' and type = 'Clerk' ";
                MySqlCommand cmd3 = new MySqlCommand(query3, dbConn);

                dbConn.Open();
                MySqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader3.Read())
                {
                    dpLabel.Text = reader3.GetString("clerkTot");
                }
                dbConn.Close();


                //dashboard (teller)
                string query4 = "select COUNT(*) as tellerTot from accounts where active = '1' and type = 'Teller' ";
                MySqlCommand cmd4 = new MySqlCommand(query4, dbConn);

                dbConn.Open();
                MySqlDataReader reader4 = cmd4.ExecuteReader();

                while (reader4.Read())
                {
                    wdLabel.Text = reader4.GetString("tellerTot");
                }
                dbConn.Close();


                //dashboard (admin)
                string query5 = "select COUNT(*) as adminTot from accounts where active = '1' and type = 'Admin' ";
                MySqlCommand cmd5 = new MySqlCommand(query5, dbConn);

                dbConn.Open();
                MySqlDataReader reader5 = cmd5.ExecuteReader();

                while (reader5.Read())
                {
                    tfLabel.Text = reader5.GetString("adminTot");
                }
                dbConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string acn = editTB.Text;

            if (acn == "")
            {
                MessageBox.Show("Please enter an Employee ID first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;sslmode=none";

            string query = "SELECT  count(*) FROM accounts WHERE id = '" + acn + "' ";
            MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);
            MySqlDataAdapter sda = new MySqlDataAdapter(query, dbConn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                var adminAccounts_edit2 = new AdminAccountsEdit2(userLabel.Text, adminID.Text, editTB.Text);
                adminAccounts_edit2.Closed += (s, args) => this.Close();
                adminAccounts_edit2.Show();
            }
            else
            {
                MessageBox.Show("Employee does not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string acn = editTB.Text;

            if (acn == "")
            {
                MessageBox.Show("Please enter the Employee ID first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete ID#'" + editTB.Text + "' ?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // db initialized
                string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
                MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

                dbConn.Open();
                string query = "UPDATE info_employee SET active = '0' WHERE id = '" + editTB.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                cmd.ExecuteNonQuery();
                dbConn.Close();

                dbConn.Open();
                string query1 = "UPDATE accounts SET active = '0' WHERE id = '" + editTB.Text + "' ";
                MySqlCommand cmd1 = new MySqlCommand(query1, dbConn);

                cmd1.ExecuteNonQuery();
                dbConn.Close();

                this.Hide();
                var adminAccounts2 = new AdminAccounts2(userLabel.Text, adminID.Text);
                adminAccounts2.Closed += (s, args) => this.Close();
                adminAccounts2.Show();

                MessageBox.Show("Employee Account Deletion Successful.", "Account Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminAccounts_add = new AdminAccountsAdd(userLabel.Text, adminID.Text);
            adminAccounts_add.Closed += (s, args) => this.Close();
            adminAccounts_add.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchAN = searchTB.Text;

            // db initialized
            string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
            MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

            string query1 = "select *, DATE_FORMAT(creation, '%Y-%m-%d') AS 'Date Created' from accounts INNER JOIN info_employee ON accounts.info_id = info_employee.id where accounts.active = '1' and accounts.id = '" + searchAN + "' or accounts.type = '" + searchAN + "' ";

            MySqlDataAdapter sda = new MySqlDataAdapter(query1, dbConn);

            dbConn.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds, "accountsearch");
            ncTable.DataSource = ds.Tables["accountsearch"];
            dbConn.Close();

            if (ncTable == null || ncTable.Rows.Count == 1)
            {
                MessageBox.Show("Please search for an existing Employee ID/Employee Role.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminAccounts2 = new AdminAccounts2(userLabel.Text, adminID.Text);
            adminAccounts2.Closed += (s, args) => this.Close();
            adminAccounts2.Show();
        }
    }
}
