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
            CategoryChange();
        }

        private void CategoryChange()
        {
            combCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            combCategory.DataSource = parfumEntities.Categories.Select(x => new Cb_category
            {
                Id = x.Id,
                Name = x.Name
            }).ToArray();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = textNewCategrory.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("write name please");
                return;
            }
            else
            {
                DbModel.Category category = new Category
                {
                    Name=name
                };
                parfumEntities.Categories.Add(category);
                parfumEntities.SaveChanges();
                CategoryChange();
                MessageBox.Show("success");
                textNewCategrory.Clear();
            }
        }


     

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name=textNewCategrory
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = textNewCategrory.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please write name");
            }
            else
            {
                DbModel.Category category = parfumEntities.Categories.FirstOrDefault(x => x.Name == name);
                if (category==null)
                {
                    MessageBox.Show("this doesn't parfum already");
                }
                else
                {
                    parfumEntities.Categories.Remove(category);
                    parfumEntities.SaveChanges();
                    CategoryChange();
                    MessageBox.Show("success deleted");
                    textNewCategrory.Clear();
                }
            }
        }
    }
}
