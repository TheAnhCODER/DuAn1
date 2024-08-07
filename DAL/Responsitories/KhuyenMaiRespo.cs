using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL.Responsitories
{
    public class KhuyenMaiRespo
    {
        private readonly DuAn1Context _context;

        public KhuyenMaiRespo()
        {
            _context = new DuAn1Context();
        }



        public List<KhuyenMai> GetAll()
        {
            return _context.KhuyenMais.ToList();
        }
        public List<KhuyenMai> GetTH(string ten)
        {
            return _context.KhuyenMais.Where(p => p.TenKhuyenMai.Contains(ten)).ToList();
        }

        //thêm Thuong hieu mới
        public bool AddTH(KhuyenMai khuyenMai)
        {
            try
            {
                _context.KhuyenMais.Add(khuyenMai);
                _context.SaveChanges();//lưu lại thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //sua Thuong Hieu mới
        public bool UpdateTH(KhuyenMai khuyenMai)
        {
            try
            {
                //lấy ra đối tượng cần được sửa
                var updateItem = _context.KhuyenMais.Find(khuyenMai.IdKhuyenMai);
                //sau khi tìm ra thì ta đi gán gía trị 
                updateItem.TenKhuyenMai = khuyenMai.TenKhuyenMai;
                updateItem.LoaiGiamGia = khuyenMai.LoaiGiamGia;
                updateItem.GiamGia = khuyenMai.GiamGia;
                updateItem.NgayBatDau = khuyenMai.NgayBatDau;
                updateItem.NgayKetThuc = khuyenMai.NgayKetThuc;
                _context.KhuyenMais.Update(updateItem);
                _context.SaveChanges();//lưu lại thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public bool IsProductExists(string tenkhuyenMai, decimal giamGia, DateTime ngayBatDau, DateTime NgayKetThuc, bool LoaiGiamGia)
        {
            return _context.KhuyenMais.Any(sp => sp.TenKhuyenMai == tenkhuyenMai && sp.GiamGia == giamGia && sp.NgayBatDau == ngayBatDau && sp.NgayKetThuc == NgayKetThuc && sp.LoaiGiamGia == LoaiGiamGia);

        }

        public Dictionary<Guid, List<KhuyenMai>> GetAllCurrentKhuyenMaiBySanPhamChiTiet()
        {
            var khuyenMaiList = _context.KhuyenMais
                .Where(km => km.TrangThai == true && km.NgayBatDau <= DateTime.Now && km.NgayKetThuc >= DateTime.Now)
                .ToList();

            Dictionary<Guid, List<KhuyenMai>> khuyenMaiDict = new Dictionary<Guid, List<KhuyenMai>>();

            foreach (var km in khuyenMaiList)
            {
                var sanPhamChiTietId = km.IdSanphamChitiet;

                if (sanPhamChiTietId != null)
                {
                    Guid sanPhamChiTietIdValue = sanPhamChiTietId.Value;

                    if (khuyenMaiDict.ContainsKey(sanPhamChiTietIdValue))
                    {
                        khuyenMaiDict[sanPhamChiTietIdValue].Add(km);
                    }
                    else
                    {
                        khuyenMaiDict[sanPhamChiTietIdValue] = new List<KhuyenMai> { km };
                    }
                }
            }

            return khuyenMaiDict;
        }

       


    }
}
