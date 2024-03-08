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
    public partial class DeleteRL : UserControl
    {
        public DeleteRL()
        {
            InitializeComponent();
        }
        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void cleardata()
        {
         
            textBox2.Text = "";
            textBox3.Text = "";
        }

        public void showData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from RubricLevel  WHere Details NOT LIKE '!%' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
            dataGridView1.Refresh();
           dataGridView1.DefaultCellStyle.BackColor = Color.AliceBlue;
       
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please select a Rubric level id to delete.");
                return;
            }

            var con = Configuration.getInstance().getConnection();

            SqlCommand updateCmd = new SqlCommand("UPDATE RubricLevel SET Details = '!' + Details WHERE Id = @Id", con);
            updateCmd.Parameters.AddWithValue("@Id", id);
            updateCmd.ExecuteNonQuery();


            MessageBox.Show("Successfully deleted ");

            cleardata();
            showData();
        }
        int indexrow;
        string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];

            id = row.Cells[0].Value.ToString();
           
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return; // Exit the method if the search term is empty
            }
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT * FROM RubricLevel WHERE Id LIKE @SearchText OR RubricId LIKE @SearchText OR Details LIKE @SearchText OR Measurementlevel LIKE @SearchText  ";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@SearchText", textBox4.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            sizeset();
            dataGridView1.Refresh();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                // Fetch Id from the database
                SqlCommand fetchIdCmd = new SqlCommand("SELECT Id FROM RubricLevel WHERE Id = @Id", con);
                fetchIdCmd.Parameters.AddWithValue("@Id", id);



                int cloId = Convert.ToInt32(fetchIdCmd.ExecuteScalar());
                if (cloId == 0)
                {
                    MessageBox.Show("Error: RubricLevel id with this ID does not exist.");
                    cleardata();
                    return;
                }

                if (  string.IsNullOrWhiteSpace(textBox2.Text.Trim()) || string.IsNullOrWhiteSpace(textBox3.Text.Trim()))
                {
                    MessageBox.Show("Error: Please fill in all fields for updation.");
                    return;
                }
                string ML = textBox3.Text;
                if (int.Parse(ML) > 4 || int.Parse(ML) < 1)
                {
                    MessageBox.Show("Maximum Measurement Level is 4 and minimum level is 1.");
                    textBox3.Clear();
                }

                SqlCommand updateCLOCmd = new SqlCommand("UPDATE RubricLevel SET   Details=@Details , MeasurementLevel = @MeasurementLevel WHERE Id = @Id", con);
        
                updateCLOCmd.Parameters.AddWithValue("@Details", textBox2.Text.Trim());
                updateCLOCmd.Parameters.AddWithValue("@MeasurementLevel", textBox3.Text.Trim());
                updateCLOCmd.Parameters.AddWithValue("@Id", id);

                updateCLOCmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
                showData();

                cleardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
