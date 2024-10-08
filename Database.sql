﻿-- Tạo cơ sở dữ liệu
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
	 Trang_thai bit not null default 1
    FOREIGN KEY (id_chucvu) REFERENCES ChucVu(id_chucvu)
);



CREATE TABLE Khach (
    So_dien_thoai NVARCHAR(20) PRIMARY KEY,
    Ten_khach_hang NVARCHAR(255) NOT NULL,
    Dia_chi NVARCHAR(255)
);

CREATE TABLE PhuongThucThanhToan (
    id_phuongthucthanhtoan int PRIMARY KEY identity(1,1),
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
	Gia_sau_giam DECIMAL(18, 2),
    FOREIGN KEY (id_san_pham) REFERENCES SanPham(id_san_pham),
    FOREIGN KEY (id_mau_sac) REFERENCES MauSac(id_mau_sac),
    FOREIGN KEY (id_kich_co) REFERENCES KichCo(id_kich_co)
);


CREATE TABLE KhuyenMai (
    IdKhuyenMai UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	TenKhuyenMai nvarchar(255),
    GiamGia DECIMAL(18, 2),
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    TrangThai BIT NOT NULL default 1,
    LoaiGiamGia BIT NOT NULL,
);

CREATE TABLE KhuyenMaiSPCT (
    Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    IdKhuyenMai UNIQUEIDENTIFIER NOT NULL,
    IdSanPhamChiTiet UNIQUEIDENTIFIER NOT NULL,
    FOREIGN KEY (IdKhuyenMai) REFERENCES KhuyenMai(IdKhuyenMai),
    FOREIGN KEY (IdSanPhamChiTiet) REFERENCES SanPham_ChiTiet(id_sanpham_chitiet)
);
CREATE PROCEDURE UpdateKhuyenMaiStatus
AS
BEGIN
    -- Cập nhật trạng thái của khuyến mãi
    UPDATE KhuyenMai
    SET TrangThai = 0
    WHERE NgayKetThuc < CAST(GETDATE() AS DATE) AND TrangThai = 1;

    -- Cập nhật giá sau giảm của sản phẩm chi tiết về NULL cho các khuyến mãi đã kết thúc
    UPDATE SanPham_ChiTiet
    SET Gia_sau_giam = NULL
    WHERE id_sanpham_chitiet IN (
        SELECT IdSanPhamChiTiet
        FROM KhuyenMaiSPCT
        WHERE IdKhuyenMai IN (
            SELECT IdKhuyenMai
            FROM KhuyenMai
            WHERE NgayKetThuc < CAST(GETDATE() AS DATE) AND TrangThai = 0
        )
    );
END
GO

drop proc UpdateKhuyenMaiStatus


