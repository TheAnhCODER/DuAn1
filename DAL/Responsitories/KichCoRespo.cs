using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Responsitories
{
    public class KichCoRespo
    {
        private readonly DuAn1Context _duan1Context;

        public KichCoRespo()
        {
            _duan1Context = new DuAn1Context();
        }

        // Lấy tất cả kích cỡ
        public List<KichCo> GetAll()
        {
            return _duan1Context.KichCos.ToList();
        }

        // Lấy kích cỡ theo tên
        public List<KichCo> GetKC(string ten)
        {
            return _duan1Context.KichCos.Where(p => p.KichCo1.Contains(ten)).ToList();
        }

        // Thêm kích cỡ mới
        public bool AddKC(KichCo kichCo)
        {
            try
            {
                _duan1Context.KichCos.Add(kichCo);
                _duan1Context.SaveChanges(); // Lưu lại thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Sửa kích cỡ
        public bool UpdateKC(KichCo kichCo)
        {
            try
            {
                // Lấy ra đối tượng cần được sửa
                var updateItem = _duan1Context.KichCos.Find(kichCo.IdKichCo);
                if (updateItem != null)
                {
                    // Gán giá trị mới
                    updateItem.KichCo1 = kichCo.KichCo1;
                    _duan1Context.KichCos.Update(updateItem);
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

        // Xóa kích cỡ
        public bool DeleteKC(Guid maKC)
        {
            try
            {
                // Lấy ra đối tượng cần được xóa
                var deleteItem = _duan1Context.KichCos.Find(maKC);
                if (deleteItem != null)
                {
                    _duan1Context.KichCos.Remove(deleteItem);
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
