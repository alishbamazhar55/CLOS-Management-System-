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
    public partial class AssessmentView : UserControl
    {
        public AssessmentView()
        {
            InitializeComponent();
            showData();
            label4.Hide();
        }
        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void showALLData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Assessment  ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
            dataGridView1.Refresh();
        }

        public void showData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Assessment  WHere Title NOT LIKE '!%' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
            dataGridView1.Refresh();
        }

        private void AssessmentView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Hide();
            showData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showALLData();
            label4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter text for search.");
            }

            else
            {
                var con = Configuration.getInstance().getConnection();
                string query = "SELECT * FROM Assessment WHERE Id LIKE @SearchText OR Title LIKE @SearchText OR DateCreated LIKE @SearchText OR TotalMarks LIKE @SearchText OR TotalWeightage LIKE @SearchText ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SearchText", textBox1.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }

            sizeset();
            textBox1.Clear();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
