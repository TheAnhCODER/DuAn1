using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public Guid IdHoadon { get; set; }
        public string? SoDienThoai { get; set; }
        public Guid? IdNhanvien { get; set; }
        public Guid? IdPhuongthucthanhtoan { get; set; }
        public decimal TongSoTienHoaDon { get; set; }
        public int TrangThaiThanhToan { get; set; }
        public DateTime? NgayTao { get; set; }

        public virtual NhanVien? IdNhanvienNavigation { get; set; }
        public virtual PhuongThucThanhToan? IdPhuongthucthanhtoanNavigation { get; set; }
        public virtual Khach? SoDienThoaiNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
