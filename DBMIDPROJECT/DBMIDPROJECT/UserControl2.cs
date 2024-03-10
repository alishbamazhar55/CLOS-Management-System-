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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            dataGridView1.Refresh();
            showData2();
          

        }
        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void UserControl2_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        

        public void showData2()
        {
         
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student where Status = 5", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showData2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();
            showData3(searchText);
            textBox1.Clear();
        }





        private void showData3(string searchText)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT * FROM Student WHERE Id LIKE @SearchText OR FirstName LIKE @SearchText OR LastName LIKE @SearchText OR Contact LIKE @SearchText OR Email LIKE @SearchText OR RegistrationNumber LIKE @SearchText or Status LIKE @SearchText ";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@SearchText",  searchText );
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            sizeset();
            dataGridView1.Refresh();
        }


        private void button3_Click(object sender, EventArgs e)
        {
         
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
            dataGridView1.Refresh();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
