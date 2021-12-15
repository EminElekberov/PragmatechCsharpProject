
namespace winformders15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBook = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBookIsbn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listRead = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.cmbReadyBook = new System.Windows.Forms.ComboBox();
            this.txtReadyBook = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(353, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOMEWORK";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage1.Controls.Add(this.listBook);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtBookIsbn);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtBookName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbType);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Page";
            // 
            // listBook
            // 
            this.listBook.FormattingEnabled = true;
            this.listBook.ItemHeight = 15;
            this.listBook.Location = new System.Drawing.Point(4, 201);
            this.listBook.Name = "listBook";
            this.listBook.Size = new System.Drawing.Size(770, 139);
            this.listBook.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(269, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(248, 50);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Elave et";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBookIsbn
            // 
            this.txtBookIsbn.Location = new System.Drawing.Point(409, 41);
            this.txtBookIsbn.Name = "txtBookIsbn";
            this.txtBookIsbn.Size = new System.Drawing.Size(155, 23);
            this.txtBookIsbn.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "ISBN no";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(195, 41);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(155, 23);
            this.txtBookName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitabin Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipi";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Action",
            "Horror",
            "History",
            "Politics",
            "Self-Hep",
            "Autobiography",
            "Cookbook"});
            this.cmbType.Location = new System.Drawing.Point(6, 41);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 23);
            this.cmbType.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listRead);
            this.tabPage2.Controls.Add(this.btnRead);
            this.tabPage2.Controls.Add(this.cmbReadyBook);
            this.tabPage2.Controls.Add(this.txtReadyBook);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ready book";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listRead
            // 
            this.listRead.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listRead.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listRead.ForeColor = System.Drawing.Color.Maroon;
            this.listRead.FormattingEnabled = true;
            this.listRead.ItemHeight = 18;
            this.listRead.Location = new System.Drawing.Point(7, 211);
            this.listRead.Name = "listRead";
            this.listRead.Size = new System.Drawing.Size(764, 128);
            this.listRead.TabIndex = 3;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(316, 132);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(180, 53);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Sec";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // cmbReadyBook
            // 
            this.cmbReadyBook.FormattingEnabled = true;
            this.cmbReadyBook.Items.AddRange(new object[] {
            "Action",
            "Horror",
            "History",
            "Politics",
            "Self-Hep",
            "Autobiography",
            "Cookbook"});
            this.cmbReadyBook.Location = new System.Drawing.Point(7, 54);
            this.cmbReadyBook.Name = "cmbReadyBook";
            this.cmbReadyBook.Size = new System.Drawing.Size(121, 23);
            this.cmbReadyBook.TabIndex = 1;
            this.cmbReadyBook.SelectedIndexChanged += new System.EventHandler(this.cmbReadyBook_SelectedIndexChanged);
            // 
            // txtReadyBook
            // 
            this.txtReadyBook.AutoSize = true;
            this.txtReadyBook.Font = new System.Drawing.Font("Swis721 Hv BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtReadyBook.Location = new System.Drawing.Point(316, 16);
            this.txtReadyBook.Name = "txtReadyBook";
            this.txtReadyBook.Size = new System.Drawing.Size(152, 25);
            this.txtReadyBook.TabIndex = 0;
            this.txtReadyBook.Text = "Hazir kitablar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox listBook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBookIsbn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listRead;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ComboBox cmbReadyBook;
        private System.Windows.Forms.Label txtReadyBook;
    }
}

