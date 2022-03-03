
namespace winform17
{
    partial class Form2
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
            this.cmb_GroupDelete = new System.Windows.Forms.ComboBox();
            this.cmb_StudentDelete = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Group";
            // 
            // cmb_GroupDelete
            // 
            this.cmb_GroupDelete.FormattingEnabled = true;
            this.cmb_GroupDelete.Location = new System.Drawing.Point(72, 64);
            this.cmb_GroupDelete.Name = "cmb_GroupDelete";
            this.cmb_GroupDelete.Size = new System.Drawing.Size(121, 23);
            this.cmb_GroupDelete.TabIndex = 1;
            // 
            // cmb_StudentDelete
            // 
            this.cmb_StudentDelete.FormattingEnabled = true;
            this.cmb_StudentDelete.Location = new System.Drawing.Point(72, 178);
            this.cmb_StudentDelete.Name = "cmb_StudentDelete";
            this.cmb_StudentDelete.Size = new System.Drawing.Size(121, 23);
            this.cmb_StudentDelete.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Student";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(27, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 77);
            this.button1.TabIndex = 4;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_StudentDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_GroupDelete);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_GroupDelete;
        private System.Windows.Forms.ComboBox cmb_StudentDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}