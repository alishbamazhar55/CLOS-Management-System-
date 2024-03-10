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
    public partial class evalution : Form
    {
        int acId = 0;
        int stdId = 0;
        int mlId = 0;
        public evalution()
        {
            InitializeComponent();
            l2();
            showAllData();
            ShowEvaluatedData();
        }

        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void sizeset1()
        {
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                dataGridView2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void sizeset2()
        {
            for (int i = 0; i < dataGridView3.Columns.Count; i++)
            {
                dataGridView3.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void showAllData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student where status=5 ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
            dataGridView1.Refresh();
        }
        void l2()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();


                comboBox1.Items.Clear();


                SqlCommand cmdFetchCLOIds = new SqlCommand("SELECT Title FROM  Assessment   WHere Title NOT LIKE '!%'", con);
                SqlDataReader reader = cmdFetchCLOIds.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Title"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching  Assessment  IDs: " + ex.Message);
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();


                comboBox2.Items.Clear();
               string cb1 = comboBox1.Text;

                SqlCommand cmdFetchCLOIds = new SqlCommand("SELECT AC.Name FROM  AssessmentComponent AC join Assessment A on AC.AssessmentId=A.Id WHere A.Title = @Title And Name NOT LIKE '!%' ", con);
                cmdFetchCLOIds.Parameters.AddWithValue("@Title", cb1);
                SqlDataReader reader = cmdFetchCLOIds.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching  AssessmentComponent  IDs: " + ex.Message);
            }
        }
        void l1()
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string selectedName = comboBox2.Text;

            SqlCommand cmdGetACId = new SqlCommand("SELECT AC.Id " +
                                                    "FROM AssessmentComponent AC " +
                                                    "JOIN Assessment A ON AC.AssessmentId = A.Id " +
                                                    "WHERE A.Title = @Title AND AC.Name = @Name", con);
            cmdGetACId.Parameters.AddWithValue("@Title", comboBox1.Text);
            cmdGetACId.Parameters.AddWithValue("@Name", selectedName);

           
            SqlDataReader reader = cmdGetACId.ExecuteReader();
            if (reader.Read())
            {
                acId = Convert.ToInt32(reader["Id"]);
            }
            reader.Close();
            SqlCommand cmdCLO = new SqlCommand("SELECT RL.Id, RL.Details, RL.MeasurementLevel " +
                "FROM AssessmentComponent AC " +
                "JOIN Rubric R ON AC.RubricId = R.Id " +
                "JOIN RubricLevel Rl ON RL.RubricId = R.Id " +
                "WHERE AC.Id = @ACId", con);
          
            if(string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Please select an assessment component");
                return;
            }
         
            cmdCLO.Parameters.AddWithValue("@ACId", acId);

            SqlDataAdapter da = new SqlDataAdapter(cmdCLO);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            sizeset2();
            dataGridView1.Refresh();


        }

        int indexrow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];
            string idstring = row.Cells[0].Value.ToString();
            if(string.IsNullOrWhiteSpace(idstring))
            {
                MessageBox.Show("Please select a valid column");
                return;
            }

            stdId = int.Parse(idstring);
        }

        private void evalution_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("Insert INTO StudentResult " +
                "VALUES (@StudentId, @AssessmentComponentId, @RubricMeasurementId, @EvaluationDate)", con);
            SqlCommand cmdCheckExistingEvaluation = new SqlCommand("SELECT COUNT(StudentId) FROM StudentResult WHERE StudentId = @StudentId AND AssessmentComponentId = @AssessmentComponentId", con);
            cmdCheckExistingEvaluation.Parameters.AddWithValue("@StudentId", stdId);
            cmdCheckExistingEvaluation.Parameters.AddWithValue("@AssessmentComponentId", acId);
            int existingCount = (int)cmdCheckExistingEvaluation.ExecuteScalar();

            if (existingCount > 0)
            {
                MessageBox.Show("Error: Student has already been evaluated on this assessment component.");
                return;
            }

            if (stdId == 0)
            {
                MessageBox.Show("Please select a student");
                return;
            }
            cmd.Parameters.AddWithValue("@StudentId", stdId);

            if(acId == 0)
            {
                MessageBox.Show("Please select an assessment component");
                return;
            }

            cmd.Parameters.AddWithValue("@AssessmentComponentId", acId);

            if(mlId == 0)
            {
                MessageBox.Show("Please select an rubric level from tabel");
                return;
            }
            cmd.Parameters.AddWithValue("@RubricMeasurementId", mlId);

            cmd.Parameters.AddWithValue("@EvaluationDate", DateTime.Now);
            cmd.ExecuteNonQuery();
            ShowEvaluatedData();
            MessageBox.Show("Evaluated Successfully");
            cleardata();
            dataGridView3.DataSource = null;
        }
        void cleardata()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView3.Rows[indexrow];
            string idstring = row.Cells[0].Value.ToString();
            string ml = row.Cells[2].Value.ToString();
            if (string.IsNullOrWhiteSpace(idstring))
            {
                MessageBox.Show("Please select a valid column");
                return;
            }
            textBox1.Text = ml;
            mlId = int.Parse(idstring);

        }

        private void ShowEvaluatedData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from StudentResult ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            sizeset1();
            dataGridView2.Refresh();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void evalution_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
