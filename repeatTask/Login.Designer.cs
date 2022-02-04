
namespace LibraryApi
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.txtPassLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAdminPassLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminEmailLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(1, 208);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnRegister);
            this.tabPage1.Controls.Add(this.BtnLogin);
            this.tabPage1.Controls.Add(this.txtPassLogin);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtEmailLogin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adminstrator Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(454, 281);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(189, 36);
            this.BtnRegister.TabIndex = 15;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click_1);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(161, 281);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(189, 36);
            this.BtnLogin.TabIndex = 14;
            this.BtnLogin.Text = "login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click_1);
            // 
            // txtPassLogin
            // 
            this.txtPassLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassLogin.Location = new System.Drawing.Point(297, 236);
            this.txtPassLogin.Name = "txtPassLogin";
            this.txtPassLogin.PasswordChar = '*';
            this.txtPassLogin.Size = new System.Drawing.Size(268, 28);
            this.txtPassLogin.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(303, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmailLogin.Location = new System.Drawing.Point(297, 61);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(268, 28);
            this.txtEmailLogin.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(303, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(788, 324);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtAdminPassLogin);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtAdminEmailLogin);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.ForeColor = System.Drawing.Color.Blue;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin Login";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(310, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAdminPassLogin
            // 
            this.txtAdminPassLogin.Location = new System.Drawing.Point(310, 232);
            this.txtAdminPassLogin.Name = "txtAdminPassLogin";
            this.txtAdminPassLogin.Size = new System.Drawing.Size(189, 26);
            this.txtAdminPassLogin.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Chartreuse;
            this.label4.Location = new System.Drawing.Point(304, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password";
            // 
            // txtAdminEmailLogin
            // 
            this.txtAdminEmailLogin.Location = new System.Drawing.Point(310, 63);
            this.txtAdminEmailLogin.Name = "txtAdminEmailLogin";
            this.txtAdminEmailLogin.Size = new System.Drawing.Size(189, 26);
            this.txtAdminEmailLogin.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Chocolate;
            this.label5.Location = new System.Drawing.Point(304, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(788, 328);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox txtPassLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtAdminPassLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdminEmailLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}