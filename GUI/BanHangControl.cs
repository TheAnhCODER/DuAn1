using BUS.Services;
using DAL.Models;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
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
using Camera;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Net.NetworkInformation;

namespace GUI
{
    public partial class BanHangControl : UserControl
    {
        private FormCamera formCamera;
        private Form childform;
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
            formCamera = new FormCamera();
            formCamera.OnQRCodeScanned += FormCamera_OnQRCodeScanned; ;
            OpenChildForm(formCamera);
            cb_HTTT_BanHang.SelectedIndexChanged += Cb_HTTT_BanHang_SelectedIndexChanged; ;
        }

        private void Cb_HTTT_BanHang_SelectedIndexChanged(object? sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;

            if (comboBox != null)
            {
                // Xử lý sự kiện khi chỉ số chọn thay đổi
                if (comboBox.SelectedIndex == 1) // Ví dụ: "Chuyển khoản"
                {
                    tb_TienKhachTra_BanHang.Enabled = false; // Tắt TextBox khi chọn "Chuyển khoản"

                }
                else if (comboBox.SelectedIndex == 0) // Ví dụ: "Tiền mặt"
                {
                    tb_TienKhachTra_BanHang.Enabled = true; // Bật TextBox khi chọn "Tiền mặt"

                }
            }
        }

        private void FormCamera_OnQRCodeScanned(string obj)
        {

            ChonSPCT(obj);

        }

