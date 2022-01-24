using LibraryApp_task27_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp_task27_
{
    public partial class Register : Form
    {
        private readonly LibraryDbEntities2 _db;
        private readonly Form _login;

        public Register(Form login)
        {
            InitializeComponent();
            _db = new LibraryDbEntities2();
            _login = login;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string Fullname = txtName.Text.Trim();
            string pass = txtPass.Text.Trim();
            string Reppass = txtRepPass.Text.Trim();
            if (!(Check(email, Fullname, pass, Reppass)))
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool EmailCheck = _db.Login_Users.Any(x => x.Email == email);
            if (EmailCheck)
            {
                MessageBox.Show("Email alredat exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                Login_Users login_Users = new Login_Users
                {
                    FullName = Fullname,
                    Pasword = pass,
                    Email = email,
                    IsActive = true,
                    IsDeleted = false,
                    IsAdmin = false
                };
                _db.Login_Users.Add(login_Users);
                _db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            MessageBox.Show("Successfully Registr", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        private bool Check(string email, string fullname, string pass, string reppas)
        {
            if (email == "" || fullname == "" || pass == "" || reppas == "")
            {
                MessageBox.Show("Fill", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(email.Contains("@")))
            {
                return false;
            }
            if (pass != reppas)
            {
                MessageBox.Show("Please repeat password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            return true;
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtRepPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
