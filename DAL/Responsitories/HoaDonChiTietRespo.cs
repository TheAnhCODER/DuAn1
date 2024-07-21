using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Responsitories
{
    public class HoaDonChiTietRespo
    {

        DuAn1Context dbContext = new DuAn1Context();

        public List<HoaDonChiTiet> GetAllHoaDonCTByMaHoaDon(Guid maHoaDon)
        {
            return dbContext.HoaDonChiTiets.Where(hdct => hdct.MaHoaDon == maHoaDon).ToList();
        }

        public HoaDonChiTiet? GetHDCTById(Guid maHoaDon, Guid maSPCT)
        {
            return dbContext.HoaDonChiTiets
                .FirstOrDefault(hdct => hdct.MaHoaDon == maHoaDon && hdct.MaSpct == maSPCT);
        }

        public void ThemMoiHDCT(HoaDonChiTiet hdct)
        {
            dbContext.HoaDonChiTiets.Add(hdct);
            dbContext.SaveChanges();
        }

        public void UpdateSoLuong(HoaDonChiTiet hdctNew)
        {
            var hdctOld = GetHDCTById(hdctNew.MaHoaDon, hdctNew.MaSpct);
            if (hdctOld != null)
            {
                hdctOld.SoLuong = hdctNew.SoLuong;
            }
            dbContext.SaveChanges();
        }
    }
}
