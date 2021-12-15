using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformders15
{
    public partial class Form1 : Form
    {
        private List<Book> _book;
        private List<ReadBook> _read;
        
        public Form1()
        {
            _book = new List<Book>();
            _read = new List<ReadBook>();
            InitializeComponent();
            _read.Add(new ReadBook("EAST OF EDEN", "Action", "1898"));
            _read.Add(new ReadBook("THE HOUSE OF MIRTH", "Horror", "484"));
            _read.Add(new ReadBook("THE SUN ALSO RISES", "Joke", "847"));
            _read.Add(new ReadBook("VILE BODIES", "Horror", "15615"));
            _read.Add(new ReadBook("A SCANNER DARKLY", "Detective", "4445"));
            _read.Add(new ReadBook("MOAB IS MY WASHPOT", "Amusemet", "15615"));
            _read.Add(new ReadBook("NUMBER THE STARS", "Horror", "15615"));
            _read.Add(new ReadBook("NOLI ME TANGERE", "Detective", "15615"));
            _read.Add(new ReadBook("BRAVE NEW WORLD", "Amusement", "15615"));
            foreach (var item in _read)
            {
                listRead.Items.Add(item);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bType = cmbType.Text.Trim();
            string bName = txtBookName.Text.Trim();
            int bNo = Convert.ToInt32(txtBookIsbn.Text.Trim());
            try
            {
                Book book = new Book()
                {
                    Name = bName,
                    Type = bType,
                    Isbn = bNo
                };
                _book.Add(book);
            }
            catch (Exception)
            {
                MessageBox.Show("xais olunur xanali doldurun ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FillLIst();
        }
        private void FillLIst()
        {
            listBook.Items.Clear();//updte edir. demelio bunun  yazmasa idik bizim evvelce yadigimiz melumatlarda yeniden gelecekdi
            foreach (var item in _book)
            {
                listBook.Items.Add(item.FullNameBook);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
                listRead.Items.Clear();
                string readyBook = cmbReadyBook.Text.Trim();
                foreach (var item in _read)
                {
                    if (readyBook == item.Genre)
                    {
                        listRead.Items.Add(item);
                    }
                }
                MessageBox.Show("xais olunur kitab  tipi secin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Search()
        {
           
            listRead.Items.Clear();
            foreach (var item in _read)
            {
                if (cmbReadyBook.Text.Trim() == item.ReadyBook.ToString())
                {
                    listRead.Items.Add(item.ReadyBook+" "+item.Genre+" "+item.PageNO);
                }
                //if (cmbReadyBook.SelectedItem.ToString()== "EAST OF EDEN ")
                //{
                //    listRead.Items.Add(item.ReadyBook + " kitabi detective typndadir");
                //}
                //else if (cmbReadyBook.SelectedItem.ToString() == "THE HOUSE OF MIRTH ")
                //{
                //    listRead.Items.Add(item.ReadyBook + " kitabi roman typndadir");
                //}

            }
        }

        private void cmbReadyBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            listRead.Items.Clear();
            string readyBook = cmbReadyBook.Text.Trim();
            foreach (ReadBook item in _read)
            {
                if (cmbReadyBook.Text.Trim() == item.Genre)
                {
                    listRead.Items.Add(item);
                }
            }
        }
    }
}
