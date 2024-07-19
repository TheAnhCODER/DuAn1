using DAL.Models;
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
        DuAn1Context dbContext = new DuAn1Context();

        public NhanVien? DangNhap(string username, string password)
        {
            return dbContext.NhanViens.FirstOrDefault(nv => (nv.DienThoai == username
            && nv.MatKhau == password) || (nv.Email == username
            && nv.MatKhau == password));
        }
    }
}
//Data Source=DESKTOP-BQH9I25;Initial Catalog=DuAn1;Integrated Security=True