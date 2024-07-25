using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class BanHangControl : UserControl
    {
        public static BanHangControl banHangControl = new BanHangControl();
        NhanVien _nhanVien { get; set; }
        ThuongHieuServices thuonghieuServices;
        DanhMucServices danhMucServices;
        KichCoServices kichCoServices;
        MauSacServices mauSacServices;
        SanPhamServices sanPhamServices;
        SanPhamChiTietServices sanPhamChiTietServices;
        KhachHangServices khachHangServices;
        HoaDonServices hoaDonServices;
        HoaDonChiTietServices hoaDonChiTietServices;
        public BanHangControl()
        {
            InitializeComponent();
            hoaDonChiTietServices = new HoaDonChiTietServices();
            khachHangServices = new KhachHangServices();
            thuonghieuServices = new ThuongHieuServices();
            danhMucServices = new DanhMucServices();
            kichCoServices = new KichCoServices();
            mauSacServices = new MauSacServices();
            sanPhamServices = new SanPhamServices();
            sanPhamChiTietServices = new SanPhamChiTietServices();
            hoaDonServices = new HoaDonServices();
            RefreshDataGridView();

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {

        }




        public void ShowSanPham_BanHang()
        {
            List<SanPhamChiTiet> sanPhamChiTiets = sanPhamChiTietServices.CNShowSPDangKinhDoanh();
            dgv_TatCaSanPham.Rows.Clear();
            dgv_TatCaSanPham.ColumnCount = 7;
            int stt = 1;
            dgv_TatCaSanPham.Columns[0].HeaderText = "Số thứ tự";
            dgv_TatCaSanPham.Columns[1].HeaderText = "Mã sản phẩm chi tiết";
            dgv_TatCaSanPham.Columns[2].HeaderText = "Tên sản phẩm";
            dgv_TatCaSanPham.Columns[3].HeaderText = "Màu sắc";
            dgv_TatCaSanPham.Columns[4].HeaderText = "Kích cỡ";
            dgv_TatCaSanPham.Columns[5].HeaderText = "Số lượng";
            dgv_TatCaSanPham.Columns[6].HeaderText = "Giá";

            dgv_TatCaSanPham.Columns[0].Visible = false;
            dgv_TatCaSanPham.Columns[1].Visible = false;

            dgv_TatCaSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đặt chiều cao cho hàng tiêu đề
            dgv_TatCaSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_TatCaSanPham.ColumnHeadersHeight = 50; // Đặt chiều cao tùy ý

            // Thiết lập màu sắc và kiểu chữ cho hàng tiêu đề
            dgv_TatCaSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_TatCaSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_TatCaSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TatCaSanPham.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_TatCaSanPham.Font, FontStyle.Bold);
            dgv_TatCaSanPham.EnableHeadersVisualStyles = false;
            Dictionary<Guid, string> sanPhamDict = sanPhamServices.GetSanPhamDict();
            Dictionary<Guid, string> mauSacDict = mauSacServices.GetMauSacDict();
            Dictionary<Guid, string> kichCoDict = kichCoServices.GetKichCoDict();

            foreach (var item in sanPhamChiTiets)
            {
                string mausac = mauSacDict.ContainsKey(item.IdMauSac.Value)
           ? mauSacDict[item.IdMauSac.Value]
           : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                string kichco = kichCoDict.ContainsKey(item.IdKichCo.Value)
           ? kichCoDict[item.IdKichCo.Value]
           : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                string tenSanPham = sanPhamDict.ContainsKey(item.IdSanPham.Value)
           ? sanPhamDict[item.IdSanPham.Value]
           : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy tên sản phẩm
                dgv_TatCaSanPham.Rows.Add(stt++, item.IdSanphamChitiet, tenSanPham, mausac, kichco, item.SoLuong, item.Gia);
            }
        }
        private void dgv_TatCaSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(string.IsNullOrEmpty(tb_MaHoaDon_BanHang.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.RowIndex >= 0)
            {

                // Lấy dữ liệu từ dòng được chọn để điền vào form

                var rowHienTai = dgv_TatCaSanPham.Rows[e.RowIndex];
                var maSPCTDangTao = rowHienTai.Cells[1].Value.ToString();
                var spctDangTao = sanPhamChiTietServices.GetAllSanPhamChiTietById(maSPCTDangTao);

                var maHoaDon = tb_MaHoaDon_BanHang.Text;
                var hoaDonDangChon = hoaDonServices.GetHoaDonbyMaHoaDon(maHoaDon); // Giả sử bạn có phương thức này để lấy chi tiết hóa đơn

                FormSoLuongMua formSoLuongMua = new FormSoLuongMua();
                formSoLuongMua.ShowDialog();

                var hoaDonChiTietTonTai = hoaDonChiTietServices.GetHDCTById(Convert.ToString(hoaDonDangChon.IdHoadon), maSPCTDangTao);

                // chưa tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> thêm mới
                if (hoaDonChiTietTonTai == null)
                {
                    HoaDonChiTiet hoaDonChiTietDangTao = new HoaDonChiTiet();
                    hoaDonChiTietDangTao.MaSpct = Guid.Parse(maSPCTDangTao);
                    hoaDonChiTietDangTao.MaHoaDon = Guid.Parse(maHoaDon);

                    hoaDonChiTietDangTao.DonGia = spctDangTao.Gia;


                    hoaDonChiTietDangTao.SoLuong = formSoLuongMua.SoLuongMua;

                    hoaDonChiTietServices.ThemMoiHDCT(hoaDonChiTietDangTao);
                }
                // nếu đã tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> cập nhật số lượng
                else
                {
                    HoaDonChiTiet hoaDonChiTietDangUpdate = new HoaDonChiTiet();
                    hoaDonChiTietDangUpdate.MaSpct = Guid.Parse(maSPCTDangTao);
                    hoaDonChiTietDangUpdate.MaHoaDon = hoaDonDangChon.IdHoadon;
                    hoaDonChiTietDangUpdate.DonGia = spctDangTao.Gia;
                    hoaDonChiTietDangUpdate.SoLuong = hoaDonChiTietTonTai.SoLuong + formSoLuongMua.SoLuongMua;

                    hoaDonChiTietServices.UpdateSoLuong(hoaDonChiTietDangUpdate);
                }

                spctDangTao.SoLuong -= formSoLuongMua.SoLuongMua;
                sanPhamChiTietServices.UpdateSoLuong(spctDangTao);

                // load lại dữ liệu trên 2 data grid view
                tb_TimKiem_SanPham.Text = string.Empty;
                ShowSanPham_BanHang();
                LoadData_dgvHoaDonChiTiet(hoaDonChiTietServices.GetAllHoaDonCTByMaHoaDon(maHoaDon));

            }
        }


        public void RefreshDataGridView()
        {

            ShowSanPham_BanHang();
        }

        private void btn_TaoHoaDon_BanHang_Click(object sender, EventArgs e)
        {
            if (TrangChu.nhanVien1 == null)
            {
                MessageBox.Show("Thông tin nhân viên không hợp lệ!");
                return;
            }

            var khachHang = khachHangServices.GetKhachHangBySDT(tb_SoDienThoai_BanHang.Text);
            if (khachHang == null)
            {
                MessageBox.Show("SĐT khách hàng không hợp lệ!");
            }
            else
            {
                HoaDon hoaDon = new HoaDon
                {
                    IdNhanvien = TrangChu.nhanVien1.IdNhanvien,
                    SoDienThoai = tb_SoDienThoai_BanHang.Text,
                    NgayTao = DateTime.Now,
                    TrangThaiThanhToan = 0 // 0: hóa đơn chờ, 1: đã thanh toán, 2: đã hủy (tự quy định)
                };

                hoaDonServices.TaoHoaDonCho(hoaDon);

                MessageBox.Show("Tạo hóa đơn chờ thành công!");
            }
            RefreshToanBoForm();
        }

        private void tb_TimKiem_SanPham_TextChanged(object sender, EventArgs e)
        {
            //List<SanPhamChiTiet> sanPhamChiTiets = sanPhamChiTietServices.(tb_TimKiem_SanPham.Text);
            //ShowSanPham_BanHang(sanPhamChiTiets);
        }

        private void tb_SoDienThoai_BanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var khachHang = khachHangServices.GetKhachHangBySDT(tb_SoDienThoai_BanHang.Text);
                if (khachHang == null)
                {
                    MessageBox.Show("SĐT khách hàng không hợp lệ!");
                }
                else
                {
                    tb_TenKhachHang_BanHang.Text = khachHang.TenKhachHang;
                }
            }
        }

        public void LoadHoaDonCho()
        {
            List<HoaDon> hoaDons = hoaDonServices.GetAllHoaDonChos();
            dgv_HoaDonCho_BanHang.Rows.Clear();
            dgv_HoaDonCho_BanHang.ColumnCount = 6;
            int stt = 1;
            dgv_HoaDonCho_BanHang.Columns[0].HeaderText = "Hóa đơn chờ";
            dgv_HoaDonCho_BanHang.Columns[1].HeaderText = "MaHoaDon";
            dgv_HoaDonCho_BanHang.Columns[2].HeaderText = "Số điện thoại khách hàng";
            dgv_HoaDonCho_BanHang.Columns[3].HeaderText = "Tên nhân viên";
            dgv_HoaDonCho_BanHang.Columns[4].HeaderText = "Phương thức thanh toán";
            dgv_HoaDonCho_BanHang.Columns[5].HeaderText = "Trạng thái thanh toán";
            dgv_HoaDonCho_BanHang.Columns[1].Visible = false;
            dgv_HoaDonCho_BanHang.Columns[3].Visible = false;
            dgv_HoaDonCho_BanHang.Columns[4].Visible = false;

            dgv_HoaDonCho_BanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // Đặt chiều cao cho hàng tiêu đề
            dgv_HoaDonCho_BanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_HoaDonCho_BanHang.ColumnHeadersHeight = 50; // Đặt chiều cao tùy ý

            // Thiết lập màu sắc và kiểu chữ cho hàng tiêu đề
            dgv_HoaDonCho_BanHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_HoaDonCho_BanHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_HoaDonCho_BanHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_HoaDonCho_BanHang.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_HoaDonCho_BanHang.Font, FontStyle.Bold);
            dgv_HoaDonCho_BanHang.EnableHeadersVisualStyles = false;

            foreach (var item in hoaDons)
            {
                string status= item.TrangThaiThanhToan.ToString();
           
                if(Convert.ToUInt32( status) == 0)
                {
                    status = "Chưa thanh toán";
                }
                
                dgv_HoaDonCho_BanHang.Rows.Add("Hóa đơn chờ "+stt++, item.IdHoadon, item.SoDienThoai, item.IdNhanvien, item.IdPhuongthucthanhtoan, status);
            
            }
        }
        private void dgv_HoaDonCho_BanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int row = e.RowIndex;
                var hoaDonDangChon = dgv_HoaDonCho_BanHang.Rows[row];
                // Kiểm tra xem người dùng có nhấp vào hàng dữ liệu hay không (không phải tiêu đề cột)
                if (e.RowIndex >= 0)
                {
                    var rowData = dgv_HoaDonCho_BanHang.Rows[row]; // Lấy dữ liệu từ dòng đó ra
                                                                   // Bạn có thể lấy thêm thông tin cần thiết từ hàng được chọn tại đây
                    tb_HoaDonCho.Text = rowData.Cells[0].Value.ToString() ?? string.Empty;
                    // Điền dữ liệu vào các trường trên form
                    tb_MaHoaDon_BanHang.Text = rowData.Cells[1].Value?.ToString() ?? string.Empty;
                    tb_SoDienThoai_BanHang.Text = rowData.Cells[2].Value?.ToString() ?? string.Empty;
                    tb_TenKhachHang_BanHang.Text = khachHangServices.GetKhachHangBySDT(tb_SoDienThoai_BanHang.Text).TenKhachHang;
                    LoadData_dgvHoaDonChiTiet(hoaDonChiTietServices.GetAllHoaDonCTByMaHoaDon(tb_MaHoaDon_BanHang.Text));
    
                }
            }
        }
        private void LoadData_dgvHoaDonChiTiet(List<HoaDonChiTiet> hoaDonChiTiets)
        {
            dgv_HoaDonChiTiet_BanHang.Rows.Clear();
            dgv_HoaDonChiTiet_BanHang.ColumnCount = 5;
            dgv_HoaDonChiTiet_BanHang.Columns[0].HeaderText = "Số thứ tự";
            dgv_HoaDonChiTiet_BanHang.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_HoaDonChiTiet_BanHang.Columns[2].HeaderText = "Mã hóa đơn";
            dgv_HoaDonChiTiet_BanHang.Columns[3].HeaderText = "Đơn giá";
            dgv_HoaDonChiTiet_BanHang.Columns[4].HeaderText = "Số lượng";

            dgv_HoaDonChiTiet_BanHang.Columns[0].Visible = false;
            dgv_HoaDonChiTiet_BanHang.Columns[2].Visible = false;

            dgv_HoaDonChiTiet_BanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đặt chiều cao cho hàng tiêu đề
            dgv_HoaDonChiTiet_BanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_HoaDonChiTiet_BanHang.ColumnHeadersHeight = 50; // Đặt chiều cao tùy ý

            // Thiết lập màu sắc và kiểu chữ cho hàng tiêu đề
            dgv_HoaDonChiTiet_BanHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_HoaDonChiTiet_BanHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_HoaDonChiTiet_BanHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_HoaDonChiTiet_BanHang.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_HoaDonChiTiet_BanHang.Font, FontStyle.Bold);
            dgv_HoaDonChiTiet_BanHang.EnableHeadersVisualStyles = false;
            Dictionary<Guid, string> sanPhamChiTietDict = sanPhamChiTietServices.GetMaSanPhamDict();
            Dictionary<Guid, string> sanphamDict = sanPhamServices.GetSanPhamDict();

            int stt = 1;
            foreach (var hdct in hoaDonChiTiets)
            {
                string masp = sanPhamChiTietDict.ContainsKey(hdct.MaSpct)
            ? sanPhamChiTietDict[hdct.MaSpct]
            : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                string tensp = sanphamDict.ContainsKey(Guid.Parse(masp)) ? sanphamDict[Guid.Parse(masp)]
            : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                dgv_HoaDonChiTiet_BanHang.Rows.Add(stt++, tensp, hdct.MaHoaDon, hdct.DonGia, hdct.SoLuong);
            }

            if (tb_MaHoaDon_BanHang != null)
            {
                var selectedHoaDon = tb_MaHoaDon_BanHang.Text.ToString();
                tb_TongTien_BanHang.Text = TinhTongTienHoaDon(selectedHoaDon).ToString("#,##0 'VND'");
            }
        }

        private decimal TinhTongTienHoaDon(string maHoaDon)
        {
            var listHDCT = hoaDonChiTietServices.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            decimal tongTien = 0;

            foreach (var hdct in listHDCT)
            {
                decimal donGia = hdct.DonGia ?? 0; // Nếu DonGia là null, gán giá trị 0
                int soLuong = hdct.SoLuong ?? 0;   // Nếu SoLuong là null, gán giá trị 0
                tongTien += donGia * soLuong;
            }

            return tongTien;
        }
        private void RefreshToanBoForm()
        {
            tb_SoDienThoai_BanHang.Text = string.Empty;
            tb_TenKhachHang_BanHang.Text = string.Empty;
            tb_TimKiem_SanPham.Text = string.Empty;
            tb_TienKhachTra_BanHang.Text = "0";
            tb_TienThua_BanHang.Text = "0";
            tb_TongTien_BanHang.Text = "0";
            tb_MaHoaDon_BanHang.Clear();
       
            LoadHoaDonCho();
            ShowSanPham_BanHang();
        }

        private void BanHangControl_Load(object sender, EventArgs e)
        {
            LoadHoaDonCho();
            ShowSanPham_BanHang();
            tb_MaHoaDon_BanHang.Visible = false;
        }

        private void btn_HuyHoaDon_BanHang_Click(object sender, EventArgs e)
        {
            if (tb_MaHoaDon_BanHang != null)
            {

                var maHoaDon = tb_MaHoaDon_BanHang.Text;

                var listHDCT = hoaDonChiTietServices.GetAllHoaDonCTByMaHoaDon(maHoaDon);
                foreach (var hdct in listHDCT)
                {
                    var spct = sanPhamChiTietServices.GetAllSanPhamChiTietById(Convert.ToString(hdct.MaSpct));
                    // Hoàn lại số lượng sản phẩm đã chọn trong hóa đơn vào lại danh sách sản phẩm
                    spct.SoLuong += hdct.SoLuong ?? 0;


                    sanPhamChiTietServices.UpdateSoLuong(spct);
                }

                hoaDonServices.SuaTrangThai(maHoaDon, 2); // Giả sử 2 là trạng thái hủy hóa đơn
                MessageBox.Show("Đã hủy hóa đơn!");
                RefreshToanBoForm();
            }
            else
            {
                MessageBox.Show("Hãy chọn hóa đơn chờ để hủy!");
            }
        }
        private bool daThanhToanDu = false;

        private void btn_ThanhToan_BanHang_Click(object sender, EventArgs e)
        {
            if (tb_MaHoaDon_BanHang != null)
            {
                if (daThanhToanDu)
                {
                    hoaDonServices.SuaTrangThai(tb_MaHoaDon_BanHang.Text.ToString(), 1);
                    MessageBox.Show("Đã thanh toán hóa đơn!");
                    RefreshToanBoForm();
                }
                else
                {
                    MessageBox.Show("Tiền khách đưa chưa đủ!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn hóa đơn chờ để thanh toán!");
            }
        }



        private void tb_TienKhachTra_BanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!SanPhamControl.ValidateNotEmpty(tb_TienKhachTra_BanHang))
                {
                    MessageBox.Show("Vui lòng nhập tiền khách trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!SanPhamControl.ValidateNumeric(tb_TienKhachTra_BanHang))
                {
                    MessageBox.Show("Giá trị nhập phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!SanPhamControl.ValidatePositiveInteger(tb_TienKhachTra_BanHang))
                {
                    MessageBox.Show("Số tiền nhập vào không được âm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    decimal tienKhachDua = Convert.ToDecimal(tb_TienKhachTra_BanHang.Text);

                    var tongSoTien = TinhTongTienHoaDon(tb_MaHoaDon_BanHang.Text.ToString());


                    tb_TienThua_BanHang.Text = (tienKhachDua - tongSoTien).ToString("#,##0 'VND'");
                    if (tienKhachDua >= tongSoTien)
                    {
                        daThanhToanDu = true;
                    }
                    else
                    {
                        daThanhToanDu = false;
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi!");
                }
            }
        }

        private void btn_ThemKhachHang_Click_1(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.ShowDialog();
        }

     

    }
}