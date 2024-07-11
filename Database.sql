-- Tạo cơ sở dữ liệu
CREATE DATABASE DuAn1;
GO

USE DuAn1;
GO

-- Bảng DanhMuc
CREATE TABLE DanhMuc (
    Id_danh_muc INT IDENTITY(1,1) PRIMARY KEY,
    Ten_danh_muc NVARCHAR(255) NOT NULL
);

-- Bảng ThuongHieu
CREATE TABLE ThuongHieu (
    Id_thuong_hieu INT IDENTITY(1,1) PRIMARY KEY,
    Ten_thuong_hieu NVARCHAR(255) NOT NULL
);

-- Bảng SanPham
CREATE TABLE SanPham (
    Id_san_pham INT IDENTITY(1,1) PRIMARY KEY,
    Id_thuong_hieu INT NOT NULL,
    Id_danh_muc INT NOT NULL,
    Ten_san_pham NVARCHAR(255) NOT NULL,
    Mo_ta NVARCHAR(MAX),
    Trang_thai_san_pham BIT NOT NULL,
    FOREIGN KEY (Id_thuong_hieu) REFERENCES ThuongHieu(Id_thuong_hieu),
    FOREIGN KEY (Id_danh_muc) REFERENCES DanhMuc(Id_danh_muc)
);

-- Bảng Anh_SanPham
CREATE TABLE Anh_SanPham (
    Id_anh_san_pham INT IDENTITY(1,1) PRIMARY KEY,
    Id_san_pham INT NOT NULL,
    Anh_san_pham VARBINARY(MAX),
    FOREIGN KEY (Id_san_pham) REFERENCES SanPham(Id_san_pham)
);

-- Bảng MauSac
CREATE TABLE MauSac (
    Id_mau_sac UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Ten_mau_sac NVARCHAR(255) NOT NULL
);

-- Bảng KichCo
CREATE TABLE KichCo (
    Id_kich_co UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Kich_co NVARCHAR(255) NOT NULL
);

-- Bảng SanPham_ChiTiet
CREATE TABLE SanPham_ChiTiet (
    Id_sanpham_chitiet INT IDENTITY(1,1) PRIMARY KEY,
    Id_sanpham INT NOT NULL,
    Id_mau_sac UNIQUEIDENTIFIER NOT NULL,
    Id_kich_co UNIQUEIDENTIFIER NOT NULL,
    So_luong INT NOT NULL,
    Gia DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (Id_sanpham) REFERENCES SanPham(Id_san_pham),
    FOREIGN KEY (Id_mau_sac) REFERENCES MauSac(Id_mau_sac),
    FOREIGN KEY (Id_kich_co) REFERENCES KichCo(Id_kich_co)
);

-- Bảng KhuyenMai
CREATE TABLE KhuyenMai (
    Id_khuyen_mai UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Id_sanpham_chitiet INT NOT NULL,
    Giam_gia DECIMAL(18, 2) NOT NULL,
    Ngay_bat_dau DATE NOT NULL,
    Ngay_ket_thuc DATE NOT NULL,
    Trang_thai_khuyen_mai BIT NOT NULL,
    Loai_giam_gia BIT NOT NULL, -- 0: % giảm, 1: Số tiền giảm
    FOREIGN KEY (Id_sanpham_chitiet) REFERENCES SanPham_ChiTiet(Id_sanpham_chitiet)
);

-- Bảng ChucVu
CREATE TABLE ChucVu (
    Id_chucvu INT IDENTITY(1,1) PRIMARY KEY,
    Ten_chuc_vu NVARCHAR(255) NOT NULL
);

-- Bảng NhanVien
CREATE TABLE NhanVien (
    Id_nhanvien UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Id_chucvu INT NOT NULL,
    Ten_nhan_vien NVARCHAR(255) NOT NULL,
    Gioi_tinh NVARCHAR(50),
    Ngay_sinh DATE,
    Dia_chi NVARCHAR(500),
    Dien_thoai NVARCHAR(15),
    Email NVARCHAR(255),
    Mat_khau NVARCHAR(255) NOT NULL,
    FOREIGN KEY (Id_chucvu) REFERENCES ChucVu(Id_chucvu)
);

-- Bảng Khach
CREATE TABLE Khach (
    So_dien_thoai NVARCHAR(15) PRIMARY KEY,
    Ten_khach_hang NVARCHAR(255),
    Dia_chi NVARCHAR(255)
);

-- Bảng PhieuQuaTang
CREATE TABLE PhieuQuaTang (
    Id_phieuquatang UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Ten_phieu_qua_tang NVARCHAR(255) NOT NULL,
    So_luong_phieu INT NOT NULL,
    So_tien_giam_toi_da DECIMAL(18, 2) NOT NULL,
    Loai_giam_gia BIT NOT NULL, -- 0: % giảm, 1: Số tiền giảm
    Ngay_bat_dau DATE NOT NULL,
    Ngay_ket_thuc DATE NOT NULL
);

-- Bảng PhuongThucThanhToan
CREATE TABLE PhuongThucThanhToan (
    Id_phuongthucthanhtoan INT IDENTITY(1,1) PRIMARY KEY,
    Ten_phuong_thuc_thanh_toan NVARCHAR(255) NOT NULL
);

-- Bảng HoaDon
CREATE TABLE HoaDon (
    Id_hoadon UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Id_khach NVARCHAR(15) NOT NULL,
    Id_nhan_vien UNIQUEIDENTIFIER NOT NULL,
    Id_phieuquatang UNIQUEIDENTIFIER,
    Id_phuongthucthanhtoan INT NOT NULL,
    Tong_so_tien_hoa_don DECIMAL(18, 2) NOT NULL,
    Trang_thai_thanh_toan BIT NOT NULL,
    FOREIGN KEY (Id_khach) REFERENCES Khach(So_dien_thoai),
    FOREIGN KEY (Id_nhan_vien) REFERENCES NhanVien(Id_nhanvien),
    FOREIGN KEY (Id_phieuquatang) REFERENCES PhieuQuaTang(Id_phieuquatang),
    FOREIGN KEY (Id_phuongthucthanhtoan) REFERENCES PhuongThucThanhToan(Id_phuongthucthanhtoan)
);


-- Bảng HoaDon_ChiTiet
CREATE TABLE HoaDon_ChiTiet (
    Id_hoadon_chitiet UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Id_hoadon UNIQUEIDENTIFIER NOT NULL,
    Id_sanpham_chitiet INT NOT NULL,
    Tong_so_tien DECIMAL(18, 2) NOT NULL,
    So_luong_san_pham INT NOT NULL,
    FOREIGN KEY (Id_sanpham_chitiet) REFERENCES SanPham_ChiTiet(Id_sanpham_chitiet),
    FOREIGN KEY (Id_hoadon) REFERENCES HoaDon(Id_hoadon)
);

