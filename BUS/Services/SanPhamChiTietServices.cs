﻿using DAL.Models;
using DAL.Responsitories;
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

        

        // Thêm danh mục mới
        public string CNThem(string idSP, string idMauSac, string idKichCo, int SoLuong, decimal gia)
        {
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
    }
}
