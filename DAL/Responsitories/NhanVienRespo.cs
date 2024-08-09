using DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
        private readonly DuAn1Context dbContext;
        public NhanVienRespo()
        {
            dbContext = new DuAn1Context();
        }

        public NhanVien? DangNhap(string username, string password)
        {
            var result = dbContext.NhanViens
                .FromSqlRaw("EXEC sp_CheckLogin @Email = {0}, @MatKhau = {1}", username, password)
                .AsEnumerable()
                .FirstOrDefault();

            return result;
        }
        // Lấy tất cả nhân viên
        public List<NhanVien> GetAll()
        {
            return dbContext.NhanViens.ToList();
        }
        public List<NhanVien> GetAllNhanVien()
        {
            return dbContext.NhanViens.Where(nv => nv.IdChucvu != 1).ToList();
        }

        // Lấy thông tin theo số điện thoại và tên
        public List<NhanVien> TimNhanVien(string tim)
        {
            return dbContext.NhanViens
                            .Where(p => p.IdChucvu == 2 &&
                                        (p.DienThoai.Contains(tim) || p.TenNhanVien.Contains(tim)))
                            .ToList();
        }
        public NhanVien GetNhanVienByPhoneNumber(string phoneNumber)
        {
            return dbContext.NhanViens.FirstOrDefault(p => p.DienThoai == phoneNumber);
        }
        public string GetNhanVienByid(Guid id)
        {
            var nhanVien = dbContext.NhanViens.FirstOrDefault(p => p.IdNhanvien == id);
            return nhanVien?.TenNhanVien; // Giả sử tên nhân viên được lưu trong thuộc tính TenNhanVien
        }


        public bool GetNhanVienByEmail(string email)
        {
            return dbContext.NhanViens.Any(p => p.Email == email);
        }

        // Thêm kích nhân viên mới
        public bool AddNV(NhanVien nhanVien)
        {
            try
            {
                dbContext.NhanViens.Add(nhanVien);
                dbContext.SaveChanges(); // Lưu lại thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Sửa kích cỡ
        public bool UpdateNV(NhanVien nhanVien)
        {
            try
            {
                // Lấy đối tượng cần được sửa
                var updateItem = dbContext.NhanViens.FirstOrDefault(nv => nv.IdNhanvien == nhanVien.IdNhanvien);
                if (updateItem != null)
                {
                    // Gán giá trị mới
                    updateItem.TenNhanVien = nhanVien.TenNhanVien;
                    updateItem.GioiTinh = nhanVien.GioiTinh;
                    updateItem.NgaySinh = nhanVien.NgaySinh;
                    updateItem.DiaChi = nhanVien.DiaChi;
                    updateItem.DienThoai = nhanVien.DienThoai;
                    updateItem.Email = nhanVien.Email;
                    updateItem.MatKhau = nhanVien.MatKhau;
                    updateItem.IdChucvu = nhanVien.IdChucvu;
                    updateItem.TrangThai = nhanVien.TrangThai;

                    dbContext.NhanViens.Update(updateItem);
                    dbContext.SaveChanges(); // Lưu lại thay đổi
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool UpdateMatKhau(string email, string matkhaumoi)
        {
            try
            {
                // Lấy đối tượng cần được sửa
                var updateItem = dbContext.NhanViens.FirstOrDefault(nv => nv.Email == email);
                if (updateItem != null)
                {
                    // Gán giá trị mới
                    updateItem.MatKhau = matkhaumoi;
                    dbContext.NhanViens.Update(updateItem);
                    dbContext.SaveChanges(); // Lưu lại thay đổi
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool IsPhoneNumberExists(string phoneNumber)
        {
            // Kiểm tra sự tồn tại của số điện thoại trong cơ sở dữ liệu
            return dbContext.NhanViens.Any(nv => nv.DienThoai == phoneNumber);
        }

        public bool IsEmailExists(string email)
        {
            return dbContext.NhanViens.Any(nv => nv.Email == email);
        }

        public NhanVien GetNhanVienByEmailOrPhone(Guid idnhanvien)
        {
            return dbContext.NhanViens
            .SingleOrDefault(nv => nv.IdNhanvien == idnhanvien);
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            try
            {
                dbContext.NhanViens.Update(nhanVien);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi nếu cần
                return false;
            }

        }
    }
}
//Data Source=DESKTOP-BQH9I25;Initial Catalog=DuAn1;Integrated Security=True