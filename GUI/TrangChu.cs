using DAL.Models;
using System.Data;

namespace GUI
{
    public partial class TrangChu : Form
    {
        NhanVien _nhanVien;

        public static NhanVien nhanVien1 = new NhanVien();

        public TrangChu(NhanVien nhanVien)
        {
            _nhanVien = nhanVien;
            InitializeComponent();
            // Đặt kích thước và vị trí ban đầu cho SidePanel
            SidePanel.Height = btn_BanHang.Height;
            SidePanel.Top = btn_BanHang.Top;
            SidePanel.BringToFront();
            banHangControl1.BringToFront();

            //phan quyen
            if (_nhanVien.IdChucvu > 0)
            {
                int idChucVu = Convert.ToInt32( nhanVien.IdChucvu);
                PhanQuyenNguoiDung(idChucVu);
            }
            string loiChao = "Xin chào: " + nhanVien.TenNhanVien.ToString();
            this.tbt_TenUser.Text = loiChao;
        }


        private void PhanQuyenNguoiDung(int idChucVu)
        {

            switch (idChucVu)
            {
                case 1: // Quản lý
                        // Hiển thị toàn bộ chức năng
                    btn_BanHang.Enabled = true;
                    btn_HoaDon.Enabled = true;
                    btn_KhachHang.Enabled = true;
                    btn_KhuyenMai.Enabled = true;
                    btn_SanPham.Enabled = true;
                    btn_TaiKhoan.Enabled = true;
                    btn_ThongKe.Enabled = true;
                    btn_NhanVien.Enabled = true;
                    break;
                case 2: // Nhân viên bán hàng
                        // Ẩn một số chức năng không cần thiết
                    btn_BanHang.Enabled = true;
                    btn_HoaDon.Enabled = false;
                    btn_KhachHang.Enabled = true;
                    btn_KhuyenMai.Enabled = false;
                    btn_SanPham.Enabled = true;
                    btn_TaiKhoan.Enabled = true;
                    btn_ThongKe.Enabled = false;
                    btn_NhanVien.Enabled = false;
                    break;
            }
        }




        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btn_BanHang);
            banHangControl1.BringToFront();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btn_SanPham);
            sanPhamControl1.BringToFront();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btn_KhachHang);
            khachHangControl1.BringToFront();
        }


        // Phương thức di chuyển SidePanel
        private void MoveSidePanel(Button btn)
        {
            SidePanel.Height = btn.Height;
            SidePanel.Top = btn.Top;
            SidePanel.BringToFront();
        }

        private void btn_NhanVien_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(btn_NhanVien);
            nhanVienControl1.BringToFront();
        }

        private void btn_HoaDon_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(btn_HoaDon);
            hoaDonControl1.BringToFront();

        }

        private void btn_ThongKe_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(btn_ThongKe);
            thongKeControl1.BringToFront();
        }

        private void btn_KhuyenMai_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(btn_KhuyenMai);
            khuyenMaiControl1.BringToFront();
        }

        private void btn_TaiKhoan_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(btn_TaiKhoan);
            taiKhoanControl1.BringToFront();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
         
        }
    }
}
