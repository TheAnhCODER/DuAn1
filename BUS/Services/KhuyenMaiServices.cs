using DAL.Models;
using DAL.Responsitories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BUS.Services
{
    public class KhuyenMaiServices
    {
        private readonly KhuyenMaiRespo _khuyenMaiRepos;


        public KhuyenMaiServices()
        {
            _khuyenMaiRepos = new KhuyenMaiRespo();

        }
        


        public List<KhuyenMai> CNShow()
        {
            return _khuyenMaiRepos.GetAll();//vi get all cung tra ve list minh can
        }

        //tim
        public List<KhuyenMai> CNTim(string ten)
        {
            return _khuyenMaiRepos.GetTH(ten);
        }

        //them
        public string CNThem(string ten, decimal giamGia, DateTime ngayBatDau, DateTime NgayKetThuc, bool LoaiGiamGia)
        {

            if (IsProductExists(ten, giamGia, ngayBatDau, NgayKetThuc, LoaiGiamGia))
            {
                return "Khuyến mãi đã tồn tại";
            }
            KhuyenMai khuyenMai = new KhuyenMai()//tao ra 1 doi tuong chua thong tin duoc truyen vao
            {
                TenKhuyenMai = ten,
                GiamGia = giamGia,
                NgayBatDau = ngayBatDau,
                NgayKetThuc = NgayKetThuc,
                LoaiGiamGia = LoaiGiamGia,
            };
            if (_khuyenMaiRepos.AddTH(khuyenMai))
            {
                return "Thêm thành công";
            }
            else
                return "Thêm thất bại";
        }

        //sua
        public string CNSua(string idkhuyenmai, string ten, decimal giamGia, DateTime ngayBatDau, DateTime NgayKetThuc, bool LoaiGiamGia)
        {
            var idkhuyenMai = Guid.Parse(idkhuyenmai);
            if (IsProductExists(ten, giamGia, ngayBatDau, NgayKetThuc, LoaiGiamGia))
            {
                return "Khuyến mãi đã tồn tại";
            }
            KhuyenMai khuyenMai = new KhuyenMai()//tao ra 1 doi tuong chua thong tin duoc truyen vao
            {
                IdKhuyenMai = idkhuyenMai,
                TenKhuyenMai = ten,
                GiamGia = giamGia,
                NgayBatDau = ngayBatDau,
                NgayKetThuc = NgayKetThuc,
                LoaiGiamGia = LoaiGiamGia,
            };
            if (_khuyenMaiRepos.UpdateTH(khuyenMai))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";

        }

        public bool IsProductExists(string tenkhuyenmai, decimal giamGia, DateTime ngayBatDau, DateTime NgayKetThuc, bool LoaiGiamGia)
        {
            return _khuyenMaiRepos.IsProductExists(tenkhuyenmai, giamGia,ngayBatDau,NgayKetThuc,LoaiGiamGia);
        }

        public Dictionary<Guid, List<KhuyenMai>> GetAllCurrentKhuyenMaiBySanPhamChiTiet()
        {
            return _khuyenMaiRepos.GetAllCurrentKhuyenMaiBySanPhamChiTiet();
        }

       


    }
}
