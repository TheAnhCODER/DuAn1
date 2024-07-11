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
        public string IdKhach { get; set; } = null!;
        public Guid IdNhanVien { get; set; }
        public Guid? IdPhieuquatang { get; set; }
        public int IdPhuongthucthanhtoan { get; set; }
        public decimal TongSoTienHoaDon { get; set; }
        public bool TrangThaiThanhToan { get; set; }

        public virtual Khach IdKhachNavigation { get; set; } = null!;
        public virtual NhanVien IdNhanVienNavigation { get; set; } = null!;
        public virtual PhieuQuaTang? IdPhieuquatangNavigation { get; set; }
        public virtual PhuongThucThanhToan IdPhuongthucthanhtoanNavigation { get; set; } = null!;
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
