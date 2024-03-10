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
    public partial class Attendence : UserControl
    {
        public Attendence()
        {
            InitializeComponent();
            DataBind();
        }
        private void DataBind()
        {


            DataGridViewComboBoxColumn status = new DataGridViewComboBoxColumn();
            status.HeaderText = "Status";
            status.Items.Add("Present");
            status.Items.Add("Absent");
            status.Items.Add("Late");
            status.Items.Add("Leave");

            dataGridView1.Columns.Add(status);

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
            SqlCommand cmd = new SqlCommand("select Student.Id , Student.FirstName,Student.LastName ,RegistrationNumber from Student where Status = 5 ", con);
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
            try
            {
                var con = Configuration.getInstance().getConnection();

                DateTime attendanceDate = DateTime.Now;
                SqlCommand classAttendanceCmd = new SqlCommand("INSERT INTO ClassAttendance (AttendanceDate) VALUES (@AttendanceDate); SELECT SCOPE_IDENTITY();", con);
                classAttendanceCmd.Parameters.AddWithValue("@AttendanceDate", attendanceDate);
                int classAttendanceId = Convert.ToInt32(classAttendanceCmd.ExecuteScalar());
                SqlCommand studentCOunt = new SqlCommand("Select COUNT(Student.Id) from Student  Where status = 5", con);
                int count = (int)studentCOunt.ExecuteScalar();
                for (int i = 0; i < count; i++)
                {
                    int S = 1;
                    string SI = dataGridView1.Rows[i].Cells[0].Value.ToString();

                    if (SI != null)
                    {
                        string StudentStatus = dataGridView1.Rows[i].Cells[4].Value.ToString();


                        if (StudentStatus == "Present")
                        {
                            S = 1;
                        }
                        else if (StudentStatus == "Absent")
                        {
                            S = 2;
                        }
                        else if (StudentStatus == "Leave")
                        {
                            S = 3;
                        }
                        else if (StudentStatus == "Late")
                        {
                            S = 4;
                        }
                    }
                    SqlCommand studentAttendanceCmd = new SqlCommand("INSERT INTO StudentAttendance (AttendanceId, StudentId, AttendanceStatus) VALUES (@AttendanceId, @StudentId, @AttendanceStatus)", con);
                    studentAttendanceCmd.Parameters.AddWithValue("@AttendanceId", classAttendanceId);
                    studentAttendanceCmd.Parameters.AddWithValue("@StudentId", SI);
                    studentAttendanceCmd.Parameters.AddWithValue("@AttendanceStatus", S);

                    studentAttendanceCmd.ExecuteNonQuery();
                }


                MessageBox.Show("Attendance marked successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
