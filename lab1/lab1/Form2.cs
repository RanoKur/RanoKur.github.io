using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (button1.Visible == false) MessageBox.Show("The first button is not visible");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Clicked on the button";
            MessageBox.Show("An event has occurred");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int viNumber = Convert.ToInt32(textBox1.Text) * 5;
            label1.Text = "Entered number multiplied by 5 =" +
                viNumber.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
