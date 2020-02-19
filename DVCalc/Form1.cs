using System;
using System.Windows.Forms;

namespace DVCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gravity = 9.81;
            double fullMass = double.Parse(textBox1.Text);
            double dryMass = double.Parse(textBox2.Text);
            double iSp = double.Parse(textBox3.Text);
            
            //  dV = specificImpulse * gravity * Math.Log(fullMass / dryMass);

            if (radioButton2.Checked)
            {
                iSp *= gravity;
             
            }

            double dV = iSp * Math.Log(fullMass / dryMass);


            label7.Text = Math.Round(dV, 2).ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
