using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tests
{
    public partial class Form1 : Form
    {
        public static List<Group> groups = new List<Group>();
        public Form1()
        {
            Student student = new Student("Emin", "Elekberov");
            Student student2 = new Student("Rasim", "Ehmedov");
            Student student3 = new Student("Eli", "Veliyev");
            Group group = new Group("P500");
            Group group2 = new Group("P550");
            group.AddStudent(student);
            group.AddStudent(student2);
            group2.AddStudent(student3);
            groups.Add(group);
            groups.Add(group2);
            InitializeComponent();
            cmbGroup.Items.AddRange(groups.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            string bName = txtStuName.Text.Trim();
            string bSurname = txtAddSurname.Text.Trim();
            Group select_group = cmbGroup.SelectedItem as Group;
            Student st = new Student(bName, bSurname);
            select_group.AddStudent(st);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = select_group.GetAllStudent();
            txtAddSurname.Text = "";
            txtStuName.Text = "";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(groups,cmbGroup,dataGridView1);
            delete.ShowDialog();
        }
    }
}