CREATE TABLE HoaDon (
    id_hoadon UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    So_dien_thoai NVARCHAR(20),
    ID_nhanvien UNIQUEIDENTIFIER,
    id_phuongthucthanhtoan int,
    Tong_so_tien_hoa_don DECIMAL(18, 2) NOT NULL,
    Trang_thai_thanh_toan int NOT NULL default '0', --0: chua thanh toan, 1: da thanh toan, 2: da huy
	Ngay_tao DATETIME DEFAULT GETDATE(),
	Ngay_thanh_toan datetime,
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
    SELECT ID_nhanvien, id_chucvu, Ten_nhan_vien, Gioi_tinh, Ngay_sinh, Dia_chi, Dien_thoai, Email, Mat_khau, Trang_thai
    FROM NhanVien
    WHERE (Email = @Email OR Dien_thoai = @Email) 
      AND Mat_khau = @MatKhau 
      AND Trang_thai = 1;
END

--drop PROC sp_CheckLogin




-- Chèn dữ liệu vào bảng ChucVu
INSERT INTO ChucVu ( Ten_chuc_vu) VALUES ( N'admin');
INSERT INTO ChucVu ( Ten_chuc_vu) VALUES ( N'Nhân viên bán hàng');

INSERT INTO PhuongThucThanhToan( Ten_phuong_thuc_thanh_toan) VALUES ( N'Tiền mặt');
INSERT INTO PhuongThucThanhToan ( Ten_phuong_thuc_thanh_toan) VALUES ( N'Chuyển khoản');

-- Chèn dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (ID_nhanvien, id_chucvu, Ten_nhan_vien, Gioi_tinh, Ngay_sinh, Dia_chi, Dien_thoai, Email, Mat_khau)
VALUES (NEWID(), 1, N'Đinh Thế Anh', N'Nam', '2005-01-29', N'Phú Thọ', '0946826098', 'dinhtheanhts29012005@gmail.com', '123456');
INSERT INTO NhanVien (ID_nhanvien, id_chucvu, Ten_nhan_vien, Gioi_tinh, Ngay_sinh, Dia_chi, Dien_thoai, Email, Mat_khau)
VALUES (NEWID(), 2, N'Vũ Anh Đức', N'Nam', '2005-07-18', N'Hà Nội', '0986184820', 'ducvaph51402@gmail.com', '123456');

-- Chèn dữ liệu vào bảng Khach
INSERT INTO Khach (So_dien_thoai, Ten_khach_hang, Dia_chi) VALUES ('0987654321', N'Lê Thị D', N'Hồ Chí Minh');

INSERT INTO MauSac (id_mau_sac, Ten_mau_sac)
VALUES 
    (NEWID(), N'Đen'),
    (NEWID(), N'Trắng'),
    (NEWID(), N'Đỏ'),
    (NEWID(), N'Xanh dương'),
    (NEWID(), N'Xanh lá'),
    (NEWID(), N'Nâu'),
    (NEWID(), N'Hồng');


INSERT INTO KichCo (id_kich_co, Kich_co)
VALUES 
    (NEWID(), N'S'),
    (NEWID(), N'M'),
    (NEWID(), N'L'),
    (NEWID(), N'XL'),
    (NEWID(), N'XXL'),
    (NEWID(), N'38'),
    (NEWID(), N'39'),
    (NEWID(), N'40'),
    (NEWID(), N'41'),
    (NEWID(), N'42'),
    (NEWID(), N'43');


INSERT INTO DanhMuc (id_danh_muc, Ten_danh_muc)
VALUES 
    (NEWID(), N'Giày'),
    (NEWID(), N'Áo'),
    (NEWID(), N'Quần'),
    (NEWID(), N'Túi xách'),
    (NEWID(), N'Phụ kiện');


INSERT INTO ThuongHieu (id_thuong_hieu, Ten_thuong_hieu)
VALUES 
    (NEWID(), N'Nike'),
    (NEWID(), N'Adidas'),
    (NEWID(), N'Puma'),
    (NEWID(), N'Gucci'),
    (NEWID(), N'Louis Vuitton'),
    (NEWID(), N'Zara'),
    (NEWID(), N'H&M'),
    (NEWID(), N'Uniqlo');


	INSERT INTO SanPham (id_san_pham, id_thuong_hieu, id_danh_muc, Ten_san_pham, Mo_ta, Trang_thai_san_pham)
VALUES 
    (NEWID(), (SELECT id_thuong_hieu FROM ThuongHieu WHERE Ten_thuong_hieu = N'Nike'), (SELECT id_danh_muc FROM DanhMuc WHERE Ten_danh_muc = N'Áo'), N'Áo thun Nike', N'Áo thun thể thao với chất liệu thoáng mát', 1),
    (NEWID(), (SELECT id_thuong_hieu FROM ThuongHieu WHERE Ten_thuong_hieu = N'Adidas'), (SELECT id_danh_muc FROM DanhMuc WHERE Ten_danh_muc = N'Áo'), N'Áo khoác Adidas', N'Áo khoác thể thao chất liệu nhẹ, chống nước', 1),
    (NEWID(), (SELECT id_thuong_hieu FROM ThuongHieu WHERE Ten_thuong_hieu = N'Puma'), (SELECT id_danh_muc FROM DanhMuc WHERE Ten_danh_muc = N'Áo'), N'Áo sơ mi Puma', N'Áo sơ mi kiểu dáng hiện đại, phù hợp cho công sở', 1),
    (NEWID(), (SELECT id_thuong_hieu FROM ThuongHieu WHERE Ten_thuong_hieu = N'Gucci'), (SELECT id_danh_muc FROM DanhMuc WHERE Ten_danh_muc = N'Áo'), N'Áo len Gucci', N'Áo len cao cấp, thiết kế thời trang', 1),
    (NEWID(), (SELECT id_thuong_hieu FROM ThuongHieu WHERE Ten_thuong_hieu = N'Louis Vuitton'), (SELECT id_danh_muc FROM DanhMuc WHERE Ten_danh_muc = N'Áo'), N'Áo sơ mi Louis Vuitton', N'Áo sơ mi thiết kế sang trọng, chất liệu cao cấp', 1),
    (NEWID(), (SELECT id_thuong_hieu FROM ThuongHieu WHERE Ten_thuong_hieu = N'Zara'), (SELECT id_danh_muc FROM DanhMuc WHERE Ten_danh_muc = N'Quần'), N'Quần jeans Zara', N'Quần jeans thiết kế trẻ trung, chất liệu bền', 1),
    (NEWID(), (SELECT id_thuong_hieu FROM ThuongHieu WHERE Ten_thuong_hieu = N'H&M'), (SELECT id_danh_muc FROM DanhMuc WHERE Ten_danh_muc = N'Quần'), N'Quần tây H&M', N'Quần tây thiết kế thanh lịch, chất liệu mềm mại', 1),
    (NEWID(), (SELECT id_thuong_hieu FROM ThuongHieu WHERE Ten_thuong_hieu = N'Uniqlo'), (SELECT id_danh_muc FROM DanhMuc WHERE Ten_danh_muc = N'Quần'), N'Quần shorts Uniqlo', N'Quần shorts thoáng mát, phù hợp cho mùa hè', 1);
   
   INSERT INTO SanPham_ChiTiet (id_sanpham_chitiet, id_san_pham, id_mau_sac, id_kich_co, So_luong, Gia, Gia_sau_giam)
VALUES
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Áo thun Nike'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Đen'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'M'), 100, 350000, 330000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Áo thun Nike'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Trắng'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'L'), 80, 350000, 320000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Áo khoác Adidas'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Xám'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'L'), 60, 800000, 750000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Áo khoác Adidas'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Xanh dương'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'XL'), 50, 800000, 700000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Áo sơ mi Puma'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Trắng'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'M'), 70, 600000, 580000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Áo sơ mi Puma'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Xám'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'L'), 50, 600000, 590000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Áo len Gucci'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Beige'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'M'), 20, 1500000, 1400000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Áo len Gucci'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Đen'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'L'), 15, 1500000, 1450000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Áo sơ mi Louis Vuitton'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Xanh dương'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'L'), 25, 2000000, 1900000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Áo sơ mi Louis Vuitton'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Trắng'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'M'), 20, 2000000, 1850000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Quần jeans Zara'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Đen'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'38'), 100, 500000, 480000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Quần jeans Zara'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Xanh nhạt'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'39'), 90, 500000, 460000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Quần tây H&M'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Xám'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'40'), 80, 600000, 580000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Quần tây H&M'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Đen'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'42'), 70, 600000, 570000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Quần shorts Uniqlo'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Xanh lá'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'S'), 150, 400000, 380000),
    (NEWID(), (SELECT id_san_pham FROM SanPham WHERE Ten_san_pham = N'Quần shorts Uniqlo'), (SELECT id_mau_sac FROM MauSac WHERE Ten_mau_sac = N'Cam'), (SELECT id_kich_co FROM KichCo WHERE Kich_co = N'M'), 120, 400000, 370000);
   
