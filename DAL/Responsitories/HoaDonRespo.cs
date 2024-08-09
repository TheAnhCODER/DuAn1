using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Responsitories
{
    public class HoaDonRespo
    {
        DuAn1Context _dbContext = new DuAn1Context();

        public HoaDon? GetHoaDonbyMaHoaDon(Guid maHoaDon)
        {
            return _dbContext.HoaDons.Find(maHoaDon);
        }

        public List<HoaDon> GetAllHoaDons()
        {
            using (var context = new DuAn1Context())
            {
                return context.HoaDons.ToList();
            }
        }


        public void TaoHoaDonCho(HoaDon hoaDon)
        {
            _dbContext.HoaDons.Add(hoaDon);
            _dbContext.SaveChanges();
        }

        public void SuaTrangThai(Guid maHoaDon, int trangThai, int phuongthucthanhtoan, decimal tongtien, string sodienthoai, DateTime ngaythanhtoan)
        {
            var hoaDonSua = _dbContext.HoaDons.Find(maHoaDon);
            if (hoaDonSua != null)
            {
                hoaDonSua.TrangThaiThanhToan = trangThai;
                hoaDonSua.IdPhuongthucthanhtoan = phuongthucthanhtoan;
                hoaDonSua.TongSoTienHoaDon = tongtien;
                hoaDonSua.SoDienThoai = sodienthoai;
                hoaDonSua.NgayThanhToan = ngaythanhtoan;
            }
            _dbContext.SaveChanges();
        }
        public void SuaSDT(Guid maHD, string sdt)
        {
            var hoaDonSua = _dbContext.HoaDons.Find(maHD);
            if (hoaDonSua != null)
            {
                hoaDonSua.SoDienThoai = sdt;
            }
            _dbContext.SaveChanges();
        }

        public List<HoaDon> GetHoaDonByTrangThaiThanhToan(int trangThaiThanhToan)
        {
            return _dbContext.HoaDons.Where(hd => hd.TrangThaiThanhToan == trangThaiThanhToan).ToList();
        }

        public List<HoaDon> GetHoaDonByDate(DateTime date)
        {
            // Xác định bắt đầu và kết thúc của ngày
            DateTime startOfDay = date.Date;
            DateTime endOfDay = startOfDay.AddDays(1).AddTicks(-1);

            // Truy vấn dữ liệu từ cơ sở dữ liệu
            return _dbContext.HoaDons
                .Where(hd => hd.NgayThanhToan >= startOfDay && hd.NgayThanhToan <= endOfDay)
                .ToList();
        }

        public List<HoaDon> GetHoaDonByPhoneNumber(string phoneNumber)
        {
            return _dbContext.HoaDons
                            .Where(hd => hd.SoDienThoai == phoneNumber && hd.TrangThaiThanhToan != 0)
                            .ToList();
        }

        public List<HoaDon> GetHoaDonsByDateRange(DateTime startDate, DateTime endDate)
        {
            return _dbContext.HoaDons
               .Where(hd => hd.NgayThanhToan >= startDate && hd.NgayThanhToan <= endDate && hd.TrangThaiThanhToan != 0)
               .ToList();
        }





        public IEnumerable<int> GetAvailableYears()
        {
            return _dbContext.HoaDons
                .Where(h => h.NgayThanhToan.HasValue)
                .Select(h => h.NgayThanhToan.Value.Year)
                .Distinct()
                .OrderBy(year => year)
                .ToList();
        }






















        public decimal GetTotalRevenueByMonth(int month, int year)
        {
            return _dbContext.HoaDons
                .Where(h => h.NgayThanhToan.HasValue && h.NgayThanhToan.Value.Month == month && h.NgayThanhToan.Value.Year == year)
                .Sum(h => h.TongSoTienHoaDon);
        }
        public decimal GetTotalRevenueByYear(int year)
        {
            return _dbContext.HoaDons
                .Where(h => h.NgayThanhToan.HasValue && h.NgayThanhToan.Value.Year == year)
                .Sum(h => h.TongSoTienHoaDon);
        }

        // Đếm số hóa đơn theo tháng và năm
        public int CountInvoicesByMonth(int month, int year)
        {
            return _dbContext.HoaDons
                .Count(hd => hd.NgayThanhToan.HasValue && hd.NgayThanhToan.Value.Month == month && hd.NgayThanhToan.Value.Year == year);
        }

        // Đếm số hóa đơn theo năm
        public int CountInvoicesByYear(int year)
        {
            return _dbContext.HoaDons
                .Count(hd => hd.NgayThanhToan.HasValue && hd.NgayThanhToan.Value.Year == year);
        }

        public Dictionary<Guid, int> GetProductSalesCountsByMonth(int month, int year)
        {
            var query = from hd in _dbContext.HoaDons
                        join hdc in _dbContext.HoaDonChiTiets on hd.IdHoadon equals hdc.MaHoaDon
                        where hd.NgayThanhToan.HasValue && hd.NgayThanhToan.Value.Year == year && hd.NgayThanhToan.Value.Month == month
                        group hdc by hdc.MaSpct into g
                        select new
                        {
                            ProductId = g.Key,
                            TotalQuantity = g.Sum(x => x.SoLuong ?? 0) // Sử dụng null-coalescing operator để tránh null
                        };

            var result = query.ToDictionary(x => x.ProductId, x => x.TotalQuantity);
            return result;
        }

        public List<int> GetMonthsWithDataByYear(int year)
        {
            // Thay đổi phương thức này để lấy các tháng có dữ liệu
            var months = _dbContext.HoaDons
                        .Where(hd => hd.NgayThanhToan.HasValue && hd.NgayThanhToan.Value.Year == year)
                        .Select(hd => hd.NgayThanhToan.Value.Month)
                        .Distinct()
                        .OrderBy(month => month)
                        .ToList();

            return months;
        }
        public Dictionary<Guid, int> GetProductSalesCountsByYear(int year)
        {
            var query = from hd in _dbContext.HoaDons
                        join hdc in _dbContext.HoaDonChiTiets on hd.IdHoadon equals hdc.MaHoaDon
                        where hd.NgayThanhToan.HasValue && hd.NgayThanhToan.Value.Year == year
                        group hdc by hdc.MaSpct into g
                        select new
                        {
                            ProductId = g.Key,
                            TotalQuantity = g.Sum(x => x.SoLuong ?? 0) // Sử dụng null-coalescing operator để tránh null
                        };

            var result = query.ToDictionary(x => x.ProductId, x => x.TotalQuantity);
            return result;
        }

        public decimal GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            return _dbContext.HoaDons
                .Where(hd => hd.NgayThanhToan.HasValue && hd.NgayThanhToan.Value >= startDate && hd.NgayThanhToan.Value <= endDate)
                .Sum(hd => hd.TongSoTienHoaDon);
        }

        public int GetInvoiceCount(DateTime startDate, DateTime endDate)
        {
            return _dbContext.HoaDons
                .Count(hd => hd.NgayThanhToan.HasValue && hd.NgayThanhToan.Value >= startDate && hd.NgayThanhToan.Value <= endDate);
        }

        public int GetProductCount(DateTime startDate, DateTime endDate)
        {
            // Tổng số lượng sản phẩm bán ra trong khoảng thời gian
            return _dbContext.HoaDonChiTiets
                .Join(_dbContext.HoaDons,
                    hdc => hdc.MaHoaDon,
                    hd => hd.IdHoadon,
                    (hdc, hd) => new { hdc, hd })
                .Where(x => x.hd.NgayThanhToan.HasValue && x.hd.NgayThanhToan.Value >= startDate && x.hd.NgayThanhToan.Value <= endDate)
                .Sum(x => x.hdc.SoLuong ?? 0);
        }

        public int GetCustomerCount(DateTime startDate, DateTime endDate)
        {
            // Số lượng khách hàng duy nhất có hóa đơn trong khoảng thời gian
            return _dbContext.HoaDons
                .Where(hd => hd.NgayThanhToan.HasValue && hd.NgayThanhToan.Value >= startDate && hd.NgayThanhToan.Value <= endDate)
                .Select(hd => hd.SoDienThoai)
                .Distinct()
                .Count();
        }

        public List<HoaDon> GetHoaDonsByYearAndMonth(int year, int month)
        {
            return _dbContext.HoaDons
                .Where(hd => hd.NgayThanhToan.HasValue
                    && hd.NgayThanhToan.Value.Year == year
                    && hd.NgayThanhToan.Value.Month == month)
                .ToList();
        }

        public List<HoaDon> GetInvoicesByYear(int year)
        {
            return _dbContext.HoaDons
                .Where(hd => hd.NgayThanhToan.HasValue && hd.NgayThanhToan.Value.Year == year)
                .ToList();
        }

        public List<HoaDonChiTiet> GetInvoiceDetailsByInvoiceId(Guid invoiceId)
        {
            return _dbContext.HoaDonChiTiets
                .Where(hdct => hdct.MaHoaDon == invoiceId)
                .ToList();
        }

        public List<HoaDon> GetHoaDonsByDateRanges(DateTime startDate, DateTime endDate)
        {
            return _dbContext.HoaDons
                .Where(hd => hd.NgayThanhToan.HasValue
                             && hd.NgayThanhToan.Value >= startDate
                             && hd.NgayThanhToan.Value <= endDate)
                .ToList();
        }
    }
}
