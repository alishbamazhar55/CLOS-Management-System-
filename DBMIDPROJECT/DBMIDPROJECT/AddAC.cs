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
    public partial class AddAC : UserControl
    {
        public AddAC()
        {
            InitializeComponent();
            l1();
            l2();
        }
        void l1()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                // Clear existing items in the ComboBox
                comboBox1.Items.Clear();

                // Fetch CLO IDs from the CLO table
                SqlCommand cmdFetchCLOIds = new SqlCommand("SELECT Details FROM  Rubric   WHere  Details NOT LIKE '!%'", con);
                SqlDataReader reader = cmdFetchCLOIds.ExecuteReader();

                // Loop through the result set and add CLO IDs to the ComboBox
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Details"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching Rubric IDs: " + ex.Message);
            }

        }
        void l2()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

       
                comboBox2.Items.Clear();

  
                SqlCommand cmdFetchCLOIds = new SqlCommand("SELECT Title FROM  Assessment   WHere Title NOT LIKE '!%'", con);
                SqlDataReader reader = cmdFetchCLOIds.ExecuteReader();

                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["Title"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching  Assessment  IDs: " + ex.Message);
            }

        }

        private void cleardata()
        {

            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string RUBRICdetails= comboBox1.Text.Trim();
            string assessmentTitle = comboBox2.Text.Trim();
            string ML = textBox3.Text;

            if (string.IsNullOrWhiteSpace(RUBRICdetails))
            {
                MessageBox.Show("Please enter Rubric ID.");
                return;
            }
            if (string.IsNullOrWhiteSpace(assessmentTitle))
            {
                MessageBox.Show("Please enter assessment  ID.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter Name of assessment component.");
                return;
            }


            else
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmdFetchAssessmentId = new SqlCommand("SELECT Id FROM Assessment WHERE Title = @Title", con);
                    cmdFetchAssessmentId.Parameters.AddWithValue("@Title", assessmentTitle);
                    int assessmentId = (int)cmdFetchAssessmentId.ExecuteScalar();
                    SqlCommand cmdFetchRubricId = new SqlCommand("SELECT Id FROM Rubric WHERE Details = @Details", con);
                    cmdFetchRubricId.Parameters.AddWithValue("@Details", RUBRICdetails);
                    int RUBRICid = (int)cmdFetchRubricId.ExecuteScalar();


                    SqlCommand cmdCLO = new SqlCommand("INSERT INTO AssessmentComponent (Name ,RubricId, TotalMarks, DateCreated ,DateUpdated, AssessmentId) VALUES (@Name ,@RubricId, @TotalMarks, @DateCreated ,@DateUpdated, @AssessmentId)", con);
                    cmdCLO.Parameters.AddWithValue("@RubricId", RUBRICid);
                    cmdCLO.Parameters.AddWithValue("@AssessmentId", assessmentId);
                    cmdCLO.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmdCLO.Parameters.AddWithValue("@TotalMarks", textBox3.Text);
                    cmdCLO.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                    cmdCLO.Parameters.AddWithValue("@DateUpdated", DateTime.Now);
                    cmdCLO.ExecuteNonQuery();

                    MessageBox.Show("Assessment Component Successfully added");
                    cleardata();
           

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox3_BorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
