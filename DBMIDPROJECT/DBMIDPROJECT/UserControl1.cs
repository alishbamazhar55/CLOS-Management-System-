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
    public partial class UserControl1 : UserControl
    {
        int status;
        public UserControl1()
        {
            InitializeComponent();
           
            if (status == 5)
            { comboBox1.Text = "Active"; }
            else if (status == 6)
            { comboBox1.Text = "Inactive"; }

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                string registrationNumber = textBox2.Text;
                string[] parts = registrationNumber.Split('-');

                if (parts.Length != 3 || parts[0].Length != 4 || !int.TryParse(parts[0], out int year) || !int.TryParse(parts[2], out int rollNumber))
                {
                    MessageBox.Show("Error: Registration Number format should be 'year-field-rollNumber' (e.g., 2022-CS-74).");
                    cleardata();
                    return;
                }
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE RegistrationNumber = @RegistrationNumber", con);
                checkCmd.Parameters.AddWithValue("@RegistrationNumber", textBox2.Text);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Error: Registration Number already exists.");
                    cleardata();
                }
                else
                {
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO Student VALUES (@FirstName, @LastName, @Contact, @Email, @RegistrationNumber, @Status)", con);
                    insertCmd.Parameters.AddWithValue("@FirstName",Validations.NameValidation( textBox1.Text));
                    insertCmd.Parameters.AddWithValue("@LastName",Validations.NameValidation( textBox5.Text));
                    insertCmd.Parameters.AddWithValue("@Contact", Validations.IntegerValidation(textBox4.Text,11) );
                    insertCmd.Parameters.AddWithValue("@Email", Validations.EmailValidation(textBox3.Text));
                    insertCmd.Parameters.AddWithValue("@RegistrationNumber", textBox2.Text);

                    int id_check = 0;
                    if (comboBox1.Text == "Active")
                    {
                        id_check = 5;
                    }
                    else
                    {
                        id_check = 6;
                    }

                    insertCmd.Parameters.AddWithValue("@Status", id_check);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved");

                    cleardata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }


        private void cleardata()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
        }
    }
}
