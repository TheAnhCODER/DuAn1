using DAL.Models;
using DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SanPhamServices
    {

        private readonly SanPhamRepos _repo;

        public SanPhamServices()
        {
            _repo = new SanPhamRepos();
        }

        // Lấy tất cả danh mục
        public List<SanPham> CNShow()
        {
            return _repo.GetAll();
        }

        // Tìm danh mục theo tên
        public List<SanPham> CNTim(string ten)
        {
            return _repo.GetSPByName(ten);
        }

        // Thêm danh mục mới
        public string CNThem(string idDanhMuc, string idThuongHieu, string ten, string moTa, bool trangthaisp)
        {
            var iddanhmuc = Guid.Parse(idDanhMuc);
            var idthuonghieu = Guid.Parse(idThuongHieu);
            if (IsProductExists(iddanhmuc, idthuonghieu, ten))
            {
                return "Sản phẩm đã tồn tại";
            }
            SanPham sanPham = new SanPham()
            {
                IdDanhMuc = Guid.Parse(idDanhMuc),
                IdThuongHieu = Guid.Parse(idThuongHieu),
                TenSanPham = ten,
                
                MoTa = moTa,
                TrangThaiSanPham = trangthaisp
            };
            if (_repo.AddSP(sanPham))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        // Sửa danh mục
        public string CNSua(string idSanPham, string idDanhMuc, string idThuongHieu, string ten, string moTa, bool trangthaisp)
        {
            
            SanPham sanPham = new SanPham()
            {
                IdSanPham = Guid.Parse(idSanPham),
                IdDanhMuc = Guid.Parse(idDanhMuc),
                IdThuongHieu = Guid.Parse(idThuongHieu),
                TenSanPham = ten,
          
                MoTa = moTa,
                TrangThaiSanPham = trangthaisp
            };
            if (_repo.UpdateSP(sanPham))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        //tim theo thuong hieu
        public List<SanPham> GetSPByThuongHieu(Guid idThuongHieu)
        {

            return _repo.GetSPByThuongHieu(idThuongHieu);
        }

        //tim theo danh muc
        public List<SanPham> GetSPByDanhMuc(Guid idDanhMuc)
        {
            
            return _repo.GetSPByDanhMuc(idDanhMuc);
        }

        //tim theo danh muc
        public List<SanPham> GetSPByTTSP(bool ttsp)
        {

            return _repo.GetSPByTTSP(ttsp);
        }
        public Dictionary<Guid, string> GetSanPhamDict()
        {

            var sanPhamList = _repo.GetAll();
            return sanPhamList.ToDictionary(sp => sp.IdSanPham, sp => sp.TenSanPham);
        }

        public bool IsProductExists(Guid idDanhMuc, Guid idThuongHieu, string tenSanPham)
        {
            return _repo.IsProductExists(idDanhMuc, idThuongHieu, tenSanPham);
        }
    }
}
