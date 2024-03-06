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
    }
}
