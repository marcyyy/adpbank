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
    public partial class LoginClientForm : Form
    {
        public LoginClientForm()
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

        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginEmp = new LoginForm();
            loginEmp.Closed += (s, args) => this.Close();
            loginEmp.Show();
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


            if (user == "" || pass == "")
            {
                MessageBox.Show("Please fill in your credentials.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string MySQLConnectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=adpbank;sslmode=none";

            string query = "SELECT count(*) FROM accounts_client WHERE username = '" +user+"' and password = '"+pass+"' ";
            MySqlConnection dbConn = new MySqlConnection(MySQLConnectionString);
            MySqlDataAdapter sda = new MySqlDataAdapter(query, dbConn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                var clientHome = new ClientHome(userTB.Text, id);
                clientHome.Closed += (s, args) => this.Close();
                clientHome.Show();
            }
            else
            {
                MessageBox.Show("Username and Password Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
