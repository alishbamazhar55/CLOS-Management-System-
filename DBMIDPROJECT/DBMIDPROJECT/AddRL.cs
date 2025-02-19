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
    public partial class AddRL : UserControl
    {
        public AddRL()
        {
            InitializeComponent();
            l1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string RUBRICdetails = comboBox1.Text.Trim();
            string ML = textBox3.Text;

            if (string.IsNullOrWhiteSpace(RUBRICdetails))
            {
                MessageBox.Show("Please enter Rubric ID.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter Details.");
                return;
            }
            if (string.IsNullOrWhiteSpace(ML))
            {
                MessageBox.Show("Please enter Measurement level.");
                return;
            }
            if (int.Parse(ML) > 4 || int.Parse(ML) < 1)
            {
                MessageBox.Show("Maximum Measurement Level is 4 and minimum level is 1.");
                textBox3.Clear();
                return;
            }
            else
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmdFetchRubricId = new SqlCommand("SELECT Id FROM Rubric WHERE Details = @Details", con);
                    cmdFetchRubricId.Parameters.AddWithValue("@Details", RUBRICdetails);
                    int RUBRICid = (int)cmdFetchRubricId.ExecuteScalar();

                    SqlCommand cmdCLO = new SqlCommand("INSERT INTO RubricLevel (RubricId, Details, MeasurementLevel) VALUES (@RubricId, @Details, @MeasurementLevel)", con);
                    cmdCLO.Parameters.AddWithValue("@RubricId", RUBRICid);
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

  
                comboBox1.Items.Clear();

                // Fetch CLO IDs from the CLO table
                SqlCommand cmdFetchCLOIds = new SqlCommand("SELECT Details FROM  Rubric   WHere  Details NOT LIKE '!%'", con);
                SqlDataReader reader = cmdFetchCLOIds.ExecuteReader();

             
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

        private void AddRL_Load(object sender, EventArgs e)
        {

        }
    }
}
