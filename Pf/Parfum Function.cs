using Pf.DbModel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;



namespace Pf
{
    public partial class Parfum_Function : Form
    {
        private ParfumEntities1 parfumEntities1;

        public Parfum_Function()
        {
            InitializeComponent();
            parfumEntities1 = new ParfumEntities1();
        }

        private void Parfum_Function_Load(object sender, EventArgs e)
        {
            // Parfum Load 
            WhenLoad();
           
        }
        private void WhenLoad()
        {
            dataGridView1.DataSource = parfumEntities1.Parfums.Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Brendd = x.Brend.Name,
                Gender = x.Gender.Name,
                Density = x.Density.Name

            }).ToArray();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ParfumeUpdate parfumeUpdate = new ParfumeUpdate();
            parfumeUpdate.ShowDialog();
        }


        public void ChangeParfum()
        {
        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            WhenLoad();
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
                dataGridView1.DataSource = parfumEntities1.Parfums.Where(x => x.Name == searchName).Select(x => new
                {
                    Name = x.Name,
                    Image = x.Image,
                    Description = x.Description,
                    Gender = x.Gender.Name,
                    Brend = x.Brend.Name
                }).ToArray();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
