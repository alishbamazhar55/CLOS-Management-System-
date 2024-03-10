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
    public partial class Rubric : Form
    {
        public Rubric()
        {
            InitializeComponent();
            clO11.Hide();
            viewRubric1.Hide();
            deleteRubric1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clO11.Show();
            clO11.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();
        }

        private void clO11_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewRubric1.Show();
            viewRubric1.BringToFront();
            viewRubric1.showData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteRubric1.Show();
            deleteRubric1.BringToFront();
            deleteRubric1.showData();
        }

        private void Rubric_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
