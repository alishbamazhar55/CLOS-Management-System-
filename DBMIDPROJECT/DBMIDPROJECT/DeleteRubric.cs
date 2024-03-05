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
    public partial class DeleteRubric : UserControl
    {
        public DeleteRubric()
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



        public void showData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Rubric WHere Details NOT LIKE '!%' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
            dataGridView1.Refresh();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please select a Rubric to delete.");
                return;
            }

            var con = Configuration.getInstance().getConnection();

            SqlCommand updateCmd = new SqlCommand("UPDATE Rubric SET Details = '!' + Details WHERE Id = @Id", con);
            updateCmd.Parameters.AddWithValue("@Id", textBox1.Text);
            updateCmd.ExecuteNonQuery();


            MessageBox.Show("Successfully deleted ");

            cleardata();
            showData();
        }
        int indexrow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];

            
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
        }
        private void cleardata()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT * FROM Rubric WHERE Id LIKE @SearchText OR Details LIKE @SearchText OR CloId LIKE @SearchText  ";

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
                SqlCommand fetchIdCmd = new SqlCommand("SELECT Id FROM Rubric WHERE Id = @Id", con);
                fetchIdCmd.Parameters.AddWithValue("@Id", textBox1.Text);



                int cloId = Convert.ToInt32(fetchIdCmd.ExecuteScalar());
                if (cloId == 0)
                {
                    MessageBox.Show("Error: Rubric with this ID does not exist.");
                    cleardata();
                    return;
                }

                // Check if the textboxes are empty
                if (string.IsNullOrWhiteSpace(textBox1.Text.Trim()) || string.IsNullOrWhiteSpace(textBox2.Text.Trim()) || string.IsNullOrWhiteSpace(textBox3.Text.Trim()))
                {
                    MessageBox.Show("Error: Please fill in all fields for updating.");
                    return;
                }
               

                SqlCommand updateCLOCmd = new SqlCommand("UPDATE Rubric SET Id = @Id, Details = @Details , CloId=@CloId WHERE Id = @Id", con);
                updateCLOCmd.Parameters.AddWithValue("@Id", textBox1.Text.Trim());
                updateCLOCmd.Parameters.AddWithValue("@Details", textBox2.Text.Trim());
                updateCLOCmd.Parameters.AddWithValue("@CloId", textBox3.Text.Trim());
                

                // Execute the update command for the CLO
                updateCLOCmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
                showData();

                cleardata(); // Assuming this method clears form fields after updating
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
