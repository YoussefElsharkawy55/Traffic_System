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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            getTables();
        }

        private void getTables()
        {
            string query = "SELECT name FROM sys.tables";
            bool connected = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(signinFrom.connectionString))
                {
                    connection.Open();
                    connected = true;
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    List<string> tableNames = new List<string>();
                    while (reader.Read())
                    {
                        tableList.Items.Add(reader["name"].ToString());
                        tableListInsert.Items.Add(reader["name"].ToString());
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch
            {
                if (!connected)
                    MessageBox.Show("Lost Connection!", "Connection Error");
                else
                    MessageBox.Show("Wrong Query!", "Database Error");
            }
        }

        private void showB_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM " + tableList.Text;
            run_connection(query);
        }

        private void queryB_Click(object sender, EventArgs e)
        {
            string query = queryTB.Text;
            run_connection(query);
        }

        public static void run_connection(string query)
        {
            bool connected = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(signinFrom.connectionString))
                {
                    connection.Open();
                    connected = true;
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    ShowTable showTable = new ShowTable(table, query);
                    showTable.Show();

                    reader.Close();
                    connection.Close();
                }
            }
            catch
            {
                if (!connected)
                    MessageBox.Show("Lost Connection!", "Connection Error");
                else
                    MessageBox.Show("Wrong Query!", "Database Error");
            }
        }

        private void insertB_Click(object sender, EventArgs e)
        {
            string queryColumn = "SELECT name,";
                   queryColumn += "CASE system_type_id ";
                       queryColumn += "WHEN 167 THEN 'varchar' ";
                       queryColumn += "WHEN 175 THEN 'char' ";
                       queryColumn += "WHEN 56 THEN 'int' ";
                       queryColumn += "WHEN 108 THEN 'numeric' ";
                       queryColumn += "WHEN 62 THEN 'float' ";
                       queryColumn += "WHEN 52 THEN 'smallint' ";
                       queryColumn += "WHEN 60 THEN 'money' ";
                       queryColumn += "WHEN 40 THEN 'date' ";
                       queryColumn += "WHEN 41 THEN 'time' ";
                       queryColumn += "ELSE 'other' ";
                       queryColumn += "END AS data_type ";
                   queryColumn += "FROM sys.columns ";
                   queryColumn += "WHERE object_id = OBJECT_ID('" + tableListInsert.Text + "')";
            insertTable(queryColumn, tableListInsert.Text);
        }

        private void insertTable(string query, string table_name)
        {
            bool connected = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(signinFrom.connectionString))
                {
                    connection.Open();
                    connected = true;
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    table.Columns.Add("Value");
                    insertTableForm insert = new insertTableForm(table, table_name);
                    insert.Show();

                    reader.Close();
                    connection.Close();
                }
            }
            catch
            {
                if (!connected)
                    MessageBox.Show("Lost Connection!", "Connection Error");
                else
                    MessageBox.Show("Wrong Query!", "Database Error");
            }
        }
    }
}
