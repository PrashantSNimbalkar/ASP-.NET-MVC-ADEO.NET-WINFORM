using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinform
{
    [Serializable]
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public object FileStremmer { get; private set; }
        public object BinnaryFormmater { get; private set; }



        FileStream fs;
        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Vehical objv = new Vehical();


                objv.ID = Convert.ToInt32(id.Text);
                objv.Name = name.Text;

                fs = new FileStream(@"E:\AllFiles\VehicalBinary", FileMode.Create, FileAccess.Write);

                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, objv);

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
                Vehical objv = new Vehical();
                fs = new FileStream(@"E:\AllFiles\VehicalBinary", FileMode.Open, FileAccess.Read);

                BinaryFormatter bf = new BinaryFormatter();

                objv = (Vehical)bf.Deserialize(fs);

                id.Text = objv.ID.ToString();
                name.Text = objv.Name;

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
    }
}