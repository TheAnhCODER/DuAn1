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
        public void updateSDTKhachHang(string mahoadon,string sdt)
        {
            var mahd = Guid.Parse(mahoadon);
            hoaDonRespo.SuaSDT(mahd,sdt);
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



    }
}
