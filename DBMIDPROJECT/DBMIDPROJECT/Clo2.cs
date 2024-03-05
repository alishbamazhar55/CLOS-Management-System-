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
    public partial class Clo2 : UserControl
    {
        public Clo2()
        {
            InitializeComponent();
            showData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int indexrow;
        string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];

            id = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();

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
            SqlCommand cmd = new SqlCommand("Select * from Clo  WHere Name NOT LIKE '!%' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT * FROM Clo WHERE Id LIKE @SearchText OR Name LIKE @SearchText OR DateCreated LIKE @SearchText OR DateUpdated LIKE @SearchText ";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@SearchText", textBox4.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }

            sizeset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                // Fetch Id from the database
                SqlCommand fetchIdCmd = new SqlCommand("SELECT Id FROM Clo WHERE Id = @Id", con);
                fetchIdCmd.Parameters.AddWithValue("@Id", id);

                SqlCommand fetchDateCreatedCmd = new SqlCommand("SELECT DateCreated FROM Clo WHERE Id = @Id", con);
                fetchDateCreatedCmd.Parameters.AddWithValue("@Id", id);

                string originalDateCreated = fetchDateCreatedCmd.ExecuteScalar().ToString();


                int cloId = Convert.ToInt32(fetchIdCmd.ExecuteScalar());
                if (cloId == 0)
                {
                    MessageBox.Show("Error: CLO with this ID does not exist.");
                    cleardata();
                    return;
                }

                // Check if the textboxes are empty
                if (string.IsNullOrWhiteSpace(textBox1.Text.Trim()) || string.IsNullOrWhiteSpace(textBox2.Text.Trim()) || string.IsNullOrWhiteSpace(textBox3.Text.Trim()))
                {
                    MessageBox.Show("Error: Please fill in all fields for updating.");
                    return;
                }
                if (!originalDateCreated.Equals(textBox2.Text.Trim(), StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("Error: You cannot update the DateCreated field.");
                    cleardata();
                    return;
                }

                SqlCommand updateCLOCmd = new SqlCommand("UPDATE Clo SET Name = @Name, DateUpdated = GETDATE() WHERE Id = @Id", con);
                updateCLOCmd.Parameters.AddWithValue("@Name", textBox1.Text.Trim());
                updateCLOCmd.Parameters.AddWithValue("@DateCreated", textBox2.Text.Trim());
                updateCLOCmd.Parameters.AddWithValue("@DateUpdated", textBox3.Text.Trim());
                updateCLOCmd.Parameters.AddWithValue("@Id", id);

                // Execute the update command for the CLO
                updateCLOCmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
                showData();

                cleardata(); // Assuming this method clears form fields after updating
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
         }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please select a CLO to delete.");
                return;
            }

            var con = Configuration.getInstance().getConnection();

            SqlCommand updateCmd = new SqlCommand("UPDATE Clo SET Name = '!' + Name WHERE Id = @Id", con);
            updateCmd.Parameters.AddWithValue("@Id", id);
            updateCmd.ExecuteNonQuery();


            MessageBox.Show("Successfully deleted ");

            cleardata();
            showData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
