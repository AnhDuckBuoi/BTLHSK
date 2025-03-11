
namespace BTL_HSK
{
    partial class LoginForm
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
            this.lb_dang_nhap = new System.Windows.Forms.Label();
            this.lb_tai_khoan = new System.Windows.Forms.Label();
            this.btn_dang_nhap = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_mat_khau = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_dang_ki = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_dang_nhap
            // 
            this.lb_dang_nhap.AutoSize = true;
            this.lb_dang_nhap.Location = new System.Drawing.Point(151, 8);
            this.lb_dang_nhap.Name = "lb_dang_nhap";
            this.lb_dang_nhap.Size = new System.Drawing.Size(78, 17);
            this.lb_dang_nhap.TabIndex = 0;
            this.lb_dang_nhap.Tag = "";
            this.lb_dang_nhap.Text = "Đăng nhập";
            this.lb_dang_nhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_tai_khoan
            // 
            this.lb_tai_khoan.AutoSize = true;
            this.lb_tai_khoan.Location = new System.Drawing.Point(28, 9);
            this.lb_tai_khoan.Name = "lb_tai_khoan";
            this.lb_tai_khoan.Size = new System.Drawing.Size(71, 17);
            this.lb_tai_khoan.TabIndex = 1;
            this.lb_tai_khoan.Text = "Tài khoản";
            // 
            // btn_dang_nhap
            // 
            this.btn_dang_nhap.Location = new System.Drawing.Point(31, 109);
            this.btn_dang_nhap.Name = "btn_dang_nhap";
            this.btn_dang_nhap.Size = new System.Drawing.Size(178, 38);
            this.btn_dang_nhap.TabIndex = 4;
            this.btn_dang_nhap.Text = "Đăng nhập";
            this.btn_dang_nhap.UseVisualStyleBackColor = true;
            this.btn_dang_nhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown_1);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lb_mat_khau
            // 
            this.lb_mat_khau.AutoSize = true;
            this.lb_mat_khau.Location = new System.Drawing.Point(28, 56);
            this.lb_mat_khau.Name = "lb_mat_khau";
            this.lb_mat_khau.Size = new System.Drawing.Size(66, 17);
            this.lb_mat_khau.TabIndex = 7;
            this.lb_mat_khau.Text = "Mật khẩu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lb_mat_khau);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btn_dang_nhap);
            this.panel1.Controls.Add(this.lb_tai_khoan);
            this.panel1.Location = new System.Drawing.Point(66, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 198);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BTL_HSK.Properties.Resources.show1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(279, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.Enter += new System.EventHandler(this.button1_Enter);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // lbl_dang_ki
            // 
            this.lbl_dang_ki.AutoSize = true;
            this.lbl_dang_ki.Location = new System.Drawing.Point(95, 206);
            this.lbl_dang_ki.Name = "lbl_dang_ki";
            this.lbl_dang_ki.Size = new System.Drawing.Size(182, 17);
            this.lbl_dang_ki.TabIndex = 11;
            this.lbl_dang_ki.TabStop = true;
            this.lbl_dang_ki.Text = "Chưa có tài khoản? Đăng kí";
            this.lbl_dang_ki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_dang_ki_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.lbl_dang_ki);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_dang_nhap);
            this.Name = "LoginForm";
            this.Tag = "Đăng nhập";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_dang_nhap;
        private System.Windows.Forms.Label lb_tai_khoan;
        private System.Windows.Forms.Button btn_dang_nhap;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_mat_khau;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lbl_dang_ki;
    }
}