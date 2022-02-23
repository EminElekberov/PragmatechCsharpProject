using Pf.DbModel;
using Pf.Helper;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Pf
{
    public partial class UserActivityMonitor : Form
    {
        private readonly ParfumEntities1 parfumEntities1;
        public UserActivityMonitor()
        {
            InitializeComponent();
            parfumEntities1 = new ParfumEntities1();
        }
        public void WhenUSerLoad()
        {
            combUser.DropDownStyle = ComboBoxStyle.DropDownList;
            combUser.DataSource = parfumEntities1.Users.Where(x => x.IsUser == true).Select(x => new Cb_category
            {
               Id=x.Id,
               Name=x.FullName
            }).ToList();
        }
        public void WhenEmployeeLoad()
        {
            combEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            combEmployee.DataSource = parfumEntities1.Users.Where(x => x.IsEmployee == true).Select(x => new Cb_category
            {
                Id = x.Id,
                Name = x.FullName
            }).ToList();
        }
        private void UserActivityMonitor_Load(object sender, EventArgs e)
        {
            WhenUSerLoad();
            WhenEmployeeLoad();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void dataGridShearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewDelete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReferes_Click(object sender, EventArgs e)
        {
        }
    }
}
