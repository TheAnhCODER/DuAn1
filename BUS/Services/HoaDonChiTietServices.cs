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
            var maspct = Guid.Parse(maSPCT);
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
        public void DeleteHDCTById(string mahoadon, string maSPCT)
        {
            hoaDonChiTietRespo.DeleteHDCTById(Guid.Parse(mahoadon), Guid.Parse(maSPCT));
        }


        public void DeleteAllHDCTByMaHoaDon(string maHoaDon)
        {
            hoaDonChiTietRespo.DeleteAllHDCTByMaHoaDon(Guid.Parse(maHoaDon));
        }





        // Phương thức để lấy tổng số lượng hóa đơn đã bán ra theo mốc thời gian
        public async Task<int> GetTotalQuantitySoldByDateAsync(DateTime startDate, DateTime endDate)
        {
            return await hoaDonChiTietRespo.GetTotalQuantitySoldByDateAsync(startDate, endDate);
        }












        public List<HoaDonChiTiet> GetAllHoaDonChiTiet()
        {
            return hoaDonChiTietRespo.GetAllHoaDonChiTiet();
        }


        public IEnumerable<HoaDonChiTiet> GetInvoiceDetailsByInvoiceId(Guid idHoadon)
        {
            return hoaDonChiTietRespo.GetInvoiceDetailsByInvoiceId(idHoadon);
        }
    }
}
