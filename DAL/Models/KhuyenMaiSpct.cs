using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KhuyenMaiSpct
    {
        public Guid Id { get; set; }
        public Guid IdKhuyenMai { get; set; }
        public Guid IdSanPhamChiTiet { get; set; }

        public virtual KhuyenMai IdKhuyenMaiNavigation { get; set; } = null!;
        public virtual SanPhamChiTiet IdSanPhamChiTietNavigation { get; set; } = null!;
    }
}
