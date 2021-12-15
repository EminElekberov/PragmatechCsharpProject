using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform17
{
    public partial class Form1 : Form
    {
      public static List<Student> _student;
      public static List<Group> _group;
        public Form1()
        {
            _student = new List<Student>();
            _group = new List<Group>();
            InitializeComponent();
            _group.Add(new Group("P124"));
            _group.Add(new Group("P189"));
            _group.Add(new Group("P789"));
            _group.Add(new Group("P985"));
            _group.Add(new Group("P153"));
            _group.Add(new Group("P985"));
            foreach (var item in _group)
            {
                cmb_select.Items.Add(item.Number);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //   cmb_select.Items.AddRange =tg54
            cmb_select.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string bName = txt_name.Text.Trim();
            string bSurname = txt_surname.Text.Trim();
           string bGorupNo=cmb_select.Text.Trim();
            try
            {
                Student st = new Student()
                {
                    Name = bName,
                    Surname = bSurname,
                    GroupNo = bGorupNo
                };
                _student.Add(st);
            }
            catch (Exception ex)
            {

                MessageBox.Show("xais olunur xanali doldurun ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             dt_grid.DataSource = _student;
        }
        private void ListStudent()
        {
            dt_grid.DataSource = cmb_select;
        }
        private void cmb_select_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string name = cmb_select.Text.Trim();
            foreach (Student item in _student)
            {
                if (cmb_select.Text.Trim() == item.Name)
                {
                    dt_grid.DataSource = _student;
                }
            }
            ListStudent();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(_student,_group);
            f2.ShowDialog(); 
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdate formUpdate = new FormUpdate(_student,_group);

            formUpdate.ShowDialog();
        }
       
    }
}
