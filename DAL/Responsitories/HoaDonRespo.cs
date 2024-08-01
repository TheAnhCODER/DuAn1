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
            return _dbContext.HoaDons.ToList();
        }

        public void TaoHoaDonCho(HoaDon hoaDon)
        {
            _dbContext.HoaDons.Add(hoaDon);
            _dbContext.SaveChanges();
        }

        public void SuaTrangThai(Guid maHoaDon, int trangThai, int phuongthucthanhtoan, decimal tongtien, string sodienthoai)
        {
            var hoaDonSua = _dbContext.HoaDons.Find(maHoaDon);
            if (hoaDonSua != null)
            {
                hoaDonSua.TrangThaiThanhToan = trangThai;
                hoaDonSua.IdPhuongthucthanhtoan = phuongthucthanhtoan;
                hoaDonSua.TongSoTienHoaDon = tongtien;
                hoaDonSua.SoDienThoai = sodienthoai;
            }
            _dbContext.SaveChanges();
        }
        public void SuaSDT(Guid maHD ,string sdt)
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
                .Where(hd => hd.NgayTao >= startOfDay && hd.NgayTao <= endOfDay)
                .ToList();
        }

        public List<HoaDon> GetHoaDonByPhoneNumber(string phoneNumber)
        {
            return _dbContext.HoaDons
                .Where(hd => hd.SoDienThoai.Contains(phoneNumber)) // Giả sử 'Sdt' là trường số điện thoại
                .ToList();
        }
        public List<HoaDon> GetHoaDonsByDateRange(DateTime startDate, DateTime endDate)
        {
            return _dbContext.HoaDons
                .Where(hd => hd.NgayTao >= startDate && hd.NgayTao <= endDate)
                .ToList();
        }
    }
}
