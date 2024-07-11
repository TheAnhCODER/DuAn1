using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ThuongHieu
    {
        public ThuongHieu()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int IdThuongHieu { get; set; }
        public string TenThuongHieu { get; set; } = null!;

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
