using DAL.Models;
using Microsoft.EntityFrameworkCore;
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

        public void DeleteAllHDCTByMaHoaDon(Guid maHoaDon)
        {
            // Thêm logic để xóa tất cả các chi tiết hóa đơn theo mã hóa đơn
            // Ví dụ:
            var hoaDonChiTietList = GetAllHoaDonCTByMaHoaDon(maHoaDon);
            foreach (var hdct in hoaDonChiTietList)
            {
                // Xóa chi tiết hóa đơn
                dbContext.HoaDonChiTiets.Remove(hdct);
            }
            dbContext.SaveChanges();
        }


        public void DeleteHDCTById(Guid maHoaDon, Guid maSPCT)
        {
            // Thêm logic để xóa chi tiết hóa đơn
            var hdct = dbContext.HoaDonChiTiets.SingleOrDefault(h => h.MaHoaDon == maHoaDon && h.MaSpct == maSPCT);
            if (hdct != null)
            {
                dbContext.HoaDonChiTiets.Remove(hdct);
                dbContext.SaveChanges();
            }
        }






        // Phương thức để lấy tổng số lượng hóa đơn đã bán ra theo mốc thời gian (ngày, tháng, năm)
        public async Task<int> GetTotalQuantitySoldByDateAsync(DateTime startDate, DateTime endDate)
        {
            return await dbContext.HoaDonChiTiets
                .Where(hdct => dbContext.HoaDons
                    .Any(hd => hd.IdHoadon == hdct.MaHoaDon && hd.NgayTao >= startDate && hd.NgayTao <= endDate))
                .SumAsync(hdct => hdct.SoLuong ?? 0);
        }




















        public List<HoaDonChiTiet> GetAllHoaDonChiTiet()
        {
            return dbContext.HoaDonChiTiets.ToList();
        }



        public List<HoaDonChiTiet> GetInvoiceDetailsByInvoiceId(Guid idHoadon)
        {
            return dbContext.HoaDonChiTiets
                .Where(hdct => hdct.MaHoaDon == idHoadon)
                .ToList();
        }
    }
}
