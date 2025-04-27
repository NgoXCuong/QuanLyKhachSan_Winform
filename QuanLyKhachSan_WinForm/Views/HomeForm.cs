using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan_WinForm.Views
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            // Xóa form cũ trong panel nếu có
            pnPage.Controls.Clear();

            // Gán thuộc tính cho form con
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Thêm form con vào panel
            pnPage.Controls.Add(childForm);
            pnPage.Tag = childForm;

            // Hiển thị form
            childForm.Show();
        }


        private void HighlightButton(Button btn)
        {
            // Reset tất cả các nút về màu bình thường
            btnHome.BackColor = Color.White;
            btnPhong.BackColor = Color.White;
            btnNhanVien.BackColor = Color.White;
            btnHoaDon.BackColor = Color.White;
            btnKhachHang.BackColor = Color.White;
            btnDichVu.BackColor = Color.White;

            // Đổi màu nút được click
            btn.BackColor = Color.DarkBlue;
            btn.ForeColor = Color.White;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TrangChuForm());
            HighlightButton(btnHome);
        }


    }
}
