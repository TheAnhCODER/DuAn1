using DAL.Models;
using DAL.Responsitories;
using Microsoft.EntityFrameworkCore;
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
        private readonly NhanVienRespo nhanVienRespo;

        public NhanVienServices()
        {
            nhanVienRespo = new NhanVienRespo();
        }

        public NhanVien? DangNhap(string username, string password)
        {
            return nhanVienRespo.DangNhap(username, password);
        }
        public List<NhanVien> CNShow()
        {
            return nhanVienRespo.GetAll();
        }
        public List<NhanVien> CNShowNhanVien()
        {
            return nhanVienRespo.GetAllNhanVien();
        }

        // Phương thức tìm kiếm nhân viên theo tên hoặc số điện thoại
        public List<NhanVien> TimNhanVien(string tim)
        {
            return nhanVienRespo.TimNhanVien(tim);
        }
        public NhanVien GetNhanVienByPhoneNumber(string phoneNumber)
        {
            return nhanVienRespo.GetNhanVienByPhoneNumber(phoneNumber);
        }
        public string GetNhanVienByid(string id)
        {
           
            return nhanVienRespo.GetNhanVienByid(Guid.Parse(id));
        }

        public bool GetNhanVienByEmail(string email)
        {
            return nhanVienRespo.GetNhanVienByEmail(email);
        }
        // Thêm nhân viên mới
        public string CNThem(string tenNhanVien, string? gioiTinh, DateTime? ngaySinh, string? diaChi, string? dienThoai, string? email, string? matKhau, bool trangThai)
        {
            NhanVien nhanVien = new NhanVien()
            {
                IdNhanvien = Guid.NewGuid(), // Tạo một Id mới cho nhân viên
                TenNhanVien = tenNhanVien,
                GioiTinh = gioiTinh,
                NgaySinh = ngaySinh.Value,
                DiaChi = diaChi,
                DienThoai = dienThoai,
                Email = email,
                MatKhau = matKhau,
                TrangThai = trangThai
            };
            if (nhanVienRespo.AddNV(nhanVien))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        // Sửa nhân viên 
        public string CNSua(string idNhanVien, string tenNhanVien, string? gioiTinh, DateTime? ngaySinh, string? diaChi, string? dienThoai, string? email, string? matKhau, bool trangThai)
        {
            // Chuyển đổi idNhanVien từ chuỗi thành Guid
            var idNhanVienGuid = Guid.Parse(idNhanVien);

            // Tạo đối tượng NhanVien để cập nhật
            NhanVien nhanVien = new NhanVien()
            {
                IdNhanvien = idNhanVienGuid,
                TenNhanVien = tenNhanVien,
                GioiTinh = gioiTinh,
                NgaySinh = ngaySinh,
                DiaChi = diaChi,
                DienThoai = dienThoai,
                Email = email,
                MatKhau = matKhau,
                TrangThai = trangThai
            };

            // Gọi phương thức cập nhật từ repository
            if (nhanVienRespo.UpdateNV(nhanVien))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }


        public bool UpdateMatKhau( string? email, string? matKhau)
        {
            // Gọi phương thức cập nhật từ repository
            if (nhanVienRespo.UpdateMatKhau(email, matKhau))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Dictionary<Guid, string> GetNhanVienDict()
        {
            var nhanViens = nhanVienRespo.GetAll();
            return nhanViens.ToDictionary(ms => ms.IdNhanvien, ms => ms.TenNhanVien);
        }

    }
}