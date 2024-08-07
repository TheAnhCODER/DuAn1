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
    public partial class GiamGiaSanPham : Form
    {
        DuAn1Context _context;

        SanPhamChiTietServices sanPhamChiTietServices;
        KichCoServices kichCoServices;
        MauSacServices mauSacServices;
        SanPhamServices sanPhamServices;
        KhuyenMaiServices KhuyenMaiServices;
        public GiamGiaSanPham()
        {
            InitializeComponent();
            sanPhamChiTietServices = new SanPhamChiTietServices();
            kichCoServices = new KichCoServices();
            mauSacServices = new MauSacServices();
            sanPhamServices = new SanPhamServices();
            KhuyenMaiServices = new KhuyenMaiServices();
            _context = new DuAn1Context();
        }

        private void btn_BoChon_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_DanhSachSPKhuyenMai.Rows)
            {
                DataGridViewCheckBoxCell chkCell = row.Cells["chkChon"] as DataGridViewCheckBoxCell;
                if (chkCell != null)
                {
                    chkCell.Value = false;
                }
            }
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgv_DanhSachSPKhuyenMai.Rows)
            {
                DataGridViewCheckBoxCell chkCell = row.Cells["chkChon"] as DataGridViewCheckBoxCell;
                if (chkCell != null)
                {
                    chkCell.Value = true;
                }
            }
        }



        public void ShowSanPham_KhuyenMai()
        {

            List<SanPhamChiTiet> sanPhamChiTiets = sanPhamChiTietServices.CNShowSPDangKinhDoanh();
            dgv_DanhSachSPKhuyenMai.Rows.Clear();
            dgv_DanhSachSPKhuyenMai.ColumnCount = 8;
            int stt = 1;
            dgv_DanhSachSPKhuyenMai.Columns[0].HeaderText = "Số thứ tự";
            dgv_DanhSachSPKhuyenMai.Columns[1].HeaderText = "Mã sản phẩm chi tiết";
            dgv_DanhSachSPKhuyenMai.Columns[2].HeaderText = "Tên sản phẩm";
            dgv_DanhSachSPKhuyenMai.Columns[3].HeaderText = "Màu sắc";
            dgv_DanhSachSPKhuyenMai.Columns[4].HeaderText = "Kích cỡ";
            dgv_DanhSachSPKhuyenMai.Columns[5].HeaderText = "Số lượng";
            dgv_DanhSachSPKhuyenMai.Columns[6].HeaderText = "Giá";
            dgv_DanhSachSPKhuyenMai.Columns[7].HeaderText = "Giá sau giảm";
            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.HeaderText = "Chọn";
            chkColumn.Name = "chkChon";
            dgv_DanhSachSPKhuyenMai.Columns.Add(chkColumn);
            dgv_DanhSachSPKhuyenMai.Columns[0].Visible = false;
            dgv_DanhSachSPKhuyenMai.Columns[1].Visible = false;

            dgv_DanhSachSPKhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đặt chiều cao cho hàng tiêu đề
            dgv_DanhSachSPKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_DanhSachSPKhuyenMai.ColumnHeadersHeight = 50; // Đặt chiều cao tùy ý

            // Thiết lập màu sắc và kiểu chữ cho hàng tiêu đề
            dgv_DanhSachSPKhuyenMai.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_DanhSachSPKhuyenMai.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_DanhSachSPKhuyenMai.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_DanhSachSPKhuyenMai.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_DanhSachSPKhuyenMai.Font, FontStyle.Bold);
            dgv_DanhSachSPKhuyenMai.EnableHeadersVisualStyles = false;
            Dictionary<Guid, string> sanPhamDict = sanPhamServices.GetSanPhamDict();
            Dictionary<Guid, string> mauSacDict = mauSacServices.GetMauSacDict();
            Dictionary<Guid, string> kichCoDict = kichCoServices.GetKichCoDict();
            Dictionary<Guid, List<KhuyenMai>> khuyenMaiDict = KhuyenMaiServices.GetAllCurrentKhuyenMaiBySanPhamChiTiet();
            foreach (var item in sanPhamChiTiets)
            {
                if (item.GiaSauGiam != null)
                {
                    continue; // Bỏ qua nếu không có giá sau giảm
                }
                // Lấy thông tin chi tiết của sản phẩm
                string mausac = mauSacDict.ContainsKey(item.IdMauSac.Value)
                    ? mauSacDict[item.IdMauSac.Value]
                    : "N/A";
                string kichco = kichCoDict.ContainsKey(item.IdKichCo.Value)
                    ? kichCoDict[item.IdKichCo.Value]
                    : "N/A";
                string tenSanPham = sanPhamDict.ContainsKey(item.IdSanPham.Value)
                    ? sanPhamDict[item.IdSanPham.Value]
                    : "N/A";

                // Tính giá sau giảm (nếu có)
                string giaSauGiam = item.GiaSauGiam.HasValue ? item.GiaSauGiam.Value.ToString("F2") : "Không có khuyến mãi";

                // Thêm thông tin vào DataGridView
                dgv_DanhSachSPKhuyenMai.Rows.Add(stt++, item.IdSanphamChitiet, tenSanPham, mausac, kichco, item.SoLuong, item.Gia.ToString("F2"), giaSauGiam);
            }
        }

        private void GiamGiaSanPham_Load(object sender, EventArgs e)
        {
            ShowSanPham_KhuyenMai();
            tb_giatrigiam.Text = KhuyenMaiControl.giatrigiam;
            if (KhuyenMaiControl.radiobt)
            {
                rb_vnd.Checked = true;
            }
            else
            {
                rb_phantram.Checked = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal discountValue = decimal.Parse(tb_giatrigiam.Text); // Giá trị giảm giá từ form này
            bool isPercentage = rb_phantram.Checked; // Kiểm tra kiểu giảm giá
            UpdatePrices(discountValue, isPercentage);
        }

        public void UpdatePrices(decimal discountValue, bool isPercentage)
        {
            foreach (DataGridViewRow row in dgv_DanhSachSPKhuyenMai.Rows)
            {
                DataGridViewCheckBoxCell chkCell = row.Cells["chkChon"] as DataGridViewCheckBoxCell;
                if (chkCell != null && Convert.ToBoolean(chkCell.Value))
                {
                    decimal giaGoc = decimal.Parse(row.Cells[6].Value.ToString());
                    decimal giamGia = 0;

                    if (isPercentage)
                    {
                        giamGia = giaGoc * (discountValue / 100);
                    }
                    else
                    {
                        giamGia = discountValue;
                    }

                    decimal giaSauGiam = giaGoc - giamGia;
                    row.Cells[7].Value = giaSauGiam.ToString("F2");

                    // Cập nhật giá vào cơ sở dữ liệu
                    Guid productId = Guid.Parse(row.Cells[1].Value.ToString());

                    // Kiểm tra xem sản phẩm đã có giá giảm chưa
                    sanPhamChiTietServices.UpdateProductPrice(productId, giaSauGiam);
                    MessageBox.Show("Thêm khuyến mãi thành công");
                    this.Close();
                }
            }
        }









    }
}
