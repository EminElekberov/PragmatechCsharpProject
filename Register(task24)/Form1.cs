using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Register_task24_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region
            //string conn = ConfigurationManager.ConnectionStrings["FirstRegisterApi"].ConnectionString;
            //SqlConnection sqlConnection = null;
            //SqlCommand sqlCommand = null;
            //SqlDataReader sqlDataReader = null;
            //try
            //{
            //    sqlConnection = new SqlConnection(conn);
            //    sqlConnection.Open();
            //    string query = "select * from tbl_login where Username='" + txtFullName.Text.Trim() + "'and Password='" + txtPassword.Text.Trim() + "'";
            //    sqlCommand = new SqlCommand(query, sqlConnection);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            #endregion
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["FirstRegisterApi"].ConnectionString;
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlConnection = new SqlConnection(conn);
                sqlConnection.Open();
                string query = "select * from tbl_login where Username='" + txtFullName.Text.Trim() + "'and Password='" + txtPassword.Text.Trim() + "'";
               // sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    frmMain frm = new frmMain();
                    Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password or name is wrong");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountCreate accountCreate = new AccountCreate();
            accountCreate.ShowDialog();
        }
    }
}
