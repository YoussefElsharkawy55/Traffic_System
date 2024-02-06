using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tataetos
{
    public partial class insertTableForm : Form
    {
        public insertTableForm(DataTable table, string table_name)
        {
            InitializeComponent();
            insertData.DataSource = table;
            tableTB.Text = table_name;
        }

        private void insertB_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO " + tableTB.Text + " (";
            List<string> columns = new List<string>();
            List<string> values = new List<string>();
            for (int i = 0; i < insertData.Rows.Count - 1; i++)
            {
                string type = insertData.Rows[i].Cells[1].Value.ToString();
                columns.Add(insertData.Rows[i].Cells[0].Value.ToString());
                if(type != "varchar" && type != "char" && type != "date" && type != "time")
                    values.Add(insertData.Rows[i].Cells[2].Value.ToString());
                else
                    values.Add("'" + insertData.Rows[i].Cells[2].Value.ToString() + "'");
            }
            foreach (var column in columns)
            {
                query += column + ',';
            }
            query = query.Remove(query.Length - 1, 1);
            query += ") VALUES (";
            foreach (var value in values)
            {
                query += value + ',';
            }
            query = query.Remove(query.Length - 1, 1);
            query += ')';
            run_insert(query, tableTB.Text);
        }
        private void run_insert(string query, string table_name)
        {
            bool connected = false;
            string showQuery = "SELECT * FROM " + table_name;
            try
            {
                using (SqlConnection connection = new SqlConnection(signinFrom.connectionString))
                {
                    connection.Open();
                    connected = true;
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Inserted successfully", "Done");
                    reader.Close();
                    connection.Close();

                    MainMenu.run_connection(showQuery);
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
