using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_WinForm.Models;

namespace QuanLyKhachSan_WinForm.ViewModel
{

    internal class NhanVienVM
    {
        private ConnectDatabase connDb = new ConnectDatabase();

        public List<NhanVienModel> getAllNhanVien()
        {
            List<NhanVienModel> list = new List<NhanVienModel>();
            string query = "SELECT * FROM NhanVien";
            using (SqlConnection conn = connDb.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NhanVienModel nv = new NhanVienModel
                    {
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        TenNV = reader["HoTen"].ToString(),
                        Sdt = reader["SoDienThoai"].ToString(),
                        Email = reader["Email"].ToString(),
                        ChucVu = reader["ChucVu"].ToString(),
                        DiaChi = reader["DiaChi"].ToString()
                    };
                    list.Add(nv);
                }
            }
            return list;
        }
    }
}
