using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace winform17
{
    public partial class FormUpdate : Form
    {
        List<Student> student;
        List<Group> group;
        public FormUpdate(List<Student> students, List<Group> groups)
        {

            this.student = students;
            this.group = groups;
            InitializeComponent();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            // cmb_studentUpdate.Items.Clear();
            foreach (Student book in student)
            {
                cmb_GroupUpdate.Items.Add(book.GroupNo);
              //  if (cmb_GroupUpdate.Text.Trim()==book.GroupNo)
                //{
                cmb_studentUpdate.Items.AddRange(student.ToArray());

                //}
            }
        }

        private void cmb_GroupUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_studentUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string nm = txt_nameUpdate.Text.Trim();
                string srnm = txt_surnameUpdate.Text.Trim();
                string updateNmAndSRNM = nm + " " + srnm;
                if (txt_nameUpdate != null && txt_surnameUpdate != null)
                {
                    int selectedindex = cmb_studentUpdate.SelectedIndex;
                    cmb_studentUpdate.Items.RemoveAt(selectedindex);
                    cmb_studentUpdate.Items.Insert(selectedindex, updateNmAndSRNM);
                    cmb_studentUpdate.DropDownStyle = ComboBoxStyle.DropDownList;

                    MessageBox.Show("Name and surname was updated ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("fill name and surname ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("please, fill name and surname ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
