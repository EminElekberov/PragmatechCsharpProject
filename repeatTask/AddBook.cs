using repeatTask.Helper;
using repeatTask.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace repeatTask
{
    public partial class AddBook : Form
    {
        private readonly LibraryEntities _db;
        public static int bookid;
        public AddBook()
        {
            InitializeComponent();
            _db = new LibraryEntities();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.DataSource = _db.Genres.Select(x => new Cb_genre
            {
                Id=x.Id,
                Name=x.Name
            }).ToArray();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int TypeId = ((Cb_genre)cmbGenre.SelectedItem).Id;
            string name = txtAddName.Text.Trim();
            string writer = txtwriter.Text.Trim();
            double price = double.Parse(txtprice.Value.ToString());
            int amount = int.Parse(txtamount.Value.ToString());
            if (name == "" || writer == "" || price == null || amount == null)
            {
                MessageBox.Show("Please Fill All TextBox", "Warning",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Model.Book books = new Book
                {
                    Name = name,
                    Price = price,
                    Writer = writer,
                    IsDeleted = false,
                    Amount = amount
                };
                _db.Books.Add(books);
                _db.SaveChanges();
                MessageBox.Show("success");
            }
        }
       

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int TypeId = ((Cb_genre)cmbGenre.SelectedItem).Id;
            string name = txtAddName.Text.Trim();
            string writer = txtwriter.Text.Trim();
            double price = double.Parse(txtprice.Value.ToString());
            int amount = int.Parse(txtamount.Value.ToString());
            Model.Book updatwBook = _db.Books.FirstOrDefault(x => x.GenreId == bookid);
            if (updatwBook==null)
            {
                MessageBox.Show("This book is not exists");
            }
            else
            {
                updatwBook.GenreId = TypeId;
                updatwBook.Amount = amount;
                updatwBook.Price = price;
                updatwBook.IsDeleted = false;
            }
            _db.SaveChanges();

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TypeId = ((Cb_genre)cmbGenre.SelectedItem).Id;
            string name = txtAddName.Text.Trim();
            string writer = txtwriter.Text.Trim();
            double price = double.Parse(txtprice.Value.ToString());
            int amount = int.Parse(txtamount.Value.ToString());
            Model.Book delBook = _db.Books.FirstOrDefault(x => x.Id == bookid);
            if (delBook!=null)
            {
                _db.Books.Remove(delBook);
            }
            _db.SaveChanges();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void bookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void giveBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }
    }
}