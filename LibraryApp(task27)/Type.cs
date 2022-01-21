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
    public partial class Type : Form
    {
        private readonly LibraryDbEntities2 _db;

        public Type()
        {
            InitializeComponent();
            _db = new LibraryDbEntities2();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            string typeName = txtType.Text.Trim();
            if (typeName == "")
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_db.Typesses.Any(x=>x.FullName==typeName))
            {
                MessageBox.Show("Bu ad var", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LibraryApp_task27_.Model.Typess typess = new Model.Typess
            {
                FullName = typeName
            };
            _db.Typesses.Add(typess);
            _db.SaveChanges();
            MessageBox.Show("Successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void Type_Load(object sender, EventArgs e)
        {

        }
    }
}
