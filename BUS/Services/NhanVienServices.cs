using DAL.Models;
using DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class NhanVienServices
    {
        NhanVienRespo nhanVienRespo = new NhanVienRespo();

        public NhanVien? DangNhap(string username, string password)
        {
            return nhanVienRespo.DangNhap(username, password);
        }
    }
}