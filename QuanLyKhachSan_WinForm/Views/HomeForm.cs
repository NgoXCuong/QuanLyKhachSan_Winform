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
        private string userName;
        public HomeForm()
        {
            InitializeComponent();
        }

        // Lay ten dang nhap tu LoginForm
        public HomeForm(string username)
        {
            InitializeComponent();
            userName = username;
        }


        private void HomeForm_Load(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
            lbAdmin.Text = userName; // Hiển thị tên tài khoản vào lbAdmin

            // 👉 Mở luôn giao diện Trang Chủ khi load HomeForm
            OpenChildForm(new TrangChuForm());
            HighlightButton(btnHome); // Và cũng tô màu nút Trang Chủ luôn cho đẹp
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
            // Reset tất cả các nút về màu mặc định
            btnHome.BackColor = Color.White;
            btnHome.ForeColor = Color.Black;

            btnPhong.BackColor = Color.White;
            btnPhong.ForeColor = Color.Black;

            btnNhanVien.BackColor = Color.White;
            btnNhanVien.ForeColor = Color.Black;

            btnHoaDon.BackColor = Color.White;
            btnHoaDon.ForeColor = Color.Black;

            btnKhachHang.BackColor = Color.White;
            btnKhachHang.ForeColor = Color.Black;

            btnDichVu.BackColor = Color.White;
            btnDichVu.ForeColor = Color.Black;

            btnThongKe.BackColor = Color.White;
            btnThongKe.ForeColor = Color.Black;

            // Chỉ đổi màu nút được click
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

        private void btnPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhongForm());
            HighlightButton(btnPhong);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVienForm());
            HighlightButton(btnNhanVien);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDonForm());
            HighlightButton(btnHoaDon);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHangForm());
            HighlightButton(btnKhachHang);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DichVuForm());
            HighlightButton(btnDichVu);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeForm());
            HighlightButton(btnThongKe);
        }
    }
}
