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
    public partial class AssessmentComponent : Form
    {
        public AssessmentComponent()
        {
            InitializeComponent();
            addAC1.Hide();
            viewAC1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addAC1.Show();
            addAC1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewAC1.Show();
            viewAC1.BringToFront();
            viewAC1.showData();
        }
    }
}
