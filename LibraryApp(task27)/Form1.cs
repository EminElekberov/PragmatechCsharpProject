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
    public partial class Form1 : Form
    {
        private readonly LibraryDbEntities1 _db;
        public Form1()
        {
            InitializeComponent();
            _db = new LibraryDbEntities1();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmailLogin.Text.Trim().ToLower();
            string pass = txtPassLogin.Text.Trim().ToLower();
            if (email=="" || pass=="")
            {
                MessageBox.Show("Fill", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Login_Users login_Users = _db.Login_Users.FirstOrDefault(x => x.Email == email);
            if (login_Users==null)
            {
                MessageBox.Show("Please register", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Books books = new Books();
                books.ShowDialog();
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtAdminEmailLogin.Text.Trim().ToLower();
            string pass = txtAdminPassLogin.Text.Trim().ToLower();
            if (name == "" || pass == "")
            {
                MessageBox.Show("Fill", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Login_Admin login_Admin = _db.Login_Admin.FirstOrDefault(x=>x.FullName==name);
            if (login_Admin == null)
            {
                MessageBox.Show("Please register", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.ShowDialog();
            }
        }
    }
}
