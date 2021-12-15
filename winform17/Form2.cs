using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace winform17
{
    public partial class Form2 : Form
    {
        List<Student> studentDelete;
        List<Group> groupDelete;
        public Form2(List<Student> studentsdel, List<Group> groupsdel)
        {
            this.studentDelete = studentsdel;
            this.groupDelete = groupsdel;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_StudentDelete.Text.Trim() != null)
                {
                    if (MessageBox.Show("Do you want remove ","remove alert",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        int selectGorupNumberDelete = cmb_GroupDelete.SelectedIndex;
                        cmb_GroupDelete.Items.RemoveAt(selectGorupNumberDelete);
                        cmb_GroupDelete.DropDownStyle = ComboBoxStyle.DropDownList;
                        int selectedindex = cmb_StudentDelete.SelectedIndex;
                        cmb_StudentDelete.Items.RemoveAt(selectedindex);
                        cmb_StudentDelete.DropDownStyle = ComboBoxStyle.DropDownList;
                        MessageBox.Show("deleted succesfull ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("data doesn't removed ", "Not remove", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception )
            {
                MessageBox.Show("melumatlari secin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var book in studentDelete)
            {
                cmb_GroupDelete.Items.Add(book.GroupNo);
            }

            cmb_StudentDelete.Items.AddRange(studentDelete.ToArray());
        }
    }
}
