using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMIDPROJECT
{
    public partial class AttendenceForm : Form
    {
        public AttendenceForm()
        {
            InitializeComponent();
            attendence1.Hide();
            viewAttendence1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            attendence1.Show();
            attendence1.BringToFront();
            attendence1.showData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewAttendence1.Show();
            viewAttendence1.BringToFront();
            viewAttendence1.student_attendance();
        }

        private void attendence1_Load(object sender, EventArgs e)
        {

        }

        private void AttendenceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
