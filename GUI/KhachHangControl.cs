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
    public partial class KhachHangControl : UserControl
    {
        KhachHangServices khachhangServices;
        private string originalSoDienThoai;
        public KhachHangControl()
        {
            InitializeComponent();
            khachhangServices = new KhachHangServices();

            // Gán giá trị Tag cho các TextBox
            tb_sdt_KhachHang.Tag = "Số điện thoại";
            tb_tenkhachhang_KhachHang.Tag = "Tên khách hàng";
            tb_diachi_KhachHang.Tag = "Địa chỉ";
            LoadKhachHang();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //ham load dgv

        private void LoadKhachHang()
        {
            try
            {
                List<Khach> khachHangList = khachhangServices.CNShow();
                dgv_danhsach_KhachHang.Rows.Clear();
                dgv_danhsach_KhachHang.ColumnCount = 4;
                int stt = 1;
                dgv_danhsach_KhachHang.Columns[0].HeaderText = "Số thứ tự";
                dgv_danhsach_KhachHang.Columns[1].HeaderText = "Số điện thoại";
                dgv_danhsach_KhachHang.Columns[2].HeaderText = "Tên khách hàng";
                dgv_danhsach_KhachHang.Columns[3].HeaderText = "Địa chỉ";

  
                dgv_danhsach_KhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (var item in khachHangList)
                {

                    dgv_danhsach_KhachHang.Rows.Add(stt++, item.SoDienThoai, item.TenKhachHang  , item.DiaChi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btn_them_KhachHang_Click(object sender, EventArgs e)
        {
            string soDienThoai = tb_sdt_KhachHang.Text;
            string tenKhachHang = tb_tenkhachhang_KhachHang.Text;
            string diaChi = tb_diachi_KhachHang.Text;

            // Kiểm tra tất cả các TextBox
            var validationResults = ValidateTextBoxes(tb_sdt_KhachHang, tb_tenkhachhang_KhachHang, tb_diachi_KhachHang);

            if (!string.IsNullOrEmpty(validationResults))
            {
                MessageBox.Show(validationResults, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra số điện thoại
            if (!ValidateData(soDienThoai))
            {
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string kq = khachhangServices.CNThem(soDienThoai, tenKhachHang, diaChi);
                MessageBox.Show(kq);

                List<Khach> khaches = khachhangServices.CNShow();
                ShowKhachHang(khaches);
            }
        }
        public void ShowKhachHang(List<Khach> khach)
        {
            dgv_danhsach_KhachHang.Rows.Clear();
            dgv_danhsach_KhachHang.ColumnCount = 4;
            int stt = 1;
            dgv_danhsach_KhachHang.Columns[0].HeaderText = "Số thứ tự";
            dgv_danhsach_KhachHang.Columns[1].HeaderText = "Số điện thoại";
            dgv_danhsach_KhachHang.Columns[2].HeaderText = "Tên khách hàng";
            dgv_danhsach_KhachHang.Columns[3].HeaderText = "Địa chỉ";
            dgv_danhsach_KhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đặt chiều cao cho hàng tiêu đề
            dgv_danhsach_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_danhsach_KhachHang.ColumnHeadersHeight = 50; // Đặt chiều cao tùy ý

            // Thiết lập màu sắc và kiểu chữ cho hàng tiêu đề
            dgv_danhsach_KhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_danhsach_KhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_danhsach_KhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_danhsach_KhachHang.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_danhsach_KhachHang.Font, FontStyle.Bold);
            dgv_danhsach_KhachHang.EnableHeadersVisualStyles = false;

            foreach (var item in khach)
            {
                int rowIndex = dgv_danhsach_KhachHang.Rows.Add(stt++, item.SoDienThoai, item.TenKhachHang, item.DiaChi);
                if ((rowIndex + 1) % 2 != 0) // Các hàng có số lẻ (1, 3, 5, ...)
                {
                    dgv_danhsach_KhachHang.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGray; // Thay đổi màu tại đây
                }
            }
        }

        private void dgv_danhsach_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_danhsach_KhachHang.Rows.Count)
            {

                // Lấy dữ liệu từ dòng được chọn để điền vào form
                int row = e.RowIndex;
                var rowData = dgv_danhsach_KhachHang.Rows[row]; // Lấy dữ liệu từ dòng đó ra

                // Kiểm tra chỉ số cột có hợp lệ hay không
                if (rowData.Cells.Count > 2)
                {
                    tb_sdt_KhachHang.Text = rowData.Cells[1].Value?.ToString() ?? string.Empty;
                    tb_tenkhachhang_KhachHang.Text = rowData.Cells[2].Value?.ToString() ?? string.Empty;
                    tb_diachi_KhachHang.Text = rowData.Cells[3].Value?.ToString() ?? string.Empty;
                }
            }
        }

        private void btn_sua_KhachHang_Click(object sender, EventArgs e)
        {
            string soDienThoai = tb_sdt_KhachHang.Text;
            string tenKhachHang = tb_tenkhachhang_KhachHang.Text;
            string diaChi = tb_diachi_KhachHang.Text;

            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (soDienThoai != originalSoDienThoai)
                {
                    MessageBox.Show("Không thể sửa số điện thoại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_sdt_KhachHang.Text = originalSoDienThoai; // Khôi phục giá trị ban đầu
                    return;
                }

                string kq = khachhangServices.CNSua(soDienThoai, tenKhachHang, diaChi);
                MessageBox.Show(kq);

                List<Khach> khaches = khachhangServices.CNShow();
                ShowKhachHang(khaches);
            }

        }

        private void btn_lammoi_KhachHang_Click(object sender, EventArgs e)
        {
            // Xóa các trường nhập liệu
            tb_sdt_KhachHang.Clear();
            tb_tenkhachhang_KhachHang.Clear();
            tb_diachi_KhachHang.Clear();
            LoadKhachHang();

            // Xóa trường tìm kiếm 
            tb_timkiem_KhachHang.Clear();
        }

        private void tb_timkiem_KhachHang_TextChanged(object sender, EventArgs e)
        {
            List<Khach> khaches = khachhangServices.CNTim(tb_timkiem_KhachHang.Text);
            ShowKhachHang(khaches);
        }
        private bool ValidateData(string soDienThoai)
        {
            // Kiểm tra số điện thoại không để trống
            if (string.IsNullOrWhiteSpace(soDienThoai))
            {
                MessageBox.Show("Số điện thoại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new Action(() => tb_sdt_KhachHang.Select()));
                return false;
            }

            // Kiểm tra số điện thoại chỉ chứa số
            if (!Regex.IsMatch(soDienThoai, @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new Action(() => tb_sdt_KhachHang.Select()));
                return false;
            }

            if (!Regex.IsMatch(soDienThoai, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải chỉ chứa 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_sdt_KhachHang.Select(); // Chọn ô để người dùng dễ sửa lỗi
                return false;
            }
            return true;
        }
        private string ValidateTextBoxes(params TextBox[] textBoxes)
        {
            bool isAllEmpty = true;
            List<string> emptyFields = new List<string>();

            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    emptyFields.Add(textBox.Tag.ToString());
                }
                else
                {
                    isAllEmpty = false;
                }
            }

            // Kiểm tra nếu tất cả các trường đều trống
            if (isAllEmpty)
            {
                return "Vui lòng nhập tất cả thông tin.";
            }

            // Kiểm tra nếu có các trường trống cụ thể
            if (emptyFields.Count > 0)
            {
                return string.Join(" và ", emptyFields) + " không được để trống.";
            }

            return string.Empty;
        }
    }
}
