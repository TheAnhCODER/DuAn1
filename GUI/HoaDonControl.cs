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

namespace GUI
{
    public partial class HoaDonControl : UserControl
    {
        HoaDonServices hoaDonServices;
        HoaDonChiTietServices hoaDonChiTietServices;
        KhachHangServices khachHangServices;
        NhanVienServices nhanVienServices;
        SanPhamServices sanPhamServices;
        SanPhamChiTietServices sanPhamChiTietServices;
        public HoaDonControl()
        {
            InitializeComponent();
            hoaDonChiTietServices = new HoaDonChiTietServices();
            hoaDonServices = new HoaDonServices();
            khachHangServices = new KhachHangServices();
            nhanVienServices = new NhanVienServices();
            sanPhamServices = new SanPhamServices();
            sanPhamChiTietServices = new SanPhamChiTietServices();
            LoadTrangThai();
            DkySuKienDateTimePicker();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void RefreshData()
        {
            LoadHoaDonAll();

        }
        public void LoadHoaDonAll()
        {
            List<HoaDon> hoaDons = hoaDonServices.GetAllHoaDons();
            dgv_hoadon_HoaDon.Rows.Clear();
            dgv_hoadon_HoaDon.ColumnCount = 9;
            int stt = 1;

            dgv_hoadon_HoaDon.Columns[0].HeaderText = "STT";
            dgv_hoadon_HoaDon.Columns[1].HeaderText = "MaHoaDon";
            dgv_hoadon_HoaDon.Columns[2].HeaderText = "Số điện thoại khách hàng";
            dgv_hoadon_HoaDon.Columns[3].HeaderText = "Tên nhân viên";
            dgv_hoadon_HoaDon.Columns[4].HeaderText = "Phương thức thanh toán";
            dgv_hoadon_HoaDon.Columns[5].HeaderText = "Trạng thái thanh toán";
            dgv_hoadon_HoaDon.Columns[6].HeaderText = "Tổng số tiền hóa đơn";
            dgv_hoadon_HoaDon.Columns[7].HeaderText = "Ngày tạo";
            dgv_hoadon_HoaDon.Columns[8].HeaderText = "Ngày thanh toán";

            dgv_hoadon_HoaDon.Columns[0].Visible = false;
            dgv_hoadon_HoaDon.Columns[1].Visible = false;

            Dictionary<Guid, string> nhanVienDict = nhanVienServices.GetNhanVienDict();

            dgv_hoadon_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_hoadon_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_hoadon_HoaDon.ColumnHeadersHeight = 50;

            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_hoadon_HoaDon.Font, FontStyle.Bold);
            dgv_hoadon_HoaDon.EnableHeadersVisualStyles = false;
            dgv_hoadon_HoaDon.ClearSelection();

            foreach (var item in hoaDons)
            {
                string nhanVien = nhanVienDict.ContainsKey(item.IdNhanvien.Value)
                ? nhanVienDict[item.IdNhanvien.Value]
                : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                string phuongthucthanhtoan = item.IdPhuongthucthanhtoan == 1 ? "Tiền mặt" : "Chuyển khoản";

                string status = "Đã thanh toán"; // Chỉ có trạng thái "Đã thanh toán"
                dgv_hoadon_HoaDon.Rows.Add(stt++, item.IdHoadon, item.SoDienThoai, nhanVien, phuongthucthanhtoan, status, item.TongSoTienHoaDon, item.NgayTao?.ToString("dd/MM/yyyy"), item.NgayThanhToan?.ToString("dd/MM/yyyy"));
            }
        }
        public void LoadHoaDon()
        {
            List<HoaDon> hoaDons = hoaDonServices.GetAllHoaDonChos();
            dgv_hoadon_HoaDon.Rows.Clear();
            dgv_hoadon_HoaDon.ColumnCount = 9;
            int stt = 1;

            dgv_hoadon_HoaDon.Columns[0].HeaderText = "STT";
            dgv_hoadon_HoaDon.Columns[1].HeaderText = "MaHoaDon";
            dgv_hoadon_HoaDon.Columns[2].HeaderText = "Số điện thoại khách hàng";
            dgv_hoadon_HoaDon.Columns[3].HeaderText = "Tên nhân viên";
            dgv_hoadon_HoaDon.Columns[4].HeaderText = "Phương thức thanh toán";
            dgv_hoadon_HoaDon.Columns[5].HeaderText = "Trạng thái thanh toán";
            dgv_hoadon_HoaDon.Columns[6].HeaderText = "Tổng số tiền hóa đơn";
            dgv_hoadon_HoaDon.Columns[7].HeaderText = "Ngày tạo";
            dgv_hoadon_HoaDon.Columns[8].HeaderText = "Ngày thanh toán";

            dgv_hoadon_HoaDon.Columns[0].Visible = false;
            dgv_hoadon_HoaDon.Columns[1].Visible = false;

            Dictionary<Guid, string> nhanVienDict = nhanVienServices.GetNhanVienDict();

            dgv_hoadon_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_hoadon_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_hoadon_HoaDon.ColumnHeadersHeight = 50;

            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_hoadon_HoaDon.Font, FontStyle.Bold);
            dgv_hoadon_HoaDon.EnableHeadersVisualStyles = false;
            dgv_hoadon_HoaDon.ClearSelection();

