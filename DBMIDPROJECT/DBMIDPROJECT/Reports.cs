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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();

            comboBox1.Items.Add("Attendance Report");
            comboBox1.Items.Add("CLO wise class result");
            comboBox1.Items.Add("Assessment wise class result");
            comboBox1.Items.Add("Evaluated Students Report");
            comboBox1.Items.Add("Students who  donot attempt any assessment");
        }

        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


          var con = Configuration.getInstance().getConnection();

            string selectedQuery = comboBox1.Text;
            if (string.IsNullOrWhiteSpace(selectedQuery))
            {
                MessageBox.Show("please select report to generate");
                return;            }
            if (selectedQuery == "Attendance Report")
            {

                string query = @"SELECT RegistrationNumber, FirstName, LastName,  Lookup.Name AS STATUS, AttendanceDate " +
                                         "FROM ClassAttendance " +
                                         "JOIN StudentAttendance ON StudentAttendance.AttendanceId = ClassAttendance.Id " +
                                         "JOIN Student ON StudentAttendance.StudentId = Student.Id " +
                                         "JOIN Lookup ON LookupId = StudentAttendance.AttendanceStatus ";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = dt;
                da.Fill(dt);
                sizeset();

                PDFgenerate.GeneratePdf(dt, "Attendance Report of the class");
            }
            else if(selectedQuery== "CLO wise class result")
            {
                string query = @"SELECT CONCAT(s.FirstName, ' ', s.LastName) as Name ,s.RegistrationNumber as Reg_no, 
                             Clo.Name AS CloName, Clo.Id AS CloId,
                             SUM(ac.TotalMarks) AS T_Marks, 
                             SUM(rl.MeasurementLevel) AS O_Level, 
                             MAX(rl2.MaxMeasurementLevel) AS MaxLevel,
                             ((SUM(CAST(rl.MeasurementLevel AS FLOAT)) / MAX(CAST(rl2.MaxMeasurementLevel AS FLOAT))) * SUM(CAST(ac.TotalMarks AS FLOAT)))
                             AS ObtainedMarks
                            FROM  StudentResult AS st 
                            JOIN  Student AS s ON st.StudentId = s.Id 
                            JOIN  AssessmentComponent AS ac ON ac.Id = st.AssessmentComponentId 
                            JOIN  Rubric AS r ON r.Id = ac.RubricId 
                            JOIN  RubricLevel AS rl ON rl.Id = st.RubricMeasurementId 
                            JOIN  (SELECT RubricId, MAX(MeasurementLevel) AS MaxMeasurementLevel
                                 FROM RubricLevel GROUP BY RubricId) AS rl2 ON rl2.RubricId = r.Id 
                            JOIN Assessment ON Assessment.Id = ac.AssessmentId 
                            JOIN Clo ON Clo.Id = r.CloId 
                            WHERE Clo.Name not like '!%'
                            GROUP BY  s.FirstName, s.LastName, s.RegistrationNumber, Clo.Name, Clo.Id";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = dt;
                da.Fill(dt);
                sizeset();

                PDFgenerate.GeneratePdf(dt, "CLO WISE CLASS RESULT");

            }
            else if (selectedQuery== "Assessment wise class result")
            {
                string query = @"SELECT CONCAT(s.FirstName, ' ', s.LastName) as Name, s.RegistrationNumber as Reg_no, 
                            Assessment.Title, ac.Name AS  AC_Name, ac.TotalMarks AS T_marks, 
                            rl.MeasurementLevel AS O_evel, MAX(rl2.MeasurementLevel) AS MaxLevel,
                            CAST(CAST(rl.MeasurementLevel AS FLOAT) / MAX(CAST(rl2.MeasurementLevel AS FLOAT)) * ac.TotalMarks AS FLOAT) AS ObtainedMarks 
                            FROM StudentResult AS st 
                            JOIN Student AS s ON st.StudentId = s.Id 
                            JOIN AssessmentComponent AS ac ON ac.Id = st.AssessmentComponentId 
                            JOIN Rubric AS r ON r.Id = ac.RubricId 
                            JOIN RubricLevel AS rl ON rl.Id = st.RubricMeasurementId 
                            JOIN RubricLevel AS rl2 ON rl2.RubricId = r.Id 
                            JOIN Assessment ON Assessment.Id = ac.AssessmentId 
                            GROUP BY ac.Name, ac.TotalMarks, rl.MeasurementLevel, s.FirstName, s.LastName,s.RegistrationNumber, Assessment.Title";


                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = dt;
                da.Fill(dt);
                sizeset();

                PDFgenerate.GeneratePdf(dt, "ASSESSMENT WISE CLASS RESULT");

            }
            else if (selectedQuery == "Evaluated Students Report")
            {
                string Query = @"Select S.RegistrationNumber , S.FirstName ,A.TItle as Assessment ,
                          AC.Name as ACName , AC.Id as ACID, RL.MeasurementLevel from StudentResult SR 
                         JOIN Student S on SR.StudentId = S.Id
                        JOIN AssessmentComponent AC ON SR.AssessmentComponentId = AC.Id
                        JOIN Assessment A on AC.AssessmentId = A.Id
                        JOIN RubricLevel RL on SR.RubricMeasurementId=RL.Id";


                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = dt;
                da.Fill(dt);
                sizeset();

                PDFgenerate.GeneratePdf(dt, "Evaluated Students Report");

            }

            else if (selectedQuery == "Students who  donot attempt any assessment")
            {
                string Query = @"select S.RegistrationNumber,S.FirstName ,S.LastName ,S.Contact from Student S
	                        left join StudentResult SR on S.Id=SR.StudentId
	                        where SR.StudentId is null and S.Status =5";

                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = dt;
                da.Fill(dt);
                sizeset();

                PDFgenerate.GeneratePdf(dt, " Students  who donot attempt any Assessment ");

            }
        }

      

     
           
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Reports_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
   
}
