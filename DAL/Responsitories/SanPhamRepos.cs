using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Responsitories
{
    public class SanPhamRepos
    {
        private readonly DuAn1Context _duan1Context;

        public SanPhamRepos()
        {
            _duan1Context = new DuAn1Context();
        }

        // Lấy tất cả san pham
        public List<SanPham> GetAll()
        {
            return _duan1Context.SanPhams.ToList();
        }

        // Lấy sp theo tên
        public List<SanPham> GetSPByName(string ten)
        {
            return _duan1Context.SanPhams.Where(p => p.TenSanPham.Contains(ten)).ToList();
        }

        // Thêm sp mục mới
        public bool AddSP(SanPham sanPham)
        {
            try
            {
                _duan1Context.SanPhams.Add(sanPham);
                _duan1Context.SaveChanges(); // Lưu lại thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Sửa sp
        public bool UpdateSP(SanPham sanPham)
        {
            try
            {
                // Lấy ra đối tượng cần được sửa
                var updateItem = _duan1Context.SanPhams.Find(sanPham.IdSanPham);
                if (updateItem != null)
                {
                    // Gán giá trị mới
                    updateItem.TenSanPham = sanPham.TenSanPham;
                    updateItem.TrangThaiSanPham = sanPham.TrangThaiSanPham;
                    updateItem.MoTa = sanPham.MoTa;
            
                    updateItem.IdDanhMuc = sanPham.IdDanhMuc;
                    updateItem.IdThuongHieu = sanPham.IdThuongHieu;
                    _duan1Context.SanPhams.Update(updateItem);
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

        //tim theo thuong hieu
        public List<SanPham> GetSPByThuongHieu(Guid maThuongHieu)
        {
            return _duan1Context.SanPhams.Where(p => p.IdThuongHieu == maThuongHieu).ToList();
        }

        //tim theo danhmuc
        public List<SanPham> GetSPByDanhMuc(Guid maThuongHieu)
        {
            return _duan1Context.SanPhams.Where(p => p.IdDanhMuc == maThuongHieu).ToList();
        }


        //tim theo trang thai san pham
        public List<SanPham> GetSPByTTSP(bool ttsp)
        {
            return _duan1Context.SanPhams.Where(p => p.TrangThaiSanPham == ttsp).ToList();
        }

    }
}
