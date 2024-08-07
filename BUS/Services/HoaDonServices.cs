using DAL.Models;
using DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonServices
    {
        HoaDonRespo hoaDonRespo = new HoaDonRespo();

        public HoaDon? GetHoaDonbyMaHoaDon(string maHoaDon)
        {
            var mahoadon = Guid.Parse(maHoaDon);
            return hoaDonRespo.GetHoaDonbyMaHoaDon(mahoadon);
        }

        public List<HoaDon> GetAllHoaDons()
        {
            return hoaDonRespo.GetAllHoaDons();
        }

        public List<HoaDon> GetAllHoaDonChos()
        {
            return hoaDonRespo.GetAllHoaDons().Where(hd => hd.TrangThaiThanhToan == 0).ToList();
        }
        public List<HoaDon> GetAllHoaDon1()
        {
            return hoaDonRespo.GetAllHoaDons().Where(hd => hd.TrangThaiThanhToan == 1).ToList();
        }
        public void TaoHoaDonCho(HoaDon hoaDon)
        {
            hoaDonRespo.TaoHoaDonCho(hoaDon);
        }
        public void updateSDTKhachHang(string mahoadon, string sdt)
        {
            var mahd = Guid.Parse(mahoadon);
            hoaDonRespo.SuaSDT(mahd, sdt);
        }

        public void SuaTrangThai(string maHoaDon, int trangThai, int phuongthuocthanhtoan, decimal tongtien, string sodienthoaikhachhang)
        {
            var mahoadon = Guid.Parse(maHoaDon);
            hoaDonRespo.SuaTrangThai(mahoadon, trangThai, phuongthuocthanhtoan, tongtien, sodienthoaikhachhang);
        }
        public List<HoaDon> GetHoaDonByTrangThai(int trangThai)
        {
            return hoaDonRespo.GetHoaDonByTrangThaiThanhToan(trangThai);
        }

        public List<HoaDon> GetHoaDonByDate(DateTime date)
        {
            return hoaDonRespo.GetHoaDonByDate(date);
        }

        public List<HoaDon> GetHoaDonByPhoneNumber(string phoneNumber)
        {
            return hoaDonRespo.GetHoaDonByPhoneNumber(phoneNumber);
        }

        public List<HoaDon> GetHoaDonsByDateRange(DateTime startDate, DateTime endDate)
        {
            // Business logic (if any) can be added here before calling the repository
            return hoaDonRespo.GetHoaDonsByDateRange(startDate, endDate);
        }

        public IEnumerable<int> GetAvailableYears()
        {
            return hoaDonRespo.GetAvailableYears();
        }
        public decimal GetTotalRevenueByMonth(int month, int year)
        {
            return hoaDonRespo.GetTotalRevenueByMonth(month, year);
        }
        public decimal GetTotalRevenueByYear(int year)
        {
            return hoaDonRespo.GetTotalRevenueByYear(year);
        }
        // Đếm số hóa đơn theo tháng và năm
        public int GetNumberOfInvoicesByMonth(int month, int year)
        {
            return hoaDonRespo.CountInvoicesByMonth(month, year);
        }

        // Đếm số hóa đơn theo năm
        public int GetNumberOfInvoicesByYear(int year)
        {
            return hoaDonRespo.CountInvoicesByYear(year);
        }

        public Dictionary<Guid, int> GetProductSalesCountsByMonth(int year, int month)
        {
            return hoaDonRespo.GetProductSalesCountsByMonth(year, month);
        }

        public Dictionary<Guid, int> GetProductSalesCountsByYear(int year)
        {
            return hoaDonRespo.GetProductSalesCountsByYear(year);
        }

        public List<int> GetMonthsWithDataByYear(int year)
        {
            return hoaDonRespo.GetMonthsWithDataByYear(year);
        }

        public decimal GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            return hoaDonRespo.GetTotalRevenue(startDate, endDate);
        }

        public int GetInvoiceCount(DateTime startDate, DateTime endDate)
        {
            return hoaDonRespo.GetInvoiceCount(startDate, endDate);
        }

        public int GetProductCount(DateTime startDate, DateTime endDate)
        {
            return hoaDonRespo.GetProductCount(startDate, endDate);
        }

        public int GetCustomerCount(DateTime startDate, DateTime endDate)
        {
            return hoaDonRespo.GetCustomerCount(startDate, endDate);
        }

        public List<HoaDon> GetHoaDonsByYearAndMonth(int year, int month)
        {
            return hoaDonRespo.GetHoaDonsByYearAndMonth(year, month);
        }

        public List<HoaDon> GetInvoicesByYear(int year)
        {
            return hoaDonRespo.GetInvoicesByYear(year);
        }

        public List<HoaDonChiTiet> GetInvoiceDetailsByInvoiceId(Guid invoiceId)
        {
            return hoaDonRespo.GetInvoiceDetailsByInvoiceId(invoiceId);
        }

        public List<HoaDon> GetHoaDonsByDateRanges(DateTime startDate, DateTime endDate)
        {
            return hoaDonRespo.GetHoaDonsByDateRanges(startDate, endDate);
        }
    }
}
