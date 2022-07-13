using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1lgn_Click(object sender, EventArgs e)
        {
            if (textBox1uid.Text == "Admin" && textBox2pass.Text == "Admin123" && (male.Checked || female.Checked))

            {
                MessageBox.Show("Login Sucsess");
            }
            else
            {
                MessageBox.Show(" Login Fail");
            }
        }

        private void textBox2pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2rst_Click(object sender, EventArgs e)
        {
            textBox1uid.Clear();
            textBox2pass.Clear();

        }

        private void textBox1uid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}