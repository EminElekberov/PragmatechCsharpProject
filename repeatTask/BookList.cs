using repeatTask.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace repeatTask
{
    public partial class BookList : Form
    {
        private readonly LibraryEntities _db;
        public static int bookId;
        public BookList()
        {
            InitializeComponent();
            _db = new LibraryEntities();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            bookDtvgrd.DataSource = _db.Books.Select(x => new 
            {
                x.Id,
                x.Name,
                x.Writer,
                x.Amount,
                x.Price,
                Type = x.Genre.Name
            }).ToArray();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string name = txtSearchname.Text.Trim();
            if (name==null)
            {
                MessageBox.Show("please enter name");
            }
            Model.Book searchBook = _db.Books.FirstOrDefault(x => x.Name == name);
            bookId = searchBook.Id;
            bookDtvgrd.DataSource = _db.Books.Where(x => x.Name == name).Select(x => new
            {
                x.Id,
                x.Name,
                x.Amount,
                x.Price,
                x.Writer,
                Type = x.Genre.Name
            }).ToArray();

        }
    }
}
