using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;
using System.Configuration;


namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form4()
        {
            InitializeComponent();

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Product values (@name,@price)";
                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@name", textBox2name.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(textBox3price.Text));
                //  cmd.Parameters.AddWithValue("@roll", Convert.ToInt32(textBox1roll.Text));

                con.Open();

                int Result = cmd.ExecuteNonQuery();

                if (Result == 1)
                {
                    MessageBox.Show("Record Save...");
                }
                else
                {
                    MessageBox.Show("Record Fail");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1id.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox2name.Text = dr["Name"].ToString();// Name , price are the col names Of DB
                        textBox3price.Text = dr["Price"].ToString();
                    }
                }
                else
                {
                    textBox2name.Clear();
                    textBox3price.Clear();
                    MessageBox.Show("Record not found");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                string qry = "update Product set Name = @name , Price = @price where Id = @id";
                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@name", textBox2name.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(textBox3price.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1id.Text));

                con.Open();

                int Result = cmd.ExecuteNonQuery();

                if (Result == 1)
                {
                    MessageBox.Show("Record Update...");
                }
                else
                {
                    MessageBox.Show("Record updation Fail");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string qry = "delete from Product where  Id = @id";

                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@name", textBox2name.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(textBox3price.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1id.Text));


                con.Open();

                int result = cmd.ExecuteNonQuery();   //nonquery coz of i u d


                if (result == 1)
                {
                    MessageBox.Show("Success ! Record Deleted");
                    textBox2name.Clear();
                    textBox3price.Clear();
                    textBox1id.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product";
                cmd = new SqlCommand(qry, con);

                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    ProductGridView.DataSource = dt;
                }
                else
                {

                    MessageBox.Show("Record not found");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}