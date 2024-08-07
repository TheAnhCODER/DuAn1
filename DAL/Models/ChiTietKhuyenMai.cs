using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ChiTietKhuyenMai
    {
        public Guid IdChitietKhuyenmai { get; set; }
        public Guid? IdKhuyenMai { get; set; }
        public Guid? IdSanphamChitiet { get; set; }
        public decimal GiamGia { get; set; }
        public bool LoaiGiamGia { get; set; }

        public virtual KhuyenMai? IdKhuyenMaiNavigation { get; set; }
        public virtual SanPhamChiTiet? IdSanphamChitietNavigation { get; set; }
    }
}
