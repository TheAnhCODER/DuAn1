using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public Guid IdNhanvien { get; set; }
        public int IdChucvu { get; set; }
        public string TenNhanVien { get; set; } = null!;
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }
        public string? Email { get; set; }
        public string MatKhau { get; set; } = null!;

        public virtual ChucVu IdChucvuNavigation { get; set; } = null!;
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
