using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Responsitories
{
    public class MauSacRespo
    {
        private readonly DuAn1Context _duan1Context;

        public MauSacRespo()
        {
            _duan1Context = new DuAn1Context();
        }

        // Lấy tất cả màu sắc
        public List<MauSac> GetAll()
        {
            return _duan1Context.MauSacs.ToList();
        }

        // Lấy màu sắc theo tên
        public List<MauSac> GetMS(string ten)
        {
            return _duan1Context.MauSacs.Where(p => p.TenMauSac.Contains(ten)).ToList();
        }

        // Thêm màu sắc mới
        public bool AddMS(MauSac mauSac)
        {
            try
            {
                _duan1Context.MauSacs.Add(mauSac);
                _duan1Context.SaveChanges(); // Lưu lại thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Sửa màu sắc
        public bool UpdateMS(MauSac mauSac)
        {
            try
            {
                // Lấy ra đối tượng cần được sửa
                var updateItem = _duan1Context.MauSacs.Find(mauSac.IdMauSac);
                if (updateItem != null)
                {
                    // Gán giá trị mới
                    updateItem.TenMauSac = mauSac.TenMauSac;
                    _duan1Context.MauSacs.Update(updateItem);
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

        // Xóa màu sắc
        public bool DeleteMS(Guid maMS)
        {
            try
            {
                // Lấy ra đối tượng cần được xóa
                var deleteItem = _duan1Context.MauSacs.Find(maMS);
                if (deleteItem != null)
                {
                    _duan1Context.MauSacs.Remove(deleteItem);
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
    }
}
