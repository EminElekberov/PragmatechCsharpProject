using Pf.DbModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Pf
{
    public partial class SinginParfum : Form
    {
        private readonly ParfumEntities1 parfumEntities1;
        public SinginParfum()
        {
            InitializeComponent();
            parfumEntities1 = new ParfumEntities1();
        }

        private void btnSingin_Click(object sender, EventArgs e)
        {
            string name = textLogin.Text.Trim();
            string password = textPassword.Text.Trim();
            if (name==null && password==null)
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (parfumEntities1.Users.Where(x=>x.FullName==name && x.Password==password && x.IsUser==true).Count()>0)
            {
                    SalePriceLists salePriceLists = new SalePriceLists();
                    salePriceLists.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Error", "Please regiter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SinginParfum_Load(object sender, EventArgs e)
        {
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SingUpParfum singUpParfum = new SingUpParfum();
            singUpParfum.ShowDialog();
        }
    }
}
