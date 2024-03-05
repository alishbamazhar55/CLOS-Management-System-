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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            dataGridView1.Refresh();
            showData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var con = Configuration.getInstance().getConnection();

            SqlCommand updateCmd = new SqlCommand("UPDATE Student SET Status = 6 WHERE Id = @Id", con);
            updateCmd.Parameters.AddWithValue("@Id", id);
            updateCmd.ExecuteNonQuery();


            MessageBox.Show("Successfully deleted and status changed to Inactive");

            cleardata();
            showData();
        }

        private void cleardata()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox5.Text = "";
            textBox6.Text = "";
            

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
            SqlCommand cmd = new SqlCommand("Select * from Student where Status = 5", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int indexrow;

        string id;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];

            id = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox4.Text = row.Cells[5].Value.ToString();
            textBox6.Text = row.Cells[6].Value.ToString();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
             

                // Fetch Id from the database
                SqlCommand fetchIdCmd = new SqlCommand("SELECT Id FROM Student WHERE Id = @Id", con);
                fetchIdCmd.Parameters.AddWithValue("@Id", id);

                int id1 = Convert.ToInt32(fetchIdCmd.ExecuteScalar());
                if (id1 == 0)
                {
                    MessageBox.Show("Error: Student with this ID does not exist.");
                    cleardata();
                    return;
                }

                // Update the student details
                SqlCommand updateCmd = new SqlCommand("UPDATE Student SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email ,RegistrationNumber=@RegistrationNumber,Status = @Status WHERE Id = @Id", con);
                updateCmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                updateCmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                updateCmd.Parameters.AddWithValue("@Contact", textBox3.Text);
                updateCmd.Parameters.AddWithValue("@Email", textBox5.Text);
                updateCmd.Parameters.AddWithValue("@RegistrationNumber", textBox4.Text);
                updateCmd.Parameters.AddWithValue("@Status", textBox6.Text);
                int status;
                if (!int.TryParse(textBox6.Text, out status) || (status != 5 && status != 6))
                {
                    MessageBox.Show("Error: Status must be either 5 or 6.");
                    return;
                }
                updateCmd.Parameters.AddWithValue("@Id", id);
                SqlCommand checkRegNoCmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE RegistrationNumber = @RegistrationNumber AND Id != @Id", con);
                checkRegNoCmd.Parameters.AddWithValue("@RegistrationNumber", textBox4.Text);
                checkRegNoCmd.Parameters.AddWithValue("@Id", id);

                int regNoCount = (int)checkRegNoCmd.ExecuteScalar();
                if (regNoCount > 0)
                {
                    MessageBox.Show("Error: Registration number already exists. Please choose a different one.");
                    return;
                }
                updateCmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
                showData();

                cleardata();
                textBox7.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT * FROM Student WHERE Id LIKE @SearchText OR FirstName LIKE @SearchText OR LastName LIKE @SearchText OR Contact LIKE @SearchText OR Email LIKE @SearchText OR RegistrationNumber LIKE @SearchText or Status LIKE @SearchText ";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@SearchText", textBox7.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
               
            }
           
            sizeset();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
