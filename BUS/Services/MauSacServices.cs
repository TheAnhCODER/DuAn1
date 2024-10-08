﻿using DAL.Models;
using DAL.Responsitories;
using System;
using System.Collections.Generic;

namespace BUS.Services
{
    public class MauSacServices
    {
        private readonly MauSacRespo _repo;

        public MauSacServices()
        {
            _repo = new MauSacRespo();
        }

        // Lấy tất cả màu sắc
        public List<MauSac> CNShow()
        {
            return _repo.GetAll();
        }

        // Tìm màu sắc theo tên
        public List<MauSac> CNTim(string ten)
        {
            return _repo.GetMS(ten);
        }

        // Thêm màu sắc mới
        public string CNThem(string ten)
        {
            if (IsProductExists(ten))
            {
                return "Màu sắc đã tồn tại";
            }
            MauSac mauSac = new MauSac()
            {
                TenMauSac = ten,
            };
            if (_repo.AddMS(mauSac))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        // Sửa màu sắc
        public string CNSua(string idMauSac, string ten)
        {
            if (IsProductExists(ten))
            {
                return "Màu sắc đã tồn tại";
            }
            MauSac mauSac = new MauSac()
            {
                IdMauSac = Guid.Parse(idMauSac),
                TenMauSac = ten,
            };
            if (_repo.UpdateMS(mauSac))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

     

        public Dictionary<Guid, string> GetMauSacDict()
        {

            var mauSacs = _repo.GetAll();
            return mauSacs.ToDictionary(ms => ms.IdMauSac, ms => ms.TenMauSac);
        }
        public bool IsProductExists(string tenmausac)
        {
            return _repo.IsProductExists(tenmausac);
        }


    }
}
