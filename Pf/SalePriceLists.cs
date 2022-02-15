using Pf.DbModel;
using Pf.Helper;
using System;
using System.Linq;
using System.Windows.Forms;


namespace Pf
{
    public partial class SalePriceLists : Form
    {
        public ParfumEntities1 parfumEntities1;
        public SalePriceLists()
        {
            InitializeComponent();
            parfumEntities1 = new ParfumEntities1();
        }

        private void SalePriceLists_Load(object sender, EventArgs e)
        {
            ViewLoad();
            CtegoryLoad();
        }

        public void ViewLoad()
        {
            dataGridShearch.DataSource = parfumEntities1.Parfums.Select(x => new
            {
                Id=x.Id,
                Name=x.Name,
                Image=x.Image,
                Description=x.Description,
                Gender=x.Gender.Name,
                Brend=x.Brend.Name
            }).ToArray();
        }
        
        public void CtegoryLoad()
        {
            combCatogory.DropDownStyle = ComboBoxStyle.DropDownList;
            combCatogory.DataSource = parfumEntities1.Categories.Select(x => new Cb_category
            {
                Id = x.Id,
                Name = x.Name
            }).ToArray();
        }
        public void ChangeData()
        {
           
            
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = textSearchName.Text.Trim();
            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("please insert name");
                return;
            }
            else
            {
                dataGridShearch.DataSource = parfumEntities1.Parfums.Where(x => x.Name == searchName).Select(x => new
                {
                    Name = x.Name,
                    Image = x.Image,
                    Description = x.Description,
                    Gender = x.Gender.Name,
                    Brend = x.Brend.Name
                }).ToArray();
            }
        }

        

        

        // Sale Price
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }


        private void btn_allparfums_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = parfumEntities1.Parfums.Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                Image = x.Image,
                Description = x.Description,
                Gender = x.Gender.Name,
                Brend = x.Brend.Name
            }).ToArray();
        }


        public void LoadCatogory()
        {
        }

        private void combCatogory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CtID = ((Cb_category)combCatogory.SelectedItem).Id;
            if (string.IsNullOrEmpty(CtID.ToString()))
            {
                MessageBox.Show("please select category");
                return;
            }
            else
            {
                dataGridView1.DataSource = parfumEntities1.CategoryParfums.Where(x => x.CategoryId == CtID).Select(x => new
                {
                   Name=x.Parfum.Name,
                    Description=x.Parfum.Description
                }).ToArray();
            }
        }



        public void ChangeCatogory()
        {

           

        }


        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryRemove categoryRemove = new CategoryRemove();
            categoryRemove.ShowDialog();
           
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryCreate categoryCreate = new CategoryCreate();
            categoryCreate.ShowDialog();
        }

        private void userActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserActivity userActivity = new UserActivity();
            userActivity.ShowDialog();
        }

        private void acivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saleAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       
        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void parfumParametrsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
