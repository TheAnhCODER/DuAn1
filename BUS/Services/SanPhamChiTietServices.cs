﻿using DAL.Models;
using DAL.Responsitories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SanPhamChiTietServices
    {
        private readonly SanPhamChiTietRespo _repo;

        public SanPhamChiTietServices()
        {
            _repo = new SanPhamChiTietRespo();
        }

        // Lấy tất cả danh mục
        public List<SanPhamChiTiet> CNShow()
        {
            return _repo.GetAll();
        }

        public async Task<List<SanPhamChiTiet>> GetSanPhamByKhuyenMaiIdAsync(Guid khuyenMaiId)
        {
            return await _repo.GetSanPhamByKhuyenMaiIdAsync(khuyenMaiId);
        }

        // Thêm danh mục mới
        public string CNThem(string idSP, string idMauSac, string idKichCo, int SoLuong, decimal gia)
        {
            var idmausac = Guid.Parse(idMauSac);
            var idkichco = Guid.Parse(idKichCo);
            var idsp = Guid.Parse(idSP);

            if (IsProductExists(idmausac, idkichco, idsp))
            {
                return "Sản phẩm đã tồn tại";
            }
            SanPhamChiTiet sanPhamChiTIet = new SanPhamChiTiet()
            {
                IdSanPham = Guid.Parse(idSP),
                IdMauSac = Guid.Parse(idMauSac),
                IdKichCo = Guid.Parse(idKichCo),
                SoLuong = SoLuong,
                Gia = gia
            };
            if (_repo.AddSPCT(sanPhamChiTIet))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        // Sửa spct
        public string CNSua(string idSPCT, string idSP, string idMauSac, string idKichCo, int SoLuong, decimal gia)
        {

            SanPhamChiTiet sanPhamChiTIet = new SanPhamChiTiet()
            {
                IdSanphamChitiet = Guid.Parse(idSPCT),
                IdSanPham = Guid.Parse(idSP),
                IdMauSac = Guid.Parse(idMauSac),
                IdKichCo = Guid.Parse(idKichCo),
                SoLuong = SoLuong,
                Gia = gia
            };
            if (_repo.UpdateSPCT(sanPhamChiTIet))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        //tim theo mau sac
        public List<SanPhamChiTiet> GetSPCTByMauSac(Guid idMauSac)
        {
            return _repo.GetSPCTByMauSac(idMauSac);
        }

        //tim theo kichco
        public List<SanPhamChiTiet> GetSPCTByKichCo(Guid idKichCo)
        {

            return _repo.GetSPCTByKichCo(idKichCo);
        }

        // Tìm spct theo masp
        public List<SanPhamChiTiet> GetSPCTBySanPham(Guid maSP)
        {
            return _repo.GetSPCTByMASP(maSP);
        }

        // Lấy tất cả sp dang kinh doanh
        public List<SanPhamChiTiet> CNShowSPDangKinhDoanh()
        {
            return _repo.GetAllSPDangKinhDoanh();
        }
        public List<SanPhamChiTiet> CNShowSPDangKinhDoanhLoad()
        {
            return _repo.GetAllSPDangKinhDoanhLoad();
        }
        public List<SanPhamChiTiet> GetAllSPDangKinhDoanhAndSale()
        {
            return _repo.GetAllSPDangKinhDoanhAndSale();
        }

        public List<SanPhamChiTiet> TimkiemSpBanHangTheoTen(string tensanpham)
        {
            return _repo.SearchSanPhamByName(tensanpham);
        }

        public bool IsProductExists(Guid idDanhMuc, Guid idThuongHieu, Guid idSp)
        {
            return _repo.IsProductExists(idDanhMuc, idThuongHieu, idSp);
        }

        public SanPhamChiTiet GetAllSanPhamChiTietById(string maSPCT)
        {
            var maspct = Guid.Parse(maSPCT);
            return _repo.GetAllSanPhamChiTietById(maspct);
        }
        public void UpdateSoLuong(SanPhamChiTiet spctNew)
        {
            _repo.UpdateSoLuong(spctNew);
        }
        public Dictionary<Guid, string> GetMaSanPhamDict()
        {

            var sanPhamList = _repo.GetAll();
            return sanPhamList.ToDictionary(sp => sp.IdSanphamChitiet, sp => Convert.ToString(sp.IdSanPham));
        }
        public void UpdateProductPrice(Guid productId, decimal newPrice)
        {
            _repo.UpdateProductPrice(productId, newPrice);
        }






    }
}
