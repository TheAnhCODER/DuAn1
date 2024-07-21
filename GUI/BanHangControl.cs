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
    public partial class BanHangControl : UserControl
    {
        NhanVien _nhanVien { get; set; }
        ThuongHieuServices thuonghieuServices;
        DanhMucServices danhMucServices;
        KichCoServices kichCoServices;
        MauSacServices mauSacServices;
        SanPhamServices sanPhamServices;
        SanPhamChiTietServices sanPhamChiTietServices;
        public BanHangControl()
        {
            InitializeComponent();
            thuonghieuServices = new ThuongHieuServices();
            danhMucServices = new DanhMucServices();
            kichCoServices = new KichCoServices();
            mauSacServices = new MauSacServices();
            sanPhamServices = new SanPhamServices();
            sanPhamChiTietServices = new SanPhamChiTietServices();
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




        public void ShowSanPham_BanHang(List<SanPhamChiTiet> sanPhamChiTiets)
        {
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
            dgv_TatCaSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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


        public void RefreshDataGridView()
        {
            List<SanPhamChiTiet> sanPhamChiTiets = sanPhamChiTietServices.CNShowSPDangKinhDoanh();
            ShowSanPham_BanHang(sanPhamChiTiets);
        }


    }
}