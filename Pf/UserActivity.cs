using Pf.DbModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Pf
{
    public partial class UserActivity : Form
    {

        private string oldname = "";

        private int UserId = 0;
        public ParfumEntities1 parfumEntities;
        public UserActivity()
        {
            InitializeComponent();
            parfumEntities = new ParfumEntities1();
        }
        private void UserActivity_Load(object sender, EventArgs e)
        {
            ChangeData();
            DgvLogin();
           
        }
        private void DgvLogin()
        {
            dataGridViwUser.DataSource = parfumEntities.Users.Where(x => x.IsActiv == true).Select(x => new
            {
                UserId = x.Id,
                x.FullName,
                x.Password
            }).ToList();
        }
      
        private void ChangeData()
        {
            dataGridViewLoginUser.DataSource = parfumEntities.Users.Where(x => x.IsActiv == false).Select(x => new
            {
                UserId = x.Id,
                x.FullName,
                x.Password
            }).ToList();

        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        

        private void dataGridViwUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int userId = int.Parse(dataGridViwUser.Rows[e.RowIndex].Cells["UserId"].Value.ToString());
            DbModel.User login = parfumEntities.Users.FirstOrDefault(x => x.Id == userId);
            textUserName.Text = login.FullName;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string name = textUserName.Text.Trim();
            string password = textPassword.Text.Trim();
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fill textbox");
            }
            else
            {
                DbModel.User user = new User
                {
                    FullName = name,
                    Password = password,
                    IsUser = checkUser.Checked,
                    IsActiv = true,
                    IsEmployee = checkEmloyee.Checked,

                };
                parfumEntities.Users.Add(user);
                parfumEntities.SaveChanges();
                MessageBox.Show("success");
                DgvLogin();
                ChangeData();
                ClearData();
            }
            
        }

        
        private void ClearData()
        {
            textUserName.Text = "";
            textPassword.Text = "";
            checkUser.Checked = false;
            checkEmloyee.Checked = false;
           
        }

        private void dataGridViewLoginUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = textUserName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("select name Please");
            }
            else
            {
                DbModel.User user = parfumEntities.Users.FirstOrDefault(x => x.FullName == name);
                if (user==null)
                {
                    MessageBox.Show("this User does not Registered", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    parfumEntities.Users.Remove(user);
                    parfumEntities.SaveChanges();
                    DgvLogin();
                    ClearData();
                    MessageBox.Show("select name is removed");
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textUserName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("ad secilmeyib.");
            }
            else
            {
                DbModel.User login_User = parfumEntities.Users.FirstOrDefault(x => x.FullName == name);
                login_User.IsActiv = false;
                parfumEntities.SaveChanges();
                MessageBox.Show("Selected Name is Accepted", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textUserName.Text = "";
                ChangeData();
                DgvLogin();
                ClearData();
            }
        }
    }
}
