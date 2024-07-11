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

        public virtual DbSet<AnhSanPham> AnhSanPhams { get; set; } = null!;
        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<DanhMuc> DanhMucs { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<Khach> Khaches { get; set; } = null!;
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; } = null!;
        public virtual DbSet<KichCo> KichCos { get; set; } = null!;
        public virtual DbSet<MauSac> MauSacs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<PhieuQuaTang> PhieuQuaTangs { get; set; } = null!;
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
            modelBuilder.Entity<AnhSanPham>(entity =>
            {
                entity.HasKey(e => e.IdAnhSanPham)
                    .HasName("PK__Anh_SanP__71780D0B5407B6E3");

                entity.ToTable("Anh_SanPham");

                entity.Property(e => e.IdAnhSanPham).HasColumnName("Id_anh_san_pham");

                entity.Property(e => e.AnhSanPham1).HasColumnName("Anh_san_pham");

                entity.Property(e => e.IdSanPham).HasColumnName("Id_san_pham");

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.AnhSanPhams)
                    .HasForeignKey(d => d.IdSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Anh_SanPh__Id_sa__3F466844");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.IdChucvu)
                    .HasName("PK__ChucVu__9F6CC82536E93B51");

                entity.ToTable("ChucVu");

                entity.Property(e => e.IdChucvu).HasColumnName("Id_chucvu");

                entity.Property(e => e.TenChucVu)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_chuc_vu");
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.HasKey(e => e.IdDanhMuc)
                    .HasName("PK__DanhMuc__74B8352682D514F2");

                entity.ToTable("DanhMuc");

                entity.Property(e => e.IdDanhMuc).HasColumnName("Id_danh_muc");

                entity.Property(e => e.TenDanhMuc)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_danh_muc");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.IdHoadon)
                    .HasName("PK__HoaDon__2385F52E5180D7AC");

                entity.ToTable("HoaDon");

                entity.Property(e => e.IdHoadon)
                    .HasColumnName("Id_hoadon")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdKhach)
                    .HasMaxLength(15)
                    .HasColumnName("Id_khach");

                entity.Property(e => e.IdNhanVien).HasColumnName("Id_nhan_vien");

                entity.Property(e => e.IdPhieuquatang).HasColumnName("Id_phieuquatang");

                entity.Property(e => e.IdPhuongthucthanhtoan).HasColumnName("Id_phuongthucthanhtoan");

                entity.Property(e => e.TongSoTienHoaDon)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Tong_so_tien_hoa_don");

                entity.Property(e => e.TrangThaiThanhToan).HasColumnName("Trang_thai_thanh_toan");

                entity.HasOne(d => d.IdKhachNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdKhach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__Id_khach__5DCAEF64");

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__Id_nhan___5EBF139D");

                entity.HasOne(d => d.IdPhieuquatangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdPhieuquatang)
                    .HasConstraintName("FK__HoaDon__Id_phieu__5FB337D6");

                entity.HasOne(d => d.IdPhuongthucthanhtoanNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdPhuongthucthanhtoan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__Id_phuon__60A75C0F");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.IdHoadonChitiet)
                    .HasName("PK__HoaDon_C__735FF2E5C71E21D9");

                entity.ToTable("HoaDon_ChiTiet");

                entity.Property(e => e.IdHoadonChitiet)
                    .HasColumnName("Id_hoadon_chitiet")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdHoadon).HasColumnName("Id_hoadon");

                entity.Property(e => e.IdSanphamChitiet).HasColumnName("Id_sanpham_chitiet");

                entity.Property(e => e.SoLuongSanPham).HasColumnName("So_luong_san_pham");

                entity.Property(e => e.TongSoTien)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Tong_so_tien");

                entity.HasOne(d => d.IdHoadonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdHoadon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon_Ch__Id_ho__656C112C");

                entity.HasOne(d => d.IdSanphamChitietNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdSanphamChitiet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon_Ch__Id_sa__6477ECF3");
            });

            modelBuilder.Entity<Khach>(entity =>
            {
                entity.HasKey(e => e.SoDienThoai)
                    .HasName("PK__Khach__F0FE0FA41BB29CC6");

                entity.ToTable("Khach");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(15)
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
                    .HasName("PK__KhuyenMa__1CC16ACBA67DBBDE");

                entity.ToTable("KhuyenMai");

                entity.Property(e => e.IdKhuyenMai)
                    .HasColumnName("Id_khuyen_mai")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiamGia)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Giam_gia");

                entity.Property(e => e.IdSanphamChitiet).HasColumnName("Id_sanpham_chitiet");

                entity.Property(e => e.LoaiGiamGia).HasColumnName("Loai_giam_gia");

                entity.Property(e => e.NgayBatDau)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_bat_dau");

                entity.Property(e => e.NgayKetThuc)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_ket_thuc");

                entity.Property(e => e.TrangThaiKhuyenMai).HasColumnName("Trang_thai_khuyen_mai");

                entity.HasOne(d => d.IdSanphamChitietNavigation)
                    .WithMany(p => p.KhuyenMais)
                    .HasForeignKey(d => d.IdSanphamChitiet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KhuyenMai__Id_sa__4D94879B");
            });

            modelBuilder.Entity<KichCo>(entity =>
            {
                entity.HasKey(e => e.IdKichCo)
                    .HasName("PK__KichCo__E3C0661DAC01A634");

                entity.ToTable("KichCo");

                entity.Property(e => e.IdKichCo)
                    .HasColumnName("Id_kich_co")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.KichCo1)
                    .HasMaxLength(255)
                    .HasColumnName("Kich_co");
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.HasKey(e => e.IdMauSac)
                    .HasName("PK__MauSac__C9E5FB393DEDFF11");

                entity.ToTable("MauSac");

                entity.Property(e => e.IdMauSac)
                    .HasColumnName("Id_mau_sac")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TenMauSac)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_mau_sac");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.IdNhanvien)
                    .HasName("PK__NhanVien__E65DFDDE4B4A70C8");

                entity.ToTable("NhanVien");

                entity.Property(e => e.IdNhanvien)
                    .HasColumnName("Id_nhanvien")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(500)
                    .HasColumnName("Dia_chi");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(15)
                    .HasColumnName("Dien_thoai");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(50)
                    .HasColumnName("Gioi_tinh");

                entity.Property(e => e.IdChucvu).HasColumnName("Id_chucvu");

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__Id_chu__534D60F1");
            });

            modelBuilder.Entity<PhieuQuaTang>(entity =>
            {
                entity.HasKey(e => e.IdPhieuquatang)
                    .HasName("PK__PhieuQua__B15DCDE53039BB34");

                entity.ToTable("PhieuQuaTang");

                entity.Property(e => e.IdPhieuquatang)
                    .HasColumnName("Id_phieuquatang")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoaiGiamGia).HasColumnName("Loai_giam_gia");

                entity.Property(e => e.NgayBatDau)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_bat_dau");

                entity.Property(e => e.NgayKetThuc)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_ket_thuc");

                entity.Property(e => e.SoLuongPhieu).HasColumnName("So_luong_phieu");

                entity.Property(e => e.SoTienGiamToiDa)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("So_tien_giam_toi_da");

                entity.Property(e => e.TenPhieuQuaTang)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_phieu_qua_tang");
            });

            modelBuilder.Entity<PhuongThucThanhToan>(entity =>
            {
                entity.HasKey(e => e.IdPhuongthucthanhtoan)
                    .HasName("PK__PhuongTh__D7B4E95A622B9F3F");

                entity.ToTable("PhuongThucThanhToan");

                entity.Property(e => e.IdPhuongthucthanhtoan).HasColumnName("Id_phuongthucthanhtoan");

                entity.Property(e => e.TenPhuongThucThanhToan)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_phuong_thuc_thanh_toan");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.IdSanPham)
                    .HasName("PK__SanPham__8A42106801FC9B2C");

                entity.ToTable("SanPham");

                entity.Property(e => e.IdSanPham).HasColumnName("Id_san_pham");

                entity.Property(e => e.IdDanhMuc).HasColumnName("Id_danh_muc");

                entity.Property(e => e.IdThuongHieu).HasColumnName("Id_thuong_hieu");

                entity.Property(e => e.MoTa).HasColumnName("Mo_ta");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_san_pham");

                entity.Property(e => e.TrangThaiSanPham).HasColumnName("Trang_thai_san_pham");

                entity.HasOne(d => d.IdDanhMucNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdDanhMuc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham__Id_danh__3C69FB99");

                entity.HasOne(d => d.IdThuongHieuNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdThuongHieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham__Id_thuo__3B75D760");
            });

            modelBuilder.Entity<SanPhamChiTiet>(entity =>
            {
                entity.HasKey(e => e.IdSanphamChitiet)
                    .HasName("PK__SanPham___F5D99494F5E598AB");

                entity.ToTable("SanPham_ChiTiet");

                entity.Property(e => e.IdSanphamChitiet).HasColumnName("Id_sanpham_chitiet");

                entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdKichCo).HasColumnName("Id_kich_co");

                entity.Property(e => e.IdMauSac).HasColumnName("Id_mau_sac");

                entity.Property(e => e.IdSanpham).HasColumnName("Id_sanpham");

                entity.Property(e => e.SoLuong).HasColumnName("So_luong");

                entity.HasOne(d => d.IdKichCoNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.IdKichCo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham_C__Id_ki__49C3F6B7");

                entity.HasOne(d => d.IdMauSacNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.IdMauSac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham_C__Id_ma__48CFD27E");

                entity.HasOne(d => d.IdSanphamNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.IdSanpham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham_C__Id_sa__47DBAE45");
            });

            modelBuilder.Entity<ThuongHieu>(entity =>
            {
                entity.HasKey(e => e.IdThuongHieu)
                    .HasName("PK__ThuongHi__0F2C43A0E38A4BAF");

                entity.ToTable("ThuongHieu");

                entity.Property(e => e.IdThuongHieu).HasColumnName("Id_thuong_hieu");

                entity.Property(e => e.TenThuongHieu)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_thuong_hieu");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
