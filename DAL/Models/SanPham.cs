using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            AnhSanPhams = new HashSet<AnhSanPham>();
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public int IdSanPham { get; set; }
        public int IdThuongHieu { get; set; }
        public int IdDanhMuc { get; set; }
        public string TenSanPham { get; set; } = null!;
        public string? MoTa { get; set; }
        public bool TrangThaiSanPham { get; set; }

        public virtual DanhMuc IdDanhMucNavigation { get; set; } = null!;
        public virtual ThuongHieu IdThuongHieuNavigation { get; set; } = null!;
        public virtual ICollection<AnhSanPham> AnhSanPhams { get; set; }
        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
