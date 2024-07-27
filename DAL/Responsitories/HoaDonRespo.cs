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

        public void SuaTrangThai(Guid maHoaDon, int trangThai)
        {
            var hoaDonSua = _dbContext.HoaDons.Find(maHoaDon);
            if (hoaDonSua != null)
            {
                hoaDonSua.TrangThaiThanhToan = trangThai;
            }
            _dbContext.SaveChanges();
        }

        public void SuaTrangThai(Guid maHoaDon, int trangThai, int phuongthucthanhtoan)
        {
            var hoaDonSua = _dbContext.HoaDons.Find(maHoaDon);
            if (hoaDonSua != null)
            {
                hoaDonSua.TrangThaiThanhToan = trangThai;
                hoaDonSua.IdPhuongthucthanhtoan = phuongthucthanhtoan;
            }
            _dbContext.SaveChanges();
        }



    }
}
