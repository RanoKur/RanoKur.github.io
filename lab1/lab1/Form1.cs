using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Hello World C#");
    
        }
      

        private void Form1_Load(object sender, EventArgs e)
        { 
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForma = new Form3();
            myForma.Show();
        }
    }
       

    
}
