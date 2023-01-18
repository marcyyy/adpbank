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
    public partial class TellerAccountNumber : Form
    {
        public TellerAccountNumber(string un_admin, string un_id)
        {
            InitializeComponent();
            // client username
            userLabel.Text = un_admin;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            try
            {
                // db initialized
                string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
                MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

                // admin info
                string query = "SELECT * FROM accounts_client WHERE active = '1' ";
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                dbConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    acnCB.Items.Add(reader.GetString("account_number"));
                }
                dbConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // db initialized
            string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
            MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

            // validations
            if (acnCB.Text == "")
            {
                MessageBox.Show("Please enter an Account Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // account number not exist
            string query0 = "SELECT count(*) FROM accounts_client WHERE account_number = '" + acnCB.Text + "' AND active = '1' ";
            MySqlDataAdapter sda = new MySqlDataAdapter(query0, dbConn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                try
                {
                    this.Hide();
                    var tellerTransaction = new TellerTransaction(userLabel.Text, adminID.Text, acnCB.Text);
                    tellerTransaction.Closed += (s, args) => this.Close();
                    tellerTransaction.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Account Number does not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tellerHome = new TellerHome(userLabel.Text, adminID.Text);
            tellerHome.Closed += (s, args) => this.Close();
            tellerHome.Show();

        }
    }
}
