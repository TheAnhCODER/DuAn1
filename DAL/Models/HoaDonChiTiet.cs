using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HoaDonChiTiet
    {
        public Guid MaSpct { get; set; }
        public Guid MaHoaDon { get; set; }
        public decimal? DonGia { get; set; }
        public int? SoLuong { get; set; }

        public virtual HoaDon MaHoaDonNavigation { get; set; } = null!;
        public virtual SanPhamChiTiet MaSpctNavigation { get; set; } = null!;
    }
}
