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
    public partial class Form3 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        public Form3()
        {
            InitializeComponent();

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into student2 values (@name,@percentage)";
                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@name", textBox2name.Text);
                cmd.Parameters.AddWithValue("@percentage", textBox3percentage.Text);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update student2 set Name = @name , Percentage = @percentage  where Rollno = @roll";
                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@name", textBox2name.Text);
                cmd.Parameters.AddWithValue("@percentage", textBox3percentage.Text);
                cmd.Parameters.AddWithValue("@roll", Convert.ToInt32(textBox1roll.Text));

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from student2 where Rollno=@roll";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll", Convert.ToInt32(textBox1roll.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox2name.Text = dr["Name"].ToString();// Name , Salary are the col names
                        textBox3percentage.Text = dr["Percentage"].ToString();
                    }
                }
                else
                {
                    textBox2name.Clear();
                    textBox3percentage.Clear();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string qry = "delete from student2 where  Rollno = @roll";

                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@name", textBox2name.Text);
                cmd.Parameters.AddWithValue("@percentage", Convert.ToDouble(textBox3percentage.Text));
                cmd.Parameters.AddWithValue("@roll", Convert.ToInt32(textBox1roll.Text));


                con.Open();

                int result = cmd.ExecuteNonQuery();   //nonquery coz of i u d


                if (result == 1)
                {
                    MessageBox.Show("Success ! Record Deleted");
                    textBox2name.Clear();
                    textBox3percentage.Clear();
                    textBox1roll.Clear();
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

        private void EmpGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from student2";
                cmd = new SqlCommand(qry, con);

                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    StudGridView.DataSource = dt;
                }
                else
                {
                    /*textBox2name.Clear();
                    textBox3salary.Clear();*/
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