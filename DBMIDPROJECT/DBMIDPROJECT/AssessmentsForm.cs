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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            assessment1.Show();
            assessment1.BringToFront();
          
        }
    }
}
