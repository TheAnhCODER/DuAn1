using DAL.Models;
using DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonChiTietServices
    {

        HoaDonChiTietRespo hoaDonChiTietRespo = new HoaDonChiTietRespo();

        public List<HoaDonChiTiet> GetAllHoaDonCTByMaHoaDon(string maHoaDon)
        {
            var mahoadon = Guid.Parse(maHoaDon);
            return hoaDonChiTietRespo.GetAllHoaDonCTByMaHoaDon(mahoadon);
        }

        public HoaDonChiTiet? GetHDCTById(string maHoaDon, string maSPCT)
        {
            var mahoadon = Guid.Parse(maHoaDon);
            var maspct = Guid.Parse(maHoaDon);
            return hoaDonChiTietRespo.GetHDCTById(mahoadon, maspct);
        }

        public void ThemMoiHDCT(HoaDonChiTiet hdct)
        {
            hoaDonChiTietRespo.ThemMoiHDCT(hdct);
        }

        public void UpdateSoLuong(HoaDonChiTiet hdctNew)
        {
            hoaDonChiTietRespo.UpdateSoLuong(hdctNew);
        }




    }
}
