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
    public partial class Form1 : Form
    {
        public Form evaluationForm = null;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form moreform = new Student();
            moreform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new CLO();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Rubric();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new AssessmentsForm();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Rubriclevel();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form f = new AttendenceForm();
            f.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form f = new AssessmentComponent();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            evaluationForm = new evalution();
            evaluationForm.Show();
            this.Hide();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form f = new AssessmentResult();
                f.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form f = new Reports();
            f.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
