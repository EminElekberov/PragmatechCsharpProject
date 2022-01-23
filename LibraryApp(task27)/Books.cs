using LibraryApp_task27_.Helper;
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
    public partial class Books : Form
    {
        private readonly LibraryDbEntities2 _db;
        public Books()
        {
            InitializeComponent();
            _db = new LibraryDbEntities2();
        }

        private void bookListdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = _db.Login_Users.Where(n => n.IsDeleted == false).Select(n => new Cb_Type
            {
                Id = n.Id,
                Name = n.FullName
            }).ToArray();
            cmbName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.DataSource = _db.Typesses.Where(x => x.Deleted == false).Select(x => new Cb_Type
            {
                Id = x.Id,
                Name = x.FullName
            }).ToList();
        }
        public void Refreshdgv()
        {
            bookListdgv.DataSource = _db.Books.Where(m => m.IsDeleted == false).Select(x => new
            {
                x.FullName,
                Type = x.Typess.FullName,
                x.Buybook,
                x.SendBook
            }).ToList();
        }
        public void Refreshdgv2()
        {
            DateTime buy = buyBookTime.Value;
            DateTime give = sendBookTime.Value;
            bookListdgv.DataSource = _db.Books.Where(m => m.IsDeleted == false).Select(x => new
            {
                x.FullName,
                Type = x.Typess.FullName,
                buy = buy,
                give = give
            }).ToList();
        }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Cb_Type)cmbType.SelectedItem).Id;
            cmbName.DataSource = _db.Books.Where(m => m.IsDeleted == false && m.TypesId == id).Select(m => new Cb_boooks
            {
                FullName=m.FullName,
                Id=m.Id,
                Price=(double)m.Price
            }).ToArray();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int UserId = ((Cb_Type)comboBox1.SelectedItem).Id;
            int id = ((Cb_Type)cmbType.SelectedItem).Id;
            DateTime buy = buyBookTime.Value;
            DateTime give = sendBookTime.Value;
            string name = cmbName.Text;
            //Books books1 = _db.Books.FirstOrDefault(x => x.UserID = UserId);
           
            Model.Book book = _db.Books.FirstOrDefault(x => x.Id == id);
            Model.Book bookSaveDb = new Model.Book
            {
                FullName = name,
                UserID=UserId,
                TypesId = id,
                Price=double.Parse(textBox1.Text),
                //Price=
                //Price=_db.Books.FirstOrDefault(x=>Convert.ToInt32(x.Price)==id),
                Buybook = buy,
                SendBook = give,
                IsDeleted=true
            };
            bookListdgv.DataSource = _db.Books.Where(m => m.IsDeleted == false && m.TypesId == id).Select(m => new
            {
                // Name=m.UserID,
                m.Id,
                m.FullName,
                Type = m.Typess.FullName,
                Price = m.Price,
                buy = buy,
                give = give
            }).ToList();
            _db.Books.Add(bookSaveDb);
            _db.SaveChanges();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price = ((Cb_boooks)cmbName.SelectedItem).Price;

            textBox1.Text = price.ToString();
           // textBox1.Text=_db.Books.Select(n=>n.)
            //  cmbName.DataSource=bk.Price.Select(c=>c.) 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buyBookTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sendBookTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updateAndAddBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAndAddBook updateAndAddBook = new UpdateAndAddBook();
            updateAndAddBook.ShowDialog();
        }
    }
}
