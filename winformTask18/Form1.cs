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
        public List<Student> students;
        public List<string> img;
        public Form1()
        {
            img = new List<string>();
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
            string file_location;

            try
            {
                file_location = img[0];
                Student st = new Student
                {
                    Name = fname,
                    Surname = fsurname,
                    Email = femail,
                    Img_Location=file_location
                };
                students.Add(st);
                pictureBox1.Image = null;
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
            if (dialog == DialogResult.OK)
            {
                if (img.Count != 0)
                {
                    img.Clear();
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Load(openFileDialog1.FileName);
                img.Add(openFileDialog1.FileName);
            }
        }

        private void btnStudentMenu_Click(object sender, EventArgs e)
        {
            StudentMenu studentMenu = new StudentMenu(students);
            studentMenu.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
