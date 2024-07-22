using DAL.Models;
using DAL.Responsitories;
using System;
using System.Collections.Generic;

namespace BUS.Services
{
    public class KichCoServices
    {
        private readonly KichCoRespo _repo;

        public KichCoServices()
        {
            _repo = new KichCoRespo();
        }

        // Lấy tất cả kích cỡ
        public List<KichCo> CNShow()
        {
            return _repo.GetAll();
        }

        // Tìm kích cỡ theo tên
        public List<KichCo> CNTim(string ten)
        {
            return _repo.GetKC(ten);
        }

        // Thêm kích cỡ mới
        public string CNThem(string ten)
        {
            if (IsProductExists(ten))
            {
                return "Kích cỡ đã tồn tại";
            }
            KichCo kichCo = new KichCo()
            {
                KichCo1 = ten,
            };
            if (_repo.AddKC(kichCo))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        // Sửa kích cỡ
        public string CNSua(string idKichCo, string ten)
        {
            if (IsProductExists(ten))
            {
                return "Kích cỡ đã tồn tại";
            }
            KichCo kichCo = new KichCo()
            {
                IdKichCo = Guid.Parse(idKichCo),
                KichCo1 = ten,
            };
            if (_repo.UpdateKC(kichCo))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

  

        public Dictionary<Guid, string> GetKichCoDict()
        {

            var kichCos = _repo.GetAll();
            return kichCos.ToDictionary(kc => kc.IdKichCo, kc => kc.KichCo1);
        }

        public bool IsProductExists(string tenkichco)
        {
            return _repo.IsProductExists(tenkichco);
        }



    }
}
