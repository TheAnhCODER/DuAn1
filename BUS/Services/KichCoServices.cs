﻿using DAL.Models;
using DAL.Responsitories;
using System;
using System.Collections.Generic;

namespace BUS.Services
{
    public class KichCoServices
    {
        private readonly KichCoRespo _repo;

        public KichCoServices()
        {
            _repo = new KichCoRespo();
        }

        // Lấy tất cả kích cỡ
        public List<KichCo> CNShow()
        {
            return _repo.GetAll();
        }

        // Tìm kích cỡ theo tên
        public List<KichCo> CNTim(string ten)
        {
            return _repo.GetKC(ten);
        }

        // Thêm kích cỡ mới
        public string CNThem(string ten)
        {
            KichCo kichCo = new KichCo()
            {
                KichCo1 = ten,
            };
            if (_repo.AddKC(kichCo))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        // Sửa kích cỡ
        public string CNSua(string idKichCo, string ten)
        {
            KichCo kichCo = new KichCo()
            {
                IdKichCo = Guid.Parse(idKichCo),
                KichCo1 = ten,
            };
            if (_repo.UpdateKC(kichCo))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        // Xóa kích cỡ
        public string XoaKC(string idKichCo)
        {
            var id = Guid.Parse(idKichCo);
            if (_repo.DeleteKC(id))
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }
    }
}
