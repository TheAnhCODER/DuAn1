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
    public partial class ThongKeControl : UserControl
    {
        private readonly DuAn1Context _context;
        HoaDonServices hoaDonServices;
        HoaDonChiTietServices hoaDonChiTietServices;
        KhachHangServices khachHangServices;
        SanPhamServices sanPhamServices;
        SanPhamChiTietServices sanPhamChiTietServices;
        public ThongKeControl()
        {
            hoaDonChiTietServices = new HoaDonChiTietServices();
            hoaDonServices = new HoaDonServices();
            khachHangServices = new KhachHangServices();
            sanPhamServices = new SanPhamServices();
            sanPhamChiTietServices = new SanPhamChiTietServices();
            _context = new DuAn1Context(); // Khởi tạo DbContext
            InitializeComponent();
            // Gọi phương thức để tính tổng doanh thu khi form được tải
            LoadTotalRevenue();
            LoadAvailableYears(); // Tải các năm có dữ liệu
            LoadInvoiceCounts(); // Tải số hóa đơn
            LoadTongKhachHang(); // Tải số khách hàng 
            LoadProductSalesCounts(); // Tải số lượng sản phẩm bán ra cho năm hiện tại
            LoadDataForCurrentYear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void LoadTotalRevenue()
        {
            int currentYear = DateTime.Now.Year;

            decimal totalRevenue = hoaDonServices.GetTotalRevenueByYear(currentYear);
            txt_doanhthu_ThongKe.Text = totalRevenue.ToString("#,##0 'VND'"); // Hiển thị tổng số tiền với định dạng tiền tệ
        }
        private void LoadInvoiceCounts()
        {
            int currentYear = DateTime.Now.Year;
            int totalInvoices = hoaDonServices.GetNumberOfInvoicesByYear(currentYear);
            txt_hoadon_ThongKe.Text = totalInvoices.ToString(); // Hiển thị số hóa đơn
        }
        private void LoadTongKhachHang()
        {
            int khachhangtheoYear = DateTime.Now.Year;
            int tongKhachHnag = hoaDonServices.GetNumberOfInvoicesByYear(khachhangtheoYear);
            txt_khachhang_ThongKe.Text = tongKhachHnag.ToString(); // Hiển thị số khách hàng
        }
        private void LoadAvailableYears()
        {
            var years = hoaDonServices.GetAvailableYears();

            cb_Nam.Items.Clear();
            foreach (var year in years)
            {
                cb_Nam.Items.Add(year);
            }

            if (cb_Nam.Items.Count > 0)
            {
                cb_Nam.SelectedItem = DateTime.Now.Year;
            }
        }

        private void rb_nam_ThongKe_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nam_ThongKe.Checked)
            {
                cb_Thang.Visible = false;
                cb_Nam.Visible = true;

                // Lấy năm hiện tại
                int currentYear = DateTime.Now.Year;

                // Thêm các năm từ 2000 đến năm hiện tại vào ComboBox
                cb_Nam.Items.Clear();
                for (int year = 2000; year <= currentYear; year++)
                {
                    cb_Nam.Items.Add(year);
                }

                // Chọn năm hiện tại mặc định
                cb_Nam.SelectedItem = currentYear;
                LoadAvailableYears(); // Tải các năm có dữ liệu
            }
        }

        private void cb_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb_thang_ThongKe.Checked && cb_Thang.SelectedItem != null && cb_Nam.SelectedItem != null)
            {
                if (cb_Thang.SelectedIndex > 0) // Kiểm tra nếu không phải là "Chọn tháng"
                {
                    int selectedMonth = (int)cb_Thang.SelectedItem;
                    int selectedYear = (int)cb_Nam.SelectedItem;

                    var totalRevenue = hoaDonServices.GetTotalRevenueByMonth(selectedMonth, selectedYear);
                    txt_doanhthu_ThongKe.Text = totalRevenue.ToString("#,##0 'VND'"); // Hiển thị tổng số tiền với định dạng tiền tệ

                    var numberOfInvoices = hoaDonServices.GetNumberOfInvoicesByMonth(selectedMonth, selectedYear);
                    txt_hoadon_ThongKe.Text = numberOfInvoices.ToString(); // Hiển thị số hóa đơn

                    var tongSoKhachHang = hoaDonServices.GetNumberOfInvoicesByMonth(selectedMonth, selectedYear);
                    txt_khachhang_ThongKe.Text = tongSoKhachHang.ToString(); // Hiển thị số khách hàng

                    LoadProductSalesCounts(); // Hiển thị số lượng bán của các sản phẩm
                    LoadInvoiceDetailsForMonthAndYear(selectedMonth, selectedYear);
                }
            }
        }

        private void cb_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb_nam_ThongKe.Checked && cb_Nam.SelectedItem != null)
            {
                int selectedYear = (int)cb_Nam.SelectedItem;

                var totalRevenue = hoaDonServices.GetTotalRevenueByYear(selectedYear);
                txt_doanhthu_ThongKe.Text = totalRevenue.ToString("#,##0 'VND'"); // Hiển thị tổng số tiền với định dạng tiền tệ

                var numberOfInvoices = hoaDonServices.GetNumberOfInvoicesByYear(selectedYear);
                txt_hoadon_ThongKe.Text = numberOfInvoices.ToString(); // Hiển thị số hóa đơn

                var tongSoKhachHang = hoaDonServices.GetNumberOfInvoicesByYear(selectedYear);
                txt_khachhang_ThongKe.Text = tongSoKhachHang.ToString(); // Hiển thị số khách hàng
                                                                         // Tải các tháng cho năm được chọn
                LoadMonthsForYear(selectedYear);
                LoadProductSalesCounts(); // Hiển thị số lượng bán của các sản phẩm
                                          // Hiển thị chi tiết hóa đơn
                LoadInvoiceDetails(selectedYear);
            }
        }

        private void LoadMonthsForYear(int year)
        {
            // Lấy danh sách các tháng có dữ liệu trong năm được chọn
            var monthsWithData = hoaDonServices.GetMonthsWithDataByYear(year);

            cb_Thang.Items.Clear();
            cb_Thang.Items.Add("Chọn tháng"); // Thêm mục đầu tiên là "Chọn tháng"

            foreach (var month in monthsWithData)
            {
                cb_Thang.Items.Add(month);
            }

            cb_Thang.SelectedIndex = 0; // Chọn mục đầu tiên mặc định
        }
        private void UpdateTotalRevenueByMonth()
        {
            if (cb_Thang.SelectedItem != null && cb_Nam.SelectedItem != null)
            {
                int selectedMonth = int.Parse(cb_Thang.SelectedItem.ToString());
                int selectedYear = int.Parse(cb_Nam.SelectedItem.ToString());
                decimal totalRevenue = hoaDonServices.GetTotalRevenueByMonth(selectedMonth, selectedYear);
                txt_doanhthu_ThongKe.Text = totalRevenue.ToString("#,##0 'VND'");
            }
        }

        private void UpdateTotalRevenueByYear()
        {
            if (cb_Nam.SelectedItem != null)
            {
                int selectedYear = int.Parse(cb_Nam.SelectedItem.ToString());
                decimal totalRevenue = hoaDonServices.GetTotalRevenueByYear(selectedYear);
                txt_doanhthu_ThongKe.Text = totalRevenue.ToString("#,##0 'VND'");
            }
        }

        private void rb_thang_ThongKe_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_thang_ThongKe.Checked)
            {
                cb_Thang.Visible = true;
                cb_Nam.Visible = false;
                // Thêm các tháng vào ComboBox
                cb_Thang.Items.Clear();
                cb_Thang.Items.Add("Chọn tháng"); // Thêm mục đầu tiên là "Chọn tháng"
                for (int month = 1; month <= 12; month++)
                {
                    cb_Thang.Items.Add(month);
                }
                //LoadAvailableYears(); // Tải các năm có dữ liệu
                cb_Thang.SelectedIndex = 0; // Chọn mục "Chọn tháng"
            }
        }

        private void LoadProductSalesCounts()
        {
            if (cb_Nam.SelectedItem != null)
            {
                // Kiểm tra và chuyển đổi kiểu dữ liệu từ ComboBox
                if (int.TryParse(cb_Nam.SelectedItem.ToString(), out int selectedYear))
                {
                    int selectedMonth = 0;
                    if (cb_Thang.SelectedItem != null && cb_Thang.SelectedItem.ToString() != "Chọn tháng")
                    {
                        int.TryParse(cb_Thang.SelectedItem.ToString(), out selectedMonth);
                    }

                    var productSalesCounts = selectedMonth > 0
                        ? hoaDonServices.GetProductSalesCountsByMonth(selectedMonth, selectedYear)
                        : hoaDonServices.GetProductSalesCountsByYear(selectedYear);

                    int totalSales = productSalesCounts.Values.Sum();

                    txt_sanpham_ThongKe.Text = totalSales.ToString();
                }
                else
                {
                    txt_sanpham_ThongKe.Text = "Vui lòng chọn năm hợp lệ.";
                }
            }
            else
            {
                txt_sanpham_ThongKe.Text = "Vui lòng chọn năm.";
            }
        }

        private void btn_timKiem_ThongKe_Click(object sender, EventArgs e)
        {
            DateTime startDate = date_ngaybatdau_ThongKe.Value.Date;
            DateTime endDate = date_ngayketthuc_ThongKe.Value.Date.AddDays(1).AddTicks(-1); // Bao gồm cả ngày kết thúc
            DateTime currentDate = DateTime.Now.Date;
            if (startDate > endDate)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (endDate > currentDate.AddDays(1))
            {
                MessageBox.Show("Ngày kết thúc không thể lớn hơn ngày hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tính toán tổng doanh thu, số lượng hóa đơn, số lượng sản phẩm và số lượng khách hàng trong khoảng thời gian
            decimal totalRevenue = hoaDonServices.GetTotalRevenue(startDate, endDate);
            int invoiceCount = hoaDonServices.GetInvoiceCount(startDate, endDate);
            int productCount = hoaDonServices.GetProductCount(startDate, endDate);
            int customerCount = hoaDonServices.GetCustomerCount(startDate, endDate);

            // Cập nhật các TextBox với kết quả thống kê
            txt_doanhthu_ThongKe.Text = totalRevenue.ToString("#,##0 'VND'");
            txt_hoadon_ThongKe.Text = invoiceCount.ToString();
            txt_sanpham_ThongKe.Text = productCount.ToString();
            txt_khachhang_ThongKe.Text = customerCount.ToString();
            LoadInvoiceDetailsForDateRange(startDate, endDate);

        }

        private void rb_timtheokhoang_ThongKe_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem RadioButton có được chọn không
            if (rb_timtheokhoang_ThongKe.Checked)
            {
                cb_Thang.Visible = false;
                cb_Nam.Visible = false;
                // Hiển thị panel nếu RadioButton được chọn
                pn_timtheokhoang_ThongKe.Visible = true;
            }
            else
            {
                // Ẩn panel nếu RadioButton không được chọn
                pn_timtheokhoang_ThongKe.Visible = false;
            }
        }
        private void LoadInvoiceDetailsToGrid(List<HoaDonChiTiet> invoiceDetails)
        {
            dgv_loadsanpham_ThongKe.Rows.Clear();
            dgv_loadsanpham_ThongKe.ColumnCount = 3;
            dgv_loadsanpham_ThongKe.Columns[0].HeaderText = "Số thứ tự";
            dgv_loadsanpham_ThongKe.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_loadsanpham_ThongKe.Columns[2].HeaderText = "Số lượt mua";
            dgv_loadsanpham_ThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đặt chiều cao cho hàng tiêu đề
            dgv_loadsanpham_ThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_loadsanpham_ThongKe.ColumnHeadersHeight = 50; // Đặt chiều cao tùy ý

            // Thiết lập màu sắc và kiểu chữ cho hàng tiêu đề
            dgv_loadsanpham_ThongKe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_loadsanpham_ThongKe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_loadsanpham_ThongKe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_loadsanpham_ThongKe.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_loadsanpham_ThongKe.Font, FontStyle.Bold);
            dgv_loadsanpham_ThongKe.EnableHeadersVisualStyles = false;

            Dictionary<Guid, string> sanPhamChiTietDict = sanPhamChiTietServices.GetMaSanPhamDict();
            Dictionary<Guid, string> sanphamDict = sanPhamServices.GetSanPhamDict();

            var groupedDetails = invoiceDetails
                .GroupBy(d => d.MaSpct)
                .Select(g => new
                {
                    MaSpct = g.Key,
                    SoLuong = g.Sum(d => d.SoLuong)
                }).ToList();

            int stt = 1;
            foreach (var detail in groupedDetails)
            {
                string masp = sanPhamChiTietDict.ContainsKey(detail.MaSpct)
                    ? sanPhamChiTietDict[detail.MaSpct]
                    : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                string tensp = sanphamDict.ContainsKey(Guid.Parse(masp)) ? sanphamDict[Guid.Parse(masp)]
                    : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                dgv_loadsanpham_ThongKe.Rows.Add(stt++, tensp, detail.SoLuong);
            }
        }
        private void LoadInvoiceDetailsForMonthAndYear(int month, int year)
        {
            // Lấy danh sách hóa đơn từ dịch vụ
            var invoices = hoaDonServices.GetHoaDonsByYearAndMonth(year, month);

            if (invoices.Any())
            {
                // Giả sử bạn muốn lấy hóa đơn đầu tiên nếu có nhiều hóa đơn trong tháng
                var firstInvoice = invoices.First();
                var invoiceDetails = hoaDonServices.GetInvoiceDetailsByInvoiceId(firstInvoice.IdHoadon);

                LoadInvoiceDetailsToGrid(invoiceDetails);
            }
            else
            {
                dgv_loadsanpham_ThongKe.Rows.Clear();
            }
        }
        private void LoadDataForCurrentYear()
        {
            int currentYear = DateTime.Now.Year;
            var invoices = hoaDonServices.GetInvoicesByYear(currentYear);

            if (invoices.Any())
            {
                var invoiceDetails = invoices
                    .SelectMany(invoice => hoaDonServices.GetInvoiceDetailsByInvoiceId(invoice.IdHoadon))
                    .ToList();

                // Hiển thị thông tin chi tiết hóa đơn trong DataGridView
                LoadInvoiceDetailsToGrid(invoiceDetails);
            }
            else
            {
                dgv_loadsanpham_ThongKe.Rows.Clear();
            }
        }

        private void LoadInvoiceDetails(int year)
        {
            // Lấy tất cả các hóa đơn của năm được chọn
            var invoices = hoaDonServices.GetInvoicesByYear(year);

            if (invoices.Any())
            {
                var invoiceDetails = invoices
                    .SelectMany(invoice => hoaDonServices.GetInvoiceDetailsByInvoiceId(invoice.IdHoadon))
                    .ToList();

                // Hiển thị thông tin chi tiết hóa đơn trong DataGridView
                LoadInvoiceDetailsToGrid(invoiceDetails);
            }
        }

        private void LoadInvoiceDetailsForDateRange(DateTime startDate, DateTime endDate)
        {
            var invoices = hoaDonServices.GetHoaDonsByDateRanges(startDate, endDate);

            if (invoices.Any())
            {
                // Lấy tất cả các chi tiết hóa đơn cho các hóa đơn trong khoảng thời gian
                var invoiceDetails = invoices
                    .SelectMany(invoice => hoaDonChiTietServices.GetInvoiceDetailsByInvoiceId(invoice.IdHoadon))
                    .ToList();

                LoadInvoiceDetailsToGrid(invoiceDetails);
            }
            else
            {
                dgv_loadsanpham_ThongKe.Rows.Clear();
            }
        }
        private void LoadInvoiceDetailsToGrid(List<object> invoiceDetails)
        {
            throw new NotImplementedException();
        }

        private void ThongKeControl_Load(object sender, EventArgs e)
        {

        }
    }
}
