using Pf.DbModel;
using Pf.Helper;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pf
{
    public partial class CategoryRemove : Form
    {
        public readonly ParfumEntities1 parfumEntities;
        public CategoryRemove()
        {
            InitializeComponent();
            parfumEntities = new ParfumEntities1();
        }

        private void combCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void CategoryElementChange()
        {
            string category = combCategory.SelectedItem.ToString().Trim();
            var categorySelected = LoadCommonData.parfumEntities.DeleteUpdateToParfums.Where(dr => dr.Category.ToLower() == category.ToLower()).Select(dr => dr.Header);
            listParfums.Items.Clear();
            foreach (var item in categorySelected)
            {
                listParfums.Items.Add(item);
            }
        }
        private void CategoryRemove_Load(object sender, EventArgs e)
        {
            LoadCommonData.LoadCategory(combCategory);
        }
        private void ViewLoad()
        {
            combCategory.DataSource = parfumEntities.Parfums.Select(x => new Cb_category
            {
                Id = x.Id,
                Name = x.Name
            }).ToArray();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            string name = "";
            foreach (var item in listParfums.SelectedItems)
            {
                name += (name == "" ? "" : ",") + item.ToString();
            }
            string[] names = name.Replace("ListViewItem: {", "").Replace("}", "").Split(',');

            string category = combCategory.SelectedItem.ToString().Trim();
            StringBuilder info = new StringBuilder();
            for (int i = 0; i < names.Length; i++)
            {
                // No Selected
                if (string.IsNullOrEmpty(names[0]))
                {
                    MessageBox.Show("You Must Be Selecet Some Elemet");
                    return;
                }

                //
                string header = names[i];
                info.Append(header);
                if (names.Length != 1)
                    info.Append(",");

                var categoryToParfumId = LoadCommonData.parfumEntities.DeleteUpdateToParfums
                    .FirstOrDefault(dr => dr.Header.ToLower() == header.ToLower() && dr.Category.ToLower() == category.ToLower()).Id;

                if (categoryToParfumId != 0)
                {
                    var categoryToParfums = LoadCommonData.parfumEntities.CategoryParfums
                        .Find(categoryToParfumId);
                    if (categoryToParfums != null)
                    {
                        LoadCommonData.parfumEntities.CategoryParfums.Remove(categoryToParfums);
                        LoadCommonData.parfumEntities.SaveChanges();
                    }

                }
                CategoryElementChange();

            }
        }
    }
}
