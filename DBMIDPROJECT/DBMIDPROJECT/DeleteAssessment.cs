﻿using System;
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
    public partial class DeleteAssessment : UserControl
    {
        public DeleteAssessment()
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
            SqlCommand cmd = new SqlCommand("Select * from Assessment  WHere Title NOT LIKE '!%' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                string searchTerm = textBox4.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    MessageBox.Show("Please enter a search term.");
                    return;
                }
                var con = Configuration.getInstance().getConnection();
                string query = "SELECT * FROM Assessment WHERE Id LIKE @SearchText OR Title LIKE @SearchText OR TotalMarks LIKE @SearchText , OR TotalWeightage LIKE @SearchText  ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SearchText", textBox4.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
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
                }

                sizeset();
                dataGridView1.Refresh();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        int indexrow;
        string id;
        string date;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];

            id = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
                 date     = row.Cells[2].Value.ToString();
            textBox2.Text = row.Cells[3].Value.ToString();
            textBox3.Text = row.Cells[4].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please select a Assessment to delete.");
                return;
            }

            var con = Configuration.getInstance().getConnection();

            SqlCommand updateCmd = new SqlCommand("UPDATE Assessment SET Title = '!' + Title WHERE Id = @Id;"+
                "UPDATE AssessmentComponent SET Name = '!' + Name Where AssessmentId = @Id", con) ;
            updateCmd.Parameters.AddWithValue("@Id", id);
            updateCmd.ExecuteNonQuery();


            MessageBox.Show("Successfully deleted ");

            cleardata();
            showData();
        }
        private void cleardata()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                var con = Configuration.getInstance().getConnection();

                // Fetch Id from the database
                SqlCommand fetchIdCmd = new SqlCommand("SELECT Id FROM Assessment WHERE Id = @Id", con);
                fetchIdCmd.Parameters.AddWithValue("@Id", id);



                int cloId = Convert.ToInt32(fetchIdCmd.ExecuteScalar());
                if (cloId == 0)
                {
                    MessageBox.Show("Error: Assessment with this ID does not exist.");
                    cleardata();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox1.Text.Trim()) || string.IsNullOrWhiteSpace(textBox2.Text.Trim()) || string.IsNullOrWhiteSpace(textBox3.Text.Trim()))
                {
                    MessageBox.Show("Error: Please fill in all fields for updation.");
                    return;
                }


                SqlCommand updateCLOCmd = new SqlCommand("UPDATE Assessment SET  Title = @Title , TotalMarks=@TotalMarks , TotalWeightage = @TotalWeightage WHERE Id = @Id", con);
                updateCLOCmd.Parameters.AddWithValue("@Title", textBox1.Text.Trim());
                updateCLOCmd.Parameters.AddWithValue("@TotalMarks", textBox2.Text.Trim());
                updateCLOCmd.Parameters.AddWithValue("@TotalWeightage", textBox3.Text.Trim());
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
