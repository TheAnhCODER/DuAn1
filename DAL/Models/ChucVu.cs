using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public int IdChucvu { get; set; }
        public string TenChucVu { get; set; } = null!;

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
