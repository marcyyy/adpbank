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
    public partial class ClerkHome : Form
    {
        public ClerkHome(string un_admin, string un_id)
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
                string query1 = "select *, DATE_FORMAT(creation, '%Y-%m-%d') AS 'Date Created' from accounts_client INNER JOIN info_client ON accounts_client.client_info = info_client.id where accounts_client.active = '1' ORDER BY accounts_client.id DESC ";
                MySqlDataAdapter sda = new MySqlDataAdapter(query1, dbConn);

                dbConn.Open();
                DataSet ds = new DataSet();
                sda.Fill(ds, "newaccounts");
                ncTable.DataSource = ds.Tables["newaccounts"];
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
                MessageBox.Show("Please enter an Account Number/Client ID first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;sslmode=none";

            string query = "SELECT  count(*) FROM accounts_client WHERE id = '" + acn + "' OR account_number = '" + acn + "' AND active = '1' ";
            MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);
            MySqlDataAdapter sda = new MySqlDataAdapter(query, dbConn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                var clerkAccounts_edit = new ClerkAccountsEdit(userLabel.Text, adminID.Text, editTB.Text);
                clerkAccounts_edit.Closed += (s, args) => this.Close();
                clerkAccounts_edit.Show();
            }
            else
            {
                MessageBox.Show("Client Account does not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string acn = editTB.Text;

            if (acn == "")
            {
                MessageBox.Show("Please enter the Client ID first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete ID#'" + editTB.Text + "' ?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // db initialized
                string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
                MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

                dbConn.Open();
                string query = "UPDATE info_client SET active = '0' WHERE id = '" + editTB.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                cmd.ExecuteNonQuery();
                dbConn.Close();

                dbConn.Open();
                string query1 = "UPDATE accounts_client SET active = '0' WHERE id = '" + editTB.Text + "' ";
                MySqlCommand cmd1 = new MySqlCommand(query1, dbConn);

                cmd1.ExecuteNonQuery();
                dbConn.Close();

                this.Hide();
                var clerkHome = new ClerkHome(userLabel.Text, adminID.Text);
                clerkHome.Closed += (s, args) => this.Close();
                clerkHome.Show();

                MessageBox.Show("Client Account Deletion Successful.", "Account Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var clerkAdd = new ClerkAccountsAdd(userLabel.Text, adminID.Text);
            clerkAdd.Closed += (s, args) => this.Close();
            clerkAdd.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchAN = searchTB.Text;

            // db initialized
            string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
            MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

            string query1 = "select *, DATE_FORMAT(creation, '%Y-%m-%d') AS 'Date Created' from accounts_client INNER JOIN info_client ON accounts_client.client_info = info_client.id where accounts_client.active = '1' and accounts_client.id = '" + searchAN + "' or accounts_client.account_number = '" + searchAN + "' ";
            MySqlDataAdapter sda = new MySqlDataAdapter(query1, dbConn);

            dbConn.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds, "accountsearch");
            ncTable.DataSource = ds.Tables["accountsearch"];
            dbConn.Close();

            if (ncTable == null || ncTable.Rows.Count == 1)
            {
                MessageBox.Show("Please search for an existing Account Number/Client ID.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var clerkHome = new ClerkHome(userLabel.Text, adminID.Text);
            clerkHome.Closed += (s, args) => this.Close();
            clerkHome.Show();
        }
    }
}
