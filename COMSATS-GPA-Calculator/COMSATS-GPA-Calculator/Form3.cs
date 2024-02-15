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
   
            this.Close();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
   
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label112.Visible = false; label113.Visible = false; label114.Visible = false;
            label115.Visible = false; label116.Visible = false; label117.Visible = false;
            label118.Visible = false; label119.Visible = false; label120.Visible = false;
            label121.Visible = false; label122.Visible = false; label123.Visible = false;
            label124.Visible = false; label125.Visible = false; label126.Visible = false;
            label127.Visible = false; label128.Visible = false; textBox53.Visible = false;
            textBox54.Visible = false; textBox55.Visible = false; textBox56.Visible = false;
            textBox57.Visible = false; textBox58.Visible = false; textBox59.Visible = false;
            textBox60.Visible = false; label129.Visible = false; label130.Visible = false;
            label131.Visible = false; label132.Visible = false; label133.Visible = false;
            label134.Visible = false; label135.Visible = false; label136.Visible = false;
            textBox61.Visible = false; textBox62.Visible = false; textBox62.Visible = false;
            textBox63.Visible = false; textBox64.Visible = false; textBox65.Visible = false;
            textBox66.Visible = false; textBox67.Visible = false; textBox68.Visible = false;
            button5.Visible = false;

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


            label91.Visible = false; label92.Visible = false; comboBox1.Visible = false;
            label93.Visible = false; comboBox2.Visible = false; label94.Visible = false;
            label95.Visible = false; comboBox3.Visible = false; label96.Visible = false;
            comboBox4.Visible = false; label97.Visible = false; label98.Visible = false;
            comboBox5.Visible = false; label99.Visible = false; comboBox6.Visible = false;
            label100.Visible = false; label101.Visible = false; comboBox7.Visible = false;
            label102.Visible = false; comboBox8.Visible = false; label103.Visible = false;
            label104.Visible = false; comboBox9.Visible = false; label105.Visible = false;
            comboBox10.Visible = false; label106.Visible = false; label107.Visible = false;
            comboBox11.Visible = false; label108.Visible = false; comboBox12.Visible = false;
            label109.Visible = false; label110.Visible = false; comboBox13.Visible = false;
            label111.Visible = false; comboBox14.Visible = false; button4.Visible = false;


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
                MessageBox.Show("Please filled all data", "Informative Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label112.Visible = false; label113.Visible = false; label114.Visible = false;
            label115.Visible = false; label116.Visible = false; label117.Visible = false;
            label118.Visible = false; label119.Visible = false; label120.Visible = false;
            label121.Visible = false; label122.Visible = false; label123.Visible = false;
            label124.Visible = false; label125.Visible = false; label126.Visible = false;
            label127.Visible = false; label128.Visible = false; textBox53.Visible = false;
            textBox54.Visible = false; textBox55.Visible = false; textBox56.Visible = false;
            textBox57.Visible = false; textBox58.Visible = false; textBox59.Visible = false;
            textBox60.Visible = false; label129.Visible = false; label130.Visible = false;
            label131.Visible = false; label132.Visible = false; label133.Visible = false;
            label134.Visible = false; label135.Visible = false; label136.Visible = false;
            textBox61.Visible = false; textBox62.Visible = false; textBox62.Visible = false;
            textBox63.Visible = false; textBox64.Visible = false; textBox65.Visible = false;
            textBox66.Visible = false; textBox67.Visible = false; textBox68.Visible = false;
            button5.Visible = false;

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

            label91.Visible = false; label92.Visible = false; comboBox1.Visible = false;
            label93.Visible = false; comboBox2.Visible = false; label94.Visible = false;
            label95.Visible = false; comboBox3.Visible = false; label96.Visible = false;
            comboBox4.Visible = false; label97.Visible = false; label98.Visible = false;
            comboBox5.Visible = false; label99.Visible = false; comboBox6.Visible = false;
            label100.Visible = false; label101.Visible = false; comboBox7.Visible = false;
            label102.Visible = false; comboBox8.Visible = false; label103.Visible = false;
            label104.Visible = false; comboBox9.Visible = false; label105.Visible = false;
            comboBox10.Visible = false; label106.Visible = false; label107.Visible = false;
            comboBox11.Visible = false; label108.Visible = false; comboBox12.Visible = false;
            label109.Visible = false; label110.Visible = false; comboBox13.Visible = false;
            label111.Visible = false; comboBox14.Visible = false; button4.Visible = false;


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
                MessageBox.Show("Please filled all data", "Informative Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
                    "\n\n\n"+"Total Marks : "+TotalMarks, "Informative Message",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label112.Visible = false; label113.Visible = false; label114.Visible = false;
            label115.Visible = false; label116.Visible = false; label117.Visible = false;
            label118.Visible = false; label119.Visible = false; label120.Visible = false;
            label121.Visible = false; label122.Visible = false; label123.Visible = false;
            label124.Visible = false; label125.Visible = false; label126.Visible = false;
            label127.Visible = false; label128.Visible = false; textBox53.Visible = false;
            textBox54.Visible = false; textBox55.Visible = false; textBox56.Visible = false;
            textBox57.Visible = false; textBox58.Visible = false; textBox59.Visible = false;
            textBox60.Visible = false; label129.Visible = false; label130.Visible = false;
            label131.Visible = false; label132.Visible = false; label133.Visible = false;
            label134.Visible = false; label135.Visible = false; label136.Visible = false;
            textBox61.Visible = false; textBox62.Visible = false; textBox62.Visible = false;
            textBox63.Visible = false; textBox64.Visible = false; textBox65.Visible = false;
            textBox66.Visible = false; textBox67.Visible = false; textBox68.Visible = false;
            button5.Visible = false;

            label36.Visible = false; label37.Visible = false; label38.Visible = false;
            label39.Visible = false; textBox21.Visible = false; label40.Visible = false;
            textBox22.Visible = false; label41.Visible = false; label42.Visible = false;
            textBox23.Visible = false; label43.Visible = false; textBox24.Visible = false;
            label44.Visible = false; label45.Visible = false; textBox25.Visible = false;
            label46.Visible = false; textBox26.Visible = false; label47.Visible = false;
            label48.Visible = false; textBox27.Visible = false; label49.Visible = false;
            textBox28.Visible = false; label50.Visible = false; label51.Visible = false;
            label52.Visible = false; textBox29.Visible = false; label53.Visible = false;
            textBox30.Visible = false; label54.Visible = false; label55.Visible = false;
            textBox31.Visible = false; label56.Visible = false; textBox32.Visible = false;
            label57.Visible = false; label58.Visible = false; textBox33.Visible = false;
            label59.Visible = false; textBox34.Visible = false; label60.Visible = false;
            label61.Visible = false; textBox35.Visible = false; label62.Visible = false;
            textBox36.Visible = false; label63.Visible = false; label64.Visible = false;
            label65.Visible = false; textBox37.Visible = false; label66.Visible = false;
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
            textBox49.Visible = false; label86.Visible = false; textBox50.Visible = false;
            label87.Visible = false; label88.Visible = false; label89.Visible = false;
            textBox51.Visible = false; label90.Visible = false; textBox52.Visible = false;
            button3.Visible = false;

            label2.Visible = false; label3.Visible = false; label10.Visible = false;
            textBox1.Visible = false; label11.Visible = false; textBox2.Visible = false;
            label7.Visible = false; label13.Visible = false; textBox4.Visible = false;
            label16.Visible = false; textBox7.Visible = false; label8.Visible = false;
            label12.Visible = false; textBox3.Visible = false; label15.Visible = false;
            textBox6.Visible = false; label9.Visible = false; label14.Visible = false;
            textBox5.Visible = false; label17.Visible = false; textBox8.Visible = false;
            label4.Visible = false; label18.Visible = false; label22.Visible = false;
            textBox9.Visible = false; label26.Visible = false; textBox10.Visible = false;
            label20.Visible = false; label24.Visible = false; textBox11.Visible = false;
            label28.Visible = false; textBox14.Visible = false; label19.Visible = false;
            label23.Visible = false; textBox12.Visible = false; label27.Visible = false;
            textBox13.Visible = false; label21.Visible = false; label25.Visible = false;
            textBox16.Visible = false; label29.Visible = false; textBox15.Visible = false;
            label5.Visible = false; label30.Visible = false; label31.Visible = false;
            textBox17.Visible = false; label32.Visible = false; textBox18.Visible = false;
            label6.Visible = false; label33.Visible = false; label34.Visible = false;
            textBox19.Visible = false; label35.Visible = false; textBox20.Visible = false;
            button2.Visible = false;

            label91.Visible = true; label92.Visible = true; comboBox1.Visible=true;
            label93.Visible = true; comboBox2.Visible= true; label94.Visible = true;
            label95.Visible = true; comboBox3.Visible = true; label96.Visible= true;
            comboBox4.Visible = true; label97.Visible = true; label98.Visible = true;
            comboBox5.Visible = true; label99.Visible = true; comboBox6.Visible = true;
            label100.Visible = true; label101.Visible = true; comboBox7.Visible = true;
            label102.Visible = true; comboBox8.Visible = true; label103.Visible = true;
            label104.Visible = true; comboBox9.Visible = true; label105.Visible=true;
            comboBox10.Visible = true; label106.Visible = true; label107.Visible = true;
            comboBox11.Visible = true; label108.Visible=true; comboBox12.Visible = true;
            label109.Visible = true; label110.Visible = true; comboBox13.Visible = true;
            label111.Visible = true; comboBox14.Visible = true; button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Atleast One Course", "Informative Text", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                int i = comboBox1.SelectedIndex;
                int j = comboBox2.SelectedIndex;
                float course1 = 0, course2 = 0, course3 = 0, course4 = 0, course5 = 0, course6 = 0, course7 = 0;
                int course1credit = 0, course2credit = 0, course3credit = 0, course4credit = 0, course5credit = 0, course6credit = 0, course7credit = 0;
                int i1 = comboBox3.SelectedIndex;
                int j1 = comboBox4.SelectedIndex;
                int i2 = comboBox5.SelectedIndex;
                int j2 = comboBox6.SelectedIndex;
                int i3 = comboBox7.SelectedIndex;
                int j3 = comboBox8.SelectedIndex;
                int i4 = comboBox9.SelectedIndex;
                int j4 = comboBox10.SelectedIndex;
                int i5 = comboBox11.SelectedIndex;
                int j5 = comboBox12.SelectedIndex;
                int i6 = comboBox13.SelectedIndex;
                int j6 = comboBox14.SelectedIndex;
                // course 1
                if (i == 0)
                {
                    if (i == 0 && j == 0) { course1 = 4 * 4.00f; course1credit = 4; }
                    else if (i == 0 && j == 1) { course1 = 3 * 4.00f; course1credit = 3; }
                    else if (i == 0 && j == 2) { course1 = 2 * 4.00f; course1credit = 2; }
                    else if (i == 0 && j == 3) { course1 = 1 * 4.00f; course1credit = 1; }
                    else if (i == 0 && j == 4) { course1 = 0 * 4.00f; course1credit = 0; }
                }
                else if (i == 1)
                {
                    if (i == 1 && j == 0) { course1 = 4 * 3.66f; course1credit = 4; }
                    else if (i == 1 && j == 1) { course1 = 3 * 3.66f; course1credit = 3; }
                    else if (i == 1 && j == 2) { course1 = 2 * 3.66f; course1credit = 2; }
                    else if (i == 1 && j == 3) { course1 = 1 * 3.66f; course1credit = 1; }
                    else if (i == 1 && j == 4) { course1 = 0 * 3.66f; course1credit = 0; }
                }
                else if (i == 2)
                {
                    if (i == 2 && j == 0) { course1 = 4 * 3.33f; course1credit = 4; }
                    else if (i == 2 && j == 1) { course1 = 3 * 3.33f; course1credit = 3; }
                    else if (i == 2 && j == 2) { course1 = 2 * 3.33f; course1credit = 2; }
                    else if (i == 2 && j == 3) { course1 = 1 * 3.33f; course1credit = 1; }
                    else if (i == 2 && j == 4) { course1 = 0 * 3.33f; course1credit = 0; }
                }
                else if (i == 3)
                {
                    if (i == 3 && j == 0) { course1 = 4 * 3.00f; course1credit = 4; }
                    else if (i == 3 && j == 1) { course1 = 3 * 3.00f; course1credit = 3; }
                    else if (i == 3 && j == 2) { course1 = 2 * 3.00f; course1credit = 2; }
                    else if (i == 3 && j == 3) { course1 = 1 * 3.00f; course1credit = 1; }
                    else if (i == 3 && j == 4) { course1 = 0 * 3.00f; course1credit = 0; }
                }
                else if (i == 4)
                {
                    if (i == 4 && j == 0) { course1 = 4 * 2.66f; course1credit = 4; }
                    else if (i == 4 && j == 1) { course1 = 3 * 2.66f; course1credit = 3; }
                    else if (i == 4 && j == 2) { course1 = 2 * 2.66f; course1credit = 2; }
                    else if (i == 4 && j == 3) { course1 = 1 * 2.66f; course1credit = 1; }
                    else if (i == 4 && j == 4) { course1 = 0 * 2.66f; course1credit = 0; }
                }
                else if (i == 5)
                {
                    if (i == 5 && j == 0) { course1 = 4 * 2.33f; course1credit = 4; }
                    else if (i == 5 && j == 1) { course1 = 3 * 2.33f; course1credit = 3; }
                    else if (i == 5 && j == 2) { course1 = 2 * 2.33f; course1credit = 2; }
                    else if (i == 5 && j == 3) { course1 = 1 * 2.33f; course1credit = 1; }
                    else if (i == 5 && j == 4) { course1 = 0 * 2.33f; course1credit = 0; }
                }
                else if (i == 6)
                {
                    if (i == 6 && j == 0) { course1 = 4 * 2.00f; course1credit = 4; }
                    else if (i == 6 && j == 1) { course1 = 3 * 2.00f; course1credit = 3; }
                    else if (i == 6 && j == 2) { course1 = 2 * 2.00f; course1credit = 2; }
                    else if (i == 6 && j == 3) { course1 = 1 * 2.00f; course1credit = 1; }
                    else if (i == 6 && j == 4) { course1 = 0 * 2.00f; course1credit = 0; }
                }
                else if (i == 7)
                {
                    if (i == 7 && j == 0) { course1 = 4 * 1.66f; course1credit = 4; }
                    else if (i == 7 && j == 1) { course1 = 3 * 1.66f; course1credit = 3; }
                    else if (i == 7 && j == 2) { course1 = 2 * 1.66f; course1credit = 2; }
                    else if (i == 7 && j == 3) { course1 = 1 * 1.66f; course1credit = 1; }
                    else if (i == 7 && j == 4) { course1 = 0 * 1.66f; course1credit = 0; }
                }
                else if (i == 8)
                {
                    if (i == 8 && j == 0) { course1 = 4 * 1.33f; course1credit = 4; }
                    else if (i == 8 && j == 1) { course1 = 3 * 1.33f; course1credit = 3; }
                    else if (i == 8 && j == 2) { course1 = 2 * 1.33f; course1credit = 2; }
                    else if (i == 8 && j == 3) { course1 = 1 * 1.33f; course1credit = 1; }
                    else if (i == 8 && j == 4) { course1 = 0 * 1.33f; course1credit = 0; }
                }
                else if (i == 9)
                {
                    if (i == 9 && j == 0) { course1 = 4 * 1.00f; course1credit = 4; }
                    else if (i == 9 && j == 1) { course1 = 3 * 1.00f; course1credit = 3; }
                    else if (i == 9 && j == 2) { course1 = 2 * 1.00f; course1credit = 2; }
                    else if (i == 9 && j == 3) { course1 = 1 * 1.00f; course1credit = 1; }
                    else if (i == 9 && j == 4) { course1 = 0 * 1.00f; course1credit = 0; }
                }
                else if (i == 10)
                {
                    if (i == 10 && j == 0) { course1 = 4 * 0.00f; course1credit = 4; }
                    else if (i == 10 && j == 1) { course1 = 3 * 0.00f; course1credit = 3; }
                    else if (i == 10 && j == 2) { course1 = 2 * 0.00f; course1credit = 2; }
                    else if (i == 10 && j == 3) { course1 = 1 * 0.00f; course1credit = 1; }
                    else if (i == 10 && j == 4) { course1 = 0 * 0.00f; course1credit = 0; }
                }
                // second course
                if (i1 == 0)
                {
                    if (i1 == 0 && j1 == 0) { course2 = 4 * 4.00f; course2credit = 4; }
                    else if (i1 == 0 && j1 == 1) { course2 = 3 * 4.00f; course2credit = 3; }
                    else if (i1 == 0 && j1 == 2) { course2 = 2 * 4.00f; course2credit = 2; }
                    else if (i1 == 0 && j1 == 3) { course2 = 1 * 4.00f; course2credit = 1; }
                    else if (i1 == 0 && j1 == 4) { course2 = 0 * 4.00f; course2credit = 0; }
                }
                else if (i1 == 1)
                {
                    if (i1 == 1 && j1 == 0) { course2 = 4 * 3.66f; course2credit = 4; }
                    else if (i1 == 1 && j1 == 1) { course2 = 3 * 3.66f; course2credit = 3; }
                    else if (i1 == 1 && j1 == 2) { course2 = 2 * 3.66f; course2credit = 2; }
                    else if (i1 == 1 && j1 == 3) { course2 = 1 * 3.66f; course2credit = 1; }
                    else if (i1 == 1 && j1 == 4) { course2 = 0 * 3.66f; course2credit = 0; }
                }
                else if (i1 == 2)
                {
                    if (i1 == 2 && j1 == 0) { course2 = 4 * 3.33f; course2credit = 4; }
                    else if (i1 == 2 && j1 == 1) { course2 = 3 * 3.33f; course2credit = 3; }
                    else if (i1 == 2 && j1 == 2) { course2 = 2 * 3.33f; course2credit = 2; }
                    else if (i1 == 2 && j1 == 3) { course2 = 1 * 3.33f; course2credit = 1; }
                    else if (i1 == 2 && j1 == 4) { course2 = 0 * 3.33f; course2credit = 0; }
                }
                else if (i1 == 3)
                {
                    if (i1 == 3 && j1 == 0) { course2 = 4 * 3.00f; course2credit = 4; }
                    else if (i1 == 3 && j1 == 1) { course2 = 3 * 3.00f; course2credit = 3; }
                    else if (i1 == 3 && j1 == 2) { course2 = 2 * 3.00f; course2credit = 2; }
                    else if (i1 == 3 && j1 == 3) { course2 = 1 * 3.00f; course2credit = 1; }
                    else if (i1 == 3 && j1 == 4) { course2 = 0 * 3.00f; course2credit = 0; }
                }
                else if (i1 == 4)
                {
                    if (i1 == 4 && j1 == 0) { course2 = 4 * 2.66f; course2credit = 4; }
                    else if (i1 == 4 && j1 == 1) { course2 = 3 * 2.66f; course2credit = 3; }
                    else if (i1 == 4 && j1 == 2) { course2 = 2 * 2.66f; course2credit = 2; }
                    else if (i1 == 4 && j1 == 3) { course2 = 1 * 2.66f; course2credit = 1; }
                    else if (i1 == 4 && j1 == 4) { course2 = 0 * 2.66f; course2credit = 0; }
                }
                else if (i1 == 5)
                {
                    if (i1 == 5 && j1 == 0) { course2 = 4 * 2.33f; course2credit = 4; }
                    else if (i1 == 5 && j1 == 1) { course2 = 3 * 2.33f; course2credit = 3; }
                    else if (i1 == 5 && j1 == 2) { course2 = 2 * 2.33f; course2credit = 2; }
                    else if (i1 == 5 && j1 == 3) { course2 = 1 * 2.33f; course2credit = 1; }
                    else if (i1 == 5 && j1 == 4) { course2 = 0 * 2.33f; course2credit = 0; }
                }
                else if (i1 == 6)
                {
                    if (i1 == 6 && j1 == 0) { course2 = 4 * 2.00f; course2credit = 4; }
                    else if (i1 == 6 && j1 == 1) { course2 = 3 * 2.00f; course2credit = 3; }
                    else if (i1 == 6 && j1 == 2) { course2 = 2 * 2.00f; course2credit = 2; }
                    else if (i1 == 6 && j1 == 3) { course2 = 1 * 2.00f; course2credit = 1; }
                    else if (i1 == 6 && j1 == 4) { course2 = 0 * 2.00f; course2credit = 0; }
                }
                else if (i1 == 7)
                {
                    if (i1 == 7 && j1 == 0) { course2 = 4 * 1.66f; course2credit = 4; }
                    else if (i1 == 7 && j1 == 1) { course2 = 3 * 1.66f; course2credit = 3; }
                    else if (i1 == 7 && j1 == 2) { course2 = 2 * 1.66f; course2credit = 2; }
                    else if (i1 == 7 && j1 == 3) { course2 = 1 * 1.66f; course2credit = 1; }
                    else if (i1 == 7 && j1 == 4) { course2 = 0 * 1.66f; course2credit = 0; }
                }
                else if (i1 == 8)
                {
                    if (i1 == 8 && j1 == 0) { course2 = 4 * 1.33f; course2credit = 4; }
                    else if (i1 == 8 && j1 == 1) { course2 = 3 * 1.33f; course2credit = 3; }
                    else if (i1 == 8 && j1 == 2) { course2 = 2 * 1.33f; course2credit = 2; }
                    else if (i1 == 8 && j1 == 3) { course2 = 1 * 1.33f; course2credit = 1; }
                    else if (i1 == 8 && j1 == 4) { course2 = 0 * 1.33f; course2credit = 0; }
                }
                else if (i1 == 9)
                {
                    if (i1 == 9 && j1 == 0) { course2 = 4 * 1.00f; course2credit = 4; }
                    else if (i1 == 9 && j1 == 1) { course2 = 3 * 1.00f; course2credit = 3; }
                    else if (i1 == 9 && j1 == 2) { course2 = 2 * 1.00f; course2credit = 2; }
                    else if (i1 == 9 && j1 == 3) { course2 = 1 * 1.00f; course2credit = 1; }
                    else if (i1 == 9 && j1 == 4) { course2 = 0 * 1.00f; course2credit = 0; }
                }
                else if (i1 == 10)
                {
                    if (i1 == 10 && j1 == 0) { course2 = 4 * 0.00f; course2credit = 4; }
                    else if (i1 == 10 && j1 == 1) { course2 = 3 * 0.00f; course2credit = 3; }
                    else if (i1 == 10 && j1 == 2) { course2 = 2 * 0.00f; course2credit = 2; }
                    else if (i1 == 10 && j1 == 3) { course2 = 1 * 0.00f; course2credit = 1; }
                    else if (i1 == 10 && j1 == 4) { course2 = 0 * 0.00f; course2credit = 0; }
                }
                // course 3
                if (i2 == 0)
                {
                    if (i2 == 0 && j2 == 0) { course3 = 4 * 4.00f; course3credit = 4; }
                    else if (i2 == 0 && j2 == 1) { course3 = 3 * 4.00f; course3credit = 3; }
                    else if (i2 == 0 && j2 == 2) { course3 = 2 * 4.00f; course3credit = 2; }
                    else if (i2 == 0 && j2 == 3) { course3 = 1 * 4.00f; course3credit = 1; }
                    else if (i2 == 0 && j2 == 4) { course3 = 0 * 4.00f; course3credit = 0; }
                }
                else if (i2 == 1)
                {
                    if (i2 == 1 && j2 == 0) { course3 = 4 * 3.66f; course3credit = 4; }
                    else if (i2 == 1 && j2 == 1) { course3 = 3 * 3.66f; course3credit = 3; }
                    else if (i2 == 1 && j2 == 2) { course3 = 2 * 3.66f; course3credit = 2; }
                    else if (i2 == 1 && j2 == 3) { course3 = 1 * 3.66f; course3credit = 1; }
                    else if (i2 == 1 && j2 == 4) { course3 = 0 * 3.66f; course3credit = 0; }
                }
                else if (i2 == 2)
                {
                    if (i2 == 2 && j2 == 0) { course3 = 4 * 3.33f; course3credit = 4; }
                    else if (i2 == 2 && j2 == 1) { course3 = 3 * 3.33f; course3credit = 3; }
                    else if (i2 == 2 && j2 == 2) { course3 = 2 * 3.33f; course3credit = 2; }
                    else if (i2 == 2 && j2 == 3) { course3 = 1 * 3.33f; course3credit = 1; }
                    else if (i2 == 2 && j2 == 4) { course3 = 0 * 3.33f; course3credit = 0; }
                }
                else if (i2 == 3)
                {
                    if (i2 == 3 && j2 == 0) { course3 = 4 * 3.00f; course3credit = 4; }
                    else if (i2 == 3 && j2 == 1) { course3 = 3 * 3.00f; course3credit = 3; }
                    else if (i2 == 3 && j2 == 2) { course3 = 2 * 3.00f; course3credit = 2; }
                    else if (i2 == 3 && j2 == 3) { course3 = 1 * 3.00f; course3credit = 1; }
                    else if (i2 == 3 && j2 == 4) { course3 = 0 * 3.00f; course3credit = 0; }
                }
                else if (i2 == 4)
                {
                    if (i2 == 4 && j2 == 0) { course3 = 4 * 2.66f; course3credit = 4; }
                    else if (i2 == 4 && j2 == 1) { course3 = 3 * 2.66f; course3credit = 3; }
                    else if (i2 == 4 && j2 == 2) { course3 = 2 * 2.66f; course3credit = 2; }
                    else if (i2 == 4 && j2 == 3) { course3 = 1 * 2.66f; course3credit = 1; }
                    else if (i2 == 4 && j2 == 4) { course3 = 0 * 2.66f; course3credit = 0; }
                }
                else if (i2 == 5)
                {
                    if (i2 == 5 && j2 == 0) { course3 = 4 * 2.33f; course3credit = 4; }
                    else if (i2 == 5 && j2 == 1) { course3 = 3 * 2.33f; course3credit = 3; }
                    else if (i2 == 5 && j2 == 2) { course3 = 2 * 2.33f; course3credit = 2; }
                    else if (i2 == 5 && j2 == 3) { course3 = 1 * 2.33f; course3credit = 1; }
                    else if (i2 == 5 && j2 == 4) { course3 = 0 * 2.33f; course3credit = 0; }
                }
                else if (i2 == 6)
                {
                    if (i2 == 6 && j2 == 0) { course3 = 4 * 2.00f; course3credit = 4; }
                    else if (i2 == 6 && j2 == 1) { course3 = 3 * 2.00f; course3credit = 3; }
                    else if (i2 == 6 && j2 == 2) { course3 = 2 * 2.00f; course3credit = 2; }
                    else if (i2 == 6 && j2 == 3) { course3 = 1 * 2.00f; course3credit = 1; }
                    else if (i2 == 6 && j2 == 4) { course3 = 0 * 2.00f; course3credit = 0; }
                }
                else if (i2 == 7)
                {
                    if (i2 == 7 && j2 == 0) { course3 = 4 * 1.66f; course3credit = 4; }
                    else if (i2 == 7 && j2 == 1) { course3 = 3 * 1.66f; course3credit = 3; }
                    else if (i2 == 7 && j2 == 2) { course3 = 2 * 1.66f; course3credit = 2; }
                    else if (i2 == 7 && j2 == 3) { course3 = 1 * 1.66f; course3credit = 1; }
                    else if (i2 == 7 && j2 == 4) { course3 = 0 * 1.66f; course3credit = 0; }
                }
                else if (i2 == 8)
                {
                    if (i2 == 8 && j2 == 0) { course3 = 4 * 1.33f; course3credit = 4; }
                    else if (i2 == 8 && j2 == 1) { course3 = 3 * 1.33f; course3credit = 3; }
                    else if (i2 == 8 && j2 == 2) { course3 = 2 * 1.33f; course3credit = 2; }
                    else if (i2 == 8 && j2 == 3) { course3 = 1 * 1.33f; course3credit = 1; }
                    else if (i2 == 8 && j2 == 4) { course3 = 0 * 1.33f; course3credit = 0; }
                }
                else if (i2 == 9)
                {
                    if (i2 == 9 && j2 == 0) { course3 = 4 * 1.00f; course3credit = 4; }
                    else if (i2 == 9 && j2 == 1) { course3 = 3 * 1.00f; course3credit = 3; }
                    else if (i2 == 9 && j2 == 2) { course3 = 2 * 1.00f; course3credit = 2; }
                    else if (i2 == 9 && j2 == 3) { course3 = 1 * 1.00f; course3credit = 1; }
                    else if (i2 == 9 && j2 == 4) { course3 = 0 * 1.00f; course3credit = 0; }
                }
                else if (i2 == 10)
                {
                    if (i2 == 10 && j2 == 0) { course3 = 4 * 0.00f; course3credit = 4; }
                    else if (i2 == 10 && j2 == 1) { course3 = 3 * 0.00f; course3credit = 3; }
                    else if (i2 == 10 && j2 == 2) { course3 = 2 * 0.00f; course3credit = 2; }
                    else if (i2 == 10 && j2 == 3) { course3 = 1 * 0.00f; course3credit = 1; }
                    else if (i2 == 10 && j2 == 4) { course3 = 0 * 0.00f; course3credit = 0; }
                }
                // course 4
                if (i3 == 0)
                {
                    if (i3 == 0 && j3 == 0) { course4 = 4 * 4.00f; course4credit = 4; }
                    else if (i3 == 0 && j3 == 1) { course4 = 3 * 4.00f; course4credit = 3; }
                    else if (i3 == 0 && j3 == 2) { course4 = 2 * 4.00f; course4credit = 2; }
                    else if (i3 == 0 && j3 == 3) { course4 = 1 * 4.00f; course4credit = 1; }
                    else if (i3 == 0 && j3 == 4) { course4 = 0 * 4.00f; course4credit = 0; }
                }
                else if (i3 == 1)
                {
                    if (i3 == 1 && j3 == 0) { course4 = 4 * 3.66f; course4credit = 4; }
                    else if (i3 == 1 && j3 == 1) { course4 = 3 * 3.66f; course4credit = 3; }
                    else if (i3 == 1 && j3 == 2) { course4 = 2 * 3.66f; course4credit = 2; }
                    else if (i3 == 1 && j3 == 3) { course4 = 1 * 3.66f; course4credit = 1; }
                    else if (i3 == 1 && j3 == 4) { course4 = 0 * 3.66f; course4credit = 0; }
                }
                else if (i3 == 2)
                {
                    if (i3 == 2 && j3 == 0) { course4 = 4 * 3.33f; course4credit = 4; }
                    else if (i3 == 2 && j3 == 1) { course4 = 3 * 3.33f; course4credit = 3; }
                    else if (i3 == 2 && j3 == 2) { course4 = 2 * 3.33f; course4credit = 2; }
                    else if (i3 == 2 && j3 == 3) { course4 = 1 * 3.33f; course4credit = 1; }
                    else if (i3 == 2 && j3 == 4) { course4 = 0 * 3.33f; course4credit = 0; }
                }
                else if (i3 == 3)
                {
                    if (i3 == 3 && j3 == 0) { course4 = 4 * 3.00f; course4credit = 4; }
                    else if (i3 == 3 && j3 == 1) { course4 = 3 * 3.00f; course4credit = 3; }
                    else if (i3 == 3 && j3 == 2) { course4 = 2 * 3.00f; course4credit = 2; }
                    else if (i3 == 3 && j3 == 3) { course4 = 1 * 3.00f; course4credit = 1; }
                    else if (i3 == 3 && j3 == 4) { course4 = 0 * 3.00f; course4credit = 0; }
                }
                else if (i3 == 4)
                {
                    if (i3 == 4 && j3 == 0) { course4 = 4 * 2.66f; course4credit = 4; }
                    else if (i3 == 4 && j3 == 1) { course4 = 3 * 2.66f; course4credit = 3; }
                    else if (i3 == 4 && j3 == 2) { course4 = 2 * 2.66f; course4credit = 2; }
                    else if (i3 == 4 && j3 == 3) { course4 = 1 * 2.66f; course4credit = 1; }
                    else if (i3 == 4 && j3 == 4) { course4 = 0 * 2.66f; course4credit = 0; }
                }
                else if (i3 == 5)
                {
                    if (i3 == 5 && j3 == 0) { course4 = 4 * 2.33f; course4credit = 4; }
                    else if (i3 == 5 && j3 == 1) { course4 = 3 * 2.33f; course4credit = 3; }
                    else if (i3 == 5 && j3 == 2) { course4 = 2 * 2.33f; course4credit = 2; }
                    else if (i3 == 5 && j3 == 3) { course4 = 1 * 2.33f; course4credit = 1; }
                    else if (i3 == 5 && j3 == 4) { course4 = 0 * 2.33f; course4credit = 0; }
                }
                else if (i3 == 6)
                {
                    if (i3 == 6 && j3 == 0) { course4 = 4 * 2.00f; course4credit = 4; }
                    else if (i3 == 6 && j3 == 1) { course4 = 3 * 2.00f; course4credit = 3; }
                    else if (i3 == 6 && j3 == 2) { course4 = 2 * 2.00f; course4credit = 2; }
                    else if (i3 == 6 && j3 == 3) { course4 = 1 * 2.00f; course4credit = 1; }
                    else if (i3 == 6 && j3 == 4) { course4 = 0 * 2.00f; course4credit = 0; }
                }
                else if (i3 == 7)
                {
                    if (i3 == 7 && j3 == 0) { course4 = 4 * 1.66f; course4credit = 4; }
                    else if (i3 == 7 && j3 == 1) { course4 = 3 * 1.66f; course4credit = 3; }
                    else if (i3 == 7 && j3 == 2) { course4 = 2 * 1.66f; course4credit = 2; }
                    else if (i3 == 7 && j3 == 3) { course4 = 1 * 1.66f; course4credit = 1; }
                    else if (i3 == 7 && j3 == 4) { course4 = 0 * 1.66f; course4credit = 0; }
                }
                else if (i3 == 8)
                {
                    if (i3 == 8 && j3 == 0) { course4 = 4 * 1.33f; course4credit = 4; }
                    else if (i3 == 8 && j3 == 1) { course4 = 3 * 1.33f; course4credit = 3; }
                    else if (i3 == 8 && j3 == 2) { course4 = 2 * 1.33f; course4credit = 2; }
                    else if (i3 == 8 && j3 == 3) { course4 = 1 * 1.33f; course4credit = 1; }
                    else if (i3 == 8 && j3 == 4) { course4 = 0 * 1.33f; course4credit = 0; }
                }
                else if (i3 == 9)
                {
                    if (i3 == 9 && j3 == 0) { course4 = 4 * 1.00f; course4credit = 4; }
                    else if (i3 == 9 && j3 == 1) { course4 = 3 * 1.00f; course4credit = 3; }
                    else if (i3 == 9 && j3 == 2) { course4 = 2 * 1.00f; course4credit = 2; }
                    else if (i3 == 9 && j3 == 3) { course4 = 1 * 1.00f; course4credit = 1; }
                    else if (i3 == 9 && j3 == 4) { course4 = 0 * 1.00f; course4credit = 0; }
                }
                else if (i3 == 10)
                {
                    if (i3 == 10 && j3 == 0) { course4 = 4 * 0.00f; course4credit = 4; }
                    else if (i3 == 10 && j3 == 1) { course4 = 3 * 0.00f; course4credit = 3; }
                    else if (i3 == 10 && j3 == 2) { course4 = 2 * 0.00f; course4credit = 2; }
                    else if (i3 == 10 && j3 == 3) { course4 = 1 * 0.00f; course4credit = 1; }
                    else if (i3 == 10 && j3 == 4) { course4 = 0 * 0.00f; course4credit = 0; }
                }
                // course 5
                if (i4 == 0)
                {
                    if (i4 == 0 && j4 == 0) { course5 = 4 * 4.00f; course5credit = 4; }
                    else if (i4 == 0 && j4 == 1) { course5 = 3 * 4.00f; course5credit = 3; }
                    else if (i4 == 0 && j4 == 2) { course5 = 2 * 4.00f; course5credit = 2; }
                    else if (i4 == 0 && j4 == 3) { course5 = 1 * 4.00f; course5credit = 1; }
                    else if (i4 == 0 && j4 == 4) { course5 = 0 * 4.00f; course5credit = 0; }
                }
                else if (i4 == 1)
                {
                    if (i4 == 1 && j4 == 0) { course5 = 4 * 3.66f; course5credit = 4; }
                    else if (i4 == 1 && j4 == 1) { course5 = 3 * 3.66f; course5credit = 3; }
                    else if (i4 == 1 && j4 == 2) { course5 = 2 * 3.66f; course5credit = 2; }
                    else if (i4 == 1 && j4 == 3) { course5 = 1 * 3.66f; course5credit = 1; }
                    else if (i4 == 1 && j4 == 4) { course5 = 0 * 3.66f; course5credit = 0; }
                }
                else if (i4 == 2)
                {
                    if (i4 == 2 && j4 == 0) { course5 = 4 * 3.33f; course5credit = 4; }
                    else if (i4 == 2 && j4 == 1) { course5 = 3 * 3.33f; course5credit = 3; }
                    else if (i4 == 2 && j4 == 2) { course5 = 2 * 3.33f; course5credit = 2; }
                    else if (i4 == 2 && j4 == 3) { course5 = 1 * 3.33f; course5credit = 1; }
                    else if (i4 == 2 && j4 == 4) { course5 = 0 * 3.33f; course5credit = 0; }
                }
                else if (i4 == 3)
                {
                    if (i4 == 3 && j4 == 0) { course5 = 4 * 3.00f; course5credit = 4; }
                    else if (i4 == 3 && j4 == 1) { course5 = 3 * 3.00f; course5credit = 3; }
                    else if (i4 == 3 && j4 == 2) { course5 = 2 * 3.00f; course5credit = 2; }
                    else if (i4 == 3 && j4 == 3) { course5 = 1 * 3.00f; course5credit = 1; }
                    else if (i4 == 3 && j4 == 4) { course5 = 0 * 3.00f; course5credit = 0; }
                }
                else if (i4 == 4)
                {
                    if (i4 == 4 && j4 == 0) { course5 = 4 * 2.66f; course5credit = 4; }
                    else if (i4 == 4 && j4 == 1) { course5 = 3 * 2.66f; course5credit = 3; }
                    else if (i4 == 4 && j4 == 2) { course5 = 2 * 2.66f; course5credit = 2; }
                    else if (i4 == 4 && j4 == 3) { course5 = 1 * 2.66f; course5credit = 1; }
                    else if (i4 == 4 && j4 == 4) { course5 = 0 * 2.66f; course5credit = 0; }
                }
                else if (i4 == 5)
                {
                    if (i4 == 5 && j4 == 0) { course5 = 4 * 2.33f; course5credit = 4; }
                    else if (i4 == 5 && j4 == 1) { course5 = 3 * 2.33f; course5credit = 3; }
                    else if (i4 == 5 && j4 == 2) { course5 = 2 * 2.33f; course5credit = 2; }
                    else if (i4 == 5 && j4 == 3) { course5 = 1 * 2.33f; course5credit = 1; }
                    else if (i4 == 5 && j4 == 4) { course5 = 0 * 2.33f; course5credit = 0; }
                }
                else if (i4 == 6)
                {
                    if (i4 == 6 && j4 == 0) { course5 = 4 * 2.00f; course5credit = 4; }
                    else if (i4 == 6 && j4 == 1) { course5 = 3 * 2.00f; course5credit = 3; }
                    else if (i4 == 6 && j4 == 2) { course5 = 2 * 2.00f; course5credit = 2; }
                    else if (i4 == 6 && j4 == 3) { course5 = 1 * 2.00f; course5credit = 1; }
                    else if (i4 == 6 && j4 == 4) { course5 = 0 * 2.00f; course5credit = 0; }
                }
                else if (i4 == 7)
                {
                    if (i4 == 7 && j4 == 0) { course5 = 4 * 1.66f; course5credit = 4; }
                    else if (i4 == 7 && j4 == 1) { course5 = 3 * 1.66f; course5credit = 3; }
                    else if (i4 == 7 && j4 == 2) { course5 = 2 * 1.66f; course5credit = 2; }
                    else if (i4 == 7 && j4 == 3) { course5 = 1 * 1.66f; course5credit = 1; }
                    else if (i4 == 7 && j4 == 4) { course5 = 0 * 1.66f; course5credit = 0; }
                }
                else if (i4 == 8)
                {
                    if (i4 == 8 && j4 == 0) { course5 = 4 * 1.33f; course5credit = 4; }
                    else if (i4 == 8 && j4 == 1) { course5 = 3 * 1.33f; course5credit = 3; }
                    else if (i4 == 8 && j4 == 2) { course5 = 2 * 1.33f; course5credit = 2; }
                    else if (i4 == 8 && j4 == 3) { course5 = 1 * 1.33f; course5credit = 1; }
                    else if (i4 == 8 && j4 == 4) { course5 = 0 * 1.33f; course5credit = 0; }
                }
                else if (i4 == 9)
                {
                    if (i4 == 9 && j4 == 0) { course5 = 4 * 1.00f; course5credit = 4; }
                    else if (i4 == 9 && j4 == 1) { course5 = 3 * 1.00f; course5credit = 3; }
                    else if (i4 == 9 && j4 == 2) { course5 = 2 * 1.00f; course5credit = 2; }
                    else if (i4 == 9 && j4 == 3) { course5 = 1 * 1.00f; course5credit = 1; }
                    else if (i4 == 9 && j4 == 4) { course5 = 0 * 1.00f; course5credit = 0; }
                }
                else if (i4 == 10)
                {
                    if (i4 == 10 && j4 == 0) { course5 = 4 * 0.00f; course5credit = 4; }
                    else if (i4 == 10 && j4 == 1) { course5 = 3 * 0.00f; course5credit = 3; }
                    else if (i4 == 10 && j4 == 2) { course5 = 2 * 0.00f; course5credit = 2; }
                    else if (i4 == 10 && j4 == 3) { course5 = 1 * 0.00f; course5credit = 1; }
                    else if (i4 == 10 && j4 == 4) { course5 = 0 * 0.00f; course5credit = 0; }
                }
                // course 6
                if (i5 == 0)
                {
                    if (i5 == 0 && j5 == 0) { course6 = 4 * 4.00f; course6credit = 4; }
                    else if (i5 == 0 && j5 == 1) { course6 = 3 * 4.00f; course6credit = 3; }
                    else if (i5 == 0 && j5 == 2) { course6 = 2 * 4.00f; course6credit = 2; }
                    else if (i5 == 0 && j5 == 3) { course6 = 1 * 4.00f; course6credit = 1; }
                    else if (i5 == 0 && j5 == 4) { course6 = 0 * 4.00f; course6credit = 0; }
                }
                else if (i5 == 1)
                {
                    if (i5 == 1 && j5 == 0) { course6 = 4 * 3.66f; course6credit = 4; }
                    else if (i5 == 1 && j5 == 1) { course6 = 3 * 3.66f; course6credit = 3; }
                    else if (i5 == 1 && j5 == 2) { course6 = 2 * 3.66f; course6credit = 2; }
                    else if (i5 == 1 && j5 == 3) { course6 = 1 * 3.66f; course6credit = 1; }
                    else if (i5 == 1 && j5 == 4) { course6 = 0 * 3.66f; course6credit = 0; }
                }
                else if (i5 == 2)
                {
                    if (i5 == 2 && j5 == 0) { course6 = 4 * 3.33f; course6credit = 4; }
                    else if (i5 == 2 && j5 == 1) { course6 = 3 * 3.33f; course6credit = 3; }
                    else if (i5 == 2 && j5 == 2) { course6 = 2 * 3.33f; course6credit = 2; }
                    else if (i5 == 2 && j5 == 3) { course6 = 1 * 3.33f; course6credit = 1; }
                    else if (i5 == 2 && j5 == 4) { course6 = 0 * 3.33f; course6credit = 0; }
                }
                else if (i5 == 3)
                {
                    if (i5 == 3 && j5 == 0) { course6 = 4 * 3.00f; course6credit = 4; }
                    else if (i5 == 3 && j5 == 1) { course6 = 3 * 3.00f; course6credit = 3; }
                    else if (i5 == 3 && j5 == 2) { course6 = 2 * 3.00f; course6credit = 2; }
                    else if (i5 == 3 && j5 == 3) { course6 = 1 * 3.00f; course6credit = 1; }
                    else if (i5 == 3 && j5 == 4) { course6 = 0 * 3.00f; course6credit = 0; }
                }
                else if (i5 == 4)
                {
                    if (i5 == 4 && j5 == 0) { course6 = 4 * 2.66f; course6credit = 4; }
                    else if (i5 == 4 && j5 == 1) { course6 = 3 * 2.66f; course6credit = 3; }
                    else if (i5 == 4 && j5 == 2) { course6 = 2 * 2.66f; course6credit = 2; }
                    else if (i5 == 4 && j5 == 3) { course6 = 1 * 2.66f; course6credit = 1; }
                    else if (i5 == 4 && j5 == 4) { course6 = 0 * 2.66f; course6credit = 0; }
                }
                else if (i5 == 5)
                {
                    if (i5 == 5 && j5 == 0) { course6 = 4 * 2.33f; course6credit = 4; }
                    else if (i5 == 5 && j5 == 1) { course6 = 3 * 2.33f; course6credit = 3; }
                    else if (i5 == 5 && j5 == 2) { course6 = 2 * 2.33f; course6credit = 2; }
                    else if (i5 == 5 && j5 == 3) { course6 = 1 * 2.33f; course6credit = 1; }
                    else if (i5 == 5 && j5 == 4) { course6 = 0 * 2.33f; course6credit = 0; }
                }
                else if (i5 == 6)
                {
                    if (i5 == 6 && j5 == 0) { course6 = 4 * 2.00f; course6credit = 4; }
                    else if (i5 == 6 && j5 == 1) { course6 = 3 * 2.00f; course6credit = 3; }
                    else if (i5 == 6 && j5 == 2) { course6 = 2 * 2.00f; course6credit = 2; }
                    else if (i5 == 6 && j5 == 3) { course6 = 1 * 2.00f; course6credit = 1; }
                    else if (i5 == 6 && j5 == 4) { course6 = 0 * 2.00f; course6credit = 0; }
                }
                else if (i5 == 7)
                {
                    if (i5 == 7 && j5 == 0) { course6 = 4 * 1.66f; course6credit = 4; }
                    else if (i5 == 7 && j5 == 1) { course6 = 3 * 1.66f; course6credit = 3; }
                    else if (i5 == 7 && j5 == 2) { course6 = 2 * 1.66f; course6credit = 2; }
                    else if (i5 == 7 && j5 == 3) { course6 = 1 * 1.66f; course6credit = 1; }
                    else if (i5 == 7 && j5 == 4) { course6 = 0 * 1.66f; course6credit = 0; }
                }
                else if (i5 == 8)
                {
                    if (i5 == 8 && j5 == 0) { course6 = 4 * 1.33f; course6credit = 4; }
                    else if (i5 == 8 && j5 == 1) { course6 = 3 * 1.33f; course6credit = 3; }
                    else if (i5 == 8 && j5 == 2) { course6 = 2 * 1.33f; course6credit = 2; }
                    else if (i5 == 8 && j5 == 3) { course6 = 1 * 1.33f; course6credit = 1; }
                    else if (i5 == 8 && j5 == 4) { course6 = 0 * 1.33f; course6credit = 0; }
                }
                else if (i5 == 9)
                {
                    if (i5 == 9 && j5 == 0) { course6 = 4 * 1.00f; course6credit = 4; }
                    else if (i5 == 9 && j5 == 1) { course6 = 3 * 1.00f; course6credit = 3; }
                    else if (i5 == 9 && j5 == 2) { course6 = 2 * 1.00f; course6credit = 2; }
                    else if (i5 == 9 && j5 == 3) { course6 = 1 * 1.00f; course6credit = 1; }
                    else if (i5 == 9 && j5 == 4) { course6 = 0 * 1.00f; course6credit = 0; }
                }
                else if (i5 == 10)
                {
                    if (i5 == 10 && j5 == 0) { course6 = 4 * 0.00f; course6credit = 4; }
                    else if (i5 == 10 && j5 == 1) { course6 = 3 * 0.00f; course6credit = 3; }
                    else if (i5 == 10 && j5 == 2) { course6 = 2 * 0.00f; course6credit = 2; }
                    else if (i5 == 10 && j5 == 3) { course6 = 1 * 0.00f; course6credit = 1; }
                    else if (i5 == 10 && j5 == 4) { course6 = 0 * 0.00f; course6credit = 0; }
                }
                // course 7
                if (i6 == 0)
                {
                    if (i6 == 0 && j6 == 0) { course7 = 4 * 4.00f; course7credit = 4; }
                    else if (i6 == 0 && j6 == 1) { course7 = 3 * 4.00f; course7credit = 3; }
                    else if (i6 == 0 && j6 == 2) { course7 = 2 * 4.00f; course7credit = 2; }
                    else if (i6 == 0 && j6 == 3) { course7 = 1 * 4.00f; course7credit = 1; }
                    else if (i6 == 0 && j6 == 4) { course7 = 0 * 4.00f; course7credit = 0; }
                }
                else if (i6 == 1)
                {
                    if (i6 == 1 && j6 == 0) { course7 = 4 * 3.66f; course7credit = 4; }
                    else if (i6 == 1 && j6 == 1) { course7 = 3 * 3.66f; course7credit = 3; }
                    else if (i6 == 1 && j6 == 2) { course7 = 2 * 3.66f; course7credit = 2; }
                    else if (i6 == 1 && j6 == 3) { course7 = 1 * 3.66f; course7credit = 1; }
                    else if (i6 == 1 && j6 == 4) { course7 = 0 * 3.66f; course7credit = 0; }
                }
                else if (i6 == 2)
                {
                    if (i6 == 2 && j6 == 0) { course7 = 4 * 3.33f; course7credit = 4; }
                    else if (i6 == 2 && j6 == 1) { course7 = 3 * 3.33f; course7credit = 3; }
                    else if (i6 == 2 && j6 == 2) { course7 = 2 * 3.33f; course7credit = 2; }
                    else if (i6 == 2 && j6 == 3) { course7 = 1 * 3.33f; course7credit = 1; }
                    else if (i6 == 2 && j6 == 4) { course7 = 0 * 3.33f; course7credit = 0; }
                }
                else if (i6 == 3)
                {
                    if (i6 == 3 && j6 == 0) { course7 = 4 * 3.00f; course7credit = 4; }
                    else if (i6 == 3 && j6 == 1) { course7 = 3 * 3.00f; course7credit = 3; }
                    else if (i6 == 3 && j6 == 2) { course7 = 2 * 3.00f; course7credit = 2; }
                    else if (i6 == 3 && j6 == 3) { course7 = 1 * 3.00f; course7credit = 1; }
                    else if (i6 == 3 && j6 == 4) { course7 = 0 * 3.00f; course7credit = 0; }
                }
                else if (i6 == 4)
                {
                    if (i6 == 4 && j6 == 0) { course7 = 4 * 2.66f; course7credit = 4; }
                    else if (i6 == 4 && j6 == 1) { course7 = 3 * 2.66f; course7credit = 3; }
                    else if (i6 == 4 && j6 == 2) { course7 = 2 * 2.66f; course7credit = 2; }
                    else if (i6 == 4 && j6 == 3) { course7 = 1 * 2.66f; course7credit = 1; }
                    else if (i6 == 4 && j6 == 4) { course7 = 0 * 2.66f; course7credit = 0; }
                }
                else if (i6 == 5)
                {
                    if (i6 == 5 && j6 == 0) { course7 = 4 * 2.33f; course7credit = 4; }
                    else if (i6 == 5 && j6 == 1) { course7 = 3 * 2.33f; course7credit = 3; }
                    else if (i6 == 5 && j6 == 2) { course7 = 2 * 2.33f; course7credit = 2; }
                    else if (i6 == 5 && j6 == 3) { course7 = 1 * 2.33f; course7credit = 1; }
                    else if (i6 == 5 && j6 == 4) { course7 = 0 * 2.33f; course7credit = 0; }
                }
                else if (i6 == 6)
                {
                    if (i6 == 6 && j6 == 0) { course7 = 4 * 2.00f; course7credit = 4; }
                    else if (i6 == 6 && j6 == 1) { course7 = 3 * 2.00f; course7credit = 3; }
                    else if (i6 == 6 && j6 == 2) { course7 = 2 * 2.00f; course7credit = 2; }
                    else if (i6 == 6 && j6 == 3) { course7 = 1 * 2.00f; course7credit = 1; }
                    else if (i6 == 6 && j6 == 4) { course7 = 0 * 2.00f; course7credit = 0; }
                }
                else if (i6 == 7)
                {
                    if (i6 == 7 && j6 == 0) { course7 = 4 * 1.66f; course7credit = 4; }
                    else if (i6 == 7 && j6 == 1) { course7 = 3 * 1.66f; course7credit = 3; }
                    else if (i6 == 7 && j6 == 2) { course7 = 2 * 1.66f; course7credit = 2; }
                    else if (i6 == 7 && j6 == 3) { course7 = 1 * 1.66f; course7credit = 1; }
                    else if (i6 == 7 && j6 == 4) { course7 = 0 * 1.66f; course7credit = 0; }
                }
                else if (i6 == 8)
                {
                    if (i6 == 8 && j6 == 0) { course7 = 4 * 1.33f; course7credit = 4; }
                    else if (i6 == 8 && j6 == 1) { course7 = 3 * 1.33f; course7credit = 3; }
                    else if (i6 == 8 && j6 == 2) { course7 = 2 * 1.33f; course7credit = 2; }
                    else if (i6 == 8 && j6 == 3) { course7 = 1 * 1.33f; course7credit = 1; }
                    else if (i6 == 8 && j6 == 4) { course7 = 0 * 1.33f; course7credit = 0; }
                }
                else if (i6 == 9)
                {
                    if (i6 == 9 && j6 == 0) { course7 = 4 * 1.00f; course7credit = 4; }
                    else if (i6 == 9 && j6 == 1) { course7 = 3 * 1.00f; course7credit = 3; }
                    else if (i6 == 9 && j6 == 2) { course7 = 2 * 1.00f; course7credit = 2; }
                    else if (i6 == 9 && j6 == 3) { course7 = 1 * 1.00f; course7credit = 1; }
                    else if (i6 == 9 && j6 == 4) { course7 = 0 * 1.00f; course7credit = 0; }
                }
                else if (i6 == 10)
                {
                    if (i6 == 10 && j6 == 0) { course7 = 4 * 0.00f; course7credit = 4; }
                    else if (i6 == 10 && j6 == 1) { course7 = 3 * 0.00f; course7credit = 3; }
                    else if (i6 == 10 && j6 == 2) { course7 = 2 * 0.00f; course7credit = 2; }
                    else if (i6 == 10 && j6 == 3) { course7 = 1 * 0.00f; course7credit = 1; }
                    else if (i6 == 10 && j6 == 4) { course7 = 0 * 0.00f; course7credit = 0; }
                }
                float add1 = course1 + course2 + course3 + course4 + course5 + course6 + course7;
                int add2 = course1credit + course2credit + course3credit + course4credit + course5credit + course6credit + course7credit;
                MessageBox.Show("Your Semester GPA is :\n\n\n" + add1/add2, "Informative Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }  
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label2.Visible = false; label3.Visible = false; label10.Visible = false;
            textBox1.Visible = false; label11.Visible = false; textBox2.Visible = false;
            label7.Visible = false; label13.Visible = false; textBox4.Visible = false;
            label16.Visible = false; textBox7.Visible = false; label8.Visible = false;
            label12.Visible = false; textBox3.Visible = false; label15.Visible = false;
            textBox6.Visible = false; label9.Visible = false; label14.Visible = false;
            textBox5.Visible = false; label17.Visible = false; textBox8.Visible = false;
            label4.Visible = false; label18.Visible = false; label22.Visible = false;
            textBox9.Visible = false; label26.Visible = false; textBox10.Visible = false;
            label20.Visible = false; label24.Visible = false; textBox11.Visible = false;
            label28.Visible = false; textBox14.Visible = false; label19.Visible = false;
            label23.Visible = false; textBox12.Visible = false; label27.Visible = false;
            textBox13.Visible = false; label21.Visible = false; label25.Visible = false;
            textBox16.Visible = false; label29.Visible = false; textBox15.Visible = false;
            label5.Visible = false; label30.Visible = false; label31.Visible = false;
            textBox17.Visible = false; label32.Visible = false; textBox18.Visible = false;
            label6.Visible = false; label33.Visible = false; label34.Visible = false;
            textBox19.Visible = false; label35.Visible = false; textBox20.Visible = false;
            button2.Visible = false;

            label91.Visible = false; label92.Visible = false; comboBox1.Visible = false;
            label93.Visible = false; comboBox2.Visible = false; label94.Visible = false;
            label95.Visible = false; comboBox3.Visible = false; label96.Visible = false;
            comboBox4.Visible = false; label97.Visible = false; label98.Visible = false;
            comboBox5.Visible = false; label99.Visible = false; comboBox6.Visible = false;
            label100.Visible = false; label101.Visible = false; comboBox7.Visible = false;
            label102.Visible = false; comboBox8.Visible = false; label103.Visible = false;
            label104.Visible = false; comboBox9.Visible = false; label105.Visible = false;
            comboBox10.Visible = false; label106.Visible = false; label107.Visible = false;
            comboBox11.Visible = false; label108.Visible = false; comboBox12.Visible = false;
            label109.Visible = false; label110.Visible = false; comboBox13.Visible = false;
            label111.Visible = false; comboBox14.Visible = false; button4.Visible = false;

            label36.Visible = false; label37.Visible = false; label38.Visible = false;
            label39.Visible = false; textBox21.Visible = false; label40.Visible = false;
            textBox22.Visible = false; label41.Visible = false; label42.Visible = false;
            textBox23.Visible = false; label43.Visible = false; textBox24.Visible = false;
            label44.Visible = false; label45.Visible = false; textBox25.Visible = false;
            label46.Visible = false; textBox26.Visible = false; label47.Visible = false;
            label48.Visible = false; textBox27.Visible = false; label49.Visible = false;
            textBox28.Visible = false; label50.Visible = false; label51.Visible = false;
            label52.Visible = false; textBox29.Visible = false; label53.Visible = false;
            textBox30.Visible = false; label54.Visible = false; label55.Visible = false;
            textBox31.Visible = false; label56.Visible = false; textBox32.Visible = false;
            label57.Visible = false; label58.Visible = false; textBox33.Visible = false;
            label59.Visible = false; textBox34.Visible = false; label60.Visible = false;
            label61.Visible = false; textBox35.Visible = false; label62.Visible = false;
            textBox36.Visible = false; label63.Visible = false; label64.Visible = false;
            label65.Visible = false; textBox37.Visible = false; label66.Visible = false;
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
            textBox49.Visible = false; label86.Visible = false; textBox50.Visible = false;
            label87.Visible = false; label88.Visible = false; label89.Visible = false;
            textBox51.Visible = false; label90.Visible = false; textBox52.Visible = false;
            button3.Visible = false;

            label112.Visible = true; label113.Visible = true; label114.Visible = true;
            label115.Visible = true; label116.Visible = true; label117.Visible = true;
            label118.Visible = true; label119.Visible = true; label120.Visible = true;
            label121.Visible = true; label122.Visible = true; label123.Visible = true;
            label124.Visible = true; label125.Visible = true; label126.Visible = true;
            label127.Visible = true; label128.Visible = true; textBox53.Visible = true;
            textBox54.Visible = true; textBox55.Visible = true; textBox56.Visible = true;
            textBox57.Visible = true; textBox58.Visible = true; textBox59.Visible = true;
            textBox60.Visible = true; label129.Visible = true; label130.Visible = true;
            label131.Visible = true; label132.Visible = true; label133.Visible = true;
            label134.Visible = true; label135.Visible=true; label136.Visible = true;
            textBox61.Visible = true; textBox62.Visible = true; textBox62.Visible = true;
            textBox63.Visible = true; textBox64.Visible = true; textBox65.Visible = true;
            textBox66.Visible = true; textBox67.Visible = true; textBox68.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox53.Text == "" && textBox61.Text == "")
            {
                MessageBox.Show("Please Enter atleast Semester 1 GPA ", "Informative Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                float sem1GPA = float.Parse(textBox53.Text);
                float sem2GPA = float.Parse(textBox54.Text);
                float sem3GPA = float.Parse(textBox55.Text);
                float sem4GPA = float.Parse(textBox56.Text);
                float sem5GPA = float.Parse(textBox57.Text);
                float sem6GPA = float.Parse(textBox58.Text);
                float sem7GPA = float.Parse(textBox59.Text);
                float sem8GPA = float.Parse(textBox60.Text);

                int sem1Credit = int.Parse(textBox61.Text);
                int sem2Credit = int.Parse(textBox62.Text);
                int sem3Credit = int.Parse(textBox63.Text);
                int sem4Credit = int.Parse(textBox64.Text);
                int sem5Credit = int.Parse(textBox65.Text);
                int sem6Credit = int.Parse(textBox66.Text);
                int sem7Credit = int.Parse(textBox67.Text);
                int sem8Credit = int.Parse(textBox68.Text);

                sem1GPA = sem1GPA * sem1Credit;
                sem2GPA = sem2GPA * sem2Credit;
                sem3GPA = sem3GPA * sem3Credit;
                sem4GPA = sem4GPA * sem4Credit;
                sem5GPA = sem5GPA * sem5Credit;
                sem6GPA = sem6GPA * sem6Credit;
                sem7GPA = sem7GPA * sem7Credit;
                sem8GPA = sem8GPA * sem8Credit;

                float semGPA = sem1GPA + sem2GPA + sem3GPA + sem4GPA + sem5GPA + sem6GPA + sem7GPA + sem8GPA;
                int semCredit = sem1Credit + sem2Credit + sem3Credit + sem4Credit + sem5Credit + sem6Credit + sem7Credit + sem8Credit;
                MessageBox.Show("Your CGPA is : \n\n" + semGPA / semCredit, "Informative Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}
