using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Pf.DbModel;
using Pf.Helper;

namespace Pf
{
    public partial class ParfumeUpdate : Form
    {
        private ParfumEntities1 parfumEntities1;
        public ParfumeUpdate()
        {
            InitializeComponent();
            parfumEntities1 = new ParfumEntities1();
        }

        //private void ParfumeUpdate_Load(object sender, EventArgs e)
        //{
        //    DenstiyLoad();
        //    GenderLoad();
        //    BrendLoad();
        //    Load();
        //}
        private void WhenLoad()
        {
            dataGridViewUpdate.DataSource = parfumEntities1.Parfums.Select(x => new 
            {
                Id=x.Id,
                Name=x.Name,
                Description=x.Description,
                Brendd=x.Brend.Name,
                Gender=x.Gender.Name,
                Density=x.Density.Name

            }).ToArray();
        }
       
        private void DenstiyLoad()
        {
            combDensity.DropDownStyle = ComboBoxStyle.DropDownList;
            combDensity.DataSource = parfumEntities1.Densities.Select(x => new Cb_category
            {
                Name=x.Name,
                Id=x.Id
            }).ToArray();
            //var data= parfumEntities1.Densities.Select(x => new Cb_category
            //{
            //    Name = x.Name,
            //    Id = x.Id
            //}).ToArray();
        }

        private void GenderLoad()
        {
            combGender.DropDownStyle = ComboBoxStyle.DropDownList;
            combGender.DataSource = parfumEntities1.Genders.Select(x => new Cb_category
            {
                Name=x.Name,
                Id = x.Id
            }).ToArray();
        } 
        private void BrendLoad()
        {
            combBrend.DropDownStyle = ComboBoxStyle.DropDownList;
            combBrend.DataSource = parfumEntities1.Brends.Select(x => new Cb_category
            {
                Name=x.Name,
                Id=x.Id
            }).ToArray();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string image = textImage.Text.Trim();
            string description = textDescription.Text.Trim();
            int brendId = ((Cb_category)combBrend.SelectedItem).Id;
            int genderId = ((Cb_category)combGender.SelectedItem).Id;
            int densityId = ((Cb_category)combDensity.SelectedItem).Id;
            if (name == null || description == null || image == null)
            {
                MessageBox.Show("Please Fill All TextBox", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DbModel.Parfum parfum = parfumEntities1.Parfums.FirstOrDefault(x => x.Image == image);
            if (parfum == null)
            {
                MessageBox.Show("wrong");
            }
            else
            {
                parfumEntities1.Parfums.Remove(parfum);
                MessageBox.Show("success deleted");
                WhenLoad();
            }
        }

        private void dataGridViewUpdate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = int.Parse(dataGridViewUpdate.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            DbModel.Parfum parfum = parfumEntities1.Parfums.FirstOrDefault(x => x.Id == Id);
            textName.Text = parfum.Name;
            textDescription.Text = parfum.Description;
            textImage.Text = parfum.Image;
            combBrend.Text = parfum.Brend.Name;
            combDensity.Text = parfum.Density.Name;
            combGender.Text = parfum.Gender.Name;
        }

        private void btnUpfate_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string image = textImage.Text.Trim();
            string description = textDescription.Text.Trim();
            int brendId = ((Cb_category)combBrend.SelectedItem).Id;
            int genderId = ((Cb_category)combGender.SelectedItem).Id;
            int densityId = ((Cb_category)combDensity.SelectedItem).Id;
            if (name == null || description == null || image == null)
            {
                MessageBox.Show("Please Fill All TextBox", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DbModel.Parfum parfum = parfumEntities1.Parfums.FirstOrDefault(x => x.Image == image);
            if (parfum == null)
            {
                MessageBox.Show("wrong");
            }
            else
            {
                    parfum.Name = name;
                    parfum.Image = image;
                    parfum.Description = description;
                    parfum.BrendID = brendId;
                    parfum.GenderId = genderId;
                    parfum.DensityId = densityId;
                    parfumEntities1.SaveChanges();
                    MessageBox.Show("success");
            }
            WhenLoad();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string image = textImage.Text.Trim();
            string description = textDescription.Text.Trim();
            int brendId = ((Cb_category)combBrend.SelectedItem).Id;
            int genderId = ((Cb_category)combGender.SelectedItem).Id;
            int densityId = ((Cb_category)combDensity.SelectedItem).Id;
            if (name == null || description == null || image == null )
            {
                MessageBox.Show("Please Fill All TextBox", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DbModel.Parfum parfum = new Parfum
                {
                    BrendID = brendId,
                    Name = name,
                    Image=image,
                    Description = description,
                    GenderId = genderId,
                    New = true,
                    DensityId = densityId
                };
                parfumEntities1.Parfums.Add(parfum);
                parfumEntities1.SaveChanges();
                MessageBox.Show("success ");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void ParfumeUpdate_Load_1(object sender, EventArgs e)
        {
            
        }

        private void ParfumeUpdate_Load(object sender, EventArgs e)
        {
            DenstiyLoad();
            GenderLoad();
            BrendLoad();
            WhenLoad();
        }
    }
}