using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Responsitories
{
    public class DanhMucRespo
    {
        private readonly DuAn1Context _duan1Context;

        public DanhMucRespo()
        {
            _duan1Context = new DuAn1Context();
        }

        // Lấy tất cả danh mục
        public List<DanhMuc> GetAll()
        {
            return _duan1Context.DanhMucs.ToList();
        }

        // Lấy danh mục theo tên
        public List<DanhMuc> GetDM(string ten)
        {
            return _duan1Context.DanhMucs.Where(p => p.TenDanhMuc.Contains(ten)).ToList();
        }

        // Thêm danh mục mới
        public bool AddDM(DanhMuc danhMuc)
        {
            try
            {
                _duan1Context.DanhMucs.Add(danhMuc);
                _duan1Context.SaveChanges(); // Lưu lại thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Sửa danh mục
        public bool UpdateDM(DanhMuc danhMuc)
        {
            try
            {
                // Lấy ra đối tượng cần được sửa
                var updateItem = _duan1Context.DanhMucs.Find(danhMuc.IdDanhMuc);
                if (updateItem != null)
                {
                    // Gán giá trị mới
                    updateItem.TenDanhMuc = danhMuc.TenDanhMuc;
                    _duan1Context.DanhMucs.Update(updateItem);
                    _duan1Context.SaveChanges(); // Lưu lại thay đổi
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsProductExists(string tendanhmuc)
        {
            return _duan1Context.DanhMucs.Any(sp => sp.TenDanhMuc == tendanhmuc);

        }

    }
}
