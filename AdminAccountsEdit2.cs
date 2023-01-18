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
    public partial class AdminAccountsEdit2: Form
    {
        public AdminAccountsEdit2(string un_admin, string un_id, string cl_id)
        {
            InitializeComponent();
            // client username
            userLabel.Text = un_admin;
            cidLabel.Text = cl_id;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            string empInfo = cidLabel.Text;

            // db initialized
            string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;sslmode=none";
            MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

            try
            {
                // employee
                string query = "SELECT *" +
                                "FROM accounts INNER JOIN info_employee ON accounts.info_id = info_employee.id " +
                                "where accounts.id = '" + empInfo + "' ";
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                dbConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    unTB.Text = reader.GetString("username");
                    typeBtn.Text = reader.GetString("type");
                    fnTB.Text = reader.GetString("first_name");
                    lnTB.Text = reader.GetString("last_name");
                    bdTB.Text = reader.GetString("birthdate");
                    cnTB.Text = reader.GetString("contact");
                    eaTB.Text = reader.GetString("email");
                    addTB.Text = reader.GetString("address");

                    cnidLabel.Text = reader.GetString("info_id");
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
            if (unTB.Text == "" || typeBtn.Text == "" || fnTB.Text == "" || lnTB.Text == "" || cnTB.Text == "" || eaTB.Text == "" || addTB.Text == "" || bdTB.Text == "")
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
                // update employee info
                dbConn.Open();
                string query = "UPDATE info_employee SET first_name = '" + fnTB.Text + "', last_name = '" + lnTB.Text + "', contact = '" + cnTB.Text + "', " +
                                "email= '" + eaTB.Text + "', address = '" + addTB.Text + "' " +
                                "WHERE id = '" + cnidLabel.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                cmd.ExecuteNonQuery();
                dbConn.Close();

                this.Hide();
                var adminAccounts2 = new AdminAccounts2(userLabel.Text, adminID.Text);
                adminAccounts2.Closed += (s, args) => this.Close();
                adminAccounts2.Show();

                MessageBox.Show("Employee Information Update Successful.", "Information Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminAccounts2 = new AdminAccounts2(userLabel.Text, adminID.Text);
            adminAccounts2.Closed += (s, args) => this.Close();
            adminAccounts2.Show();

        }

        private void passBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminAccounts_edit = new AdminPassword(userLabel.Text, adminID.Text, cnidLabel.Text);
            adminAccounts_edit.Closed += (s, args) => this.Close();
            adminAccounts_edit.Show();
        }
    }
}
