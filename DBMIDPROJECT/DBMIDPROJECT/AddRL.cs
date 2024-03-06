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

            if (string.IsNullOrWhiteSpace(RUBRICid))
            {
                MessageBox.Show("Please enter Rubric ID.");
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

        }
    }
}
