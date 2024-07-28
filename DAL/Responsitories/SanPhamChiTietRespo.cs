using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Responsitories
{
    public class SanPhamChiTietRespo
    {
        private readonly DuAn1Context _duan1Context;

        public SanPhamChiTietRespo()
        {
            _duan1Context = new DuAn1Context();
        }

        // Lấy tất cả san pham ct
        public List<SanPhamChiTiet> GetAll()
        {
            return _duan1Context.SanPhamChiTiets.ToList();
        }

        // Lấy spct theo ma sp
        public List<SanPhamChiTiet> GetSPCTByMASP(Guid maSP)
        {
            return _duan1Context.SanPhamChiTiets.Where(p => p.IdSanPham ==maSP).ToList();
        }

        // Thêm spct mới
        public bool AddSPCT(SanPhamChiTiet sanPhamChiTiet)
        {
            try
            {
                _duan1Context.SanPhamChiTiets.Add(sanPhamChiTiet);
                _duan1Context.SaveChanges(); // Lưu lại thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Sửa spct
        public bool UpdateSPCT(SanPhamChiTiet sanPhamChiTiet)
        {
            try
            {
                // Lấy ra đối tượng cần được sửa
                var updateItem = _duan1Context.SanPhamChiTiets.Find(sanPhamChiTiet.IdSanphamChitiet);
                if (updateItem != null)
                {
                    // Gán giá trị mới
                    updateItem.IdSanPham = sanPhamChiTiet.IdSanPham;
                    updateItem.IdMauSac = sanPhamChiTiet.IdMauSac;
                    updateItem.IdKichCo = sanPhamChiTiet.IdKichCo;
                    updateItem.SoLuong = sanPhamChiTiet.SoLuong;
                    updateItem.Gia = sanPhamChiTiet.Gia;
                    _duan1Context.SanPhamChiTiets.Update(updateItem);
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

        //tim theo mau sac
        public List<SanPhamChiTiet> GetSPCTByMauSac(Guid maMauSac)
        {
            return _duan1Context.SanPhamChiTiets.Where(p => p.IdMauSac == maMauSac).ToList();
        }

        //tim theo kich co
        public List<SanPhamChiTiet> GetSPCTByKichCo(Guid maKichCo)
        {
            return _duan1Context.SanPhamChiTiets.Where(p => p.IdKichCo == maKichCo).ToList();
        }
        // Lấy tất cả sản phẩm chi tiết từ các sản phẩm có trạng thái Đang Kinh Doanh
        public List<SanPhamChiTiet> GetAllSPDangKinhDoanh()
        {
            return _duan1Context.SanPhamChiTiets
                .Where(spct => spct.IdSanPhamNavigation.TrangThaiSanPham == true && spct.SoLuong > 0)
                .ToList();
        }
        //tim iem theo ten
        public List<SanPhamChiTiet> SearchSanPhamByName(string tenSanPham)
        {
            return _duan1Context.SanPhamChiTiets
                .Where(spct => spct.IdSanPhamNavigation.TrangThaiSanPham == true
                               && spct.SoLuong > 0
                               && spct.IdSanPhamNavigation.TenSanPham.Contains(tenSanPham))
                .ToList();
        }

        public bool IsProductExists(Guid idMauSac, Guid idKichCo, Guid idSP)
        {
            return _duan1Context.SanPhamChiTiets.Any(sp => sp.IdMauSac == idMauSac
                                              && sp.IdKichCo == idKichCo
                                              && sp.IdSanPham == idSP);
        }
        public SanPhamChiTiet GetAllSanPhamChiTietById(Guid maSPCT)
        {
            return _duan1Context.SanPhamChiTiets.Find(maSPCT);
        }
        public void UpdateSoLuong(SanPhamChiTiet spctNew)
        {
            var spctOld = GetAllSanPhamChiTietById(spctNew.IdSanphamChitiet);
            if (spctOld != null)
            {
                spctOld.SoLuong = spctNew.SoLuong;
            }
            _duan1Context.SaveChanges();
        }

    }
}
