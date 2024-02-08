using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace COMSATS_GPA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            this.Visible = false;
            f2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            DayOfWeek currentDay = currentDateTime.DayOfWeek;
            label2.Text = currentDay+" "+currentDateTime.ToString();
            label2.Visible= true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Visible = false;
            f3.Show();
        }
    }
}