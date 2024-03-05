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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string RUBRICid = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(RUBRICid))
            {
                MessageBox.Show("Please enter Rubric ID.");
            }
            else
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();

                    SqlCommand cmdCLO = new SqlCommand("INSERT INTO Rubric (Id, Details, CloId) VALUES (@Id, @Details, @CloId)", con);
                    cmdCLO.Parameters.AddWithValue("@Id", RUBRICid);
                    cmdCLO.Parameters.AddWithValue("@Details", textBox3.Text);
                    cmdCLO.Parameters.AddWithValue("@CloId", textBox4.Text);
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
        private void cleardata()
        {

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
