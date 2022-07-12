using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SampleWinform
{
    [Serializable]
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        FileStream fs;
        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee objemp = new Employee();
                objemp.Empid = Convert.ToInt32(empid.Text);
                objemp.Empname = name.Text;
                objemp.Salary = Convert.ToInt32(salary.Text);

                fs = new FileStream(@"E:\AllFiles\EmployeeBinary", FileMode.Create, FileAccess.Write);

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, objemp);

                MessageBox.Show("Binary File Created");

            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            finally
            {
                fs.Close();


            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee objemp = new Employee();
                fs = new FileStream(@"E:\AllFiles\EmployeeBinary", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                objemp = (Employee)bf.Deserialize(fs);

                empid.Text = objemp.Empid.ToString();
                name.Text = objemp.Empname;
                salary.Text = objemp.Salary.ToString();
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            finally
            {
                fs.Close();
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee objemp = new Employee();
                objemp.Empid = Convert.ToInt32(empid.Text);
                objemp.Empname = name.Text;
                objemp.Salary = Convert.ToInt32(salary.Text);


                fs = new FileStream(@"E:\AllFiles\EmployeeXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                xs.Serialize(fs, objemp);
                MessageBox.Show("XML File Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee objemp = new Employee();
                fs = new FileStream(@"E:\AllFiles\EmployeeXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                objemp = (Employee)xs.Deserialize(fs);
                empid.Text = objemp.Empid.ToString();
                name.Text = objemp.Empname;
                salary.Text = objemp.Salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee objemp = new Employee();

                objemp.Empid = Convert.ToInt32(empid.Text);
                objemp.Empname = name.Text;
                objemp.Salary = Convert.ToInt32(salary.Text);

                fs = new FileStream(@"E:\AllFiles\EmployeeSOAP", FileMode.Create, FileAccess.Write);

                SoapFormatter sf = new SoapFormatter();

                sf.Serialize(fs, objemp);

                MessageBox.Show("SOAP File Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee objemp = new Employee();
                fs = new FileStream(@"E:\AllFiles\EmployeeSOAP", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                objemp = (Employee)sf.Deserialize(fs);
                empid.Text = objemp.Empid.ToString();
                name.Text = objemp.Empname;
                salary.Text = objemp.Salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee objemp = new Employee();
                objemp.Empid = Convert.ToInt32(empid.Text);
                objemp.Empname = name.Text;
                objemp.Salary = Convert.ToInt32(salary.Text);

                fs = new FileStream(@"E:\AllFiles\EmployeeJSON", FileMode.Create, FileAccess.Write);


                JsonSerializer.Serialize(fs, objemp);
                MessageBox.Show("Json File Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee objemp = new Employee();
                fs = new FileStream(@"E:\AllFiles\EmployeeJSON", FileMode.Open, FileAccess.Read);
                objemp = JsonSerializer.Deserialize<Employee>(fs);
                empid.Text = objemp.Empid.ToString();
                name.Text = objemp.Empname;
                salary.Text = objemp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
