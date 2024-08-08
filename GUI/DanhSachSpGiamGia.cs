using BUS.Services;
using DAL.Models;
using DAL.Responsitories;
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
    public partial class DanhSachSpGiamGia : Form
    {
        SanPhamChiTietServices sanPhamChiTietServices = new SanPhamChiTietServices();
        KichCoServices kichCoServices;
        MauSacServices mauSacServices;
        SanPhamServices sanPhamServices;
        KhuyenMaiServices khuyenMaiServices = new KhuyenMaiServices();
        SanPhamChiTietRespo sanPhamChiTietRespo = new SanPhamChiTietRespo();
        public DanhSachSpGiamGia()
        {
            InitializeComponent();
            kichCoServices = new KichCoServices();
            mauSacServices = new MauSacServices();
            sanPhamServices = new SanPhamServices();
        }

        private void DanhSachSpGiamGia_Load(object sender, EventArgs e)
        {
            ShowSanPham_TheoKhuyenMai(KhuyenMaiControl.makhuyenmai);
        }

        public async void ShowSanPham_TheoKhuyenMai(string khuyenMaiId)
        {

            // Lấy danh sách sản phẩm chi tiết theo mã khuyến mại
            List<SanPhamChiTiet> sanPhamChiTiets = await sanPhamChiTietServices.GetSanPhamByKhuyenMaiIdAsync(Guid.Parse(khuyenMaiId));

            dgv_DanhSachSp.Rows.Clear();
            dgv_DanhSachSp.ColumnCount = 8;
            int stt = 1;

            dgv_DanhSachSp.Columns[0].HeaderText = "Số thứ tự";
            dgv_DanhSachSp.Columns[1].HeaderText = "Mã sản phẩm chi tiết";
            dgv_DanhSachSp.Columns[2].HeaderText = "Tên sản phẩm";
            dgv_DanhSachSp.Columns[3].HeaderText = "Màu sắc";
            dgv_DanhSachSp.Columns[4].HeaderText = "Kích cỡ";
            dgv_DanhSachSp.Columns[5].HeaderText = "Số lượng";
            dgv_DanhSachSp.Columns[6].HeaderText = "Giá";
            dgv_DanhSachSp.Columns[7].HeaderText = "Giá sau giảm";

            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Chọn",
                Name = "chkChon"
            };
            dgv_DanhSachSp.Columns.Add(chkColumn);

            dgv_DanhSachSp.Columns[0].Visible = false;
            dgv_DanhSachSp.Columns[1].Visible = false;

            dgv_DanhSachSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DanhSachSp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_DanhSachSp.ColumnHeadersHeight = 50; // Đặt chiều cao tùy ý

            dgv_DanhSachSp.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 135, 209);
            dgv_DanhSachSp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_DanhSachSp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_DanhSachSp.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_DanhSachSp.Font, FontStyle.Bold);
            dgv_DanhSachSp.EnableHeadersVisualStyles = false;

            Dictionary<Guid, string> sanPhamDict = sanPhamServices.GetSanPhamDict();
            Dictionary<Guid, string> mauSacDict = mauSacServices.GetMauSacDict();
            Dictionary<Guid, string> kichCoDict = kichCoServices.GetKichCoDict();

            foreach (var item in sanPhamChiTiets)
            {
                if (!item.GiaSauGiam.HasValue)
                {
                    continue; // Bỏ qua nếu không có giá sau giảm
                }

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
                dgv_DanhSachSp.Rows.Add(stt++, item.IdSanphamChitiet, tenSanPham, mausac, kichco, item.SoLuong, item.Gia.ToString("F2"), giaSauGiam);
            }
        }

        private void btn_XoaSp_Click(object sender, EventArgs e)
        {
            var selectedProductIds = GetSelectedProductIds(dgv_DanhSachSp);

            if (selectedProductIds.Count > 0)
            {
                // Cập nhật giá sau giảm và xóa khuyến mãi cho các sản phẩm đã chọn
                sanPhamChiTietRespo.UpdateGiaSauGiam(selectedProductIds);
                sanPhamChiTietRespo.DeleteKhuyenMaiSpct(selectedProductIds, Guid.Parse(KhuyenMaiControl.makhuyenmai));
                ShowSanPham_TheoKhuyenMai(KhuyenMaiControl.makhuyenmai); // Cập nhật lại danh sách sản phẩm nếu cần
                MessageBox.Show("Đã xóa tất cả sản phẩm đã chọn và cập nhật giá sau giảm.");
                GiamGiaSanPham giamGiaSanPham = new GiamGiaSanPham();
                giamGiaSanPham.ShowSanPham_KhuyenMai();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để xóa.");
            }
        }

        private List<Guid> GetSelectedProductIds(DataGridView dgv)
        {
            var selectedProductIds = new List<Guid>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["chkChon"] is DataGridViewCheckBoxCell chkCell &&
                    Convert.ToBoolean(chkCell.Value))
                {
                    if (Guid.TryParse(row.Cells[1].Value?.ToString(), out var productId))
                    {
                        selectedProductIds.Add(productId);
                    }
                }
            }

            return selectedProductIds;
        }

        private void btn_XoaLuaChon_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_DanhSachSp.Rows)
            {
                DataGridViewCheckBoxCell chkCell = row.Cells["chkChon"] as DataGridViewCheckBoxCell;
                if (chkCell != null)
                {
                    chkCell.Value = false;
                }
            }
        }

        private void btn_ChonTatCa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_DanhSachSp.Rows)
            {
                DataGridViewCheckBoxCell chkCell = row.Cells["chkChon"] as DataGridViewCheckBoxCell;
                if (chkCell != null)
                {
                    chkCell.Value = true;
                }
            }
        }
    }
}
