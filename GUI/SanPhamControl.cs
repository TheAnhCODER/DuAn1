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
        SanPhamServices sanPhamServices;
        public SanPhamControl()
        {
            InitializeComponent();
            thuonghieuServices = new ThuongHieuServices();
            danhMucServices = new DanhMucServices();
            kichCoServices = new KichCoServices();
            mauSacServices = new MauSacServices();
            sanPhamServices = new SanPhamServices();
            LoadDanhMuc();
            LoadThuongHieu();
            LoadTrangThai();
            LoadThuongHieuTimKiem();
            LoadDanhMucTimKiem();
            LoadTrangThaiTimKiem();
            LoadSanPham();
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
            string idDanhMuc = cb_DanhMuc_SanPham.SelectedValue.ToString();
            string idThuongHieu = cb_ThuongHieu_SanPham.SelectedValue.ToString();
            string ten = tb_TenSanPham_SanPham.Text;

            string moTa = tb_MoTa_SanPham.Text;
            bool trangthaisp = (bool)cb_TrangThaiSP_SanPham.SelectedValue;
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string kq = sanPhamServices.CNThem(idDanhMuc, idThuongHieu, ten, moTa, trangthaisp);
                MessageBox.Show(kq);
                List<SanPham> sanPhams = sanPhamServices.CNShow();
                ShowSanPham(sanPhams);
                return;

            }
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
                    LoadThuongHieu();
                    LoadThuongHieuTimKiem();
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
                    LoadDanhMuc();
                    LoadDanhMucTimKiem();
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
                    LoadThuongHieu();
                    LoadThuongHieuTimKiem();
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
                    LoadDanhMuc();
                    LoadDanhMucTimKiem();
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
                    LoadThuongHieu();
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
                    LoadDanhMuc();
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

        //form sản phẩm

        private void LoadDanhMucTimKiem()
        {
            try
            {
                List<DanhMuc> danhMucList = danhMucServices.CNShow();

                cb_Loc_DanhMuc.DataSource = danhMucList;
                cb_Loc_DanhMuc.DisplayMember = "TenDanhMuc"; // Thuộc tính tên để hiển thị
                cb_Loc_DanhMuc.ValueMember = "IdDanhMuc"; // Thuộc tính giá trị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadDanhMuc()
        {
            try
            {
                List<DanhMuc> danhMucList = danhMucServices.CNShow();
                cb_DanhMuc_SanPham.DataSource = danhMucList;
                cb_DanhMuc_SanPham.DisplayMember = "TenDanhMuc"; // Thuộc tính tên để hiển thị
                cb_DanhMuc_SanPham.ValueMember = "IdDanhMuc"; // Thuộc tính giá trị

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadThuongHieuTimKiem()
        {
            try
            {
                List<ThuongHieu> thuongHieulist = thuonghieuServices.CNShow();

                cb_Loc_TH.DataSource = thuongHieulist;
                cb_Loc_TH.DisplayMember = "TenThuongHieu"; // Thuộc tính tên để hiển thị
                cb_Loc_TH.ValueMember = "IdThuongHieu"; // Thuộc tính giá trị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadThuongHieu()
        {
            try
            {
                List<ThuongHieu> thuongHieulist = thuonghieuServices.CNShow();
                cb_ThuongHieu_SanPham.DataSource = thuongHieulist;
                cb_ThuongHieu_SanPham.DisplayMember = "TenThuongHieu"; // Thuộc tính tên để hiển thị
                cb_ThuongHieu_SanPham.ValueMember = "IdThuongHieu"; // Thuộc tính giá trị

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadSanPham()
        {
            try
            {
                List<SanPham> sanPhams = sanPhamServices.CNShow();
                dgv_DanhSachSP_SanPham.Rows.Clear();
                dgv_DanhSachSP_SanPham.ColumnCount = 7;
                int stt = 1;
                dgv_DanhSachSP_SanPham.Columns[0].HeaderText = "Số thứ tự";
                dgv_DanhSachSP_SanPham.Columns[1].HeaderText = "Mã sản phẩm";
                dgv_DanhSachSP_SanPham.Columns[2].HeaderText = "Mã thương hiệu";
                dgv_DanhSachSP_SanPham.Columns[3].HeaderText = "Mã danh mục";
                dgv_DanhSachSP_SanPham.Columns[4].HeaderText = "Tên sản phẩm";

                dgv_DanhSachSP_SanPham.Columns[5].HeaderText = "Mô tả";
                dgv_DanhSachSP_SanPham.Columns[6].HeaderText = "Trạng thái sản phẩm";
                dgv_DanhSachSP_SanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (var item in sanPhams)
                {
                    string trangThaiSanPham = item.TrangThaiSanPham ? "Đang kinh doanh" : "Ngưng kinh doanh";
                    dgv_DanhSachSP_SanPham.Rows.Add(stt++, item.IdSanPham, item.IdThuongHieu, item.IdDanhMuc, item.TenSanPham, item.MoTa, trangThaiSanPham);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


        public void ShowSanPham(List<SanPham> sanPhams)
        {
            dgv_DanhSachSP_SanPham.Rows.Clear();
            dgv_DanhSachSP_SanPham.ColumnCount = 7;
            int stt = 1;
            dgv_DanhSachSP_SanPham.Columns[0].HeaderText = "Số thứ tự";
            dgv_DanhSachSP_SanPham.Columns[1].HeaderText = "Mã sản phẩm";
            dgv_DanhSachSP_SanPham.Columns[2].HeaderText = "Mã thương hiệu";
            dgv_DanhSachSP_SanPham.Columns[3].HeaderText = "Mã danh mục";
            dgv_DanhSachSP_SanPham.Columns[4].HeaderText = "Tên sản phẩm";

            dgv_DanhSachSP_SanPham.Columns[5].HeaderText = "Mô tả";
            dgv_DanhSachSP_SanPham.Columns[6].HeaderText = "Trạng thái sản phẩm";
            dgv_DanhSachSP_SanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var item in sanPhams)
            {
                string trangThaiSanPham = item.TrangThaiSanPham ? "Đang kinh doanh" : "Ngưng kinh doanh";
                dgv_DanhSachSP_SanPham.Rows.Add(stt++, item.IdSanPham, item.IdThuongHieu, item.IdDanhMuc, item.TenSanPham, item.MoTa, trangThaiSanPham);
            }
        }

        private void LoadTrangThai()
        {
            try
            {
                // Tạo danh sách trạng thái dưới dạng Dictionary
                var trangThaiList = new Dictionary<bool, string>
                {
                    { true, "Kinh doanh" },
                    { false, "Ngưng kinh doanh" }
                };
                cb_TrangThaiSP_SanPham.DataSource = new BindingSource(trangThaiList, null);
                cb_TrangThaiSP_SanPham.DisplayMember = "Value";
                cb_TrangThaiSP_SanPham.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadTrangThaiTimKiem()
        {
            try
            {
                // Tạo danh sách trạng thái dưới dạng Dictionary
                var trangThaiList = new Dictionary<bool, string>
                {
                    { true, "Kinh doanh" },
                    { false, "Ngưng kinh doanh" }
                };
                cb_Loc_TTSP.DataSource = new BindingSource(trangThaiList, null);
                cb_Loc_TTSP.DisplayMember = "Value";
                cb_Loc_TTSP.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void dgv_DanhSachSP_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_DanhSachSP_SanPham.Rows.Count)
            {
                // Lấy dữ liệu từ dòng được chọn để điền vào form
                int row = e.RowIndex;
                var rowData = dgv_DanhSachSP_SanPham.Rows[row]; // Lấy dữ liệu từ dòng đó ra

                // Điền dữ liệu vào các trường trên form
                tb_MaSP_SP.Text = rowData.Cells[1].Value?.ToString() ?? string.Empty;
                string idThuongHieu = rowData.Cells[2].Value?.ToString() ?? string.Empty;

                // Thiết lập SelectedValue của ComboBox thuong hieu
                if (!string.IsNullOrEmpty(idThuongHieu))
                {
                    cb_ThuongHieu_SanPham.SelectedValue = Guid.Parse(idThuongHieu);
                }
                // Lấy IdDanhMuc từ dòng được chọn
                string idDanhMuc = rowData.Cells[3].Value?.ToString() ?? string.Empty;

                // Thiết lập SelectedValue của ComboBox danh mục
                if (!string.IsNullOrEmpty(idDanhMuc))
                {
                    cb_DanhMuc_SanPham.SelectedValue = Guid.Parse(idDanhMuc);
                }
                tb_TenSanPham_SanPham.Text = rowData.Cells[4].Value?.ToString() ?? string.Empty;

                tb_MoTa_SanPham.Text = rowData.Cells[5].Value?.ToString() ?? string.Empty;

                // Chuyển đổi trạng thái sản phẩm từ chuỗi sang giá trị bool
                string trangThai = rowData.Cells[6].Value?.ToString() ?? string.Empty;
                cb_TrangThaiSP_SanPham.SelectedValue = trangThai == "Đang kinh doanh" ? true : false;
            }
        }

        private void btn_Sua_SP_Click(object sender, EventArgs e)
        {
            string masp = tb_MaSP_SP.Text;
            string idDanhMuc = cb_DanhMuc_SanPham.SelectedValue.ToString();
            string idThuongHieu = cb_ThuongHieu_SanPham.SelectedValue.ToString();
            string ten = tb_TenSanPham_SanPham.Text;

            string moTa = tb_MoTa_SanPham.Text;
            bool trangthaisp = (bool)cb_TrangThaiSP_SanPham.SelectedValue;
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string kq = sanPhamServices.CNSua(masp, idDanhMuc, idThuongHieu, ten, moTa, trangthaisp);
                MessageBox.Show(kq);
                List<SanPham> sanPhams = sanPhamServices.CNShow();
                ShowSanPham(sanPhams);
                return;

            }
        }

        private void btn_LamMoi_SanPham_Click(object sender, EventArgs e)
        {
            tb_MaSP_SP.Clear();
            tb_TenSanPham_SanPham.Clear();
            tb_MoTa_SanPham.Clear();
            tb_timKiem_SanPham.Clear();
            LoadSanPham();
        }

        private void tb_timKiem_SanPham_TextChanged(object sender, EventArgs e)
        {
            List<SanPham> sanPhams = sanPhamServices.CNTim(tb_timKiem_SanPham.Text);
            ShowSanPham(sanPhams);
        }

        private void cb_Loc_TH_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_DanhSachSP_SanPham.Rows.Clear();

            // Kiểm tra nếu SelectedValue không null và có kiểu Guid
            if (cb_Loc_TH.SelectedValue != null && cb_Loc_TH.SelectedValue is Guid)
            {
                Guid maThuongHieu = (Guid)cb_Loc_TH.SelectedValue;
                List<SanPham> sanPhams = sanPhamServices.GetSPByThuongHieu(maThuongHieu);
                ShowSanPham(sanPhams);
            }
        }



        private void cb_Loc_DanhMuc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dgv_DanhSachSP_SanPham.Rows.Clear();

            // Kiểm tra nếu SelectedValue không null và có kiểu Guid
            if (cb_Loc_DanhMuc.SelectedValue != null && cb_Loc_DanhMuc.SelectedValue is Guid)
            {
                Guid maDanhMuc = (Guid)cb_Loc_DanhMuc.SelectedValue;
                List<SanPham> sanPhams = sanPhamServices.GetSPByDanhMuc(maDanhMuc);
                ShowSanPham(sanPhams);
            }
        }

        private void cb_Loc_TTSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_DanhSachSP_SanPham.Rows.Clear();

            // Kiểm tra nếu SelectedValue không null
            if (cb_Loc_TTSP.SelectedValue != null && cb_Loc_TTSP.SelectedValue is bool)
            {
                bool trangThai = (bool)cb_Loc_TTSP.SelectedValue;
                List<SanPham> sanPhams = sanPhamServices.GetSPByTTSP(trangThai);
                ShowSanPham(sanPhams);
            }
        }
    }
}
