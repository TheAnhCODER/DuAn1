using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Responsitories
{
    public class KhachHangRespo
    {
        private readonly DuAn1Context _duan1Context;
        public KhachHangRespo()
        {
            _duan1Context = new DuAn1Context();
        }
        // Lấy tất cả khách hàng
        public List<Khach> GetAll()
        {
            return _duan1Context.Khaches.ToList();
        }
        // Lấy thông tin theo số điện thoại
        public List<Khach> GetK(string sdt)
        {
            return _duan1Context.Khaches.Where(p => p.SoDienThoai.Contains(sdt)).ToList();
        }
        // Thêm kích khách hàng mới
        public bool AddK(Khach khach)
        {
            try
            {
                _duan1Context.Khaches.Add(khach);
                _duan1Context.SaveChanges(); // Lưu lại thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Sửa kích cỡ
        public bool UpdateK(Khach khach)
        {
            try
            {
                // Lấy ra đối tượng cần được sửa
                var updateItem = _duan1Context.Khaches.FirstOrDefault(k => k.SoDienThoai == khach.SoDienThoai);
                if (updateItem != null)
                {
                    // Gán giá trị mới
                    updateItem.TenKhachHang = khach.TenKhachHang;
                    updateItem.DiaChi = khach.DiaChi;
                    _duan1Context.Khaches.Update(updateItem);
                    _duan1Context.SaveChanges(); // Lưu lại thay đổi
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Khach? GetKhachHangBySDT(string sdt)
        {
            return _duan1Context.Khaches.FirstOrDefault(kh => kh.SoDienThoai == sdt);
        }
    }
}
