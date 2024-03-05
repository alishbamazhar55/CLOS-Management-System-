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
            clO11.Hide();
            clo21.Hide();
            clo31.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clO11.Show();
        
            clO11.BringToFront();
        }

        private void CLO_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clo21.Show();
            clo21.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clo31.Show();
         
            clo31.BringToFront();
            clo31.showData();
        }
    }
}
