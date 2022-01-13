using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace savedeleteupdateapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = ConfigurationManager.ConnectionStrings["uniqeAd"].ConnectionString;
        private void btnsave_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("insert into student_detail values('" + txtname.Text + "','" + txtcourse.Text + "')", conn);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Saved...");
            }
            catch (Exception)
            {
                MessageBox.Show("Not Saved");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcourse.Clear();
            txtname.Clear();
            txtrn.Clear();
            txtrn.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("delete from student_detail where Id = " + txtrn.Text + " ", conn);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Deleted...");
                txtcourse.Clear();
                txtname.Clear();
                txtrn.Clear();
                txtrn.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show(" Not Deleted" + x.Message );
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("select * from student_detail where id = " + txtrn.Text + " ", conn);
           try
            {
                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    txtname.Text = dreader[1].ToString();
                    txtcourse.Text = dreader[2].ToString();
                }
                else
                {
                    MessageBox.Show(" No Record");
                }
                dreader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(" No Record");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("update student_detail set name= '"+txtname.Text+"', course=' "+txtcourse.Text+"' where id = "+txtrn.Text+" ", conn);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Updated..");
            }
            catch (Exception)
            {
                MessageBox.Show(" Not Updated");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtrn.Focus();
        }
    }
}
