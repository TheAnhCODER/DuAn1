using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DanhMuc
    {
        public DanhMuc()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public Guid IdDanhMuc { get; set; }
        public string TenDanhMuc { get; set; } = null!;

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
