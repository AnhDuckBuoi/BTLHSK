using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace BTL_HSK
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tên tài khoản không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = textBox1.Text;
            string password = textBox2.Text;

            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_DangNhap", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sTenDangNhap", username);
                    cmd.Parameters.AddWithValue("@sMatKhau", password);

                    object result = cmd.ExecuteScalar(); // Lấy kết quả trả về

                    if (result != null )
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.Hide();
                        if (result.Equals("Admin")) {
                            FAM fam = new FAM(username);
                            fam.ShowDialog();
                        }
                        else
                        {
                            FBS fbs = new FBS(username);
                            fbs.ShowDialog();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Text = "";
                    }
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
                textBox2.PasswordChar = '\0';// Hiển thị nội dung bình thường
            else
                textBox2.PasswordChar = '*';  // Ẩn nội dung
        }

        private void lbl_quen_mat_khau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
       
        }

        private void lbl_dang_ki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            textBox1.Focus();
        }

        public void LoginForm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox2.PasswordChar = '*';
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           //button1.Focus();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng "beep"
                textBox2.Focus(); // Chuyển sang ô mật khẩu
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng "beep"
                btn_dang_nhap.Focus();
                // Giả lập click vào nút đăng nhập
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng "beep"
                btn_dang_nhap.PerformClick();
                // Giả lập click vào nút đăng nhập
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng "beep"
                btn_dang_nhap.PerformClick(); // Gọi sự kiện Click của nút đăng nhập
            }
        }


        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
