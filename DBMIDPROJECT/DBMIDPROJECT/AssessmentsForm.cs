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
    public partial class AssessmentsForm : Form
    {
        public AssessmentsForm()
        {
            InitializeComponent();
            assessment1.Hide();
            assessmentView1.Hide();
            deleteAssessment1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            assessment1.Show();
            assessment1.BringToFront();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            assessmentView1.Show();
            assessmentView1.BringToFront();
            assessmentView1.showData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteAssessment1.Show();
            deleteAssessment1.BringToFront();
            deleteAssessment1.showData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();

        }

        private void deleteAssessment1_Load(object sender, EventArgs e)
        {

        }

        private void AssessmentsForm_Load(object sender, EventArgs e)
        {

        }

        private void AssessmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
