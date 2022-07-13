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

    [Serializable]
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Arethmatic A = new Arethmatic();

                A.N1 = Convert.ToInt64(textNumber1.Text);
                A.N2 = Convert.ToInt64(textNumber2.Text);

                // A.R = Convert.ToInt64(textResult.Text);


                A.R = A.N1 + A.N2;

                textResult.Text = A.R.ToString();
            }
            catch (Exception em)
            {
                Console.WriteLine(em.Message);
            }





        }

        private void Mul_Click(object sender, EventArgs e)
        {

            try
            {
                Arethmatic A = new Arethmatic();

                A.N1 = Convert.ToInt64(textNumber1.Text);
                A.N2 = Convert.ToInt64(textNumber2.Text);

                A.R = A.N1 * A.N2;

                textResult.Text = A.R.ToString();
            }
            catch (Exception em)
            {
                Console.WriteLine(em.Message);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textNumber1.Clear();
            textNumber2.Clear();
            textResult.Clear();
        }

        private void Div_Click(object sender, EventArgs e)
        {
            try
            {
                Arethmatic A = new Arethmatic();

                A.N1 = Convert.ToInt64(textNumber1.Text);
                A.N2 = Convert.ToInt64(textNumber2.Text);

                A.R = A.N1 / A.N2;

                textResult.Text = A.R.ToString();
            }
            catch (Exception em)
            {
                Console.WriteLine(em.Message);
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            try
            {
                Arethmatic A = new Arethmatic();

                A.N1 = Convert.ToInt64(textNumber1.Text);
                A.N2 = Convert.ToInt64(textNumber2.Text);

                A.R = A.N1 - A.N2;

                textResult.Text = A.R.ToString();
            }
            catch (Exception em)
            {
                Console.WriteLine(em.Message);
            }
        }
    }
}