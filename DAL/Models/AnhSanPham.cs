using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnhSanPham
    {
        public int IdAnhSanPham { get; set; }
        public int IdSanPham { get; set; }
        public byte[]? AnhSanPham1 { get; set; }

        public virtual SanPham IdSanPhamNavigation { get; set; } = null!;
    }
}
