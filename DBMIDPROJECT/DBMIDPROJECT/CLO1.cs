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
    public partial class CLO1 : UserControl
    {
        public CLO1()
        {
            InitializeComponent();
            l1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string RUBRICid = textBox2.Text.Trim();
            string clos = comboBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(RUBRICid))
            {
                MessageBox.Show("Please enter Rubric ID.");
            }
            else
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmdFetchRubricId = new SqlCommand("SELECT Id FROM Clo WHERE Name = @Detail", con);
                    cmdFetchRubricId.Parameters.AddWithValue("@Detail", clos);
                    int cloid = (int)cmdFetchRubricId.ExecuteScalar();
                    SqlCommand cmdCLO = new SqlCommand("INSERT INTO Rubric (Id, Details, CloId) VALUES (@Id, @Details, @CloId)", con);
                    cmdCLO.Parameters.AddWithValue("@Id", RUBRICid);
                    cmdCLO.Parameters.AddWithValue("@Details", textBox3.Text);
                    cmdCLO.Parameters.AddWithValue("@CloId", cloid);
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
                SqlCommand cmdFetchCLOIds = new SqlCommand("SELECT Name FROM CLO   WHere Name NOT LIKE '!%'", con);
                SqlDataReader reader = cmdFetchCLOIds.ExecuteReader();

                // Loop through the result set and add CLO IDs to the ComboBox
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching CLO IDs: " + ex.Message);
            }

        }
        private void cleardata()
        {

            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
