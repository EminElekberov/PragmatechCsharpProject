
namespace winform17
{
    partial class FormUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_GroupUpdate = new System.Windows.Forms.ComboBox();
            this.cmb_studentUpdate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nameUpdate = new System.Windows.Forms.TextBox();
            this.txt_surnameUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Group";
            // 
            // cmb_GroupUpdate
            // 
            this.cmb_GroupUpdate.FormattingEnabled = true;
            this.cmb_GroupUpdate.Location = new System.Drawing.Point(91, 52);
            this.cmb_GroupUpdate.Name = "cmb_GroupUpdate";
            this.cmb_GroupUpdate.Size = new System.Drawing.Size(121, 23);
            this.cmb_GroupUpdate.TabIndex = 1;
            this.cmb_GroupUpdate.SelectedIndexChanged += new System.EventHandler(this.cmb_GroupUpdate_SelectedIndexChanged);
            // 
            // cmb_studentUpdate
            // 
            this.cmb_studentUpdate.FormattingEnabled = true;
            this.cmb_studentUpdate.Location = new System.Drawing.Point(91, 134);
            this.cmb_studentUpdate.Name = "cmb_studentUpdate";
            this.cmb_studentUpdate.Size = new System.Drawing.Size(121, 23);
            this.cmb_studentUpdate.TabIndex = 3;
            this.cmb_studentUpdate.SelectedIndexChanged += new System.EventHandler(this.cmb_studentUpdate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // txt_nameUpdate
            // 
            this.txt_nameUpdate.Location = new System.Drawing.Point(12, 218);
            this.txt_nameUpdate.Name = "txt_nameUpdate";
            this.txt_nameUpdate.Size = new System.Drawing.Size(216, 23);
            this.txt_nameUpdate.TabIndex = 5;
            // 
            // txt_surnameUpdate
            // 
            this.txt_surnameUpdate.Location = new System.Drawing.Point(12, 289);
            this.txt_surnameUpdate.Name = "txt_surnameUpdate";
            this.txt_surnameUpdate.Size = new System.Drawing.Size(216, 23);
            this.txt_surnameUpdate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surname";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(12, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(231, 49);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 408);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txt_surnameUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nameUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_studentUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_GroupUpdate);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdate";
            this.Text = "FormUpdate";
            this.Load += new System.EventHandler(this.FormUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_GroupUpdate;
        private System.Windows.Forms.ComboBox cmb_studentUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nameUpdate;
        private System.Windows.Forms.TextBox txt_surnameUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
    }
}