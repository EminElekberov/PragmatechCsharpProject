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
        }
        public void WhenWiewLoad()
        {
            combSearchName.DataSource = parfumEntities1.Parfums.Select(x => new Cb_category
            {
                Id = x.Id,
                Name = x.Name
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
