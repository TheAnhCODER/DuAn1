-- Tạo cơ sở dữ liệu
CREATE DATABASE DuAn1;
GO

USE DuAn1;
GO

CREATE TABLE ChucVu (
    id_chucvu INT IDENTITY(1,1) PRIMARY KEY,
    Ten_chuc_vu NVARCHAR(255) NOT NULL
);

CREATE TABLE NhanVien (
    ID_nhanvien UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    id_chucvu INT,
    Ten_nhan_vien NVARCHAR(255) NOT NULL,
    Gioi_tinh NVARCHAR(10),
    Ngay_sinh DATE,
    Dia_chi NVARCHAR(255),
    Dien_thoai NVARCHAR(20),
    Email NVARCHAR(255),
    Mat_khau NVARCHAR(255),
    FOREIGN KEY (id_chucvu) REFERENCES ChucVu(id_chucvu)
);

CREATE TABLE Khach (
    So_dien_thoai NVARCHAR(20) PRIMARY KEY,
    Ten_khach_hang NVARCHAR(255) NOT NULL,
    Dia_chi NVARCHAR(255)
);

CREATE TABLE PhuongThucThanhToan (
    id_phuongthucthanhtoan UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    Ten_phuong_thuc_thanh_toan NVARCHAR(255) NOT NULL
);

CREATE TABLE MauSac (
    id_mau_sac UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    Ten_mau_sac NVARCHAR(255) NOT NULL
);

CREATE TABLE KichCo (
    id_kich_co UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    Kich_co NVARCHAR(50) NOT NULL
);

CREATE TABLE DanhMuc (
    id_danh_muc UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    Ten_danh_muc NVARCHAR(255) NOT NULL
);

CREATE TABLE ThuongHieu (
    id_thuong_hieu UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    Ten_thuong_hieu NVARCHAR(255) NOT NULL
);

CREATE TABLE SanPham (
    id_san_pham UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    id_thuong_hieu UNIQUEIDENTIFIER,
    id_danh_muc UNIQUEIDENTIFIER,
    Ten_san_pham NVARCHAR(255) NOT NULL,
    Mo_ta NVARCHAR(MAX),
    Trang_thai_san_pham BIT NOT NULL,
    FOREIGN KEY (id_thuong_hieu) REFERENCES ThuongHieu(id_thuong_hieu),
    FOREIGN KEY (id_danh_muc) REFERENCES DanhMuc(id_danh_muc)
);


CREATE TABLE SanPham_ChiTiet (
    id_sanpham_chitiet UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    id_san_pham UNIQUEIDENTIFIER,
    id_mau_sac UNIQUEIDENTIFIER,
    id_kich_co UNIQUEIDENTIFIER,
    So_luong INT NOT NULL,
	Gia DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (id_san_pham) REFERENCES SanPham(id_san_pham),
    FOREIGN KEY (id_mau_sac) REFERENCES MauSac(id_mau_sac),
    FOREIGN KEY (id_kich_co) REFERENCES KichCo(id_kich_co)
);

CREATE TABLE KhuyenMai (
    id_khuyen_mai UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    id_sanpham_chitiet UNIQUEIDENTIFIER,
    Giam_gia DECIMAL(18, 2),
    Ngay_bat_dau DATE,
    Ngay_ket_thuc DATE,
    Trang_thai BIT,
    Loai_giam_gia NVARCHAR(255),
    FOREIGN KEY (id_sanpham_chitiet) REFERENCES SanPham_ChiTiet(id_sanpham_chitiet)
);

CREATE TABLE HoaDon (
    id_hoadon UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    So_dien_thoai NVARCHAR(20),
    ID_nhanvien UNIQUEIDENTIFIER,
    id_phuongthucthanhtoan UNIQUEIDENTIFIER,
    Tong_so_tien_hoa_don DECIMAL(18, 2) NOT NULL,
    Trang_thai_thanh_toan int NOT NULL default '0', --0: chua thanh toan, 1: da thanh toan, 2: da huy
	Ngay_tao DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (So_dien_thoai) REFERENCES Khach(So_dien_thoai),
    FOREIGN KEY (ID_nhanvien) REFERENCES NhanVien(ID_nhanvien),
    FOREIGN KEY (id_phuongthucthanhtoan) REFERENCES PhuongThucThanhToan(id_phuongthucthanhtoan)
);

