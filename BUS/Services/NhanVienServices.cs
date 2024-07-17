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
        private NhanVienRespo nhanVienRespo = new NhanVienRespo();

        public bool CheckLogin(string email, string matKhau, out DataTable userInfo)
        {
            userInfo = nhanVienRespo.CheckLogin(email, matKhau);
            return userInfo.Rows.Count > 0;
        }
    }
}