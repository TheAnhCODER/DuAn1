using DAL.Models;
using DAL.Responsitories;
using System;
using System.Collections.Generic;

namespace BUS.Services
{
    public class DanhMucServices
    {
        private readonly DanhMucRespo _repo;

        public DanhMucServices()
        {
            _repo = new DanhMucRespo();
        }

        // Lấy tất cả danh mục
        public List<DanhMuc> CNShow()
        {
            return _repo.GetAll();
        }

        // Tìm danh mục theo tên
        public List<DanhMuc> CNTim(string ten)
        {
            return _repo.GetDM(ten);
        }

        // Thêm danh mục mới
        public string CNThem(string ten)
        {
            DanhMuc danhMuc = new DanhMuc()
            {
                TenDanhMuc = ten,
            };
            if (_repo.AddDM(danhMuc))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        // Sửa danh mục
        public string CNSua(string idDanhMuc, string ten)
        {
            DanhMuc danhMuc = new DanhMuc()
            {
                IdDanhMuc = Guid.Parse(idDanhMuc),
                TenDanhMuc = ten,
            };
            if (_repo.UpdateDM(danhMuc))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }




        public Dictionary<Guid, string> GetDanhMucDict()
        {

            var danhMucs = _repo.GetAll();
            return danhMucs.ToDictionary(ms => ms.IdDanhMuc, ms => ms.TenDanhMuc);
        }





    }
}
