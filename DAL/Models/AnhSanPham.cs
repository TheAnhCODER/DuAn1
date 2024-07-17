using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnhSanPham
    {
        public Guid IdAnhSanPham { get; set; }
        public Guid? IdSanPham { get; set; }
        public string? AnhSanPham1 { get; set; }

        public virtual SanPham? IdSanPhamNavigation { get; set; }
    }
}
