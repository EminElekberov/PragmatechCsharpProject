using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformTask18
{
    public partial class Form1 : Form
    {
       public  List<Student> students;
        public Form1()
        {
            students = new List<Student>();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fname = txtName.Text.Trim();
            string fsurname = txtSurname.Text.Trim();
            string femail = txtEmail.Text.Trim();
            try
            {
                Student st = new Student
                {
                    Name = fname,
                    Surname = fsurname,
                    Email = femail
                };
                students.Add(st);
                MessageBox.Show("Tebrikler elave olundunuz ", "Success", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("xais olunur xanali doldurun ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #region
            //string fName = txtName.Text.Trim();
            //string fSurname = txtSurname.Text.Trim();
            //string fEmail = txtEmail.Text.Trim();
            //try
            //{
            //    Student st = new Student
            //    {
            //        Name = fName,
            //        Surname = fSurname,
            //        Email = fEmail

            //    };
            //    students.Add(st);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("xais olunur xanali doldurun ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
            #endregion
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFileDialog1.ShowDialog();
            if (dialog==DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void btnStudentMenu_Click(object sender, EventArgs e)
        {
            StudentMenu studentMenu = new StudentMenu(students);
            studentMenu.ShowDialog();
        }
    }
}
