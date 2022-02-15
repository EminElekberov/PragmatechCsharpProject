using Pf.DbModel;
using Pf.Helper;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Pf
{
    public partial class CategoryAdd : Form
    {
        public ParfumEntities1 parfumEntities1;
        public CategoryAdd()
        {
            InitializeComponent();
            parfumEntities1 = new ParfumEntities1();
        }

        public void ViewLod()
        {
            combSearchName.DropDownStyle = ComboBoxStyle.DropDownList;
            combSearchName.DataSource = parfumEntities1.Parfums.Select(x => new Cb_category
            {
                Id=x.Id,
               Name=x.Name
            }).ToArray();
        }
        private void CategoryAdd_Load(object sender, EventArgs e)
        {
            ViewLod();
            var data = parfumEntities1.Categories.Select(x => x.Name).ToList();
            foreach (var item in data)
            {
                listCategory.Items.Add(item);
            }

        }

        private void LoadCategoryList()
        {
          
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string name = "";
            foreach (var item in listCategory.SelectedItems)
            {
                name += (name == "" ? "" : " ") + item.ToString();
            }
            string[] names = name.Replace("ListViewItem: {", "").Replace("}", "").Split(' ');
            int parfumId = ((Cb_category)combSearchName.SelectedItem).Id;

            int categoryId = 0;
            string categoryName = "";


            // Check Add  

            var categoryIdes = LoadCommonData.parfumEntities
            .CategoryParfums
            .Where(dr => dr.ParfumId == parfumId)
            .Select(us => us.CategoryId).ToList();

            CategoryParfum toParfum = new CategoryParfum();
            for (int i = 0; i < names.Length; i++)
            {
                if (string.IsNullOrEmpty(names[0]))
                {
                    return;
                }
                categoryName = names[i];
                categoryId = LoadCommonData.parfumEntities.Categories.FirstOrDefault(dr => dr.Name.Trim().ToLower() == categoryName).Id;

                bool isAdded = false;
                foreach (var item in categoryIdes)
                {
                    if (item == categoryId)
                        isAdded = true;
                }
                if (isAdded)
                    continue;


                if (categoryId != 0)
                {
                    toParfum.CategoryId = categoryId;
                    toParfum.ParfumId = parfumId;
                    LoadCommonData.parfumEntities.CategoryParfums.Add(toParfum);
                    LoadCommonData.parfumEntities.SaveChanges();
                }

            }

            
            //RefresData.salePriceLists.ChangeData();
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
