using repeatTask.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace repeatTask
{
    public partial class AddReader : Form
    {
        private readonly LibraryEntities _db;

        public AddReader()
        {
            InitializeComponent();
            _db = new LibraryEntities();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string email = txtemail.Text.Trim();
            string identity = txtidentity.Text.Trim();
            Model.Reader reader = _db.Readers.FirstOrDefault(x => x.Email.ToLower() == email);
            if (reader==null)
            {
                Reader addreader = new Reader
                {
                    Fullanme=name,
                    Email=email,
                    IdentityNum=identity
                };
                _db.Readers.Add(addreader);
            }
            else
            {
                MessageBox.Show("Bu id adam var xahis olunur dogru buttoun secesiz");

            }
            _db.SaveChanges();
            DgvRrefresh();
            MessageBox.Show("success");
        }

        private void AddReader_Load(object sender, EventArgs e)
        {
            DgvRrefresh();
        }
        private void DgvRrefresh()
        {
            dataGridView1.DataSource = _db.Readers.Select(x => new
            {
                x.Id,
                x.Fullanme,
                x.IdentityNum
            }).ToArray();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string email = txtemail.Text.Trim();
            string identity = txtidentity.Text.Trim();
            Model.Reader reader = _db.Readers.FirstOrDefault(x => x.Email.ToLower() == email);
            if (reader == null)
            {
                Reader addreader = new Reader
                {
                    Fullanme = name,
                    Email = email,
                    IdentityNum = identity
                };
                _db.Readers.Add(addreader);
            }
            else
            {
                reader.Fullanme = name;
                reader.IdentityNum = identity;
            }
            _db.SaveChanges();
            DgvRrefresh();
            MessageBox.Show("success");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            Model.Reader reader = _db.Readers.FirstOrDefault(x => x.Id == id);
            txtemail.Text = reader.Email;
            txtidentity.Text = reader.IdentityNum;
            txtname.Text = reader.Fullanme;
        }
    }
}
