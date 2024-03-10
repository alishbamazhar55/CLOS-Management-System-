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
    public partial class AssessmentResult : Form
    {
  
        public AssessmentResult()
        {
            InitializeComponent();
            l2();

        }
        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
     
        public void showAllData()
        {

           
            var con = Configuration.getInstance().getConnection();


            string selectedTitle = comboBox1.Text;
            SqlCommand cmdFetchAssessmentId = new SqlCommand("SELECT Id FROM Assessment WHERE Title = @Title", con);
            cmdFetchAssessmentId.Parameters.AddWithValue("@Title", selectedTitle);
            int assessmentId = (int)cmdFetchAssessmentId.ExecuteScalar();

            SqlCommand cmd = new SqlCommand("SELECT s.FirstName , s.RegistrationNumber AS Reg_no, " +
                    "Assessment.Title, ac.Name AS AC_Name, ac.TotalMarks AS Totalmarks, " +
                    "rl.MeasurementLevel AS O_Level, MAX(rl2.MeasurementLevel) AS MaxLevel, " +
                    "CAST(CAST(rl.MeasurementLevel AS FLOAT) / MAX(CAST(rl2.MeasurementLevel AS FLOAT)) * ac.TotalMarks AS FLOAT) AS ObtainedMarks " +
                    "FROM StudentResult AS st " +
                   "JOIN Student AS s ON st.StudentId = s.Id " +
                    "JOIN AssessmentComponent AS ac ON ac.Id = st.AssessmentComponentId " +
                    "JOIN Rubric AS r ON r.Id = ac.RubricId " +
                    "JOIN RubricLevel AS rl ON rl.Id = st.RubricMeasurementId " +
                    "JOIN RubricLevel AS rl2 ON rl2.RubricId = r.Id " +
                     "JOIN Assessment ON Assessment.Id = ac.AssessmentId " +
                     "WHERE Assessment.Id = @ASSTitle " +
                     "GROUP BY ac.Name, ac.TotalMarks, rl.MeasurementLevel, s.FirstName, s.LastName,s.RegistrationNumber, Assessment.Title", con);
            cmd.Parameters.AddWithValue("@ASSTitle", assessmentId);
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAllData();
        }

        private void button2_Click(object sender, EventArgs e)
        { 

            Form f = new Form1();
                f.Show();
            this.Hide();
        }

        private void AssessmentResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
