using repeatTask.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace repeatTask
{
    public partial class AdminPage : Form
    {
        private readonly LibraryEntities _db;
        public AdminPage()
        {
            InitializeComponent();
            _db = new LibraryEntities();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            StudentListDgv.DataSource = _db.Login_User.Where(x => x.IsAdmin == false && x.IsDeleted == false).Select(x => new
            {
                x.Id,
                x.Fullname,
                x.Email
            }).ToArray();
        }

        private void StudentListDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(StudentListDgv.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            Model.Login_User login_User = _db.Login_User.FirstOrDefault(x => x.Id == id);
            txtname.Text = login_User.Fullname;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            Model.Login_User login_User = _db.Login_User.FirstOrDefault(x => x.Fullname == name);
            login_User.IsDeleted = true;
            _db.SaveChanges();
            MessageBox.Show("Selected Name is Accepted", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtname.Text = "";
            StudentListDgv.DataSource = _db.Login_User.Where(x => x.IsAdmin == false && x.IsDeleted == false).Select(x => new
            {
                UserId = x.Id,
                x.Fullname,
                x.Email
            }).ToList();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            Model.Login_User login_User = _db.Login_User.FirstOrDefault(x => x.Fullname == name);
            _db.Login_User.Remove(login_User);
            _db.SaveChanges();
            MessageBox.Show("Selected Name is deleted", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtname.Text = "";
            StudentListDgv.DataSource = _db.Login_User.Where(x => x.IsAdmin == false && x.IsDeleted == false).Select(x => new
            {
                UserId = x.Id,
                x.Fullname,
                x.Email
            }).ToList();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
