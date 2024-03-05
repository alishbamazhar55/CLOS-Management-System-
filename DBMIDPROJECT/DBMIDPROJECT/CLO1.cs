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
            string cloName = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(cloName))
            {
                MessageBox.Show("Please enter CLO name.");
            }
            else
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();

                    SqlCommand cmdCLO = new SqlCommand("INSERT INTO Clo (Name, DateCreated, DateUpdated) VALUES (@Name, @DateCreated, @DateUpdated)", con);
                    cmdCLO.Parameters.AddWithValue("@Name", cloName);
                    cmdCLO.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                    cmdCLO.Parameters.AddWithValue("@DateUpdated", DateTime.Now);
                    cmdCLO.ExecuteNonQuery();

                    MessageBox.Show("CLO Successfully added");
                    cleardata(); // Assuming this method clears CLO-related input fields
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
        }
    }
}
