using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace winformders15
{
    public partial class random : Form
    {
        public random()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            Random select = new Random();
            int i = listBox1.Items.Count;
            int chooseItem = select.Next(0, i);
            listBox1.SelectedIndex = chooseItem;
            MessageBox.Show("the select name : " + listBox1.SelectedItem.ToString());
        }
    }
}
