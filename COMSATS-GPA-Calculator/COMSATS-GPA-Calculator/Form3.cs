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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label2.Visible= true;
            label3.Visible = true;
            label10.Visible = true;
            textBox1.Visible = true;
            label11.Visible = true;
            textBox2.Visible = true;
            label7.Visible = true;
            label13.Visible = true;
            textBox4.Visible = true;
            label16.Visible= true;
            textBox7.Visible=true;
            label8.Visible=true;
            label12.Visible = true;
            textBox3.Visible=true;
            label15.Visible=true;
            textBox6.Visible=true;
            label9.Visible=true;
            label14.Visible=true;
            textBox5.Visible=true;
            label17.Visible=true;
            textBox8.Visible=true;
            label4.Visible= true;
            label18.Visible=true;
            label22.Visible=true;
            textBox9.Visible=true;
            label26.Visible=true;
            textBox10.Visible=true;
            label20.Visible = true;
            label24.Visible=true;
            textBox11.Visible=true;
            label28.Visible=true;
            textBox14.Visible=true;
            label19.Visible =true;
            label23.Visible=true;
            textBox12.Visible=true;
            label27.Visible=true;
            textBox13.Visible =true;
            label21.Visible=true;
            label25.Visible=true;
            textBox16.Visible=true;
            label29.Visible=true;
            textBox15.Visible = true;
            label5.Visible= true;
            label30.Visible =true;
            label31.Visible =true;  
            textBox17.Visible= true;
            label32.Visible= true;
            textBox18.Visible= true;
            label6.Visible= true;
            label33.Visible= true;
            label34.Visible= true;
            textBox19.Visible= true;
            label35.Visible= true;
            textBox20.Visible= true;
            button2.Visible=true;
        }

        private void button2_Click(object sender, EventArgs e) { 
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||
                textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || 
                textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == ""  || textBox14.Text == "" || textBox15.Text == "" ||
                textBox16.Text == ""|| textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "")
            {
                MessageBox.Show("Please filled all data", "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float assign1 = (float.Parse(textBox1.Text) / int.Parse(textBox2.Text)) * 2.5f;
                float assign2 = (float.Parse(textBox4.Text) / int.Parse(textBox7.Text)) * 2.5f;
                float assign3 = (float.Parse(textBox3.Text) / int.Parse(textBox6.Text)) * 2.5f;
                float assign4 = (float.Parse(textBox4.Text) / int.Parse(textBox8.Text)) * 2.5f;
                float assignSum = assign1 + assign2 + assign3 + assign4;

                float quiz1 = (float.Parse(textBox9.Text) / int.Parse(textBox10.Text)) * 3.5f;
                float quiz2 = (float.Parse(textBox11.Text) / int.Parse(textBox14.Text)) * 3.5f;
                float quiz3 = (float.Parse(textBox12.Text) / int.Parse(textBox13.Text)) * 3.5f;
                float quiz4 = (float.Parse(textBox16.Text) / int.Parse(textBox15.Text)) * 3.5f;
                float quizSum = quiz1 + quiz2 + quiz3 + quiz4;

                float midTermMarks = (float.Parse(textBox17.Text) / int.Parse(textBox18.Text)) * 25;
                float finalMarks = (float.Parse(textBox19.Text) / int.Parse(textBox20.Text)) * 50;
                MessageBox.Show("Assignment Marks : " + assignSum + "\n" + "Quizes Marks : " + quizSum + "\n"
                    + "MidTerm Marks : " + midTermMarks + "\n" + "Terminal Marks : " + finalMarks + "\n\n" +
                    "Total Marks : " + (assignSum + quizSum + midTermMarks + finalMarks), "Informative Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
