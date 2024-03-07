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
    public partial class Rubriclevel : Form
    {
        public Rubriclevel()
        {
            InitializeComponent();
            addRL1.Hide();
            vIewRL1.Hide();
            deleteRL1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addRL1.Show();
            addRL1.BringToFront();
          
        }

        private void addRL1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vIewRL1.Show();
            vIewRL1.BringToFront();
            vIewRL1.showData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteRL1.Show();
            deleteRL1.showData();
            deleteRL1.BringToFront();
        }

        private void deleteRL1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
