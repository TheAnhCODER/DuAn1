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
    public partial class FormKhachHang : Form
    {
        BanHangControl banHangControl;
        FormKhacHangServices khachhangServices;
        private string originalSoDienThoai;
        public FormKhachHang()
        {
            InitializeComponent();
            khachhangServices = new FormKhacHangServices();
            LoadKhachHang();
  
           
        }



        private void LoadKhachHang()
        {
            try
            {
                List<Khach> khachHangList = khachhangServices.CNShow();
                dgv_danhsach.Rows.Clear();
                dgv_danhsach.ColumnCount = 4;
                int stt = 1;
                dgv_danhsach.Columns[0].HeaderText = "Số thứ tự";
                dgv_danhsach.Columns[1].HeaderText = "Số điện thoại";
                dgv_danhsach.Columns[2].HeaderText = "Tên khách hàng";
                dgv_danhsach.Columns[3].HeaderText = "Địa chỉ";
                dgv_danhsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Đặt chiều cao cho hàng tiêu đề
                dgv_danhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dgv_danhsach.ColumnHeadersHeight = 50; // Đặt chiều cao tùy ý

                // Thiết lập màu sắc và kiểu chữ cho hàng tiêu đề
                dgv_danhsach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
                dgv_danhsach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_danhsach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_danhsach.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_danhsach.Font, FontStyle.Bold);
                dgv_danhsach.EnableHeadersVisualStyles = false;

                foreach (var item in khachHangList)
                {
                    dgv_danhsach.Rows.Add(stt++, item.SoDienThoai, item.TenKhachHang, item.DiaChi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        public static bool IsVietnamesePhoneNumber(string number)
        {
            string pattern = @"^(|84|0|0084)(3|5|7|8|9)\d{8}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(number);
        }
        public void ShowKhachHang(List<Khach> khach)
        {
            dgv_danhsach.Rows.Clear();
            dgv_danhsach.ColumnCount = 4;
            int stt = 1;
            dgv_danhsach.Columns[0].HeaderText = "Số thứ tự";
            dgv_danhsach.Columns[1].HeaderText = "Số điện thoại";
            dgv_danhsach.Columns[2].HeaderText = "Tên khách hàng";
            dgv_danhsach.Columns[3].HeaderText = "Địa chỉ";
            dgv_danhsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var item in khach)
            {
                dgv_danhsach.Rows.Add(stt++, item.SoDienThoai, item.TenKhachHang, item.DiaChi);
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ValidateNotEmpty(tb_sdt, tb_ten, tb_diachi))
                {
                    if (IsVietnamesePhoneNumber(tb_sdt.Text))
                    {
                        string soDienThoai = tb_sdt.Text.ToString();
                        string tenKhachHang = tb_ten.Text.ToString();
                        string diaChi = tb_diachi.Text.ToString();
                        string kq = khachhangServices.CNThem(soDienThoai, tenKhachHang, diaChi);
                        MessageBox.Show(kq);
                        List<Khach> khachHang = khachhangServices.CNShow();
                        ShowKhachHang(khachHang);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không đúng định dạng. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (ValidateNotEmpty(tb_sdt, tb_ten))
                {
                    MessageBox.Show("Không được để trống địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidateNotEmpty(tb_sdt, tb_diachi))
                {
                    MessageBox.Show("Không được để trống tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidateNotEmpty(tb_ten, tb_diachi))
                {
                    MessageBox.Show("Không được để trống số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidateNotEmpty(tb_sdt))
                {
                    MessageBox.Show("Không được để trống tên và địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidateNotEmpty(tb_ten))
                {
                    MessageBox.Show("Không được để trống số điện thoại và địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidateNotEmpty(tb_diachi))
                {
                    MessageBox.Show("Không được để trống số điện thoại và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgv_danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_danhsach.Rows.Count)
            {

                // Lấy dữ liệu từ dòng được chọn để điền vào form
                int row = e.RowIndex;
                var rowData = dgv_danhsach.Rows[row]; // Lấy dữ liệu từ dòng đó ra

                // Kiểm tra chỉ số cột có hợp lệ hay không
                if (rowData.Cells.Count > 2)
                {
                    tb_sdt.Text = rowData.Cells[1].Value?.ToString() ?? string.Empty;
                    tb_ten.Text = rowData.Cells[2].Value?.ToString() ?? string.Empty;
                    tb_diachi.Text = rowData.Cells[3].Value?.ToString() ?? string.Empty;

                    // Lưu số điện thoại ban đầu
                    originalSoDienThoai = tb_sdt.Text;
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ValidateNotEmpty(tb_sdt, tb_ten, tb_diachi))
                {
                    if (ValidateNumeric(tb_sdt))
                    {
                        if (ValidateNumericInt(tb_sdt))
                        {

                            // Kiểm tra nếu số điện thoại đã thay đổi
                            if (tb_sdt.Text.ToString() != originalSoDienThoai)
                            {
                                MessageBox.Show("Không thể sửa số điện thoại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tb_sdt.Text = originalSoDienThoai; // Khôi phục giá trị ban đầu
                                return;
                            }

                            string soDienThoai = tb_sdt.Text.ToString();
                            string tenKhachHang = tb_ten.Text.ToString();
                            string diaChi = tb_diachi.Text.ToString();
                            string kq = khachhangServices.CNSua(soDienThoai, tenKhachHang, diaChi);
                            MessageBox.Show(kq);
                            List<Khach> khachHang = khachhangServices.CNShow();
                            ShowKhachHang(khachHang);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại chỉ được nhập bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (ValidateNotEmpty(tb_sdt, tb_ten))
                {
                    MessageBox.Show("Không được để trống địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidateNotEmpty(tb_sdt, tb_diachi))
                {
                    MessageBox.Show("Không được để trống tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidateNotEmpty(tb_ten, tb_diachi))
                {
                    MessageBox.Show("Không được để trống số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidateNotEmpty(tb_sdt))
                {
                    MessageBox.Show("Không được để trống tên và địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidateNotEmpty(tb_ten))
                {
                    MessageBox.Show("Không được để trống số điện thoại và địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidateNotEmpty(tb_diachi))
                {
                    MessageBox.Show("Không được để trống số điện thoại và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            // Xóa các trường nhập liệu
            tb_sdt.Clear();
            tb_ten.Clear();
            tb_diachi.Clear();
            LoadKhachHang();

            // Xóa trường tìm kiếm 
            tb_timkiem.Clear();
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            List<Khach> khaches = khachhangServices.CNTim(tb_timkiem.Text);
            ShowKhachHang(khaches);
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

       

      

       
    }
}
