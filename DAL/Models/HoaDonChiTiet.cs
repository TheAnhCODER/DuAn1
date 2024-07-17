using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HoaDonChiTiet
    {
        public Guid IdHoadonChitiet { get; set; }
        public Guid? IdHoadon { get; set; }
        public Guid? IdSanphamChitiet { get; set; }
        public decimal TongSoTien { get; set; }
        public int SoLuongSanPham { get; set; }
        public decimal DonGia { get; set; }

        public virtual HoaDon? IdHoadonNavigation { get; set; }
        public virtual SanPhamChiTiet? IdSanphamChitietNavigation { get; set; }
    }
}
