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
    public partial class AdminPanel : Form
    {
        private readonly LibraryDbEntities2 _db;
        public AdminPanel()
        {
            InitializeComponent();
            _db = new LibraryDbEntities2();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = _db.Login_Users.Where(n => n.IsDeleted == false).Select(n => new Cb_Type
            {
                Id = n.Id,
                Name = n.FullName
            }).ToArray();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = ((Cb_Type)comboBox1.SelectedItem).Id;
                dataGridView1.DataSource = _db.Books.Where(m => m.IsDeleted == true && m.UserID == id).Select(m => new
                {
                    UserId = m.UserID,
                    Price = m.Price,
                    Name = m.FullName,
                    SendBook = m.SendBook
                }).ToArray();

            }
            catch (Exception)
            {

                throw;
            }
            // string name = ((Cb_Type)comboBox1.SelectedItem).Name;

        }
        public void Check()
        {
            #region
            //DateTime dt = dateTimePicker1.Value;
            //string dtS = dt.Day.ToString();
            //label2.Text = dtS;
            //int dtI = Convert.ToInt32(dtS);
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = double.Parse(numericUpDown1.Value.ToString());
            DateTime toDay = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;
            TimeSpan sp = toDay - endDate;
            int days = sp.Days;
            if (toDay > endDate)
            {
                double otherMany = (price * 0.3) * days;
                CheckLabel.Text = "Bu kitab " + days.ToString() + " gecikib ve elave odenis " + otherMany.ToString();
            }
            else
            {
                MessageBox.Show("Kitab Ugurla qaytardi", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numericUpDown1.Value = 0;
                dateTimePicker1.Value = DateTime.Now;
            }
            //CheckLabel.Text="";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            Model.Book bk = _db.Books.FirstOrDefault(m => m.FullName == name);
            dateTimePicker2.Value = DateTime.Parse(bk.SendBook.ToString());
            numericUpDown1.Value = decimal.Parse(bk.Price.ToString());
            comboBox1.SelectedIndex = comboBox1.FindString(bk.Typess.FullName);
        }
    }
}
