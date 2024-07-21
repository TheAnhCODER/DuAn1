﻿using DAL.Models;
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

        public void TaoHoaDonCho(HoaDon hoaDon)
        {
            hoaDonRespo.TaoHoaDonCho(hoaDon);
        }

        public void SuaTrangThai(string maHoaDon, int trangThai)
        {
            var mahoadon = Guid.Parse(maHoaDon);
            hoaDonRespo.SuaTrangThai(mahoadon, trangThai);
        }
    }
}
