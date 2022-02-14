using Pf.DbModel;
using Pf.Helper;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Pf
{
    public partial class CategoryCreate : Form
    {
        private ParfumEntities parfumEntities; 
        public CategoryCreate()
        {
            InitializeComponent();
            parfumEntities = new ParfumEntities();
        }

        private void CategoryCreate_Load(object sender, EventArgs e)
        {
            combCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            combCategory.DataSource = parfumEntities.Categories.Select(x => new Cb_category
            {
                Id=x.Id,
                Name = x.Name
            }).ToArray();
        }

        private void CategoryChange()
        {
           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           
        }


     

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


        }
    }
}
