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
    public partial class viewAttendence : UserControl
    {
        string x;
        
        public viewAttendence()
        {
            InitializeComponent();
          
            student_attendance();
           

        }
 
        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

       

        public void student_attendance()
        {
         
                string selectedDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            var con2 = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("SELECT RegistrationNumber,FirstName, LastName,  Lookup.Name AS STATUS, AttendanceDate " +
                                     "FROM ClassAttendance " +
                                     "JOIN StudentAttendance ON StudentAttendance.AttendanceId = ClassAttendance.Id " +
                                     "JOIN Student ON StudentAttendance.StudentId = Student.Id " +
                                     "JOIN Lookup ON LookupId = StudentAttendance.AttendanceStatus ", con2);

            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1. DataSource = null;
            dataGridView1.DataSource = dt;
         
            sizeset();


        }

        private void View_Specific_student_attendance()
        {
            string selectedDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            var con2 = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("SELECT RegistrationNumber, FirstName, LastName,  Lookup.Name AS STATUS, AttendanceDate " +
                                         "FROM ClassAttendance " +
                                         "JOIN StudentAttendance ON StudentAttendance.AttendanceId = ClassAttendance.Id " +
                                         "JOIN Student ON StudentAttendance.StudentId = Student.Id " +
                                         "JOIN Lookup ON LookupId = StudentAttendance.AttendanceStatus " +
                                         "WHERE FORMAT(ClassAttendance.AttendanceDate, 'yyyy-MM-dd') = @date", con2);
            cmd2.Parameters.AddWithValue("@date", selectedDate);

            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Check if the DataTable is empty
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No records found for the selected date.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
                sizeset();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Specific_student_attendance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student_attendance();
        }
    }
}