        private void OpenChildForm(Form chillform)
        {
            if (this.childform != null)
            {
                this.childform.Close();
            }
            this.childform = chillform;
            chillform.TopLevel = false;
            chillform.FormBorderStyle = FormBorderStyle.None;
            chillform.Dock = DockStyle.Fill;
            panel_Cam.Controls.Add(chillform);
            panel_Cam.Tag = chillform;
            chillform.BringToFront();
            chillform.Show();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                childform?.Close();
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

        private void ChonSPCT(string maspct)
        {
            if (string.IsNullOrEmpty(tb_MaHoaDon_BanHang.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                formCamera.ResetProcessing(); // Reset processing flag
                return;
            }

            var spctDangTao = sanPhamChiTietServices.GetAllSanPhamChiTietById(maspct);
            var maHoaDon = tb_MaHoaDon_BanHang.Text;
            var hoaDonDangChon = hoaDonServices.GetHoaDonbyMaHoaDon(maHoaDon); // Giả sử bạn có phương thức này để lấy chi tiết hóa đơn
            FormSoLuongMua formSoLuongMua = new FormSoLuongMua();                                                                   // Kiểm tra số lượng sản phẩm có đủ không
            formSoLuongMua.ShowDialog();
            if (spctDangTao.SoLuong < formSoLuongMua.SoLuongMua)
            {
                MessageBox.Show("Số lượng sản phẩm không đủ để thêm vào hóa đơn chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                formCamera.ResetProcessing(); // Reset processing flag
                return;
            }


            var hoaDonChiTietTonTai = hoaDonChiTietServices.GetHDCTById(Convert.ToString(hoaDonDangChon.IdHoadon), maspct);

            // chưa tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> thêm mới
            if (hoaDonChiTietTonTai == null)
            {
                HoaDonChiTiet hoaDonChiTietDangTao = new HoaDonChiTiet();
                hoaDonChiTietDangTao.MaSpct = Guid.Parse(maspct);
                hoaDonChiTietDangTao.MaHoaDon = Guid.Parse(maHoaDon);

                hoaDonChiTietDangTao.DonGia = spctDangTao.Gia;


                hoaDonChiTietDangTao.SoLuong = formSoLuongMua.SoLuongMua;

                hoaDonChiTietServices.ThemMoiHDCT(hoaDonChiTietDangTao);
            }
            // chưa tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> thêm mới
            if (hoaDonChiTietTonTai == null)
            {
                HoaDonChiTiet hoaDonChiTietDangTao = new HoaDonChiTiet();
                hoaDonChiTietDangTao.MaSpct = Guid.Parse(maspct);
                hoaDonChiTietDangTao.MaHoaDon = Guid.Parse(maHoaDon);

                hoaDonChiTietDangTao.DonGia = spctDangTao.Gia;


                hoaDonChiTietDangTao.SoLuong = formSoLuongMua.SoLuongMua;

                hoaDonChiTietServices.ThemMoiHDCT(hoaDonChiTietDangTao);
            }

            // nếu đã tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> cập nhật số lượng
            else
            {
                HoaDonChiTiet hoaDonChiTietDangUpdate = new HoaDonChiTiet();
                hoaDonChiTietDangUpdate.MaSpct = Guid.Parse(maspct);
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
            formCamera.ResetProcessing(); // Reset processing flag
        }


        private void dgv_TatCaSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_MaHoaDon_BanHang.Text))
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
                FormSoLuongMua formSoLuongMua = new FormSoLuongMua();                                                                   // Kiểm tra số lượng sản phẩm có đủ không
                formSoLuongMua.ShowDialog();
                if (spctDangTao.SoLuong < formSoLuongMua.SoLuongMua)
                {
                    MessageBox.Show("Số lượng sản phẩm không đủ để thêm vào hóa đơn chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    formCamera.ResetProcessing(); // Reset processing flag
                    return;
                }


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
                string status = item.TrangThaiThanhToan.ToString();

                if (Convert.ToUInt32(status) == 0)
                {
                    status = "Chưa thanh toán";
                }

                dgv_HoaDonCho_BanHang.Rows.Add("Hóa đơn chờ " + stt++, item.IdHoadon, item.SoDienThoai, item.IdNhanvien, item.IdPhuongthucthanhtoan, status);

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
            dgv_HoaDonChiTiet_BanHang.ColumnCount = 6;
            dgv_HoaDonChiTiet_BanHang.Columns[0].HeaderText = "Số thứ tự";
            dgv_HoaDonChiTiet_BanHang.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_HoaDonChiTiet_BanHang.Columns[2].HeaderText = "Mã hóa đơn";
            dgv_HoaDonChiTiet_BanHang.Columns[3].HeaderText = "Đơn giá";
            dgv_HoaDonChiTiet_BanHang.Columns[4].HeaderText = "Số lượng";
            dgv_HoaDonChiTiet_BanHang.Columns[5].HeaderText = "MaSP";
            dgv_HoaDonChiTiet_BanHang.Columns[5].Visible = false;
            dgv_HoaDonChiTiet_BanHang.Columns[0].Visible = false;
            dgv_HoaDonChiTiet_BanHang.Columns[2].Visible = false;

            dgv_HoaDonChiTiet_BanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // Thêm cột nút xóa
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Xóa";
            btnColumn.Name = "btnXoa";
            btnColumn.Text = "Xóa";
            btnColumn.UseColumnTextForButtonValue = true;
            dgv_HoaDonChiTiet_BanHang.Columns.Add(btnColumn);




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
                dgv_HoaDonChiTiet_BanHang.Rows.Add(stt++, tensp, hdct.MaHoaDon, hdct.DonGia, hdct.SoLuong, hdct.MaSpct);
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
            dgv_HoaDonChiTiet_BanHang.Rows.Clear();
            cb_HTTT_BanHang.SelectedIndex = -1;
            tb_HoaDonCho.Clear();
            LoadHoaDonCho();
            ShowSanPham_BanHang();
        }

        private void BanHangControl_Load(object sender, EventArgs e)
        {
            LoadHoaDonCho();
            ShowSanPham_BanHang();
            tb_MaHoaDon_BanHang.Visible = false;
            LoadComboBoxPTT();
        }

        private void LoadComboBoxPTT()
        {
            // Xóa tất cả các mục hiện có
            cb_HTTT_BanHang.Items.Clear();

            // Thêm các mục mới
            cb_HTTT_BanHang.Items.Add("Tiền mặt");
            cb_HTTT_BanHang.Items.Add("Chuyển khoản");

            // Đặt giá trị chọn thành -1 để không có mục nào được chọn
            cb_HTTT_BanHang.SelectedIndex = -1;
        }


        private void btn_HuyHoaDon_BanHang_Click(object sender, EventArgs e)
        {
            RefreshToanBoForm();

        }
        private bool daThanhToanDu = false;
        public static int tienQR;
        private void btn_ThanhToan_BanHang_Click(object sender, EventArgs e)
        {// Kiểm tra xem mã hóa đơn có giá trị không
            if (!string.IsNullOrEmpty(tb_MaHoaDon_BanHang.Text))
            {
                // Kiểm tra phương thức thanh toán
                if (cb_HTTT_BanHang.SelectedIndex == 0) // "Tiền mặt"
                {
                    if (daThanhToanDu)
                    {
                        checkInHoaDon();
                        hoaDonServices.SuaTrangThai(tb_MaHoaDon_BanHang.Text, 1, 1);
                        MessageBox.Show("Đã thanh toán hóa đơn!");
                        RefreshToanBoForm();

                    }
                    else
                    {
                        MessageBox.Show("Tiền khách đưa chưa đủ!");
                    }
                }
                else if (cb_HTTT_BanHang.SelectedIndex == 1) // "Chuyển khoản"
                {
                    checkInHoaDon();
                    var tongSoTien = TinhTongTienHoaDon(tb_MaHoaDon_BanHang.Text.ToString());
                    tienQR = Convert.ToInt32(tongSoTien);
                    FormBank formBank = new FormBank();
                    formBank.ShowDialog();
                    hoaDonServices.SuaTrangThai(tb_MaHoaDon_BanHang.Text, 1, 2);
                    MessageBox.Show("Đã thanh toán hóa đơn!");
                    RefreshToanBoForm();
                }
                else
                {
                    MessageBox.Show("Hãy chọn phương thức thanh toán hợp lệ!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn hóa đơn chờ để thanh toán!");
            }
        }

        private void checkInHoaDon()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string folderPath = @"D:\Hoc\HOCKI3\Dự án 1\DuAn1Repos\DuAn1\HoaDon";
                // Gọi hàm để tạo file PDF
                CreatePdfInvoice(folderPath);
            }
        }
        public void CreatePdfInvoice(string folderPath)
        {
            try
            {
                // Kiểm tra và tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Tạo tên file độc nhất bằng cách sử dụng dấu thời gian
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                string filePath = Path.Combine(folderPath, $"invoice_{timestamp}.pdf");

                // Tạo tài liệu PDF
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Hóa đơn bán hàng";

                // Tạo trang và thêm nội dung
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Verdana", 12);
                XFont fontBold = new XFont("Verdana", 12);
                XFont titleFont = new XFont("Verdana", 18);
                XFont storeFont = new XFont("Verdana", 22);

                // Tạo tiêu đề cửa hàng và ngày tháng
                gfx.DrawString("ADV STORE", storeFont, XBrushes.Black, new XRect(0, 20, page.Width, 40), XStringFormats.TopCenter);
                gfx.DrawString("Hóa đơn bán hàng", titleFont, XBrushes.Black, new XRect(0, 60, page.Width, 40), XStringFormats.TopCenter);
                // Vẽ đường kẻ chia ranh giới giữa tiêu đề và bảng
                gfx.DrawLine(XPens.Black, 20, 140, page.Width - 20, 140);
                gfx.DrawString("Ngày tạo: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), font, XBrushes.Black, new XRect(20, 110, page.Width - 40, 20), XStringFormats.TopLeft);

            

                // Vẽ bảng từ DataGridView
                int yPosition = 150;
                int rowHeight = 25;
                int[] columnWidths = { 50, 200, 100, 100, 100 }; // Đặt chiều rộng các cột

                // Tiêu đề cột
                XSolidBrush headerBackground = new XSolidBrush(XColor.FromArgb(29, 135, 209));
                XSolidBrush headerForeground = XBrushes.White;
                gfx.DrawRectangle(headerBackground, 20, yPosition, page.Width - 40, rowHeight);
                gfx.DrawRectangle(XPens.Black, 20, yPosition, page.Width - 40, rowHeight);
                gfx.DrawString("STT", fontBold, headerForeground, new XRect(25, yPosition, columnWidths[0], rowHeight), XStringFormats.Center);
                gfx.DrawString("Tên sản phẩm", fontBold, headerForeground, new XRect(75, yPosition, columnWidths[1], rowHeight), XStringFormats.Center);
                gfx.DrawString("Đơn giá", fontBold, headerForeground, new XRect(275, yPosition, columnWidths[2], rowHeight), XStringFormats.Center);
                gfx.DrawString("Số lượng", fontBold, headerForeground, new XRect(375, yPosition, columnWidths[3], rowHeight), XStringFormats.Center);
                gfx.DrawString("Thành tiền", fontBold, headerForeground, new XRect(475, yPosition, columnWidths[4], rowHeight), XStringFormats.Center);
                yPosition += rowHeight;

                // Dữ liệu từ DataGridView
                int stt = 1;
                decimal totalAmount = 0;
                XPen borderPen = new XPen(XColors.Black, 1);
                foreach (DataGridViewRow row in dgv_HoaDonChiTiet_BanHang.Rows)
                {
                    if (row.IsNewRow) continue;

                    string tenSanPham = row.Cells[1].Value?.ToString() ?? string.Empty;
                    string donGiaStr = row.Cells[3].Value?.ToString() ?? string.Empty;
                    string soLuongStr = row.Cells[4].Value?.ToString() ?? string.Empty;
                    decimal donGia = decimal.TryParse(donGiaStr, out donGia) ? donGia : 0;
                    int soLuong = int.TryParse(soLuongStr, out soLuong) ? soLuong : 0;
                    decimal thanhTien = donGia * soLuong;
                    totalAmount += thanhTien;

                    gfx.DrawRectangle(borderPen, 20, yPosition, page.Width - 40, rowHeight);
                    gfx.DrawLine(borderPen, 20 + columnWidths[0], yPosition, 20 + columnWidths[0], yPosition + rowHeight);
                    gfx.DrawLine(borderPen, 20 + columnWidths[0] + columnWidths[1], yPosition, 20 + columnWidths[0] + columnWidths[1], yPosition + rowHeight);
                    gfx.DrawLine(borderPen, 20 + columnWidths[0] + columnWidths[1] + columnWidths[2], yPosition, 20 + columnWidths[0] + columnWidths[1] + columnWidths[2], yPosition + rowHeight);
                    gfx.DrawLine(borderPen, 20 + columnWidths[0] + columnWidths[1] + columnWidths[2] + columnWidths[3], yPosition, 20 + columnWidths[0] + columnWidths[1] + columnWidths[2] + columnWidths[3], yPosition + rowHeight);

                    gfx.DrawString(stt.ToString(), font, XBrushes.Black, new XRect(25, yPosition, columnWidths[0], rowHeight), XStringFormats.Center);
                    gfx.DrawString(tenSanPham, font, XBrushes.Black, new XRect(75, yPosition, columnWidths[1], rowHeight), XStringFormats.Center);
                    gfx.DrawString(donGia.ToString("#,##0 'VND'"), font, XBrushes.Black, new XRect(275, yPosition, columnWidths[2], rowHeight), XStringFormats.Center);
                    gfx.DrawString(soLuong.ToString(), font, XBrushes.Black, new XRect(375, yPosition, columnWidths[3], rowHeight), XStringFormats.Center);
                    gfx.DrawString(thanhTien.ToString("#,##0 'VND'"), font, XBrushes.Black, new XRect(475, yPosition, columnWidths[4], rowHeight), XStringFormats.Center);

                    yPosition += rowHeight;
                    stt++;
                }

                // Vẽ đường kẻ ngang để kết thúc bảng
                gfx.DrawLine(XPens.Black, 20, yPosition, page.Width - 20, yPosition);

                // Tổng cộng
                yPosition += 20;
                gfx.DrawString("Tổng cộng:", fontBold, XBrushes.Black, new XRect(375, yPosition, columnWidths[3], rowHeight), XStringFormats.Center);
                gfx.DrawString(totalAmount.ToString("#,##0 'VND'"), fontBold, XBrushes.Black, new XRect(475, yPosition, columnWidths[4], rowHeight), XStringFormats.Center);

                // Thông điệp cảm ơn
                yPosition += rowHeight + 20;
                gfx.DrawString("Cảm ơn quý khách. Hẹn gặp lại!", font, XBrushes.Black, new XRect(20, yPosition, page.Width - 40, rowHeight), XStringFormats.TopCenter);

                // Lưu tài liệu PDF
                document.Save(filePath);

                MessageBox.Show("Hóa đơn đã được in thành công: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Không có quyền truy cập thư mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi IO: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgv_HoaDonChiTiet_BanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải cột nút xóa không
            if (e.ColumnIndex == dgv_HoaDonChiTiet_BanHang.Columns["btnXoa"].Index && e.RowIndex >= 0)
            {
                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Lấy mã sản phẩm chi tiết
                    var rowHienTai = dgv_HoaDonChiTiet_BanHang.Rows[e.RowIndex];
                    var maSPCT = rowHienTai.Cells[5].Value.ToString();
                    var maHoaDon = tb_MaHoaDon_BanHang.Text;

                    // Hoàn lại số lượng sản phẩm vào kho
                    var spct = sanPhamChiTietServices.GetAllSanPhamChiTietById(maSPCT);
                    var hdct = hoaDonChiTietServices.GetHDCTById(maHoaDon, maSPCT);
                    spct.SoLuong += hdct.SoLuong ?? 0;
                    sanPhamChiTietServices.UpdateSoLuong(spct);

                    // Xóa hóa đơn chi tiết
                    hoaDonChiTietServices.DeleteHDCTById(maHoaDon, maSPCT);

                    // Tải lại dữ liệu
                    LoadData_dgvHoaDonChiTiet(hoaDonChiTietServices.GetAllHoaDonCTByMaHoaDon(maHoaDon));
                    ShowSanPham_BanHang();

                    MessageBox.Show("Đã xóa sản phẩm và cập nhật lại số lượng sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_XoaTatCa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_MaHoaDon_BanHang.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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
                // Xóa tất cả các chi tiết hóa đơn liên quan đến hóa đơn đang chọn
                hoaDonChiTietServices.DeleteAllHDCTByMaHoaDon(maHoaDon);

                // Load lại dữ liệu trên DataGridView
                tb_TimKiem_SanPham.Text = string.Empty;
                ShowSanPham_BanHang();
                LoadData_dgvHoaDonChiTiet(hoaDonChiTietServices.GetAllHoaDonCTByMaHoaDon(tb_MaHoaDon_BanHang.Text));
                return;
            }
        }

        private void dgv_HoaDonChiTiet_BanHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_MaHoaDon_BanHang.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (e.RowIndex >= 0)
            {

                var rowHienTai = dgv_HoaDonChiTiet_BanHang.Rows[e.RowIndex];
                var maSPCTDangTao = rowHienTai.Cells[5].Value.ToString();
                var spctDangTao = sanPhamChiTietServices.GetAllSanPhamChiTietById(maSPCTDangTao);
                var maHoaDon = tb_MaHoaDon_BanHang.Text;
                var hoaDonDangChon = hoaDonServices.GetHoaDonbyMaHoaDon(maHoaDon); // Giả sử bạn có phương thức này để lấy chi tiết hóa đơn
                FormSoLuongMua formSoLuongMua = new FormSoLuongMua();                                                                   // Kiểm tra số lượng sản phẩm có đủ không
                formSoLuongMua.ShowDialog();
                if (spctDangTao.SoLuong < formSoLuongMua.SoLuongMua)
                {
                    MessageBox.Show("Số lượng sản phẩm không đủ để thêm vào hóa đơn chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                var hoaDonChiTietTonTai = hoaDonChiTietServices.GetHDCTById(Convert.ToString(hoaDonDangChon.IdHoadon), maSPCTDangTao);
                int soLuong = 0;
                if (hoaDonChiTietTonTai != null)
                {

                    HoaDonChiTiet hoaDonChiTietDangUpdate = new HoaDonChiTiet();
                    soLuong = Convert.ToInt32(formSoLuongMua.SoLuongMua - hoaDonChiTietTonTai.SoLuong);
                    hoaDonChiTietDangUpdate.MaSpct = Guid.Parse(maSPCTDangTao);
                    hoaDonChiTietDangUpdate.MaHoaDon = hoaDonDangChon.IdHoadon;
                    hoaDonChiTietDangUpdate.DonGia = spctDangTao.Gia;
                    hoaDonChiTietDangUpdate.SoLuong = formSoLuongMua.SoLuongMua;
                    hoaDonChiTietServices.UpdateSoLuong(hoaDonChiTietDangUpdate);



                }
                spctDangTao.SoLuong -= soLuong;
                sanPhamChiTietServices.UpdateSoLuong(spctDangTao);

                // load lại dữ liệu trên 2 data grid view
                tb_TimKiem_SanPham.Text = string.Empty;
                ShowSanPham_BanHang();
                LoadData_dgvHoaDonChiTiet(hoaDonChiTietServices.GetAllHoaDonCTByMaHoaDon(maHoaDon));

            }
        }
    }
}