CREATE TABLE dbo.HoaDonChiTiet (
    MaSPCT UNIQUEIDENTIFIER NOT NULL,
    MaHoaDon UNIQUEIDENTIFIER NOT NULL,
    DonGia DECIMAL(18, 2) NULL,
    SoLuong INT NULL,
    PRIMARY KEY (MaSPCT, MaHoaDon),
    FOREIGN KEY (MaSPCT) REFERENCES SanPham_ChiTiet(id_sanpham_chitiet),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(id_hoadon)
);
GO




	CREATE PROCEDURE sp_CheckLogin
		@Email NVARCHAR(255),
		@MatKhau NVARCHAR(255)

	AS
	BEGIN
	   SELECT Id_nhanvien, Id_chucvu, Ten_nhan_vien
		FROM NhanVien
		WHERE Email = @Email AND Mat_khau = @MatKhau or Dien_thoai = @Email and Mat_khau = @MatKhau;
	END

--drop PROC sp_CheckLogin




-- Chèn dữ liệu vào bảng ChucVu
INSERT INTO ChucVu ( Ten_chuc_vu) VALUES ( 'admin');
INSERT INTO ChucVu ( Ten_chuc_vu) VALUES ( 'Nhân viên bán hàng');

-- Chèn dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (ID_nhanvien, id_chucvu, Ten_nhan_vien, Gioi_tinh, Ngay_sinh, Dia_chi, Dien_thoai, Email, Mat_khau)
VALUES (NEWID(), 1, 'Đinh Thế Anh', 'Nam', '2005-01-29', 'Phú Thọ', '0946826098', 'dinhtheanhts29012005@gmail.com', '123456');
INSERT INTO NhanVien (ID_nhanvien, id_chucvu, Ten_nhan_vien, Gioi_tinh, Ngay_sinh, Dia_chi, Dien_thoai, Email, Mat_khau)
VALUES (NEWID(), 2, 'Vũ Anh Đức', 'Nam', '2005-07-18', 'Hà Nội', '0986184820', 'ducvaph51402@gmail.com', '123456');

-- Chèn dữ liệu vào bảng Khach
INSERT INTO Khach (So_dien_thoai, Ten_khach_hang, Dia_chi) VALUES ('0123456789', 'Nguyễn Văn C', 'Hà Nội');
INSERT INTO Khach (So_dien_thoai, Ten_khach_hang, Dia_chi) VALUES ('0987654321', 'Lê Thị D', 'Hồ Chí Minh');

-- Chèn dữ liệu vào bảng PhuongThucThanhToan
INSERT INTO PhuongThucThanhToan (id_phuongthucthanhtoan, Ten_phuong_thuc_thanh_toan) VALUES (NEWID(), 'Tiền mặt');
INSERT INTO PhuongThucThanhToan (id_phuongthucthanhtoan, Ten_phuong_thuc_thanh_toan) VALUES (NEWID(), 'Chuyển khoản');

-- Chèn dữ liệu vào bảng MauSac
INSERT INTO MauSac (id_mau_sac, Ten_mau_sac) VALUES (NEWID(), 'Đỏ');
INSERT INTO MauSac (id_mau_sac, Ten_mau_sac) VALUES (NEWID(), 'Xanh');

-- Chèn dữ liệu vào bảng KichCo
INSERT INTO KichCo (id_kich_co, Kich_co) VALUES (NEWID(), 'S');
INSERT INTO KichCo (id_kich_co, Kich_co) VALUES (NEWID(), 'M');

-- Chèn dữ liệu vào bảng DanhMuc
INSERT INTO DanhMuc (id_danh_muc, Ten_danh_muc) VALUES (NEWID(), 'Áo');
INSERT INTO DanhMuc (id_danh_muc, Ten_danh_muc) VALUES (NEWID(), 'Quần');

-- Chèn dữ liệu vào bảng ThuongHieu
INSERT INTO ThuongHieu (id_thuong_hieu, Ten_thuong_hieu) VALUES (NEWID(), 'Nike');
INSERT INTO ThuongHieu (id_thuong_hieu, Ten_thuong_hieu) VALUES (NEWID(), 'Adidas');

