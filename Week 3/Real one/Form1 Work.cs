using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Charlie_Week_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (textBox1.Text == "")//Firstname
            {
                MessageBox.Show("Firstname can't be empty");
                textBox1.BackColor = Color.Red;
                textBox1.Focus();
            }
            else if (textBox1.Text == "")//Lastname
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("Lastname can't be empty");
                textBox2.BackColor = Color.Red;
            }
            else if (int.TryParse(textBox3.Text, out num) == false)// mobile
            {
                textBox2.BackColor = Color.White;
                MessageBox.Show("Enter Digits only");
                textBox3.BackColor = Color.Red;
            }
            else if (numericUpDown1.Value == 0)//time
            {
                textBox3.BackColor = Color.White;
                MessageBox.Show("Please enter the hour time:");
            }
            else if (comboBox1.SelectedIndex == -1)//bk combo with drink
            {
                MessageBox.Show("Please select any item.");
            }
            else if (button3.Text == ("Nature of meeting"))
            {
                MessageBox.Show("Please select the aim of the meeting");
            }

            else
            {
                listBox1.Items.Add("Name: " + textBox1.Text + " " + textBox2.Text);
                listBox1.Items.Add("Hours: " + numericUpDown1.Value + ":" + numericUpDown2.Value);
                listBox1.Items.Add("Meeting With: " + comboBox1.SelectedItem);
                listBox1.Items.Add("Meeting Aim " + button3.Text);
                listBox1.Items.Add("------------------------------------------------------");

                textBox1.Text = ("");
                textBox1.BackColor = Color.White;
                textBox2.Text = ("");
                textBox2.BackColor = Color.White;
                textBox3.Text = ("");
                textBox3.BackColor = Color.White;
                textBox7.Text = ("");
                textBox7.BackColor = Color.White; 
                numericUpDown1.Value = (0); 
                numericUpDown2.Value = (0);
                comboBox1.Text = ("Select Any");
                button3.Text = ("Nature of meeting");


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            second_form sv = new second_form();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                
                if (sv.radioButton1.Checked == true)
                    button3.Text = sv.radioButton1.Text;
                else if (sv.radioButton2.Checked == true)
                    button3.Text = sv.radioButton2.Text;
                else if (sv.radioButton3.Checked == true)
                    button3.Text = sv.radioButton3.Text;
                else if (sv.radioButton4.Checked == true)
                    button3.Text = sv.radioButton4.Text;
                else
                {
                    button3.Text = ("Nature of meeting");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }




              