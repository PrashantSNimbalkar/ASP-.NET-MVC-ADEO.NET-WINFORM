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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        FileStream fs;
        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                c.Courseid = int.Parse(courseid.Text);
                c.Name = name.Text;
                c.Fees = int.Parse(fees.Text);


                fs = new FileStream(@"E:\AllFiles\CourseBinary", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, c);

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
                Course c = new Course();
                fs = new FileStream(@"E:\AllFiles\CourseBinary", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                c = (Course)bf.Deserialize(fs);

                courseid.Text = c.Courseid.ToString();
                name.Text = c.Name;
                fees.Text = c.Fees.ToString();
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

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Course objcourse = new Course();
                objcourse.Courseid = Convert.ToInt32(courseid.Text);
                objcourse.Name = name.Text;
                objcourse.Fees = Convert.ToInt32(fees.Text);


                fs = new FileStream(@"E:\AllFiles\CourseXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Course));
                xs.Serialize(fs, objcourse);
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

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                Course objcourse = new Course();
                fs = new FileStream(@"E:\AllFiles\CourseXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Course));
                objcourse = (Course)xs.Deserialize(fs);
                courseid.Text = objcourse.Courseid.ToString();
                name.Text = objcourse.Name;
                fees.Text = objcourse.Fees.ToString();

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
                Course objcourse = new Course();
                objcourse.Courseid = Convert.ToInt32(courseid.Text);
                objcourse.Name = name.Text;
                objcourse.Fees = Convert.ToInt32(fees.Text);


                fs = new FileStream(@"E:\AllFiles\CourseSOAP", FileMode.Create, FileAccess.Write);

                SoapFormatter sf = new SoapFormatter();

                sf.Serialize(fs, objcourse);

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
                Course objcourse = new Course();
                fs = new FileStream(@"E:\AllFiles\CourseSOAP", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                objcourse = (Course)sf.Deserialize(fs);
                courseid.Text = objcourse.Courseid.ToString();
                name.Text = objcourse.Name;
                fees.Text = objcourse.Fees.ToString();

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
                Course objcourse = new Course();
                objcourse.Courseid = Convert.ToInt32(courseid.Text);
                objcourse.Name = name.Text;
                objcourse.Fees = Convert.ToInt32(fees.Text);


                fs = new FileStream(@"E:\AllFiles\CourseJSON", FileMode.Create, FileAccess.Write);


                JsonSerializer.Serialize(fs, objcourse);
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
                Course objcourse = new Course();
                fs = new FileStream(@"E:\AllFiles\CourseJSON", FileMode.Open, FileAccess.Read);
                objcourse = JsonSerializer.Deserialize<Course>(fs);
                courseid.Text = objcourse.Courseid.ToString();
                name.Text = objcourse.Name;
                fees.Text = objcourse.Fees.ToString();
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

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}