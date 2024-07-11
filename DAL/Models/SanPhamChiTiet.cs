using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SanPhamChiTiet
    {
        public SanPhamChiTiet()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
            KhuyenMais = new HashSet<KhuyenMai>();
        }

        public int IdSanphamChitiet { get; set; }
        public int IdSanpham { get; set; }
        public Guid IdMauSac { get; set; }
        public Guid IdKichCo { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }

        public virtual KichCo IdKichCoNavigation { get; set; } = null!;
        public virtual MauSac IdMauSacNavigation { get; set; } = null!;
        public virtual SanPham IdSanphamNavigation { get; set; } = null!;
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual ICollection<KhuyenMai> KhuyenMais { get; set; }
    }
}
