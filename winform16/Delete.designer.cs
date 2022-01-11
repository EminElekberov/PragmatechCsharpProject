namespace winform16
{
    partial class Delete
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStuDelete = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroupDelete = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(49, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(246, 80);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(84, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Student";
            // 
            // cmbStuDelete
            // 
            this.cmbStuDelete.FormattingEnabled = true;
            this.cmbStuDelete.Location = new System.Drawing.Point(49, 197);
            this.cmbStuDelete.Name = "cmbStuDelete";
            this.cmbStuDelete.Size = new System.Drawing.Size(246, 21);
            this.cmbStuDelete.TabIndex = 9;
            this.cmbStuDelete.SelectedIndexChanged += new System.EventHandler(this.cmbStuDelete_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Group";
            // 
            // cmbGroupDelete
            // 
            this.cmbGroupDelete.FormattingEnabled = true;
            this.cmbGroupDelete.Location = new System.Drawing.Point(49, 73);
            this.cmbGroupDelete.Name = "cmbGroupDelete";
            this.cmbGroupDelete.Size = new System.Drawing.Size(246, 21);
            this.cmbGroupDelete.TabIndex = 7;
            this.cmbGroupDelete.SelectedIndexChanged += new System.EventHandler(this.cmbGroupDelete_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 412);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStuDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGroupDelete);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStuDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroupDelete;
    }
}