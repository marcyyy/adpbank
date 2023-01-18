using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace adpbank
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passTB.PasswordChar = '*';
            passTB.MaxLength = 24;
        }

        public static class ControlID
        {
            public static string TextData { get; set; }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.authCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void empBtn_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery()
        {
            string id = " ";
            string user = userTB.Text;
            string pass = passTB.Text;
            string type = authCB.Text;


            if (user == "" || pass == "" || type == "")
            {
                MessageBox.Show("Please fill in your credentials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (type == "Admin")
            {
                string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;sslmode=none";

                string query = "SELECT  count(*) FROM accounts WHERE username = '" +user+"' and password = '"+pass+"' and type = '"+type+"' ";
                MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);
                MySqlDataAdapter sda = new MySqlDataAdapter(query, dbConn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    var adminHome = new AdminHome(userTB.Text, id);
                    adminHome.Closed += (s, args) => this.Close();
                    adminHome.Show();
                }
                else
                {
                    MessageBox.Show("Username, Password or Role Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (type == "Teller")
            {
                string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;sslmode=none";

                string query = "SELECT  count(*) FROM accounts WHERE username = '" + user + "' and password = '" + pass + "' and type = '" + type + "' ";
                MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);
                MySqlDataAdapter sda = new MySqlDataAdapter(query, dbConn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    var tellerHome = new TellerHome(userTB.Text, id);
                    tellerHome.Closed += (s, args) => this.Close();
                    tellerHome.Show();
                }
                else
                {
                    MessageBox.Show("Username, Password or Role Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (type == "Clerk")
            {
                string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;sslmode=none";

                string query = "SELECT  count(*) FROM accounts WHERE username = '" + user + "' and password = '" + pass + "' and type = '" + type + "' ";
                MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);
                MySqlDataAdapter sda = new MySqlDataAdapter(query, dbConn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    var clerkHome = new ClerkHome(userTB.Text, id);
                    clerkHome.Closed += (s, args) => this.Close();
                    clerkHome.Show();
                }
                else
                {
                    MessageBox.Show("Username, Password or Role Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginClient = new LoginClientForm();
            loginClient.Closed += (s, args) => this.Close();
            loginClient.Show();
        }

        private void authCB_Click(object sender, EventArgs e)
        {
            authCB.DroppedDown = true;
        }
    }
}
