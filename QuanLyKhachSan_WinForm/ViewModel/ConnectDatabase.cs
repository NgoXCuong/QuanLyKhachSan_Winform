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
        string connectionString = "Server=localhost;Database=BTL_QuanLyKhachSan;User Id=sa;Password=123;";

        // Để lại dòng đã Comment (Manh)
        //string connectionString = "Server=localhost;Database=QLKhachSan;User Id=sa;Password=123;";

        //string connectionString1 = "Data Source=Mr-Cuong\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";

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
