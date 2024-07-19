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

        public Guid IdSanphamChitiet { get; set; }
        public Guid? IdSanPham { get; set; }
        public Guid? IdMauSac { get; set; }
        public Guid? IdKichCo { get; set; }
        public int SoLuong { get; set; }
        public bool TrangThaiSanPham { get; set; }

        public virtual KichCo? IdKichCoNavigation { get; set; }
        public virtual MauSac? IdMauSacNavigation { get; set; }
        public virtual SanPham? IdSanPhamNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual ICollection<KhuyenMai> KhuyenMais { get; set; }
    }
}
