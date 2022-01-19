using LibraryApp_task27_.Helper;
using LibraryApp_task27_.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryApp_task27_
{
    public partial class UpdateAndAddBook : Form
    {
        private readonly LibraryDbEntities1 _db;
        public UpdateAndAddBook()
        {
            InitializeComponent();
            _db = new LibraryDbEntities1();
        }

        private void UpdateAndAddBook_Load(object sender, EventArgs e)
        {
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.DataSource = _db.Typesses.Where(x => x.Deleted == false).Select(x => new Cb_Type
            {
                Id = x.Id,
                Name = x.FullName
            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtMedicines.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Please filled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            int typeId = ((Cb_Type)cmbType.SelectedItem).Id;
            float price = float.Parse(txtPrice.Value.ToString());
            LibraryApp_task27_.Model.Book book= _db.Books.FirstOrDefault(x => x.FullName.ToLower() == name);
            if (book==null)
            {
                LibraryApp_task27_.Model.Book book1 = new LibraryApp_task27_.Model.Book()
                {
                    FullName=name,
                    IsDeleted=false,
                    Price=price,
                    TypesId=typeId
                };
                _db.Books.Add(book1);
            }
            else
            {
                MessageBox.Show("bu kitab var", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _db.SaveChanges();
            MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string name = txtMedicines.Text.Trim().ToLower();
            LibraryApp_task27_.Model.Book book = _db.Books.FirstOrDefault(x => x.FullName.ToLower() == name);
            if (book != null)
            {
                book.IsDeleted = true;
                _db.SaveChanges();
                Refreshdgv();
                MessageBox.Show("Deleted", "DEleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("This is not exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void Refreshdgv()
        {
            dtvUpdate.DataSource = _db.Books.Where(m => m.IsDeleted == false).Select(x => new
            {
                x.FullName,
                Type = x.Typess.FullName,
                x.Price
            }).ToList();
        }
        private void dtvUpdate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dtvUpdate.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
            LibraryApp_task27_.Model.Book med = _db.Books.FirstOrDefault(m => m.FullName == name);
            txtMedicines.Text = name;
            txtPrice.Value = decimal.Parse(med.Price.ToString());
            cmbType.SelectedIndex = cmbType.FindString(med.Typess.FullName);
        }
    }
}
