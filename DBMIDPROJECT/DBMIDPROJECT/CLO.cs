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
    public partial class CLO : Form
    {
        public CLO()
        {
            InitializeComponent();
           
            clo22.Hide();
            clo32.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void CLO_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clo32.Show();

            clo32.BringToFront();
            clo32.showData2();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            clo22.Show();
            clo22.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();
        }

        private void CLO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
