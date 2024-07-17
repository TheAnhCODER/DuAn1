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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class SanPhamControl : UserControl
    {
        ThuongHieuServices thuonghieuServices;
        DanhMucServices danhMucServices;
        KichCoServices kichCoServices;
        MauSacServices mauSacServices;
        public SanPhamControl()
        {
            InitializeComponent();
            thuonghieuServices = new ThuongHieuServices();
            danhMucServices = new DanhMucServices();
            kichCoServices = new KichCoServices();
            mauSacServices = new MauSacServices();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Them_SanPham_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_ThuocTinhSanPham_Click(object sender, EventArgs e)
        {
            if (rb_ThuongHieu.Checked)
            {
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kq = thuonghieuServices.CNThem(ten);
                    MessageBox.Show(kq);
                    List<ThuongHieu> thuongHieus = thuonghieuServices.CNShow();
                    ShowThuongHieu(thuongHieus);
                    return;

                }

            }
            else if (rb_DanhMuc.Checked)
            {
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kq = danhMucServices.CNThem(ten);
                    MessageBox.Show(kq);
                    List<DanhMuc> danhMucs = danhMucServices.CNShow();
                    ShowDanhMuc(danhMucs);
                    return;

                }

            }
            else if (rb_MauSac.Checked)
            {
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kq = mauSacServices.CNThem(ten);
                    MessageBox.Show(kq);
                    List<MauSac> mauSacs = mauSacServices.CNShow();
                    ShowMauSac(mauSacs);
                    return;

                }

            }
            else if (rb_KichCo.Checked)
            {
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kq = kichCoServices.CNThem(ten);
                    MessageBox.Show(kq);
                    List<KichCo> kichCos = kichCoServices.CNShow();
                    ShowKichCo(kichCos);
                    return;
                }
            }
        }

        public void ShowThuongHieu(List<ThuongHieu> thuongHieus)
        {
            dgv_ThuocTinh.Rows.Clear();
            dgv_ThuocTinh.ColumnCount = 3;
            int stt = 1;
            dgv_ThuocTinh.Columns[0].HeaderText = "Số thứ tự";
            dgv_ThuocTinh.Columns[1].HeaderText = "Mã thương hiệu";
            dgv_ThuocTinh.Columns[2].HeaderText = "Tên thương hiệu";
            dgv_ThuocTinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var item in thuongHieus)
            {
                dgv_ThuocTinh.Rows.Add(stt++, item.IdThuongHieu, item.TenThuongHieu);
            }
        }

        public void ShowDanhMuc(List<DanhMuc> danhMucs)
        {
            dgv_ThuocTinh.Rows.Clear();
            dgv_ThuocTinh.ColumnCount = 3;
            int stt = 1;
            dgv_ThuocTinh.Columns[0].HeaderText = "Số thứ tự";
            dgv_ThuocTinh.Columns[1].HeaderText = "Mã danh mục";
            dgv_ThuocTinh.Columns[2].HeaderText = "Tên danh mục";
            dgv_ThuocTinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var item in danhMucs)
            {
                dgv_ThuocTinh.Rows.Add(stt++, item.IdDanhMuc, item.TenDanhMuc);
            }
        }

        public void ShowMauSac(List<MauSac> mauSacs)
        {
            dgv_ThuocTinh.Rows.Clear();
            dgv_ThuocTinh.ColumnCount = 3;
            int stt = 1;
            dgv_ThuocTinh.Columns[0].HeaderText = "Số thứ tự";
            dgv_ThuocTinh.Columns[1].HeaderText = "Mã màu sắc";
            dgv_ThuocTinh.Columns[2].HeaderText = "Tên màu sắc";
            dgv_ThuocTinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var item in mauSacs)
            {
                dgv_ThuocTinh.Rows.Add(stt++, item.IdMauSac, item.TenMauSac);
            }
        }

        public void ShowKichCo(List<KichCo> kichCos)
        {
            dgv_ThuocTinh.Rows.Clear();
            dgv_ThuocTinh.ColumnCount = 3;
            int stt = 1;
            dgv_ThuocTinh.Columns[0].HeaderText = "Số thứ tự";
            dgv_ThuocTinh.Columns[1].HeaderText = "Mã kích cỡ";
            dgv_ThuocTinh.Columns[2].HeaderText = "Tên kích cỡ";
            dgv_ThuocTinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var item in kichCos)
            {
                dgv_ThuocTinh.Rows.Add(stt++, item.IdKichCo, item.KichCo1);
            }
        }





        private void dgv_ThuocTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem chỉ số hàng có hợp lệ hay không
            if (e.RowIndex >= 0 && e.RowIndex < dgv_ThuocTinh.Rows.Count)
            {
                // Lấy dữ liệu từ dòng được chọn để điền vào form
                int row = e.RowIndex;
                var rowData = dgv_ThuocTinh.Rows[row]; // Lấy dữ liệu từ dòng đó ra

                // Kiểm tra chỉ số cột có hợp lệ hay không
                if (rowData.Cells.Count > 2)
                {
                    tb_MaThuocTinh.Text = rowData.Cells[1].Value?.ToString() ?? string.Empty;
                    tb_TenThuocTinh.Text = rowData.Cells[2].Value?.ToString() ?? string.Empty;
                }
            }
        }

        private void rb_ThuongHieu_CheckedChanged(object sender, EventArgs e)
        {
            List<ThuongHieu> thuongHieus = thuonghieuServices.CNShow();
            ShowThuongHieu(thuongHieus);
            return;
        }

        private void btn_LamMoi_ThuocTinh_Click(object sender, EventArgs e)
        {
            tb_MaThuocTinh.Clear();
            tb_TenThuocTinh.Clear();
            rb_DanhMuc.Checked = false;
            rb_KichCo.Checked = false;
            rb_ThuongHieu.Checked = false;
            rb_DanhMuc.Checked = false;
            dgv_ThuocTinh.Rows.Clear();
            tb_TimKiem_ThuocTinh.Clear();
            rb_MauSac.Checked = false;
        }

        private void btn_Sua_ThuocTinh_Click(object sender, EventArgs e)
        {
            if (rb_ThuongHieu.Checked)
            {
                string idThuongHieu = tb_MaThuocTinh.Text;
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kq = thuonghieuServices.CNSua(idThuongHieu, ten);
                    MessageBox.Show(kq);
                    List<ThuongHieu> thuongHieus = thuonghieuServices.CNShow();
                    ShowThuongHieu(thuongHieus);
                    return;

                }

            }
            else if (rb_DanhMuc.Checked)
            {
                string id = tb_MaThuocTinh.Text;
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kq = danhMucServices.CNSua(id, ten);
                    MessageBox.Show(kq);
                    List<DanhMuc> danhMucs = danhMucServices.CNShow();
                    ShowDanhMuc(danhMucs);
                    return;

                }

            }
            else if (rb_MauSac.Checked)
            {
                string id = tb_MaThuocTinh.Text;
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kq = mauSacServices.CNSua(id, ten);
                    MessageBox.Show(kq);
                    List<MauSac> mauSacs = mauSacServices.CNShow();
                    ShowMauSac(mauSacs);
                    return;

                }

            }
            else if (rb_KichCo.Checked)
            {
                string id = tb_MaThuocTinh.Text;
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kq = kichCoServices.CNSua(id, ten);
                    MessageBox.Show(kq);
                    List<KichCo> kichCos = kichCoServices.CNShow();
                    ShowKichCo(kichCos);
                    return;
                }
            }
        }

        private void btn_Xoa_ThuocTinh_Click(object sender, EventArgs e)
        {
            if (rb_ThuongHieu.Checked)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    thuonghieuServices.XoaTH(tb_MaThuocTinh.Text);
                    List<ThuongHieu> thuongHieus = thuonghieuServices.CNShow();
                    ShowThuongHieu(thuongHieus);
                    return;
                }

            }
            else if (rb_DanhMuc.Checked)
            {
                string id = tb_MaThuocTinh.Text;

                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kq = danhMucServices.XoaDM(id);
                    MessageBox.Show(kq);
                    List<DanhMuc> danhMucs = danhMucServices.CNShow();
                    ShowDanhMuc(danhMucs);
                    return;

                }

            }
            else if (rb_MauSac.Checked)
            {
                string id = tb_MaThuocTinh.Text;

                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kq = mauSacServices.XoaMS(id);
                    MessageBox.Show(kq);
                    List<MauSac> mauSacs = mauSacServices.CNShow();
                    ShowMauSac(mauSacs);
                    return;

                }

            }
            else if (rb_KichCo.Checked)
            {
                string id = tb_MaThuocTinh.Text;

                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kq = kichCoServices.XoaKC(id);
                    MessageBox.Show(kq);
                    List<KichCo> kichCos = kichCoServices.CNShow();
                    ShowKichCo(kichCos);
                    return;
                }
            }
        }

        private void rb_DanhMuc_CheckedChanged(object sender, EventArgs e)
        {
            List<DanhMuc> danhMucs = danhMucServices.CNShow();
            ShowDanhMuc(danhMucs);
            return;
        }

        private void rb_MauSac_CheckedChanged(object sender, EventArgs e)
        {
            List<MauSac> mauSacs = mauSacServices.CNShow();
            ShowMauSac(mauSacs);
            return;
        }

        private void rb_KichCo_CheckedChanged(object sender, EventArgs e)
        {
            List<KichCo> kichCos = kichCoServices.CNShow();
            ShowKichCo(kichCos);
            return;
        }

        private void tb_TimKiem_ThuocTinh_TextChanged(object sender, EventArgs e)
        {
            if (rb_ThuongHieu.Checked)
            {
                List<ThuongHieu> thuongHieus = thuonghieuServices.CNTim(tb_TimKiem_ThuocTinh.Text);
                ShowThuongHieu(thuongHieus);

            }
            else if (rb_DanhMuc.Checked)
            {
                List<DanhMuc> danhMucs = danhMucServices.CNTim(tb_TimKiem_ThuocTinh.Text);
                ShowDanhMuc(danhMucs);

            }
            else if (rb_MauSac.Checked)
            {
                List<MauSac> mauSacs = mauSacServices.CNTim(tb_TimKiem_ThuocTinh.Text);
                ShowMauSac(mauSacs);

            }
            else if (rb_KichCo.Checked)
            {
                List<KichCo> kichCos = kichCoServices.CNTim(tb_TimKiem_ThuocTinh.Text);
                ShowKichCo(kichCos);
            }
        }
    }
}