-- Chèn dữ liệu vào bảng SanPham
INSERT INTO SanPham (id_san_pham, id_thuong_hieu, id_danh_muc, Ten_san_pham, Gia, Mo_ta, Trang_thai_san_pham)
VALUES (NEWID(), (SELECT id_thuong_hieu FROM ThuongHieu WHERE Ten_thuong_hieu = 'Nike'), (SELECT id_danh_muc FROM DanhMuc WHERE Ten_danh_muc = 'Áo'), 'Áo Thun', 200000, 'Áo thun thể thao', 1);
INSERT INTO SanPham (id_san_pham, id_thuong_hieu, id_danh_muc, Ten_san_pham, Gia, Mo_ta, Trang_thai_san_pham)
VALUES (NEWID(), (SELECT id_thuong_hieu FROM ThuongHieu WHERE Ten_thuong_hieu = 'Adidas'), (SELECT id_danh_muc FROM DanhMuc WHERE Ten_danh_muc = 'Quần'), 'Quần Dài', 300000, 'Quần dài thể thao', 1);

-- Chèn dữ liệu vào bảng Anh_SanPham
INSERT INTO Anh_SanPham (id_anh_san_pham, id_san_pham, Anh_san_pham)
VALUES (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = 'Áo Thun'), 'https://example.com/ao_thun.jpg');
INSERT INTO Anh_SanPham (id_anh_san_pham, id_san_pham, Anh_san_pham)
VALUES (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = 'Quần Dài'), 'https://example.com/quan_dai.jpg');

-- Chèn dữ liệu vào bảng SanPham_ChiTiet
INSERT INTO SanPham_ChiTiet (id_sanpham_chitiet, id_san_pham, id_mau_sac, id_kich_co, So_luong, Trang_thai_san_pham)
VALUES (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = 'Áo Thun'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = 'Đỏ'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = 'S'), 100, 1);
INSERT INTO SanPham_ChiTiet (id_sanpham_chitiet, id_san_pham, id_mau_sac, id_kich_co, So_luong, Trang_thai_san_pham)
VALUES (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = 'Quần Dài'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = 'Xanh'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = 'M'), 50, 1);

-- Chèn dữ liệu vào bảng KhuyenMai
INSERT INTO KhuyenMai (id_khuyen_mai, id_sanpham_chitiet, Giam_gia, Ngay_bat_dau, Ngay_ket_thuc, Trang_thai, Loai_giam_gia)
VALUES (NEWID(), (SELECT id_sanpham_chitiet FROM SanPham_ChiTiet WHERE So_luong = 100), 10.0, '2024-07-01', '2024-07-31', 1, 'Phần trăm');
INSERT INTO KhuyenMai (id_khuyen_mai, id_sanpham_chitiet, Giam_gia, Ngay_bat_dau, Ngay_ket_thuc, Trang_thai, Loai_giam_gia)
VALUES (NEWID(), (SELECT id_sanpham_chitiet FROM SanPham_ChiTiet WHERE So_luong = 50), 50000, '2024-07-01', '2024-07-31', 1, 'Số tiền');

-- Chèn dữ liệu vào bảng HoaDon
INSERT INTO HoaDon (id_hoadon, So_dien_thoai, ID_nhanvien, id_phuongthucthanhtoan, Tong_so_tien_hoa_don, Trang_thai_thanh_toan)
VALUES (NEWID(), '0123456789', (SELECT ID_nhanvien FROM NhanVien WHERE Ten_nhan_vien = 'Đinh Thế Anh'), (SELECT id_phuongthucthanhtoan FROM PhuongThucThanhToan WHERE Ten_phuong_thuc_thanh_toan = 'Tiền mặt'), 500000, 1);
INSERT INTO HoaDon (id_hoadon, So_dien_thoai, ID_nhanvien, id_phuongthucthanhtoan, Tong_so_tien_hoa_don, Trang_thai_thanh_toan)
VALUES (NEWID(), '0987654321', (SELECT ID_nhanvien FROM NhanVien WHERE Ten_nhan_vien = 'Vũ Anh Đức'), (SELECT id_phuongthucthanhtoan FROM PhuongThucThanhToan WHERE Ten_phuong_thuc_thanh_toan = 'Chuyển Khoản'), 300000, 1);

-- Chèn dữ liệu vào bảng HoaDon_ChiTiet
INSERT INTO HoaDon_ChiTiet (id_hoadon_chitiet, id_hoadon, id_sanpham_chitiet, Tong_so_tien, So_luong_san_pham, Don_gia)
VALUES (NEWID(), (SELECT id_hoadon FROM HoaDon WHERE Tong_so_tien_hoa_don = 500000), (SELECT id_sanpham_chitiet FROM SanPham_ChiTiet WHERE So_luong = 100), 200000, 2, 100000);