            foreach (var item in hoaDons)
            {
                string nhanVien = nhanVienDict.ContainsKey(item.IdNhanvien.Value)
                ? nhanVienDict[item.IdNhanvien.Value]
                : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                string phuongthucthanhtoan = item.IdPhuongthucthanhtoan == 1 ? "Tiền mặt" : "Chuyển khoản";
                string status = "Đã thanh toán"; // Chỉ có trạng thái "Đã thanh toán"
                dgv_hoadon_HoaDon.Rows.Add(stt++, item.IdHoadon, item.SoDienThoai, nhanVien, phuongthucthanhtoan, status, item.TongSoTienHoaDon, item.NgayTao?.ToString("dd/MM/yyyy"), item.NgayThanhToan?.ToString("dd/MM/yyyy"));
            }
        }
        public void LoadHoaDon1()
        {
            List<HoaDon> hoaDon1 = hoaDonServices.GetAllHoaDon1();
            dgv_hoadon_HoaDon.Rows.Clear();
            dgv_hoadon_HoaDon.ColumnCount = 9;
            int stt = 1;

            dgv_hoadon_HoaDon.Columns[0].HeaderText = "STT";
            dgv_hoadon_HoaDon.Columns[1].HeaderText = "MaHoaDon";
            dgv_hoadon_HoaDon.Columns[2].HeaderText = "Số điện thoại khách hàng";
            dgv_hoadon_HoaDon.Columns[3].HeaderText = "Tên nhân viên";
            dgv_hoadon_HoaDon.Columns[4].HeaderText = "Phương thức thanh toán";
            dgv_hoadon_HoaDon.Columns[5].HeaderText = "Trạng thái thanh toán";
            dgv_hoadon_HoaDon.Columns[6].HeaderText = "Tổng số tiền hóa đơn";
            dgv_hoadon_HoaDon.Columns[7].HeaderText = "Ngày tạo";
            dgv_hoadon_HoaDon.Columns[8].HeaderText = "Ngày thanh toán";

            dgv_hoadon_HoaDon.Columns[0].Visible = false;
            dgv_hoadon_HoaDon.Columns[1].Visible = false;

            Dictionary<Guid, string> nhanVienDict = nhanVienServices.GetNhanVienDict();

            dgv_hoadon_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_hoadon_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_hoadon_HoaDon.ColumnHeadersHeight = 50;

            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_hoadon_HoaDon.Font, FontStyle.Bold);
            dgv_hoadon_HoaDon.EnableHeadersVisualStyles = false;
            dgv_hoadon_HoaDon.ClearSelection();

