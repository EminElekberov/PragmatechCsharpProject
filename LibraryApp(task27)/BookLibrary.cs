using LibraryApp_task27_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp_task27_
{
    public partial class BookLibrary : Form
    {
        private readonly LibraryDbEntities2 _db;

        public BookLibrary()
        {
            InitializeComponent();
            _db = new LibraryDbEntities2();
        }

        private void BookLibrary_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Books.Where(m => m.IsDeleted == false).Select(x => new
            {
                x.FullName,
                Type = x.Typess.FullName,
               
            }).ToList();
        }
    }
}
