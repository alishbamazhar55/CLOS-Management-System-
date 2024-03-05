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

namespace DBMIDPROJECT
{
    public partial class Clo3 : UserControl
    {
        public Clo3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public void showData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Clo ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                // Search for CLOs based on the provided search term
                string searchTerm = textBox1.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    MessageBox.Show("Please enter a search term.");
                    return; // Exit the method if the search term is empty
                }

                SqlCommand searchCmd = new SqlCommand("SELECT * FROM Clo WHERE Name LIKE @SearchTerm OR Id LIKE @SearchTerm", con);
                searchCmd.Parameters.AddWithValue("@SearchTerm", searchTerm); // Add wildcard characters to search for matches

                SqlDataAdapter da = new SqlDataAdapter(searchCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0) // Check if no records are found
                {
                    MessageBox.Show("No item matched for the provided search term.");
                }
                else
                {
                    // Display the search results in a DataGridView or any other appropriate control
                    dataGridView1.DataSource = dt;
                }

                // Clear the search term textbox after displaying the results
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
