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
    public partial class AddRL : UserControl
    {
        public AddRL()
        {
            InitializeComponent();
            l1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string RUBRICid = comboBox1.Text.Trim();
            string ML = textBox3.Text;

            if (string.IsNullOrWhiteSpace(RUBRICid))
            {
                MessageBox.Show("Please enter Rubric ID.");
            }
            if (int.Parse(ML) > 4 || int.Parse(ML) < 1)
            {
                MessageBox.Show("Maximum Measurement Level is 4 and minimum level is 1.");
                textBox3.Clear();
            }
            else
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();

                    SqlCommand cmdCLO = new SqlCommand("INSERT INTO RubricLevel (RubricId, Details, MeasurementLevel) VALUES (@RubricId, @Details, @MeasurementLevel)", con);
                    cmdCLO.Parameters.AddWithValue("@RubricId", comboBox1.Text);
                    cmdCLO.Parameters.AddWithValue("@Details", textBox2.Text);
                    cmdCLO.Parameters.AddWithValue("@measurementLevel", textBox3.Text );
                    cmdCLO.ExecuteNonQuery();

                    MessageBox.Show("Rubrics Successfully added");
                    cleardata();
                    /*  showData2();*/// Assuming this method clears CLO-related input fields

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        void l1()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                // Clear existing items in the ComboBox
                comboBox1.Items.Clear();

                // Fetch CLO IDs from the CLO table
                SqlCommand cmdFetchCLOIds = new SqlCommand("SELECT Id FROM  Rubric   WHere  Details NOT LIKE '!%'", con);
                SqlDataReader reader = cmdFetchCLOIds.ExecuteReader();

                // Loop through the result set and add CLO IDs to the ComboBox
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Id"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching Rubric IDs: " + ex.Message);
            }

        }

        private void cleardata()
        {

            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
