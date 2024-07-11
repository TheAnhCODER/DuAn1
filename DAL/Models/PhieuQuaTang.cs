using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PhieuQuaTang
    {
        public PhieuQuaTang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public Guid IdPhieuquatang { get; set; }
        public string TenPhieuQuaTang { get; set; } = null!;
        public int SoLuongPhieu { get; set; }
        public decimal SoTienGiamToiDa { get; set; }
        public bool LoaiGiamGia { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
