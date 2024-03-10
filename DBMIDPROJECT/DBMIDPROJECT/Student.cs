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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();


        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl21.BringToFront();
            userControl21.showData2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl31.Show();
            userControl31.BringToFront();
            userControl31.showData();

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();

        }

        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
