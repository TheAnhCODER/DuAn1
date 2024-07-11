using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Responsitories
{
    public class NhanVienRespo
    {
        private string connectionString = "Data Source=DESKTOP-BQH9I25;Initial Catalog=DuAn1;Integrated Security=True";

        public DataTable CheckLogin(string taikhoan, string matKhau)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_CheckLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", taikhoan);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
    }
}
//Data Source=DESKTOP-BQH9I25;Initial Catalog=DuAn1;Integrated Security=True