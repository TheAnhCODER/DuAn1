using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class DuAn1Context : DbContext
    {
        public DuAn1Context()
        {
        }

        public DuAn1Context(DbContextOptions<DuAn1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<DanhMuc> DanhMucs { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<Khach> Khaches { get; set; } = null!;
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; } = null!;
        public virtual DbSet<KichCo> KichCos { get; set; } = null!;
        public virtual DbSet<MauSac> MauSacs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<SanPhamChiTiet> SanPhamChiTiets { get; set; } = null!;
        public virtual DbSet<ThuongHieu> ThuongHieus { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BQH9I25;Database=DuAn1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.IdChucvu)
                    .HasName("PK__ChucVu__B4FC39BFD1AE8683");

                entity.ToTable("ChucVu");

                entity.Property(e => e.IdChucvu).HasColumnName("id_chucvu");

                entity.Property(e => e.TenChucVu)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_chuc_vu");
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.HasKey(e => e.IdDanhMuc)
                    .HasName("PK__DanhMuc__8CE82CD16CE60338");

                entity.ToTable("DanhMuc");

                entity.Property(e => e.IdDanhMuc)
                    .HasColumnName("id_danh_muc")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TenDanhMuc)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_danh_muc");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.IdHoadon)
                    .HasName("PK__HoaDon__F9F51331BD2475BC");

                entity.ToTable("HoaDon");

                entity.Property(e => e.IdHoadon)
                    .HasColumnName("id_hoadon")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdNhanvien).HasColumnName("ID_nhanvien");

                entity.Property(e => e.IdPhuongthucthanhtoan).HasColumnName("id_phuongthucthanhtoan");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_tao")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(20)
                    .HasColumnName("So_dien_thoai");

                entity.Property(e => e.TongSoTienHoaDon)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Tong_so_tien_hoa_don");

                entity.Property(e => e.TrangThaiThanhToan)
                    .HasColumnName("Trang_thai_thanh_toan")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.IdNhanvienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdNhanvien)
                    .HasConstraintName("FK__HoaDon__ID_nhanv__5FB337D6");

                entity.HasOne(d => d.IdPhuongthucthanhtoanNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdPhuongthucthanhtoan)
                    .HasConstraintName("FK__HoaDon__id_phuon__60A75C0F");

                entity.HasOne(d => d.SoDienThoaiNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.SoDienThoai)
                    .HasConstraintName("FK__HoaDon__So_dien___5EBF139D");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.IdHoadonChitiet)
                    .HasName("PK__HoaDon_C__EA24FCBAB0F248C6");

                entity.ToTable("HoaDon_ChiTiet");

                entity.Property(e => e.IdHoadonChitiet)
                    .HasColumnName("id_hoadon_chitiet")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Don_gia");

                entity.Property(e => e.IdHoadon).HasColumnName("id_hoadon");

                entity.Property(e => e.IdSanphamChitiet).HasColumnName("id_sanpham_chitiet");

                entity.Property(e => e.SoLuongSanPham).HasColumnName("So_luong_san_pham");

                entity.Property(e => e.TongSoTien)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Tong_so_tien");

                entity.HasOne(d => d.IdHoadonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdHoadon)
                    .HasConstraintName("FK__HoaDon_Ch__id_ho__6477ECF3");

                entity.HasOne(d => d.IdSanphamChitietNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdSanphamChitiet)
                    .HasConstraintName("FK__HoaDon_Ch__id_sa__656C112C");
            });

            modelBuilder.Entity<Khach>(entity =>
            {
                entity.HasKey(e => e.SoDienThoai)
                    .HasName("PK__Khach__F0FE0FA475045B2E");

                entity.ToTable("Khach");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(20)
                    .HasColumnName("So_dien_thoai");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_chi");

                entity.Property(e => e.TenKhachHang)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_khach_hang");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasKey(e => e.IdKhuyenMai)
                    .HasName("PK__KhuyenMa__E5173E9844142204");

                entity.ToTable("KhuyenMai");

                entity.Property(e => e.IdKhuyenMai)
                    .HasColumnName("id_khuyen_mai")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiamGia)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Giam_gia");

                entity.Property(e => e.IdSanphamChitiet).HasColumnName("id_sanpham_chitiet");

                entity.Property(e => e.LoaiGiamGia)
                    .HasMaxLength(255)
                    .HasColumnName("Loai_giam_gia");

                entity.Property(e => e.NgayBatDau)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_bat_dau");

                entity.Property(e => e.NgayKetThuc)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_ket_thuc");

                entity.Property(e => e.TrangThai).HasColumnName("Trang_thai");

                entity.HasOne(d => d.IdSanphamChitietNavigation)
                    .WithMany(p => p.KhuyenMais)
                    .HasForeignKey(d => d.IdSanphamChitiet)
                    .HasConstraintName("FK__KhuyenMai__id_sa__59063A47");
            });

            modelBuilder.Entity<KichCo>(entity =>
            {
                entity.HasKey(e => e.IdKichCo)
                    .HasName("PK__KichCo__EBB498AF484A530C");

                entity.ToTable("KichCo");

                entity.Property(e => e.IdKichCo)
                    .HasColumnName("id_kich_co")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.KichCo1)
                    .HasMaxLength(50)
                    .HasColumnName("Kich_co");
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.HasKey(e => e.IdMauSac)
                    .HasName("PK__MauSac__5D8EF426E21909DD");

                entity.ToTable("MauSac");

                entity.Property(e => e.IdMauSac)
                    .HasColumnName("id_mau_sac")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TenMauSac)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_mau_sac");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.IdNhanvien)
                    .HasName("PK__NhanVien__38E5C90521EC9B3C");

                entity.ToTable("NhanVien");

                entity.Property(e => e.IdNhanvien)
                    .HasColumnName("ID_nhanvien")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_chi");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(20)
                    .HasColumnName("Dien_thoai");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(10)
                    .HasColumnName("Gioi_tinh");

                entity.Property(e => e.IdChucvu).HasColumnName("id_chucvu");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(255)
                    .HasColumnName("Mat_khau");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_sinh");

                entity.Property(e => e.TenNhanVien)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_nhan_vien");

                entity.HasOne(d => d.IdChucvuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdChucvu)
                    .HasConstraintName("FK__NhanVien__id_chu__3A81B327");
            });

            modelBuilder.Entity<PhuongThucThanhToan>(entity =>
            {
                entity.HasKey(e => e.IdPhuongthucthanhtoan)
                    .HasName("PK__PhuongTh__99624A7B8C2250EC");

                entity.ToTable("PhuongThucThanhToan");

                entity.Property(e => e.IdPhuongthucthanhtoan)
                    .HasColumnName("id_phuongthucthanhtoan")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TenPhuongThucThanhToan)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_phuong_thuc_thanh_toan");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.IdSanPham)
                    .HasName("PK__SanPham__5776A5295164E6F2");

                entity.ToTable("SanPham");

                entity.Property(e => e.IdSanPham)
                    .HasColumnName("id_san_pham")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdDanhMuc).HasColumnName("id_danh_muc");

                entity.Property(e => e.IdThuongHieu).HasColumnName("id_thuong_hieu");

                entity.Property(e => e.MoTa).HasColumnName("Mo_ta");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_san_pham");

                entity.Property(e => e.TrangThaiSanPham).HasColumnName("Trang_thai_san_pham");

                entity.HasOne(d => d.IdDanhMucNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdDanhMuc)
                    .HasConstraintName("FK__SanPham__id_danh__4F7CD00D");

                entity.HasOne(d => d.IdThuongHieuNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdThuongHieu)
                    .HasConstraintName("FK__SanPham__id_thuo__4E88ABD4");
            });

            modelBuilder.Entity<SanPhamChiTiet>(entity =>
            {
                entity.HasKey(e => e.IdSanphamChitiet)
                    .HasName("PK__SanPham___A718EABE52E6393F");

                entity.ToTable("SanPham_ChiTiet");

                entity.Property(e => e.IdSanphamChitiet)
                    .HasColumnName("id_sanpham_chitiet")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdKichCo).HasColumnName("id_kich_co");

                entity.Property(e => e.IdMauSac).HasColumnName("id_mau_sac");

                entity.Property(e => e.IdSanPham).HasColumnName("id_san_pham");

                entity.Property(e => e.SoLuong).HasColumnName("So_luong");

                entity.HasOne(d => d.IdKichCoNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.IdKichCo)
                    .HasConstraintName("FK__SanPham_C__id_ki__5535A963");

                entity.HasOne(d => d.IdMauSacNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.IdMauSac)
                    .HasConstraintName("FK__SanPham_C__id_ma__5441852A");

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.IdSanPham)
                    .HasConstraintName("FK__SanPham_C__id_sa__534D60F1");
            });

            modelBuilder.Entity<ThuongHieu>(entity =>
            {
                entity.HasKey(e => e.IdThuongHieu)
                    .HasName("PK__ThuongHi__37E13EF3CBF9134B");

                entity.ToTable("ThuongHieu");

                entity.Property(e => e.IdThuongHieu)
                    .HasColumnName("id_thuong_hieu")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TenThuongHieu)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_thuong_hieu");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
