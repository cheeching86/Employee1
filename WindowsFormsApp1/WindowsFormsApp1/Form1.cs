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
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This method is called when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            // Get the connection string from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            // Define your SQL query
            string query = "SELECT [EmailAddress] FROM [erplivedb_customer_test2].[dbo].[QUANTA_EMAILSETTINGS]  where Id=7";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the connection to the database

                    // Create a command object to execute the query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Execute the query and get the result (assuming you are expecting one result)
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Fetch the EmailAddress column value and set it in textBox1
                        txtEmail.Text = reader["EmailAddress"].ToString();
                    }
                    else
                    {
                        txtEmail.Text = "No data found.";
                    }

                    reader.Close();  // Close the reader after reading the data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}