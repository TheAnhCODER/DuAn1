namespace GUI
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            // Đặt kích thước và vị trí ban đầu cho SidePanel
            SidePanel.Height = btn_BanHang.Height;
            SidePanel.Top = btn_BanHang.Top;
            SidePanel.BringToFront();
            banHangControl1.BringToFront();
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
    }
}
