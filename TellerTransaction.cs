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
    public partial class TellerTransaction : Form
    {
        public TellerTransaction(string un_admin, string un_id, string accnum)
        {
            InitializeComponent();
            // client username
            userLabel.Text = un_admin;
            acnLabel.Text = accnum;
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

        private void logoutNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();

            MessageBox.Show("Logout Successful", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string accnum = acnLabel.Text;
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
                    adminID.Text = reader.GetString("id");
                }
                dbConn.Close();

                // client fund balance
                string query1 = "SELECT * FROM accounts_client WHERE account_number = '" + accnum + "' and active = '1' ";
                MySqlCommand cmd1 = new MySqlCommand(query1, dbConn);

                dbConn.Open();
                MySqlDataReader reader1 = cmd1.ExecuteReader();

                while (reader1.Read())
                {
                    fundLabel.Text = reader1.GetString("total_amount");
                    cidLabel.Text = reader1.GetString("id");
                }
                dbConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void trBtn_Click(object sender, EventArgs e)
        {

        }

        private void backNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tellerHome = new TellerHome(userLabel.Text, adminID.Text);
            tellerHome.Closed += (s, args) => this.Close();
            tellerHome.Show();
        }

        private void dpBtn_Click(object sender, EventArgs e)
        {

                double og_amount = Common.ConvertToDouble(fundLabel.Text.ToString());
                double tr_amount = Common.ConvertToDouble(dpTB.Text.ToString());

                if (dpTB.Text == "")
                {
                    MessageBox.Show("Enter an Amount to Deposit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string client = cidLabel.Text;
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
                string transactionID = "DP" + client + "-" + finalString;

                //compute deposit
                double new_amount = og_amount + tr_amount;

                if (tr_amount < 100)
                {
                    MessageBox.Show("Deposit Amount cannot be lower than 100.", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        // db initialized
                        string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
                        MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

                        // deposit function
                        dbConn.Open();
                        string query = "INSERT INTO transaction (transaction_type, client_id, og_amount, tr_amount, new_amount, tr_id)" +
                            "VALUES ('Deposit', '" + client + "', '" + og_amount + "', '" + tr_amount + "', '" + new_amount + "', '" + transactionID + "')";
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
                        var tellerHome = new TellerHome(userLabel.Text, adminID.Text);
                        tellerHome.Closed += (s, args) => this.Close();
                        tellerHome.Show();
                        MessageBox.Show("Deposit Successful", "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
        }

        private void wdBtn_Click(object sender, EventArgs e)
        {
            double og_amount = Common.ConvertToDouble(fundLabel.Text.ToString());
            double tr_amount = Common.ConvertToDouble(wdTB.Text.ToString());

            if (wdTB.Text == "")
            {
                MessageBox.Show("Enter an Amount to Withdraw.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                string client = cidLabel.Text;
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
                    var tellerHome = new TellerHome(userLabel.Text, adminID.Text);
                    tellerHome.Closed += (s, args) => this.Close();
                    tellerHome.Show();
                    MessageBox.Show("Withdraw Successful", "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tfBtn_Click(object sender, EventArgs e)
        {
            double og_amount = Common.ConvertToDouble(fundLabel.Text.ToString());
            double tr_amount = Common.ConvertToDouble(tfTB.Text.ToString());

            if (tfTB.Text == "")
            {
                MessageBox.Show("Enter an Amount to Transfer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (raccTB.Text == "")
            {
                MessageBox.Show("Enter Recipient Account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (og_amount <= 0)
            {
                MessageBox.Show("You do not have enough balance to transfer funds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tr_amount < 1000)
            {
                MessageBox.Show("You cannot transfer amount less than 1000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tr_amount > 50000)
            {
                MessageBox.Show("You cannot transfer amount more than 50000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tr_amount > og_amount)
            {
                MessageBox.Show("You can not transfer funds more than your remaining balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string client = cidLabel.Text;
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
                string transferID = "TF" + client + "-" + finalString;

                //compute withdraw
                double new_amount = og_amount - tr_amount;


                try
                {
                    // db initialized
                    string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;";
                    MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);

                    string query0 = "SELECT count(*) FROM accounts_client WHERE account_number = '" + raccTB.Text + "' AND account_number != '" + acnLabel.Text+ "' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query0, dbConn);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        // withdraw function
                        dbConn.Open();
                        string query = "INSERT INTO transfer (client_id, r_acc, amount, tf_id)" +
                            "VALUES ('" + client + "', '" + raccTB.Text + "', '" + tr_amount + "', '" + transferID + "')";
                        MySqlCommand cmd = new MySqlCommand(query, dbConn);

                        cmd.ExecuteNonQuery();
                        dbConn.Close();

                        //account balance update (from)
                        dbConn.Open();
                        string query1 = "UPDATE accounts_client SET total_amount = '" + new_amount + "' WHERE id='" + client + "'";
                        MySqlCommand cmd1 = new MySqlCommand(query1, dbConn);

                        cmd1.ExecuteNonQuery();
                        dbConn.Close();

                        //account balance update (to)
                        dbConn.Open();
                        string query2 = "UPDATE accounts_client SET total_amount = total_amount + '" + tr_amount + "' WHERE account_number='" + raccTB.Text + "'";
                        MySqlCommand cmd2 = new MySqlCommand(query2, dbConn);

                        cmd2.ExecuteNonQuery();
                        dbConn.Close();

                        this.Hide();
                        var tellerHome = new TellerHome(userLabel.Text, adminID.Text);
                        tellerHome.Closed += (s, args) => this.Close();
                        tellerHome.Show();
                        MessageBox.Show("Transfer Successful", "Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Recipient Account Number does not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
