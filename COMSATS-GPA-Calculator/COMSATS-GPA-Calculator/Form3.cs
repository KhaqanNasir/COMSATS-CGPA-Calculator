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
            label36.Visible = false; label37.Visible = false; label38.Visible= false;
            label39.Visible = false; textBox21.Visible = false; label40.Visible = false;
            textBox22.Visible = false; label41.Visible = false; label42.Visible = false;
            textBox23.Visible = false; label43.Visible = false; textBox24.Visible = false;
            label44.Visible = false; label45.Visible=false; textBox25.Visible = false;
            label46.Visible=false; textBox26.Visible = false; label47.Visible = false;
            label48.Visible=false; textBox27.Visible=false; label49.Visible=false;
            textBox28.Visible = false; label50.Visible = false; label51.Visible = false;
            label52.Visible = false; textBox29.Visible=false; label53.Visible = false;
            textBox30.Visible = false; label54.Visible = false; label55.Visible = false;
            textBox31.Visible = false; label56.Visible = false; textBox32.Visible = false;
            label57.Visible = false; label58.Visible= false; textBox33.Visible=false;
            label59.Visible = false; textBox34.Visible=false; label60.Visible = false;
            label61.Visible=false; textBox35.Visible=false; label62.Visible=false;
            textBox36.Visible=false; label63.Visible = false; label64.Visible = false;
            label65.Visible = false; textBox37.Visible=false; label66.Visible=false;
            textBox38.Visible = false; label67.Visible = false; label68.Visible = false;
            label69.Visible = false; textBox39.Visible = false; label70.Visible = false;
            textBox40.Visible = false; label71.Visible = false; label72.Visible = false;
            textBox41.Visible = false; label73.Visible = false; textBox42.Visible = false;
            label74.Visible = false; label75.Visible = false; textBox43.Visible = false;
            label76.Visible = false; textBox44.Visible = false; label77.Visible = false;
            label79.Visible = false; textBox45.Visible = false; label78.Visible = false;
            textBox46.Visible = false; label80.Visible = false; label81.Visible = false;
            textBox47.Visible = false; label82.Visible = false; textBox48.Visible = false;
            label83.Visible = false; label84.Visible = false; label85.Visible = false;
            textBox49.Visible = false; label86.Visible=false; textBox50.Visible = false;
            label87.Visible = false; label88.Visible = false; label89.Visible = false;
            textBox51.Visible = false; label90.Visible = false; textBox52.Visible = false;
            button3.Visible = false;


            label2.Visible = true;  label3.Visible = true; label10.Visible = true;
            textBox1.Visible = true; label11.Visible = true; textBox2.Visible = true;
            label7.Visible = true; label13.Visible = true; textBox4.Visible = true;
            label16.Visible= true; textBox7.Visible=true; label8.Visible=true;
            label12.Visible = true; textBox3.Visible=true; label15.Visible=true;
            textBox6.Visible=true; label9.Visible=true; label14.Visible=true;
            textBox5.Visible=true; label17.Visible=true; textBox8.Visible=true;
            label4.Visible= true; label18.Visible = true; label22.Visible=true;
            textBox9.Visible=true; label26.Visible=true; textBox10.Visible=true;
            label20.Visible = true; label24.Visible=true; textBox11.Visible=true;
            label28.Visible = true; textBox14.Visible = true; label19.Visible =true;
            label23.Visible=true; textBox12.Visible=true; label27.Visible=true;
            textBox13.Visible =true; label21.Visible = true; label25.Visible=true;
            textBox16.Visible=true; label29.Visible=true; textBox15.Visible = true;
            label5.Visible= true; label30.Visible =true; label31.Visible =true;
            textBox17.Visible = true; label32.Visible= true; textBox18.Visible= true;
            label6.Visible= true; label33.Visible = true;  label34.Visible= true;
            textBox19.Visible= true; label35.Visible= true; textBox20.Visible= true;
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
                    + "MidTerm Marks : " + midTermMarks + "\n" + "Final Marks : " + finalMarks + "\n\n" +
                    "Total Marks : " + (assignSum + quizSum + midTermMarks + finalMarks), "Informative Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label2.Visible = false;  label3.Visible = false; label10.Visible = false;
            textBox1.Visible = false; label11.Visible = false; textBox2.Visible = false;
            label7.Visible = false; label13.Visible = false; textBox4.Visible = false;
            label16.Visible= false; textBox7.Visible= false; label8.Visible= false;
            label12.Visible = false; textBox3.Visible= false; label15.Visible= false;
            textBox6.Visible= false; label9.Visible= false; label14.Visible= false;
            textBox5.Visible= false; label17.Visible= false; textBox8.Visible= false;
            label4.Visible= false; label18.Visible = false; label22.Visible= false;
            textBox9.Visible= false; label26.Visible= false; textBox10.Visible= false;
            label20.Visible = false; label24.Visible= false; textBox11.Visible= false;
            label28.Visible = false; textBox14.Visible = false; label19.Visible = false;
            label23.Visible= false; textBox12.Visible= false; label27.Visible= false;
            textBox13.Visible = false; label21.Visible = false; label25.Visible= false;
            textBox16.Visible= false; label29.Visible= false; textBox15.Visible = false;
            label5.Visible= false; label30.Visible = false; label31.Visible = false;
            textBox17.Visible = false; label32.Visible= false; textBox18.Visible= false;
            label6.Visible= false; label33.Visible = false;  label34.Visible= false;
            textBox19.Visible= false; label35.Visible= false; textBox20.Visible= false;
            button2.Visible= false;


            label36.Visible = true; label37.Visible = true; label38.Visible= true;
            label39.Visible = true; textBox21.Visible= true; label40.Visible= true;
            textBox22.Visible = true; label41.Visible= true; label42.Visible= true;
            textBox23.Visible = true; label43.Visible= true; textBox24.Visible= true;
            label44.Visible = true; label45.Visible = true; textBox25.Visible= true;
            label46.Visible = true; textBox26.Visible = true; label47.Visible= true;
            label48.Visible = true; textBox27.Visible= true; label49.Visible= true;
            textBox28.Visible = true; label50.Visible = true; label51.Visible= true; 
            label52.Visible= true; textBox29.Visible= true; label53.Visible= true;
            textBox30.Visible = true; label54.Visible= true; label55.Visible = true;
            textBox31.Visible = true; label56.Visible = true; textBox32.Visible = true;
            label57.Visible = true; label58.Visible = true; textBox33.Visible = true;
            label59.Visible = true; textBox34.Visible = true; label60.Visible = true;
            label61.Visible = true; textBox35.Visible = true; label62.Visible = true;
            textBox36.Visible= true; label63.Visible = true; label64.Visible = true;
            label65.Visible = true; textBox37.Visible = true; label66.Visible = true;
            textBox38.Visible = true; label67.Visible = true; label68.Visible = true;
            label69.Visible = true; textBox39.Visible = true; label70.Visible = true;
            textBox40.Visible = true; label71.Visible = true; label72.Visible = true;
            textBox41.Visible = true; label73.Visible = true; textBox42.Visible = true;
            label74.Visible = true; label75.Visible = true; textBox43.Visible = true;
            label76.Visible = true; textBox44.Visible = true; label77.Visible=true;
            label79.Visible = true; textBox45.Visible = true; label78.Visible = true;
            textBox46.Visible = true; label80.Visible= true; label81.Visible = true;
            textBox47.Visible = true; label82.Visible = true; textBox48.Visible = true;
            label83.Visible = true; label84.Visible = true; label85.Visible = true;
            textBox49.Visible = true; label86.Visible= true; textBox50.Visible = true;
            label87.Visible = true; label88.Visible = true; label89.Visible=true;
            textBox51.Visible = true; label90.Visible = true; textBox52.Visible = true;
            button3.Visible=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox21.Text == "" || textBox22.Text == "" || textBox23.Text == "" || textBox24.Text == "" || textBox25.Text == "" ||
                textBox26.Text == "" || textBox27.Text == "" || textBox28.Text == "" || textBox29.Text == "" || textBox30.Text == "" ||
                textBox31.Text == "" || textBox32.Text == "" || textBox33.Text == "" || textBox34.Text == "" || textBox35.Text == "" ||
                textBox36.Text == "" || textBox37.Text == "" || textBox38.Text == "" || textBox39.Text == "" || textBox40.Text == "" || 
                textBox41.Text == "" || textBox42.Text == "" || textBox43.Text == "" || textBox44.Text == "" || textBox45.Text == "" || 
                textBox46.Text == "" || textBox47.Text == "" || textBox48.Text == "" || textBox49.Text == "" || textBox50.Text == "" ||
                textBox51.Text == "" || textBox52.Text == "")

            {
                MessageBox.Show("Please filled all data", "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float assign1 = (float.Parse(textBox21.Text) / int.Parse(textBox22.Text)) * 2.5f;
                float assign2 = (float.Parse(textBox23.Text) / int.Parse(textBox24.Text)) * 2.5f;
                float assign3 = (float.Parse(textBox25.Text) / int.Parse(textBox26.Text)) * 2.5f;
                float assign4 = (float.Parse(textBox27.Text) / int.Parse(textBox28.Text)) * 2.5f;
                float assignSum = assign1 + assign2 + assign3 + assign4;

                float quiz1 = (float.Parse(textBox29.Text) / int.Parse(textBox30.Text)) * 3.75f;
                float quiz2 = (float.Parse(textBox31.Text) / int.Parse(textBox32.Text)) * 3.75f;
                float quiz3 = (float.Parse(textBox33.Text) / int.Parse(textBox34.Text)) * 3.75f;
                float quiz4 = (float.Parse(textBox35.Text) / int.Parse(textBox36.Text)) * 3.75f;
                float quizSum = quiz1 + quiz2 + quiz3 + quiz4;

                float midTermMarks = (float.Parse(textBox37.Text) / int.Parse(textBox38.Text)) * 25;
                float finalMarks = (float.Parse(textBox39.Text) / int.Parse(textBox40.Text)) * 50;

                float assign5 = (float.Parse(textBox41.Text) / int.Parse(textBox42.Text)) * 6.25f;
                float assign6 = (float.Parse(textBox43.Text) / int.Parse(textBox44.Text)) * 6.25f;
                float assign7 = (float.Parse(textBox45.Text) / int.Parse(textBox46.Text)) * 6.25f;
                float assign8 = (float.Parse(textBox47.Text) / int.Parse(textBox48.Text)) * 6.25f;
                float labAssignSum = assign5 + assign6 + assign7 + assign8;

                float labMidTermMarks = (float.Parse(textBox49.Text) / int.Parse(textBox50.Text)) * 25;
                float labFinalMarks = (float.Parse(textBox51.Text) / int.Parse(textBox52.Text)) * 50;

                float theoryTotal = assignSum+quizSum+finalMarks+midTermMarks;
                float labTotal =labAssignSum+labMidTermMarks+labFinalMarks;
                float TotalMarks = ((theoryTotal / 100) * 75) + ((labTotal/100)*25);

                MessageBox.Show("Theorey Assignment Marks : " + assignSum + "\n" + " Theorey Quizes Marks : " + quizSum + "\n"
                    + "Theorey MidTerm Marks : " + midTermMarks + "\n" + "Theorey Final Marks : " + finalMarks + "\n\n" +
                    "Theorey Total Marks : " + theoryTotal+"\n\n"+"Lab Assignments Marks : "+labAssignSum+
                    "\n"+"Lab MidTerm Marks : "+labMidTermMarks+"\n"+"Lab Final Marks : "+labFinalMarks+"\n\n"+"Lab Total Marks : "+labTotal+
                    "\n\n\n"+"Total Marks : "+TotalMarks, "Informative Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
