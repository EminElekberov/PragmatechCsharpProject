using Pf.DbModel;
using Pf.Helper;
using System;
using System.Linq;
using System.Windows.Forms;


namespace Pf
{
    public partial class SalePrice : Form
    {
        private ParfumEntities1 parfumEntities1;

        public SalePrice()
        {
            InitializeComponent();
            parfumEntities1 = new ParfumEntities1();
        }


        private void SalePrice_Load(object sender, EventArgs e)
        {
            WhenWiewLoad();
            WhenWiewSizeLoad();
        }
        public void WhenWiewLoad()
        {
            combSearchName.DropDownStyle = ComboBoxStyle.DropDownList;
            combSearchName.DataSource = parfumEntities1.Parfums.Select(x => new Cb_category
            {
                Id = x.Id,
                Name = x.Name
            }).ToArray();
        }
        public void WhenWiewSizeLoad()
        {
            combSize.DropDownStyle = ComboBoxStyle.DropDownList;
            combSize.DataSource = parfumEntities1.SizeMls.Select(x => new Cb_category
            {
                Id = x.Id,
                Name=x.SizeMl1.ToString()
            }).ToArray();
        }

        //Save 
        private void button1_Click(object sender, EventArgs e)
        {

        }


        public void ChangeSize()
        {
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int SearchName = ((Cb_category)combSearchName.SelectedItem).Id;
            int Sizecomb = ((Cb_category)combSize.SelectedItem).Id;
            int price = Convert.ToInt32(textPrice.Text.Trim());
            int count = Convert.ToInt32(textNumber.Text.Trim());
            if (price==null || count==null)
            {
                MessageBox.Show("please insert information");
            }
            else
            {
                DbModel.Saleprice saleprice = new Saleprice
                {
                    ParfumID=SearchName,
                    SizeMlId=Sizecomb,
                    Price=price,
                    Count=count
                };
            }
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChangeInfo()
        {
        }

        // Data Grid View Price List
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void ClearInfo()
        {

        }
    }
}
