using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KhuyenMai
    {
        public Guid IdKhuyenMai { get; set; }
        public Guid? IdSanphamChitiet { get; set; }
        public string? TenKhuyenMai { get; set; }
        public decimal? GiamGia { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public bool? TrangThai { get; set; }
        public bool LoaiGiamGia { get; set; }

        public virtual SanPhamChiTiet? IdSanphamChitietNavigation { get; set; }
    }
}
