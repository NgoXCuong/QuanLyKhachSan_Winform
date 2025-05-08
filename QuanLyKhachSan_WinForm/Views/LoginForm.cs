using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan_WinForm.Models;
using QuanLyKhachSan_WinForm.ViewModel;

namespace QuanLyKhachSan_WinForm.Views
{
    public partial class LoginForm : Form
    {
        private TaiKhoanVM taiKhoanVM = new TaiKhoanVM();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;

            if ((string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password)))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<TaiKhoanModel> listLogin = taiKhoanVM.getTaiKhoanLogin();

            bool isAuth = listLogin.Any(tk =>
                tk.TenDangNhap.Equals(user, StringComparison.OrdinalIgnoreCase)
                && tk.MatKhau == password);

            if (isAuth)
            {
                //this.Hide();
                //new HomeForm().Show();
                this.Hide();
                HomeForm homeForm = new HomeForm(user); // TRUYỀN tên user vào HomeForm
                homeForm.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Clear();
                txtPassword.Clear();
                txtUser.Focus();
            }
        }

        // Ân hiện mật khẩu
        private void checkBoxHidePass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHidePass.Checked)
            {
                txtPassword.UseSystemPasswordChar = true; // Ẩn mật khẩu thành ***
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false; // Hiện mật khẩu ra bình thường
            }
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //DangKyForm dangKyForm = new DangKyForm();
            //this.Hide(); // Ẩn login
            //dangKyForm.FormClosed += (s, args) => this.Show(); // Hiện lại login khi form đăng ký đóng
            //dangKyForm.Show();
        }
    }
}
