using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BUS.Services
{

    public class KhuyenMaiSPCTService
    {
        DuAn1Context _context;

        public KhuyenMaiSPCTService()
        {
            _context = new DuAn1Context();
        }

        public async Task AddOrUpdateKhuyenMaiSPCTAsync(Guid khuyenMaiId, Guid sanPhamId, decimal giaGiam)
        {
            var khuyenMaiSPCT = await _context.KhuyenMaiSpcts
                .FirstOrDefaultAsync(k => k.IdKhuyenMai == khuyenMaiId && k.IdSanPhamChiTiet == sanPhamId);

            if (khuyenMaiSPCT == null)
            {
                khuyenMaiSPCT = new KhuyenMaiSpct
                {
                    Id = Guid.NewGuid(),
                    IdKhuyenMai = khuyenMaiId,
                    IdSanPhamChiTiet = sanPhamId,
                };
                _context.KhuyenMaiSpcts.Add(khuyenMaiSPCT);
            }
            else
            {

                _context.KhuyenMaiSpcts.Update(khuyenMaiSPCT);
            }

            await _context.SaveChangesAsync();
        }



    }
}
