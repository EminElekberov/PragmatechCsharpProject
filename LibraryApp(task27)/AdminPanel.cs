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
            int id = ((Cb_Type)comboBox1.SelectedItem).Id;
          // string name = ((Cb_Type)comboBox1.SelectedItem).Name;
            dataGridView1.DataSource = _db.Books.Where(m => m.IsDeleted == false && m.UserID==id).Select(m => new
            {
                UserId = (int)m.UserID,
                Price = (float)m.Price,
                Name = m.FullName
            }).ToArray();
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
            TimeSpan sp = endDate - toDay;
            int days = sp.Days;
            if (days>0)
            {
                double otherMany = (price * 0.3) * days + price;
                CheckLabel.Text = "Bu kitab " + days.ToString()+" gecikib ve elave odenis "+ otherMany.ToString();

            }
            else
            {
                MessageBox.Show("Kitab Ugurla qaytardi", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numericUpDown1.Value = 0;
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
