using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NhanVienControl : UserControl
    {
        NhanVienServices nhanVienServices;
        private string IdNhanVien;
        public NhanVienControl()
        {
            InitializeComponent();
            nhanVienServices = new NhanVienServices();
            LoadTrangThai();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // Hàm kiểm tra các TextBox không được null hoặc rỗng
        public static bool ValidateNotEmpty(params TextBox[] textboxes)
        {
            foreach (var textbox in textboxes)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    return false; // Trả về false nếu bất kỳ TextBox nào rỗng
                }
            }
            return true; // Trả về true nếu tất cả các TextBox đều không rỗng
        }

        public static bool IsNumeric(string input)
        {
            return int.TryParse(input, out _) || double.TryParse(input, out _) || decimal.TryParse(input, out _);
        }

        // Hàm kiểm tra chuỗi có phải là số nguyên hay không
        public static bool IsNumericInt(string input)
        {
            return int.TryParse(input, out _);
        }

        // Hàm kiểm tra các TextBox chứa giá trị số
        public static bool ValidateNumeric(params TextBox[] textboxes)
        {
            foreach (var textbox in textboxes)
            {
                if (!IsNumeric(textbox.Text))
                {
                    return false; // Trả về false nếu bất kỳ TextBox nào không chứa giá trị số
                }
            }
            return true; // Trả về true nếu tất cả các TextBox đều chứa giá trị số
        }

        public static bool ValidateNumericInt(params TextBox[] textboxes)
        {
            foreach (var textbox in textboxes)
            {
                if (!IsNumericInt(textbox.Text))
                {
                    return false; // Trả về false nếu bất kỳ TextBox nào không chứa giá trị số
                }
            }
            return true; // Trả về true nếu tất cả các TextBox đều chứa giá trị số
        }
        private bool IsGenderSelected()
        {
            return rb_nam_NhanVien.Checked || rb_nu_NhanVien.Checked;
        }
        private void LoadNhanVien()
        {
            try
            {
                List<NhanVien> nhanVienList = nhanVienServices.CNShowNhanVien();
                dgv_danhsach_NhanVien.Rows.Clear();
                dgv_danhsach_NhanVien.ColumnCount = 7;
                int stt = 1;
                dgv_danhsach_NhanVien.Columns[0].HeaderText = "Id";
                dgv_danhsach_NhanVien.Columns[0].Visible = false;
                dgv_danhsach_NhanVien.Columns[1].HeaderText = "Số Điện Thoại";
                dgv_danhsach_NhanVien.Columns[2].HeaderText = "Tên Nhân Viên";
                dgv_danhsach_NhanVien.Columns[3].HeaderText = "Giới Tính";
                dgv_danhsach_NhanVien.Columns[4].HeaderText = "Ngày Sinh";
                dgv_danhsach_NhanVien.Columns[5].HeaderText = "Địa Chỉ";
                dgv_danhsach_NhanVien.Columns[6].HeaderText = "Trạng Thái";
                dgv_danhsach_NhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Đặt chiều cao cho hàng tiêu đề
                dgv_danhsach_NhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dgv_danhsach_NhanVien.ColumnHeadersHeight = 50; // Đặt chiều cao tùy ý

                // Thiết lập màu sắc và kiểu chữ cho hàng tiêu đề
                dgv_danhsach_NhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
                dgv_danhsach_NhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_danhsach_NhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_danhsach_NhanVien.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_danhsach_NhanVien.Font, FontStyle.Bold);
                dgv_danhsach_NhanVien.EnableHeadersVisualStyles = false;

                foreach (var item in nhanVienList)
                {
                    string trangThai = (item.TrangThai != null && item.TrangThai.Value) ? "Làm việc" : "Không làm việc";
                    dgv_danhsach_NhanVien.Rows.Add(item.IdNhanvien, item.DienThoai, item.TenNhanVien, item.GioiTinh, item.NgaySinh?.ToString("dd/MM/yyyy"), item.DiaChi, trangThai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        public void ShowNhanVien(List<NhanVien> nhanViens)
        {
            dgv_danhsach_NhanVien.Rows.Clear();
            dgv_danhsach_NhanVien.ColumnCount = 7;
            int stt = 1;
            dgv_danhsach_NhanVien.Columns[0].HeaderText = "Id";
            dgv_danhsach_NhanVien.Columns[0].Visible = false;
            dgv_danhsach_NhanVien.Columns[1].HeaderText = "Số Điện Thoại";
            dgv_danhsach_NhanVien.Columns[2].HeaderText = "Tên Nhân Viên";
            dgv_danhsach_NhanVien.Columns[3].HeaderText = "Giới Tính";
            dgv_danhsach_NhanVien.Columns[4].HeaderText = "Ngày Sinh";
            dgv_danhsach_NhanVien.Columns[5].HeaderText = "Địa Chỉ";
            dgv_danhsach_NhanVien.Columns[6].HeaderText = "Trạng Thái";
            dgv_danhsach_NhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var item in nhanViens)
            {
                string trangThai = (item.TrangThai != null && item.TrangThai.Value) ? "Làm việc" : "Không làm việc";
                dgv_danhsach_NhanVien.Rows.Add(item.IdNhanvien, item.DienThoai, item.TenNhanVien, item.GioiTinh, item.NgaySinh?.ToString("dd/MM/yyyy"), item.DiaChi, trangThai);
            }
        }
        public static bool IsVietnamesePhoneNumber(string number)
        {
            string pattern = @"^(|84|0|0084)(3|5|7|8|9)\d{8}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(number);
        }
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            // Regex to match an email with domain @gmail.com
            string strRegex = @"^[\w\.\-]+@gmail\.com$";
            Regex regex = new Regex(strRegex);

            return regex.IsMatch(email);
        }

        private void btn_them_NhanVien_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ValidateNotEmpty(tb_ten_NhanVien, tb_diachi_NhanVien, tb_sdt_NhanVien, tb_email_NhanVien, tb_matkhau_NhanVien))
                {
                    if (!IsGenderSelected())
                    {
                        MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (IsVietnamesePhoneNumber(tb_sdt_NhanVien.Text))
                    {
                        if (IsEmail(tb_email_NhanVien.Text))
                        {
                            string tenNhanVien = tb_ten_NhanVien.Text;
                            string? gioiTinh = rb_nam_NhanVien.Checked ? "Nam" : rb_nu_NhanVien.Checked ? "Nữ" : null;
                            DateTime ngaySinh = dateTime_ngaysinh_NhanVien.Value; // Sử dụng thuộc tính Value để lấy giá trị DateTime
                            string diaChi = tb_diachi_NhanVien.Text;
                            string dienThoai = tb_sdt_NhanVien.Text;
                            string email = tb_email_NhanVien.Text;
                            string matKhau = tb_matkhau_NhanVien.Text;
                            bool trangThai = (bool)cb_trangthai_NhanVien.SelectedValue;
                            string kq = nhanVienServices.CNThem(tenNhanVien, gioiTinh, ngaySinh, diaChi, dienThoai, email, matKhau, trangThai);
                            MessageBox.Show(kq);
                            LoadNhanVien();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Email không đúng định dạng. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không đúng định dạng. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void NhanVienControl_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btn_sua_NhanVien_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ValidateNotEmpty(tb_ten_NhanVien, tb_diachi_NhanVien, tb_sdt_NhanVien, tb_email_NhanVien, tb_matkhau_NhanVien))
                {
                    if (IsVietnamesePhoneNumber(tb_sdt_NhanVien.Text))
                    {
                        if (IdNhanVien == "")
                        {
                            MessageBox.Show("Vui lòng chọn một nhân viên để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (IsEmail(tb_email_NhanVien.Text))
                        {
                            string tenNhanVien = tb_ten_NhanVien.Text;
                            string? gioiTinh = rb_nam_NhanVien.Checked ? "Nam" : rb_nu_NhanVien.Checked ? "Nữ" : null;
                            DateTime ngaySinh = dateTime_ngaysinh_NhanVien.Value; // Sử dụng thuộc tính Value để lấy giá trị DateTime
                            string diaChi = tb_diachi_NhanVien.Text;
                            string dienThoai = tb_sdt_NhanVien.Text;
                            string email = tb_email_NhanVien.Text;
                            string matKhau = tb_matkhau_NhanVien.Text;
                            bool trangThai = (bool)cb_trangthai_NhanVien.SelectedValue;

                            string kq = nhanVienServices.CNSua(IdNhanVien, tenNhanVien, gioiTinh, ngaySinh, diaChi, dienThoai, email, matKhau, trangThai);
                            MessageBox.Show(kq);
                            LoadNhanVien();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Email không đúng định dạng. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không đúng định dạng. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void dgv_danhsach_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_danhsach_NhanVien.Rows.Count)
            {
                // Lấy dữ liệu từ dòng được chọn để điền vào form
                int row = e.RowIndex;
                var rowData = dgv_danhsach_NhanVien.Rows[row]; // Lấy dữ liệu từ dòng đó ra
                // Kiểm tra chỉ số cột có hợp lệ hay không
                if (rowData.Cells.Count > 4)
                {
                    IdNhanVien = rowData.Cells[0].Value?.ToString() ?? string.Empty;

                    tb_sdt_NhanVien.Text = rowData.Cells[1].Value?.ToString() ?? string.Empty;

                    // Hiển thị Email và Mật khẩu từ dịch vụ
                    string sdt = rowData.Cells[1].Value?.ToString();
                    if (!string.IsNullOrEmpty(sdt))
                    {
                        // Sử dụng dịch vụ để lấy thông tin nhân viên
                        var nhanVien = nhanVienServices.GetNhanVienByPhoneNumber(sdt);
                        if (nhanVien != null)
                        {
                            tb_email_NhanVien.Text = nhanVien.Email ?? string.Empty;
                            tb_matkhau_NhanVien.Text = nhanVien.MatKhau ?? string.Empty;
                        }
                    }

                    tb_ten_NhanVien.Text = rowData.Cells[2].Value?.ToString() ?? string.Empty;

                    // Đặt giá trị cho RadioButton giới tính
                    string gioiTinh = rowData.Cells[3].Value?.ToString() ?? string.Empty;
                    if (gioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase))
                    {
                        rb_nam_NhanVien.Checked = true;
                        rb_nu_NhanVien.Checked = false;
                    }
                    else if (gioiTinh.Equals("Nữ", StringComparison.OrdinalIgnoreCase))
                    {
                        rb_nam_NhanVien.Checked = false;
                        rb_nu_NhanVien.Checked = true;
                    }
                    else
                    {
                        rb_nam_NhanVien.Checked = false;
                        rb_nu_NhanVien.Checked = false;
                    }

                    // Đặt giá trị cho DateTimePicker
                    if (DateTime.TryParse(rowData.Cells[4].Value?.ToString(), out DateTime ngaySinh))
                    {
                        dateTime_ngaysinh_NhanVien.Value = ngaySinh;
                    }
                    else
                    {
                        dateTime_ngaysinh_NhanVien.Value = DateTime.Now; // Hoặc một giá trị mặc định nào đó
                    }

                    tb_diachi_NhanVien.Text = rowData.Cells[5].Value?.ToString() ?? string.Empty;

                    // Chuyển đổi trạng thái sản phẩm từ chuỗi sang giá trị bool
                    string trangThai = rowData.Cells[6].Value?.ToString() ?? string.Empty;
                    cb_trangthai_NhanVien.SelectedValue = trangThai == "Làm việc" ? true : false;
                }
            }
        }

        private void btn_lammoi_NhanVien_Click(object sender, EventArgs e)
        {
            // Xóa các trường thông tin nhân viên
            tb_ten_NhanVien.Clear();
            rb_nam_NhanVien.Checked = false;
            rb_nu_NhanVien.Checked = false;
            dateTime_ngaysinh_NhanVien.Value = DateTime.Now; // Đặt giá trị mặc định cho DateTimePicker
            tb_diachi_NhanVien.Clear();
            tb_sdt_NhanVien.Clear();
            tb_email_NhanVien.Clear();
            tb_matkhau_NhanVien.Clear();

            // Tải lại danh sách nhân viên
            LoadNhanVien();

            // Xóa trường tìm kiếm nếu có
            tb_timkiem_NhanVien.Clear();
        }

        private void tb_timkiem_NhanVien_TextChanged(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm
            string tim = tb_timkiem_NhanVien.Text;

            // Tìm kiếm nhân viên theo tên hoặc số điện thoại
            List<NhanVien> nhanViens = nhanVienServices.TimNhanVien(tim);

            // Hiển thị kết quả tìm kiếm
            ShowNhanVien(nhanViens);
        }
        private void LoadTrangThai()
        {
            try
            {
                // Tạo danh sách trạng thái dưới dạng Dictionary
                var trangThaiList = new Dictionary<bool, string>
        {
            { true, "Làm việc" },
            { false, "Không làm việc" }
        };
                cb_trangthai_NhanVien.DataSource = new BindingSource(trangThaiList, null);
                cb_trangthai_NhanVien.DisplayMember = "Value";
                cb_trangthai_NhanVien.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
