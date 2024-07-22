using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Khach
    {
        public Khach()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string SoDienThoai { get; set; } = null!;
        public string TenKhachHang { get; set; } = null!;
        public string? DiaChi { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
