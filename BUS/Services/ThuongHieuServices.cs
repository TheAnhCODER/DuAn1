using DAL.Models;
using DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ThuongHieuServices
    {
        ThuongHieuRespo _repo;
        public ThuongHieuServices()
        {
            _repo = new ThuongHieuRespo();
        }
        //cac phuong thuc
        public List<ThuongHieu> CNShow()
        {
            return _repo.GetAll();//vi get all cung tra ve list minh can
        }

        //tim
        public List<ThuongHieu> CNTim(string ten)
        {
            return _repo.GetTH(ten);
        }

        //them
        public string CNThem(string ten)
        {
            
            if (IsProductExists( ten))
            {
                return "Thương hiệu đã tồn tại";
            }
            ThuongHieu thuongHieu = new ThuongHieu()//tao ra 1 doi tuong chua thong tin duoc truyen vao
            {
                TenThuongHieu = ten,
            };
            if (_repo.AddTH(thuongHieu))
            {
                return "Thêm thành công";
            }
            else
                return "Thêm thất bại";
        }

        //sua
        public string CNSua(string idThuongHieu, string ten)
        {
            if (IsProductExists(ten))
            {
                return "Thương hiệu đã tồn tại";
            }
            ThuongHieu thuongHieu = new ThuongHieu()//tao ra 1 doi tuong chua thong tin duoc truyen vao
            {
                IdThuongHieu = Guid.Parse(idThuongHieu),
                TenThuongHieu = ten,

            };
            if (_repo.UpdateTH(thuongHieu))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";

        }

     


        public Dictionary<Guid, string> GetThuongHieuDict()
        {

            var thuongHieus = _repo.GetAll();
            return thuongHieus.ToDictionary(ms => ms.IdThuongHieu, ms => ms.TenThuongHieu);
        }

        public bool IsProductExists( string tenthuonghieu)
        {
            return _repo.IsProductExists(tenthuonghieu);
        }








    }
}
