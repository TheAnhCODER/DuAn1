using BUS.Services;
using DAL.Models;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GUI
{
    public partial class KhuyenMaiControl : UserControl
    {

        KhuyenMaiServices KhuyenMaiServices;
        public KhuyenMaiControl()
        {
            InitializeComponent();
            KhuyenMaiServices = new KhuyenMaiServices();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgv_DanhSachSPKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void KhuyenMaiControl_Load(object sender, EventArgs e)
        {
            dtk_NgayBatDau_TimKiem.CustomFormat = " ";
            dtk_NgayBatDau_TimKiem.Format = DateTimePickerFormat.Custom;
            dtp_NgayKetThuc_TimKiem.CustomFormat = " ";
            dtp_NgayKetThuc_TimKiem.Format = DateTimePickerFormat.Custom;
            ShowKhuyenMai();
        }

        

       


        private void btn_themKhuyenMai_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            // Kiểm tra nếu ngày bắt đầu và ngày kết thúc được chọn hay không
            if (dtp_NgayBatDau.Value.Date == DateTime.MinValue || dtp_NgayKetThuc.Value.Date == DateTime.MinValue)
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu và ngày kết thúc.");
                return;
            }

            // Kiểm tra ngày bắt đầu phải lớn hơn hoặc bằng ngày hiện tại
            if (dtp_NgayBatDau.Value.Date < today)
            {
                MessageBox.Show("Ngày bắt đầu phải lớn hơn hoặc bằng ngày hiện tại.");
                return;
            }

            // Kiểm tra ngày kết thúc phải lớn hơn hoặc bằng ngày hiện tại
            if (dtp_NgayKetThuc.Value.Date < today)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày hiện tại.");
                return;
            }

            // Kiểm tra ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu
            if (dtp_NgayKetThuc.Value.Date < dtp_NgayBatDau.Value.Date)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.");
                return;
            }
            if (!SanPhamControl.ValidateNotEmpty(tb_TenKhuyenMai, tb_GiaTriGiam))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }

            if (!SanPhamControl.ValidateNumeric(tb_GiaTriGiam))
            {
                MessageBox.Show("Vui lòng nhập giá trị giảm là số");
                return;
            }

            if (!SanPhamControl.ValidatePositiveInteger(tb_GiaTriGiam))
            {
                MessageBox.Show("Vui lòng nhập giá trị giảm là số dương");
                return;
            }

            if (rb_PhanTram.Checked)
            {
                if (int.TryParse(tb_GiaTriGiam.Text, out int giaTriGiam))
                {
                    if (giaTriGiam > 100)
                    {
                        MessageBox.Show("Giá trị giảm chỉ trong khoảng 0 đến 100%");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị giảm không hợp lệ");
                    return;
                }
            }
            string tenKhuyenMai = tb_TenKhuyenMai.Text;
            decimal giamGia = decimal.Parse(tb_GiaTriGiam.Text);
            DateTime ngayBatDau = dtp_NgayBatDau.Value;
            DateTime ngayKetThuc = dtp_NgayKetThuc.Value;
            bool loaiGiamGia = rb_VND.Checked;

            string ketQua = KhuyenMaiServices.CNThem(tenKhuyenMai, giamGia, ngayBatDau, ngayKetThuc, loaiGiamGia);

            switch (ketQua)
            {
                case "Khuyến mãi đã tồn tại":
                    MessageBox.Show("Khuyến mãi đã tồn tại");
                    break;
                case "Thêm thất bại":
                    MessageBox.Show("Thêm thất bại");
                    break;
                case "Thêm thành công":
                    MessageBox.Show("Thêm thành công");
                    ShowKhuyenMai();
                    break;
            }
        }

        public void ShowKhuyenMai()
        {
            List<KhuyenMai> khuyenMais = KhuyenMaiServices.CNShow();
            dgv_DanhSachKhuyenMai.Rows.Clear();
            dgv_DanhSachKhuyenMai.ColumnCount = 8;
            int stt = 1;
            dgv_DanhSachKhuyenMai.Columns[0].HeaderText = "Số thứ tự";
            dgv_DanhSachKhuyenMai.Columns[1].HeaderText = "Mã khuyến mãi";
            dgv_DanhSachKhuyenMai.Columns[2].HeaderText = "Tên khuyến mãi";
            dgv_DanhSachKhuyenMai.Columns[3].HeaderText = "Giảm giá";
            dgv_DanhSachKhuyenMai.Columns[4].HeaderText = "Ngày bắt đầu";
            dgv_DanhSachKhuyenMai.Columns[5].HeaderText = "Ngày kết thúc";
            dgv_DanhSachKhuyenMai.Columns[6].HeaderText = "Trạng thái";
            dgv_DanhSachKhuyenMai.Columns[7].HeaderText = "Loại giảm giá";

            dgv_DanhSachKhuyenMai.Columns[0].Visible = false;
            dgv_DanhSachKhuyenMai.Columns[1].Visible = false;

            dgv_DanhSachKhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đặt chiều cao cho hàng tiêu đề
            dgv_DanhSachKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_DanhSachKhuyenMai.ColumnHeadersHeight = 50; // Đặt chiều cao tùy ý

            // Thiết lập màu sắc và kiểu chữ cho hàng tiêu đề
            dgv_DanhSachKhuyenMai.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_DanhSachKhuyenMai.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_DanhSachKhuyenMai.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_DanhSachKhuyenMai.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_DanhSachKhuyenMai.Font, FontStyle.Bold);
            dgv_DanhSachKhuyenMai.EnableHeadersVisualStyles = false;


            foreach (var item in khuyenMais)
            {

                dgv_DanhSachKhuyenMai.Rows.Add(stt++, item.IdKhuyenMai, item.TenKhuyenMai, item.GiamGia, item.NgayBatDau, item.NgayKetThuc, item.TrangThai, item.LoaiGiamGia);
            }
        }

        private void btn_suaKhuyenMai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_makhuyenmai.Text))
            {
                MessageBox.Show("Hãy chọn khuyến mãi muốn sửa");
                return;
            }
            DateTime today = DateTime.Today;

            // Kiểm tra nếu ngày bắt đầu và ngày kết thúc được chọn hay không
            if (dtp_NgayBatDau.Value.Date == DateTime.MinValue || dtp_NgayKetThuc.Value.Date == DateTime.MinValue)
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu và ngày kết thúc.");
                return;
            }

            // Kiểm tra ngày bắt đầu phải lớn hơn hoặc bằng ngày hiện tại
            if (dtp_NgayBatDau.Value.Date < today)
            {
                MessageBox.Show("Ngày bắt đầu phải lớn hơn hoặc bằng ngày hiện tại.");
                return;
            }

            // Kiểm tra ngày kết thúc phải lớn hơn hoặc bằng ngày hiện tại
            if (dtp_NgayKetThuc.Value.Date < today)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày hiện tại.");
                return;
            }

            // Kiểm tra ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu
            if (dtp_NgayKetThuc.Value.Date < dtp_NgayBatDau.Value.Date)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.");
                return;
            }
            if (!SanPhamControl.ValidateNotEmpty(tb_TenKhuyenMai, tb_GiaTriGiam))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }

            if (!SanPhamControl.ValidateNumeric(tb_GiaTriGiam))
            {
                MessageBox.Show("Vui lòng nhập giá trị giảm là số");
                return;
            }

            if (!SanPhamControl.ValidatePositiveInteger(tb_GiaTriGiam))
            {
                MessageBox.Show("Vui lòng nhập giá trị giảm là số dương");
                return;
            }

            if (rb_PhanTram.Checked)
            {
                if (int.TryParse(tb_GiaTriGiam.Text, out int giaTriGiam))
                {
                    if (giaTriGiam > 100)
                    {
                        MessageBox.Show("Giá trị giảm chỉ trong khoảng 0 đến 100%");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị giảm không hợp lệ");
                    return;
                }
            }
            string idkhuyenmai = tb_makhuyenmai.Text;
            string tenkhuyenmai = tb_TenKhuyenMai.Text;
            decimal giamgia = decimal.Parse(tb_GiaTriGiam.Text);
            DateTime ngaybatdau = dtp_NgayBatDau.Value;
            DateTime ngayketthuc = dtp_NgayKetThuc.Value;
            bool loaigiamgia = rb_VND.Checked ? true : rb_PhanTram.Checked ? false : false;
            string ketqua = KhuyenMaiServices.CNSua(idkhuyenmai, tenkhuyenmai, giamgia, ngaybatdau, ngayketthuc, loaigiamgia);
            if (ketqua == "Khuyến mãi đã tồn tại")
            {
                MessageBox.Show("Khuyến mãi đã tồn tại");
                return;

            }
            else if (ketqua == "Sửa thất bại")
            {
                MessageBox.Show("Sửa thất bại");
                return;
            }
            else if (ketqua == "Sửa thành công")
            {
                MessageBox.Show("Sửa thành công");
                ShowKhuyenMai();
                return;
            }
        }

        private void dgv_DanhSachKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng hàng có chỉ số hợp lệ
            {
                DataGridViewRow row = dgv_DanhSachKhuyenMai.Rows[e.RowIndex];

                string idKhuyenMai = row.Cells[1].Value.ToString();
                string tenKhuyenMai = row.Cells[2].Value.ToString();
                decimal giamGia = decimal.Parse(row.Cells[3].Value.ToString());
                DateTime ngayBatDau = DateTime.Parse(row.Cells[4].Value.ToString());
                DateTime ngayKetThuc = DateTime.Parse(row.Cells[5].Value.ToString());
                bool trangThai = bool.Parse(row.Cells[6].Value.ToString());
                bool loaiGiamGia = bool.Parse(row.Cells[7].Value.ToString());

                // Cập nhật các điều khiển trên form với thông tin chi tiết của khuyến mãi
                tb_makhuyenmai.Text = idKhuyenMai;
                tb_TenKhuyenMai.Text = tenKhuyenMai;
                tb_GiaTriGiam.Text = giamGia.ToString();
                dtp_NgayBatDau.Value = ngayBatDau;
                dtp_NgayKetThuc.Value = ngayKetThuc;
                // Giả sử loaiGiamGia là một biến boolean


                // Đặt trạng thái cho các RadioButton dựa trên giá trị của loaiGiamGia
                rb_VND.Checked = loaiGiamGia;
                rb_PhanTram.Checked = !loaiGiamGia;
            }
        }

        public static string giatrigiam;
        public static bool radiobt = true;

        private void dgv_DanhSachKhuyenMai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng hàng có chỉ số hợp lệ
            {
                DataGridViewRow row = dgv_DanhSachKhuyenMai.Rows[e.RowIndex];
                bool trangThai = bool.Parse(row.Cells[6].Value.ToString()); // Cột trạng thái
                giatrigiam = row.Cells[3].Value.ToString();
                if (rb_VND.Checked)
                {
                    radiobt = true;
                }
                else if (rb_PhanTram.Checked)
                {
                    radiobt = false;
                }; 
                if (trangThai)
                {
                    GiamGiaSanPham giamGiaSanPham = new GiamGiaSanPham();
                    giamGiaSanPham.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Khuyến mãi này không còn hiệu lực.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_lammoiKhuyenMai_Click(object sender, EventArgs e)
        {
            tb_GiaTriGiam.Clear();
            tb_makhuyenmai.Clear();
            tb_TenKhuyenMai.Clear();
            dtp_NgayKetThuc.Value = DateTime.Now;
            dtp_NgayBatDau.Value = DateTime.Now;
            textBox1.Clear();
            dtk_NgayBatDau_TimKiem.CustomFormat = " ";
            dtk_NgayBatDau_TimKiem.Format = DateTimePickerFormat.Custom;
            dtp_NgayKetThuc_TimKiem.CustomFormat = " ";
            dtp_NgayKetThuc_TimKiem.Format = DateTimePickerFormat.Custom;
            rb_VND.Checked = true;
        }
        private bool isChangingngaybatdau = false;
        private void dtp_NgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            //if (isChangingngaybatdau) return;

            //try
            //{
            //    isChangingngaybatdau = true;
            //    dtp_NgayBatDau.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày
            //    dtp_NgayBatDau.Format = DateTimePickerFormat.Custom;
            //    dtp_NgayBatDau.MinDate = DateTime.Now;
            //}
            //finally
            //{
            //    isChangingngaybatdau = false;
            //}
        }
        private bool isChangingngayketthuc = false;
        private void dtp_NgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
