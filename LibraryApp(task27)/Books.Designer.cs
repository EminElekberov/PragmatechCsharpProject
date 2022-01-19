
namespace LibraryApp_task27_
{
    partial class Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buyBookTime = new System.Windows.Forms.DateTimePicker();
            this.sendBookTime = new System.Windows.Forms.DateTimePicker();
            this.bookListdgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateAndAddBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bookListdgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(10, 60);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(131, 21);
            this.cmbType.TabIndex = 13;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(205, 60);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(131, 21);
            this.cmbName.TabIndex = 14;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buyBookTime
            // 
            this.buyBookTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.buyBookTime.Location = new System.Drawing.Point(405, 60);
            this.buyBookTime.Name = "buyBookTime";
            this.buyBookTime.Size = new System.Drawing.Size(103, 20);
            this.buyBookTime.TabIndex = 16;
            this.buyBookTime.ValueChanged += new System.EventHandler(this.buyBookTime_ValueChanged);
            // 
            // sendBookTime
            // 
            this.sendBookTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sendBookTime.Location = new System.Drawing.Point(599, 57);
            this.sendBookTime.Name = "sendBookTime";
            this.sendBookTime.Size = new System.Drawing.Size(112, 20);
            this.sendBookTime.TabIndex = 17;
            this.sendBookTime.Value = new System.DateTime(2022, 1, 18, 18, 41, 24, 0);
            this.sendBookTime.ValueChanged += new System.EventHandler(this.sendBookTime_ValueChanged);
            // 
            // bookListdgv
            // 
            this.bookListdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookListdgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookListdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListdgv.Location = new System.Drawing.Point(2, 206);
            this.bookListdgv.Name = "bookListdgv";
            this.bookListdgv.Size = new System.Drawing.Size(794, 240);
            this.bookListdgv.TabIndex = 18;
            this.bookListdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookListdgv_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Buy date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Give Back";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(259, 120);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(271, 48);
            this.BtnAdd.TabIndex = 21;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateAndAddBookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateAndAddBookToolStripMenuItem
            // 
            this.updateAndAddBookToolStripMenuItem.Name = "updateAndAddBookToolStripMenuItem";
            this.updateAndAddBookToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.updateAndAddBookToolStripMenuItem.Text = "Update and Add Book";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookListdgv);
            this.Controls.Add(this.sendBookTime);
            this.Controls.Add(this.buyBookTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookListdgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker buyBookTime;
        private System.Windows.Forms.DateTimePicker sendBookTime;
        private System.Windows.Forms.DataGridView bookListdgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateAndAddBookToolStripMenuItem;
    }
}