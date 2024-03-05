﻿using System;
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
    public partial class ViewRubric : UserControl
    {
        public ViewRubric()
        {
            InitializeComponent();
            showData();
            label4.Hide();
        }
        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void showAllData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Rubric  ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
            dataGridView1.Refresh();
        }


        public void showData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Rubric  WHere Details NOT LIKE '!%' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Show();
            showAllData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Hide();
            showData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT * FROM Rubric WHERE Id LIKE @SearchText OR Details LIKE @SearchText OR CloId LIKE @SearchText  ";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@SearchText", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            sizeset();
            dataGridView1.Refresh();
            textBox1.Clear();
        }

        private void ViewRubric_Load(object sender, EventArgs e)
        {

        }
    }
}