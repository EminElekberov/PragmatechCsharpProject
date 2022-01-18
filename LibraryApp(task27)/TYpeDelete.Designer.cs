
namespace LibraryApp_task27_
{
    partial class TYpeDelete
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
            this.BtnTypeDelete = new System.Windows.Forms.Button();
            this.cmbDeleteType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnTypeDelete
            // 
            this.BtnTypeDelete.Location = new System.Drawing.Point(68, 106);
            this.BtnTypeDelete.Name = "BtnTypeDelete";
            this.BtnTypeDelete.Size = new System.Drawing.Size(155, 41);
            this.BtnTypeDelete.TabIndex = 5;
            this.BtnTypeDelete.Text = "Delete";
            this.BtnTypeDelete.UseVisualStyleBackColor = true;
            this.BtnTypeDelete.Click += new System.EventHandler(this.BtnTypeDelete_Click);
            // 
            // cmbDeleteType
            // 
            this.cmbDeleteType.FormattingEnabled = true;
            this.cmbDeleteType.Location = new System.Drawing.Point(31, 56);
            this.cmbDeleteType.Name = "cmbDeleteType";
            this.cmbDeleteType.Size = new System.Drawing.Size(231, 21);
            this.cmbDeleteType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type";
            // 
            // TYpeDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 177);
            this.Controls.Add(this.BtnTypeDelete);
            this.Controls.Add(this.cmbDeleteType);
            this.Controls.Add(this.label1);
            this.Name = "TYpeDelete";
            this.Text = "TYpeDelete";
            this.Load += new System.EventHandler(this.TYpeDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTypeDelete;
        private System.Windows.Forms.ComboBox cmbDeleteType;
        private System.Windows.Forms.Label label1;
    }
}