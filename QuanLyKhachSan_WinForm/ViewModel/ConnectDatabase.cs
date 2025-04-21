using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_WinForm.ViewModel
{
    internal class ConnectDatabase
    {
        string connectionString = "Data Source=Mr-Cuong\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            return conn;
        }
    }
}
