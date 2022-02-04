using LibraryApi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApi
{
    public partial class Login : Form
    {
        private readonly LibraryEntities3 _db;

        public Login()
        {
            InitializeComponent();
            _db = new LibraryEntities3();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            string name = txtEmailLogin.Text.Trim();
            string pass = txtPassLogin.Text.Trim();
            if (name == "" || pass == "")
            {
                MessageBox.Show("Fill", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (_db.Login_User.Where(x=>x.Email==name && x.Password==pass).Count()>0)
            {
                AddBook addBook = new AddBook();
                addBook.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please register", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRegister_Click_1(object sender, EventArgs e)
        {
            Regsiter regsiter = new Regsiter();
            regsiter.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtAdminEmailLogin.Text.Trim();
            string pass = txtAdminPassLogin.Text.Trim();
            if (name == "" || pass == "")
            {
                MessageBox.Show("Fill", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (_db.Login_Admin.Where(x => x.Names == name && x.Pasword == pass).Count() > 0)
            {
                AdminPage addBook = new AdminPage();
                addBook.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please register", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
