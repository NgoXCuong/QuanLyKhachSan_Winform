using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_WinForm.ViewModel;

namespace QuanLyKhachSan_WinForm.Models
{
    internal class PhongRepository
    {
        public void addPhong(PhongModel phong)
        {
            using (var conn = new ConnectDatabase().GetConnection())
            {
                string query = "INSERT INTO Phong (SoPhong, MaLoaiPhong, donGia, trangThai, mota) VALUES (@soPhong, @maloaiPhong, @donGia, @trangThai, @mota)";
                SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@MaPhong", phong.MaPhong);
                cmd.Parameters.AddWithValue("@soPhong", phong.soPhong);
                cmd.Parameters.AddWithValue("@maloaiPhong", phong.maloaiPhong);
                cmd.Parameters.AddWithValue("@donGia", phong.donGia);
                cmd.Parameters.AddWithValue("@trangThai", phong.trangThai);
                cmd.Parameters.AddWithValue("@mota", phong.mota);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
