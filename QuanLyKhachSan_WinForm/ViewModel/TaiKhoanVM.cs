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
    }
}
