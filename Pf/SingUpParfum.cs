using Pf.DbModel;
using System;
using System.Windows.Forms;

namespace Pf
{
    public partial class SingUpParfum : Form
    {
        private readonly ParfumEntities1 parfumEntities1;
        public SingUpParfum()
        {
            InitializeComponent();
            parfumEntities1 = new ParfumEntities1();
        }

        private void SingUpParfum_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textLogin.Text.Trim();
            string password = textPassword.Text.Trim();
            string repPass = textCheckPassword.Text.Trim();
            if (repPass != password)
            {
                MessageBox.Show("wrong password");
                return;
            }
            if (name=="" && password=="" && repPass=="")
            {
                MessageBox.Show("Error", "Please all input insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            else
            {
                try
                {
                    DbModel.User user = new DbModel.User
                    {
                        FullName = name,
                        Password = password,
                        IsUser = true,
                        IsAdmin = false,
                        IsEmployee = false,
                        IsActiv = false
                    };
                    parfumEntities1.Users.Add(user);
                    parfumEntities1.SaveChanges();
                    MessageBox.Show("Success");
                }
                catch (Exception)
                {
                    MessageBox.Show("error");
                    throw;
                }
            }
        }
    }
}
