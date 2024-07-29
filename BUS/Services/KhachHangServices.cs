using DAL.Models;
using DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class KhachHangServices
    {
        private readonly KhachHangRespo _repo;

        public KhachHangServices()
        {
            _repo = new KhachHangRespo();
        }
        // Lấy tất cả khách hàng
        public List<Khach> CNShow()
        {
            return _repo.GetAll();
        }
        // Tìm khách hàng theo số điện thoại
        public List<Khach> CNTim(string sdt)
        {
            return _repo.GetK(sdt);
        }
        // Thêm khách hàng mới
        public string CNThem(string soDienThoai, string tenKhachHang, string? diaChi)
        {
            Khach khach = new Khach()
            {
                SoDienThoai = soDienThoai,
                TenKhachHang = tenKhachHang,
                DiaChi = diaChi
            };
            if (_repo.AddK(khach))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string CNThemKhachVangLai(string soDienThoai, string tenKhachHang)
        {
            Khach khach = new Khach()
            {
                SoDienThoai = soDienThoai,
                TenKhachHang = tenKhachHang,
               
            };
            if (_repo.AddK(khach))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        // Sửa khách hàng 
        public string CNSua(string soDienThoai, string tenKhachHang, string? diaChi)
        {
            Khach khach = new Khach()
            {
                SoDienThoai = soDienThoai,
                TenKhachHang = tenKhachHang,
                DiaChi = diaChi
            };
            if (_repo.UpdateK(khach))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }
        public Khach? GetKhachHangBySDT(string sdt)
        {
            return _repo.GetKhachHangBySDT(sdt);
        }
    }
}
