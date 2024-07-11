using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KichCo
    {
        public KichCo()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public Guid IdKichCo { get; set; }
        public string KichCo1 { get; set; } = null!;

        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
