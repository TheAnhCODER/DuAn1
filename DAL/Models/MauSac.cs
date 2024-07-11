using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MauSac
    {
        public MauSac()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public Guid IdMauSac { get; set; }
        public string TenMauSac { get; set; } = null!;

        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
