using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Responsitories
{

    public class ThuongHieuRespo
    {
        DuAn1Context _duan1Context;
        public ThuongHieuRespo()
        {
            _duan1Context = new DuAn1Context();
        }

        //lấy tất cả thuong hieu
        public List<ThuongHieu> GetAll()
        {
            return _duan1Context.ThuongHieus.ToList();
        }

        //lấy Thuong hieu theo tên
        public List<ThuongHieu> GetTH(string ten)
        {
            return _duan1Context.ThuongHieus.Where(p => p.TenThuongHieu.Contains(ten)).ToList();
        }

        //thêm Thuong hieu mới
        public bool AddTH(ThuongHieu thuongHieu)
        {
            try
            {
                _duan1Context.ThuongHieus.Add(thuongHieu);
                _duan1Context.SaveChanges();//lưu lại thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //sua Thuong Hieu mới
        public bool UpdateTH(ThuongHieu thuongHieu)
        {
            try
            {
                //lấy ra đối tượng cần được sửa
                var updateItem = _duan1Context.ThuongHieus.Find(thuongHieu.IdThuongHieu);
                //sau khi tìm ra thì ta đi gán gía trị 
                updateItem.TenThuongHieu = thuongHieu.TenThuongHieu;
                _duan1Context.ThuongHieus.Update(updateItem);
                _duan1Context.SaveChanges();//lưu lại thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool IsProductExists( string tenThuongHieu)
        {
            return _duan1Context.ThuongHieus.Any(sp => sp.TenThuongHieu == tenThuongHieu);
                                          
        }



    }
}
