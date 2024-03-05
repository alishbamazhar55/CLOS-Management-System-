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
    public partial class Assessment : UserControl
    {
        public Assessment()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            string date = dateTimePicker1.Value.ToString();

            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter Data about assessment.");
            }
            else
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();

                    SqlCommand cmdAssessment = new SqlCommand("INSERT INTO Assessment (Id,Title, DateCreated, TotalMarks, TotalWeightage) VALUES (@Id,@Title, @DateCreated, @TotalMarks, @TotalWeightage)", con);
                    cmdAssessment.Parameters.AddWithValue("@Id", textBox2.Text);
                    cmdAssessment.Parameters.AddWithValue("@Title", textBox3.Text);
                    cmdAssessment.Parameters.AddWithValue("@DateCreated",date );
                    cmdAssessment.Parameters.AddWithValue("@TotalMarks", textBox5.Text);
                    cmdAssessment.Parameters.AddWithValue("@TotalWeightage", textBox1.Text);
                    cmdAssessment.ExecuteNonQuery();

                    MessageBox.Show("Assessment Successfully added");
                    cleardata(); // Assuming this method clears assessment-related input fields
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void cleardata()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
