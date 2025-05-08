using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyKhachSan_WinForm.Models;
using System.Security.Cryptography;

namespace QuanLyKhachSan_WinForm.ViewModel
{
    internal class TaiKhoanVM
    {
        private ConnectDatabase connDb = new ConnectDatabase();

        public List<TaiKhoanModel> getAllTaiKhoan()
        {
            List<TaiKhoanModel> list = new List<TaiKhoanModel>();
            string query = "SELECT * FROM TaiKhoan";
            using (SqlConnection conn = connDb.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TaiKhoanModel tk = new TaiKhoanModel
                    {
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        MaNV = reader["MaNV"].ToString(),
                        Quyen = reader["Quyen"].ToString(),
                        TrangThai = reader["TrangThai"].ToString()
                    };
                    list.Add(tk);
                }
            }
            return list;
        }

        public List<TaiKhoanModel> getTaiKhoanLogin()
        {
            List<TaiKhoanModel> list = new List<TaiKhoanModel>();
            string query = "SELECT * FROM TaiKhoan WHERE Quyen = 'Admin' AND TrangThai = 1";
            using (SqlConnection conn = connDb.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TaiKhoanModel tk = new TaiKhoanModel
                    {
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        //MaNV = reader["MaNV"].ToString(),
                        //Quyen = reader["Quyen"].ToString(),
                        //TrangThai = reader["TrangThai"].ToString()
                    };
                    list.Add(tk);
                }
            }
            return list;
        }


        //public bool DangKyTaiKhoan(TaiKhoanModel tk)
        //{
        //    // Kiểm tra tên đăng nhập đã tồn tại
        //    string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
        //    string insertQuery = @"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, MaNV, Quyen, TrangThai)
        //                   VALUES (@TenDangNhap, @MatKhau, @MaNV, @Quyen, @TrangThai)";

        //    using (SqlConnection conn = connDb.GetConnection())
        //    {
        //        // Kiểm tra trùng
        //        SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
        //        checkCmd.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap);
        //        int count = (int)checkCmd.ExecuteScalar();
        //        if (count > 0)
        //            return false; // Tài khoản đã tồn tại

        //        // Mã hóa mật khẩu
        //        string matKhauMaHoa = MaHoaSHA256(tk.MatKhau);

        //        // Insert tài khoản
        //        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
        //        insertCmd.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap);
        //        insertCmd.Parameters.AddWithValue("@MatKhau", matKhauMaHoa);
        //        insertCmd.Parameters.AddWithValue("@MaNV", tk.MaNV);
        //        insertCmd.Parameters.AddWithValue("@Quyen", tk.Quyen);
        //        insertCmd.Parameters.AddWithValue("@TrangThai", 1); // hoạt động

        //        int rows = insertCmd.ExecuteNonQuery();
        //        return rows > 0;
        //    }
        //}

    }
}
