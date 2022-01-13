using StudenRegister_task25_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudenRegister_task25_
{
    public partial class Form1 : Form
    {
        private readonly LoginDbEntities lb;
        public Form1()
        {
            InitializeComponent();
            lb = new LoginDbEntities();
        }
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = ConfigurationManager.ConnectionStrings["FirstRegisterApiStudent"].ConnectionString;
        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
            studentsRegisterBindingSource.DataSource = lb.StudentsRegisters.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["FirstRegisterApiStudent"].ConnectionString;
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlConnection = new SqlConnection(conn);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("insert into StudentsRegister (Rol_Number,Names,Age,Course) values ('" + txt_Role.Text.Trim() + "','" + txtFullName.Text.Trim() + "','" + txtPassword.Text.Trim() + "','" + txtCourse.Text.Trim() + "')", sqlConnection);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Success");
                }
                UpdateDtGridView();
                ClearTextBox();
            }
            catch (Exception)
            {

                throw new Exception();
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["FirstRegisterApiStudent"].ConnectionString;
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlConnection = new SqlConnection(conn);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("delete from StudentsRegister where Rol_Number =" + txt_Role.Text.Trim() + "", sqlConnection);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Success");
                }
                UpdateDtGridView();
                ClearTextBox();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void UpdateDtGridView()
        {
            studentsRegisterDataGridView.AutoGenerateColumns = false;
            studentsRegisterDataGridView.DataSource = lb.StudentsRegisters.ToList();
        }
        public void ClearTextBox()
        {
            txt_Role.Clear();
            txtCourse.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("select * from StudentsRegister where id = " + txt_Role.Text + " ", conn);
            try
            {
                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    txtFullName.Text = dreader[2].ToString();
                    txtCourse.Text = dreader[4].ToString();
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
    }
}

