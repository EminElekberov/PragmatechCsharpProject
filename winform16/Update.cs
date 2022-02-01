using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform16
{
    public partial class Update : Form
    {
        private ComboBox _cmb;
        private DataGridView _dgv;
        public Update(List<Group> groups, ComboBox cmb, DataGridView dgv)
        {
            InitializeComponent();
            _cmb = cmb;
            _dgv = dgv;
            cmbGroupUpdate.Items.AddRange(groups.ToArray());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string nm = txtNameUpdate.Text.Trim();
            string srnm = txtSurnameUpdate.Text.Trim();
            string updateNmAndSRNM = nm + " " + srnm;
            Group selectgroup = cmbGroupUpdate.SelectedItem as Group;
            Student selectStudent = cmbStuUpdate.SelectedItem as Student;
            if (txtNameUpdate != null && txtSurnameUpdate != null)
            {
                selectStudent.name = txtNameUpdate.Text;
                selectStudent.Surname = txtSurnameUpdate.Text;
                MessageBox.Show("Name and surname was updated ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //diger formda deyisik;ik  etmek
                if (selectgroup == (Group)_cmb.SelectedItem)
                {
                    _dgv.DataSource = null;
                    _dgv.DataSource = selectgroup.GetAlLStudent();
                }
            }
            //
            else
            {
                MessageBox.Show("fill name and surname ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void cmbGroupUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selected_group = cmbGroupUpdate.SelectedItem as Group;
            cmbStuUpdate.Items.Clear();
            cmbStuUpdate.Text = "";
            cmbStuUpdate.Items.AddRange(selected_group.GetAlLStudent().ToArray());
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void cmbStuUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
