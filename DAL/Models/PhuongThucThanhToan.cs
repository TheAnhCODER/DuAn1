using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PhuongThucThanhToan
    {
        public PhuongThucThanhToan()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int IdPhuongthucthanhtoan { get; set; }
        public string TenPhuongThucThanhToan { get; set; } = null!;

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
