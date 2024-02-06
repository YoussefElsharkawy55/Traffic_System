using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tataetos
{
    public partial class signinFrom : Form
    {
        public static string connectionString;
        public signinFrom()
        {
            InitializeComponent();
        }

        private void signInB_Click(object sender, EventArgs e)
        {
            string server = serverTB.Text;      //DESKTOP-BL4GHI2
            string userName = userNameTB.Text;  //yoyo
            string password = passwordTB.Text;  //123456
            string database = databaseTB.Text;  //Traffic

            connectionString = "Server=" + server + ";Database=" + database + ";Uid=" + userName + ";password=" + password + ';';

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //MessageBox.Show("Connected!");

                    MainMenu mm = new MainMenu();
                    mm.Show();
                    this.Hide();
                }
            }
            catch 
            {
                MessageBox.Show("Check for wrong info", "Cannot signin!");
            }

        }

        private void serverTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signInB_Click(sender, e);
            }
        }
    }
}