            foreach (var item in hoaDon1)
            {

                string nhanVien = nhanVienDict.ContainsKey(item.IdNhanvien.Value)
                ? nhanVienDict[item.IdNhanvien.Value]
                : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                string phuongthucthanhtoan = item.IdPhuongthucthanhtoan == 1 ? "Tiền mặt" : "Chuyển khoản";
                string status = "Đã thanh toán"; // Chỉ có trạng thái "Đã thanh toán"
                dgv_hoadon_HoaDon.Rows.Add(stt++, item.IdHoadon, item.SoDienThoai, nhanVien, phuongthucthanhtoan, status, item.TongSoTienHoaDon, item.NgayTao?.ToString("dd/MM/yyyy"), item.NgayThanhToan?.ToString("dd/MM/yyyy"));
            }
        }
        public void ShowHoaDon(List<HoaDon> hoaDonList)
        {
            dgv_hoadon_HoaDon.Rows.Clear();
            dgv_hoadon_HoaDon.ColumnCount = 9;
            int stt = 1;

            dgv_hoadon_HoaDon.Columns[0].HeaderText = "STT";
            dgv_hoadon_HoaDon.Columns[1].HeaderText = "MaHoaDon";
            dgv_hoadon_HoaDon.Columns[2].HeaderText = "Số điện thoại khách hàng";
            dgv_hoadon_HoaDon.Columns[3].HeaderText = "Tên nhân viên";
            dgv_hoadon_HoaDon.Columns[4].HeaderText = "Phương thức thanh toán";
            dgv_hoadon_HoaDon.Columns[5].HeaderText = "Trạng thái thanh toán";
            dgv_hoadon_HoaDon.Columns[6].HeaderText = "Tổng số tiền hóa đơn";
            dgv_hoadon_HoaDon.Columns[7].HeaderText = "Ngày tạo";
            dgv_hoadon_HoaDon.Columns[8].HeaderText = "Ngày thanh toán";

            dgv_hoadon_HoaDon.Columns[0].Visible = false;
            dgv_hoadon_HoaDon.Columns[1].Visible = false;

            Dictionary<Guid, string> nhanVienDict = nhanVienServices.GetNhanVienDict();

            dgv_hoadon_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_hoadon_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_hoadon_HoaDon.ColumnHeadersHeight = 50;

            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_hoadon_HoaDon.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_hoadon_HoaDon.Font, FontStyle.Bold);
            dgv_hoadon_HoaDon.EnableHeadersVisualStyles = false;

            foreach (var item in hoaDonList)
            {
                string nhanVien = nhanVienDict.ContainsKey(item.IdNhanvien.Value)
                ? nhanVienDict[item.IdNhanvien.Value]
                : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 

                string phuongthucthanhtoan = item.IdPhuongthucthanhtoan == 1 ? "Tiền mặt" : "Chuyển khoản";
                string status = "Đã thanh toán"; // Chỉ có trạng thái "Đã thanh toán"
                dgv_hoadon_HoaDon.Rows.Add(stt++, item.IdHoadon, item.SoDienThoai, nhanVien, phuongthucthanhtoan, status, item.TongSoTienHoaDon, item.NgayTao?.ToString("dd/MM/yyyy"), item.NgayThanhToan?.ToString("dd/MM/yyyy"));
            }
        }
        private void LoadData_dgvHoaDonChiTiet(List<HoaDonChiTiet> hoaDonChiTiets)
        {
            dgv_hoadonchitiet_HoaDon.Rows.Clear();
            dgv_hoadonchitiet_HoaDon.ColumnCount = 5;
            dgv_hoadonchitiet_HoaDon.Columns[0].HeaderText = "Số thứ tự";
            dgv_hoadonchitiet_HoaDon.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_hoadonchitiet_HoaDon.Columns[2].HeaderText = "Mã hóa đơn";
            dgv_hoadonchitiet_HoaDon.Columns[3].HeaderText = "Đơn giá";
            dgv_hoadonchitiet_HoaDon.Columns[4].HeaderText = "Số lượng";

            dgv_hoadonchitiet_HoaDon.Columns[0].Visible = false;
            dgv_hoadonchitiet_HoaDon.Columns[2].Visible = false;

            dgv_hoadonchitiet_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đặt chiều cao cho hàng tiêu đề
            dgv_hoadonchitiet_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_hoadonchitiet_HoaDon.ColumnHeadersHeight = 50; // Đặt chiều cao tùy ý

            // Thiết lập màu sắc và kiểu chữ cho hàng tiêu đề
            dgv_hoadonchitiet_HoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_hoadonchitiet_HoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_hoadonchitiet_HoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_hoadonchitiet_HoaDon.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_hoadonchitiet_HoaDon.Font, FontStyle.Bold);
            dgv_hoadonchitiet_HoaDon.EnableHeadersVisualStyles = false;
            dgv_hoadonchitiet_HoaDon.ClearSelection();
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
                dgv_hoadonchitiet_HoaDon.Rows.Add(stt++, tensp, hdct.MaHoaDon, hdct.DonGia, hdct.SoLuong);
            }
        }
        private void LoadTrangThai()
        {
            try
            {
                var trangThaiList = new Dictionary<int, string>
                {
                    { 1, "Đã thanh toán" } // Chỉ có trạng thái "Đã thanh toán"
                };
                cb_trangthai_HoaDon.DataSource = new BindingSource(trangThaiList, null);
                cb_trangthai_HoaDon.DisplayMember = "Value";
                cb_trangthai_HoaDon.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void cb_trangthai_HoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_timkiem_HoaDon.Clear();
            dateTime_ngaytaohoadon_HoaDon.CustomFormat = " ";
            dateTime_ngaytaohoadon_HoaDon.Format = DateTimePickerFormat.Custom;
            dtp_NgayKetThuc.CustomFormat = " ";
            dtp_NgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtp_NgayBatDau.CustomFormat = " ";
            dtp_NgayBatDau.Format = DateTimePickerFormat.Custom;
            dgv_hoadon_HoaDon.Rows.Clear();
            dgv_hoadonchitiet_HoaDon.Rows.Clear();
            // Kiểm tra nếu SelectedValue không null và là kiểu int
            if (cb_trangthai_HoaDon.SelectedValue != null && cb_trangthai_HoaDon.SelectedValue is int trangThai)
            {
                if (trangThai == -1)  // Nếu chọn "Tất cả"
                {
                    LoadHoaDonAll();
                }
                else
                {
                    List<HoaDon> hoaDons = hoaDonServices.GetHoaDonByTrangThai(trangThai);
                    ShowHoaDon(hoaDons);
                }
            }
        }

        private void dgv_hoadon_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấp vào một hàng và không phải tiêu đề cột
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị của mã hóa đơn từ dòng được chọn
                var maHoaDon = dgv_hoadon_HoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Lấy danh sách chi tiết hóa đơn từ mã hóa đơn
                List<HoaDonChiTiet> hoaDonChiTiets = hoaDonChiTietServices.GetAllHoaDonCTByMaHoaDon(maHoaDon);

                // Tải dữ liệu vào DataGridView chi tiết hóa đơn
                LoadData_dgvHoaDonChiTiet(hoaDonChiTiets);
            }
        }
        private void SearchHoaDon()
        {
            dgv_hoadon_HoaDon.Rows.Clear();

            DateTime selectedDate = dateTime_ngaytaohoadon_HoaDon.Value.Date;

            // Lấy danh sách hóa đơn theo ngày
            List<HoaDon> hoaDons = hoaDonServices.GetHoaDonByDate(selectedDate);
            ShowHoaDon(hoaDons);
        }
        private void DkySuKienDateTimePicker()
        {
            dateTime_ngaytaohoadon_HoaDon.ValueChanged += dateTime_ngaytaohoadon_HoaDon_ValueChanged;
        }

        private void SearchHoaDonByPhoneNumber()
        {
            string phoneNumber = txt_timkiem_HoaDon.Text.Trim();

            if (!string.IsNullOrEmpty(phoneNumber))
            {
                // Lấy danh sách hóa đơn theo số điện thoại
                List<HoaDon> hoaDons = hoaDonServices.GetHoaDonByPhoneNumber(phoneNumber);
                ShowHoaDon(hoaDons);
            }
            else
            {
                dgv_hoadon_HoaDon.Rows.Clear(); // Xóa dữ liệu nếu không có số điện thoại nhập
            }
        }

        private void dateTime_ngaytaohoadon_HoaDon_ValueChanged(object sender, EventArgs e)
        {
            refreshForm();
            dateTime_ngaytaohoadon_HoaDon.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày
            dateTime_ngaytaohoadon_HoaDon.Format = DateTimePickerFormat.Custom;
            // Giới hạn ngày lớn nhất là ngày hiện tại
            dateTime_ngaytaohoadon_HoaDon.MaxDate = DateTime.Now;

            SearchHoaDon();
        }

        private void txt_timkiem_HoaDon_TextChanged(object sender, EventArgs e)
        {
            cb_trangthai_HoaDon.SelectedIndex = -1;

            dateTime_ngaytaohoadon_HoaDon.CustomFormat = " ";
            dateTime_ngaytaohoadon_HoaDon.Format = DateTimePickerFormat.Custom;
            dtp_NgayKetThuc.CustomFormat = " ";
            dtp_NgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtp_NgayBatDau.CustomFormat = " ";
            dtp_NgayBatDau.Format = DateTimePickerFormat.Custom;
            SearchHoaDonByPhoneNumber();

        }
        // Phương thức kiểm tra ngày hợp lệ
        private bool IsValidDay(string input)
        {
            if (int.TryParse(input, out int day))
            {
                return day >= 1 && day <= 31;
            }
            return false;
        }

        // Phương thức kiểm tra tháng hợp lệ
        private bool IsValidMonth(string input)
        {
            if (int.TryParse(input, out int month))
            {
                return month >= 1 && month <= 12;
            }
            return false;
        }

        // Phương thức kiểm tra năm hợp lệ
        private bool IsValidYear(string input)
        {
            if (int.TryParse(input, out int year))
            {
                return year > 0;
            }
            return false;
        }
        // Tìm kiếm hóa đơn theo ngày
        private void SearchHoaDonByDay(string ngay)
        {
            if (!string.IsNullOrEmpty(ngay) && !IsValidDay(ngay))
            {
                MessageBox.Show("Ngày không hợp lệ. Phải từ 1 đến 31.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string formattedDay = string.IsNullOrEmpty(ngay) ? "" : ngay.PadLeft(2, '0');

            List<HoaDon> hoaDons = hoaDonServices.GetAllHoaDons();
            if (!string.IsNullOrEmpty(formattedDay))
            {
                hoaDons = hoaDons.Where(hd => hd.NgayTao.HasValue && hd.NgayTao.Value.Day.ToString("00") == formattedDay).ToList();
            }

            ShowHoaDon(hoaDons);
        }

        // Tìm kiếm hóa đơn theo tháng
        private void SearchHoaDonByMonth(string thang)
        {
            if (!string.IsNullOrEmpty(thang) && !IsValidMonth(thang))
            {
                MessageBox.Show("Tháng không hợp lệ. Phải từ 1 đến 12.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string formattedMonth = string.IsNullOrEmpty(thang) ? "" : thang.PadLeft(2, '0');

            List<HoaDon> hoaDons = hoaDonServices.GetAllHoaDons();
            if (!string.IsNullOrEmpty(formattedMonth))
            {
                hoaDons = hoaDons.Where(hd => hd.NgayTao.HasValue && hd.NgayTao.Value.Month.ToString("00") == formattedMonth).ToList();
            }

            ShowHoaDon(hoaDons);
        }

        // Tìm kiếm hóa đơn theo năm
        private void SearchHoaDonByYear(string nam)
        {
            if (!string.IsNullOrEmpty(nam) && !IsValidYear(nam))
            {
                MessageBox.Show("Năm không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<HoaDon> hoaDons = hoaDonServices.GetAllHoaDons();
            if (!string.IsNullOrEmpty(nam))
            {
                hoaDons = hoaDons.Where(hd => hd.NgayTao.HasValue && hd.NgayTao.Value.Year.ToString() == nam).ToList();
            }

            ShowHoaDon(hoaDons);
        }



        private void HoaDonControl_Load(object sender, EventArgs e)
        {
            LoadHoaDonAll();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void refreshForm()
        {
            cb_trangthai_HoaDon.SelectedIndex = -1;
            txt_timkiem_HoaDon.Clear();
            dateTime_ngaytaohoadon_HoaDon.CustomFormat = " ";
            dateTime_ngaytaohoadon_HoaDon.Format = DateTimePickerFormat.Custom;
            dtp_NgayKetThuc.CustomFormat = " ";
            dtp_NgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtp_NgayBatDau.CustomFormat = " ";
            dtp_NgayBatDau.Format = DateTimePickerFormat.Custom;
            dgv_hoadonchitiet_HoaDon.Rows.Clear();
      
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            cb_trangthai_HoaDon.SelectedIndex = -1;
            txt_timkiem_HoaDon.Clear();
            dateTime_ngaytaohoadon_HoaDon.CustomFormat = " ";
            dateTime_ngaytaohoadon_HoaDon.Format = DateTimePickerFormat.Custom;
            dgv_hoadonchitiet_HoaDon.Rows.Clear();
            if (dtp_NgayBatDau.CustomFormat == " " || dtp_NgayKetThuc.CustomFormat == " ")
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu và ngày kết thúc.");
                return;
            }
            DateTime startDate = dtp_NgayBatDau.Value.Date;
            DateTime endDate = dtp_NgayKetThuc.Value.Date.AddDays(1).Date;
            List<HoaDon> hoaDons = hoaDonServices.GetHoaDonsByDateRange(startDate, endDate);
            ShowHoaDon(hoaDons);

        }

        private void dtp_NgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            cb_trangthai_HoaDon.SelectedIndex = -1;
            dtp_NgayBatDau.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày
            dtp_NgayBatDau.Format = DateTimePickerFormat.Custom;
            // Giới hạn ngày lớn nhất là ngày hiện tại
            dtp_NgayBatDau.MaxDate = DateTime.Now;
        }

        private void dtp_NgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            dtp_NgayKetThuc.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày
            dtp_NgayKetThuc.Format = DateTimePickerFormat.Custom;
            // Giới hạn ngày lớn nhất là ngày hiện tại
            dtp_NgayKetThuc.MaxDate = DateTime.Now;
        }
    }
}
