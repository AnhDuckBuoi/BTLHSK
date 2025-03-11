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
using System.Security.Cryptography;

namespace BTL_HSK
{
    public partial class Form1 : Form

    { 
        private Dictionary<Control, Rectangle> originalSizes = new Dictionary<Control, Rectangle>();
        public Form1()
        {
            InitializeComponent();
        
        }
        LoginForm f;
        private void lb_dang_nhap_Click(object sender, EventArgs e)
        {

        }

        private void btn_dang_ky_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Tên tài khoản không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Mật khẩu không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = textBox1.Text;
            string password = textBox2.Text;
            string role = username.StartsWith("admin") ? "Admin" : "BacSi"; // Xác định vai trò mặc định

            try
            {
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {
                    cnn.Open();

                    // Kiểm tra tên đăng nhập đã tồn tại hay chưa
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblNguoiDung WHERE sTenDangNhap = @Username", cnn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Gọi thủ tục đăng ký tài khoản
                    using (SqlCommand cmd = new SqlCommand("sp_DangKy", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sTenDangNhap", username);
                        cmd.Parameters.AddWithValue("@sMatKhau", password); // Không cần hash ở đây, SQL tự xử lý
                        cmd.Parameters.AddWithValue("@sVaiTro", role);

                        cmd.ExecuteNonQuery(); // Chạy lệnh

                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Đóng form đăng ký sau khi thành công
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0'; // Hiển thị nội dung bình thường
                textBox3.PasswordChar = '\0'; // Hiển thị nội dung bình thường
            }
            else
            {
                textBox2.PasswordChar = '*';  // Ẩn nội dung
                textBox3.PasswordChar = '*';  // Ẩn nội dung
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox2.PasswordChar = textBox3.PasswordChar = '*';
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng "beep"
                textBox2.Focus(); // Chuyển sang ô mật khẩu
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng "beep"
                textBox3.Focus(); // Chuyển sang ô mật khẩu
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng "beep"
                btn_dang_nhap.PerformClick(); // Chuyển sang ô mật khẩu
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        
        }

    }

}
