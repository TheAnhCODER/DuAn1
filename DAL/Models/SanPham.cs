using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public Guid IdSanPham { get; set; }
        public Guid? IdThuongHieu { get; set; }
        public Guid? IdDanhMuc { get; set; }
        public string TenSanPham { get; set; } = null!;
        public string? MoTa { get; set; }
        public bool TrangThaiSanPham { get; set; }

        public virtual DanhMuc? IdDanhMucNavigation { get; set; }
        public virtual ThuongHieu? IdThuongHieuNavigation { get; set; }
        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
