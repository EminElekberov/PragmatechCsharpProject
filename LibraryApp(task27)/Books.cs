﻿using LibraryApp_task27_.Helper;
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
    public partial class Books : Form
    {
        private readonly LibraryDbEntities1 _db;
        public Books()
        {
            InitializeComponent();
            _db = new LibraryDbEntities1();
        }

        private void bookListdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.DataSource = _db.Typesses.Where(x => x.Deleted == false).Select(x => new Cb_Type
            {
                Id = x.Id,
                Name = x.FullName
            }).ToList();

        }
        public void Refreshdgv()
        {
            bookListdgv.DataSource = _db.Books.Where(m => m.IsDeleted == false).Select(x => new
            {
                x.FullName,
                Type = x.Typess.FullName,
                x.Buybook,
                x.SendBook
            }).ToList();
        }
        public void Refreshdgv2()
        {
            DateTime buy = buyBookTime.Value;
            DateTime give = sendBookTime.Value;
            bookListdgv.DataSource = _db.Books.Where(m => m.IsDeleted == false).Select(x => new
            {
                x.FullName,
                Type = x.Typess.FullName,
                buy = buy,
                give = give
            }).ToList();
        }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Cb_Type)cmbType.SelectedItem).Id;
            cmbName.DataSource = _db.Books.Where(m => m.IsDeleted == false && m.TypesId == id).Select(m => new
            {
                m.FullName
            }).ToArray();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int id = ((Cb_Type)cmbType.SelectedItem).Id;
            DateTime buy = buyBookTime.Value;
            DateTime give = sendBookTime.Value;
            //int typeID = ((Cb_Type)cmbName.SelectedItem).Id;
            bookListdgv.DataSource = _db.Books.Where(m => m.IsDeleted == false && m.TypesId == id).Select(m => new
            {
                m.FullName,
                Type = m.Typess.FullName,
                buy=buy,
                give=give
            }).ToList();
            //Refreshdgv2();
        }
    }
}
