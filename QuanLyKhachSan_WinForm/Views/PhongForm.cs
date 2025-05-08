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
    public partial class PhongForm : Form
    {
        private PhongVM PhongVM = new PhongVM();
        public PhongForm()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhongVM.MaPhong = txtMaPhong.Text;
            PhongVM.soPhong = int.Parse(txtSoPhong.Text);
            PhongVM.maloaiPhong = int.Parse(txtLoaiPhong.Text);
            PhongVM.donGia = decimal.Parse(txtDonGia.Text);
            PhongVM.trangThai = txtTrangThai.Text;
            PhongVM.mota = rtbMoTa.Text;

            PhongVM.saveDatabase();
            MessageBox.Show("Thêm phòng thành công!");
        }
    }
}
