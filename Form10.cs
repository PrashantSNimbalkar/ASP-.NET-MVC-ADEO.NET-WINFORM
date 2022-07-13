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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            //step1
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write a query that needs to be fire
                string qry = "insert into Employee1 values(@name,@salary)";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@name", textBox2name.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(textBox3salary.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record inserted");
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
                string qry = "select * from Employee1 where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1id.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox2name.Text = dr["Name"].ToString();// Name , Salary are the col names
                        textBox3salary.Text = dr["Salary"].ToString();
                    }
                }
                else
                {
                    textBox2name.Clear();
                    textBox3salary.Clear();
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
                //step2 write a query that needs to be fire
                string qry = "update Employee1 set Name = @name , Salary = @salary  where Id = @id";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@name", textBox2name.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(textBox3salary.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1id.Text));

                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record Updated");
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
                //step2 write a query that needs to be fire
                string qry = "delete from Employee1 where  Id = @id";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@name", textBox2name.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(textBox3salary.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1id.Text));

                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record Deleted");
                    textBox2name.Clear();
                    textBox3salary.Clear();
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
                string qry = "select * from Employee1";
                cmd = new SqlCommand(qry, con);

                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    EmpGridView.DataSource = dt;
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

        private void textBox1id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}