using BUS.Services;
using DAL.Models;
using QRCoder;
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
    public partial class SanPhamControl : UserControl
    {
        ThuongHieuServices thuonghieuServices;
        DanhMucServices danhMucServices;
        KichCoServices kichCoServices;
        MauSacServices mauSacServices;
        SanPhamServices sanPhamServices;
        SanPhamChiTietServices sanPhamChiTietServices;

        public SanPhamControl()
        {
            InitializeComponent();
            thuonghieuServices = new ThuongHieuServices();
            danhMucServices = new DanhMucServices();
            kichCoServices = new KichCoServices();
            mauSacServices = new MauSacServices();
            sanPhamServices = new SanPhamServices();
            sanPhamChiTietServices = new SanPhamChiTietServices();
            LoadDanhMuc();
            LoadThuongHieu();
            LoadTrangThai();
            LoadThuongHieuTimKiem();
            LoadDanhMucTimKiem();
            LoadTrangThaiTimKiem();
            LoadKichCo();
            LoadKichCoTimKiem();
            LoadMauSac();
            LoadMauSacTimKiem();
            LoadSanPhamSPCT();
            LoadSanPhamTimKiem();
            LoadSanPhamCT();
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
            if (ValidateNotEmpty(tb_TenSanPham_SanPham))
            {
                // Thực hiện hành động lưu dữ liệu
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
                    LoadSanPhamTimKiem();
                    LoadSanPhamSPCT();
                    return;

                }

            }
            else
            {
                MessageBox.Show("Vui lòng điền tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (ValidateNotEmpty(tb_TenThuocTinh))
                    {

                        string kq = thuonghieuServices.CNThem(ten);
                        MessageBox.Show(kq);
                        List<ThuongHieu> thuongHieus = thuonghieuServices.CNShow();
                        ShowThuongHieu(thuongHieus);
                        LoadThuongHieu();
                        LoadThuongHieuTimKiem();
                        return;
                    }

                    else
                    {
                        MessageBox.Show("Vui lòng điền tên thuộc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else if (rb_DanhMuc.Checked)
            {
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (ValidateNotEmpty(tb_TenThuocTinh))
                    {

                        string kq = danhMucServices.CNThem(ten);
                        MessageBox.Show(kq);
                        List<DanhMuc> danhMucs = danhMucServices.CNShow();
                        ShowDanhMuc(danhMucs);
                        LoadDanhMuc();
                        LoadDanhMucTimKiem();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền tên thuộc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else if (rb_MauSac.Checked)
            {
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (ValidateNotEmpty(tb_TenThuocTinh))
                    {

                        string kq = mauSacServices.CNThem(ten);
                        MessageBox.Show(kq);
                        List<MauSac> mauSacs = mauSacServices.CNShow();
                        ShowMauSac(mauSacs);
                        LoadMauSac();
                        LoadMauSacTimKiem();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền tên thuộc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else if (rb_KichCo.Checked)
            {
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (ValidateNotEmpty(tb_TenThuocTinh))
                    {

                        string kq = kichCoServices.CNThem(ten);
                        MessageBox.Show(kq);
                        List<KichCo> kichCos = kichCoServices.CNShow();
                        ShowKichCo(kichCos);
                        LoadKichCo();
                        LoadKichCoTimKiem();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền tên thuộc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
                    if (ValidateNotEmpty(tb_TenThuocTinh, tb_MaThuocTinh))
                    {

                        string kq = thuonghieuServices.CNSua(idThuongHieu, ten);
                        MessageBox.Show(kq);
                        List<ThuongHieu> thuongHieus = thuonghieuServices.CNShow();
                        ShowThuongHieu(thuongHieus);
                        LoadThuongHieu();
                        LoadThuongHieuTimKiem();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin thuộc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else if (rb_DanhMuc.Checked)
            {
                string id = tb_MaThuocTinh.Text;
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (ValidateNotEmpty(tb_TenThuocTinh, tb_MaThuocTinh))
                    {

                        string kq = danhMucServices.CNSua(id, ten);
                        MessageBox.Show(kq);
                        List<DanhMuc> danhMucs = danhMucServices.CNShow();
                        ShowDanhMuc(danhMucs);
                        LoadDanhMuc();
                        LoadDanhMucTimKiem();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin thuộc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else if (rb_MauSac.Checked)
            {
                string id = tb_MaThuocTinh.Text;
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (ValidateNotEmpty(tb_TenThuocTinh, tb_MaThuocTinh))
                    {

                        string kq = mauSacServices.CNSua(id, ten);
                        MessageBox.Show(kq);
                        List<MauSac> mauSacs = mauSacServices.CNShow();
                        ShowMauSac(mauSacs);
                        LoadMauSacTimKiem();
                        LoadMauSac();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin thuộc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else if (rb_KichCo.Checked)
            {
                string id = tb_MaThuocTinh.Text;
                string ten = tb_TenThuocTinh.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (ValidateNotEmpty(tb_TenThuocTinh, tb_MaThuocTinh))
                    {

                        string kq = kichCoServices.CNSua(id, ten);
                        MessageBox.Show(kq);
                        List<KichCo> kichCos = kichCoServices.CNShow();
                        ShowKichCo(kichCos);
                        LoadKichCoTimKiem();
                        LoadKichCo();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin thuộc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
                dgv_DanhSachSP_SanPham.Columns[2].HeaderText = "Thương hiệu";
                dgv_DanhSachSP_SanPham.Columns[3].HeaderText = "Danh mục";
                dgv_DanhSachSP_SanPham.Columns[4].HeaderText = "Tên sản phẩm";
                dgv_DanhSachSP_SanPham.Columns[5].HeaderText = "Mô tả";
                dgv_DanhSachSP_SanPham.Columns[6].HeaderText = "Trạng thái sản phẩm";

                dgv_DanhSachSP_SanPham.Columns[0].Visible = false;
                dgv_DanhSachSP_SanPham.Columns[1].Visible = false;

                Dictionary<Guid, string> thuonghieuDict = thuonghieuServices.GetThuongHieuDict();
                Dictionary<Guid, string> danhmucDict = danhMucServices.GetDanhMucDict();
                dgv_DanhSachSP_SanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (var item in sanPhams)
                {
                    string danhmuc = danhmucDict.ContainsKey(item.IdDanhMuc.Value)
           ? danhmucDict[item.IdDanhMuc.Value]
           : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                    string thuonghieu = thuonghieuDict.ContainsKey(item.IdThuongHieu.Value)
               ? thuonghieuDict[item.IdThuongHieu.Value]
               : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                    string trangThaiSanPham = item.TrangThaiSanPham ? "Đang kinh doanh" : "Ngưng kinh doanh";
                    dgv_DanhSachSP_SanPham.Rows.Add(stt++, item.IdSanPham, thuonghieu, danhmuc, item.TenSanPham, item.MoTa, trangThaiSanPham);
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
            dgv_DanhSachSP_SanPham.Columns[2].HeaderText = "Thương hiệu";
            dgv_DanhSachSP_SanPham.Columns[3].HeaderText = "Danh mục";
            dgv_DanhSachSP_SanPham.Columns[4].HeaderText = "Tên sản phẩm";

            dgv_DanhSachSP_SanPham.Columns[5].HeaderText = "Mô tả";
            dgv_DanhSachSP_SanPham.Columns[6].HeaderText = "Trạng thái sản phẩm";

            dgv_DanhSachSP_SanPham.Columns[0].Visible = false;
            dgv_DanhSachSP_SanPham.Columns[1].Visible = false;


            Dictionary<Guid, string> thuonghieuDict = thuonghieuServices.GetThuongHieuDict();
            Dictionary<Guid, string> danhmucDict = danhMucServices.GetDanhMucDict();
            dgv_DanhSachSP_SanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var item in sanPhams)
            {
                string danhmuc = danhmucDict.ContainsKey(item.IdDanhMuc.Value)
           ? danhmucDict[item.IdDanhMuc.Value]
           : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                string thuonghieu = thuonghieuDict.ContainsKey(item.IdThuongHieu.Value)
           ? thuonghieuDict[item.IdThuongHieu.Value]
           : "N/A"; // Thay "N/A" bằng chuỗi bạn muốn hiển thị khi không tìm thấy 
                string trangThaiSanPham = item.TrangThaiSanPham ? "Đang kinh doanh" : "Ngưng kinh doanh";
                dgv_DanhSachSP_SanPham.Rows.Add(stt++, item.IdSanPham, thuonghieu, danhmuc, item.TenSanPham, item.MoTa, trangThaiSanPham);
            }
        }
        // Hàm để lấy Id thương hiệu từ tên thương hiệu
        private Guid? GetThuongHieuIdByName(string tenThuongHieu)
        {
            try
            {
                List<ThuongHieu> thuongHieulist = thuonghieuServices.CNShow();
                var thuongHieu = thuongHieulist.FirstOrDefault(th => th.TenThuongHieu.Equals(tenThuongHieu, StringComparison.OrdinalIgnoreCase));
                return thuongHieu?.IdThuongHieu; // Trả về null nếu không tìm thấy
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return null; // Trả về null nếu có lỗi
            }
        }
        // Hàm để lấy Id danh mục từ tên danh mục
        private Guid? GetDanhMucIdByName(string tenDanhMuc)
        {
            try
            {
                List<DanhMuc> danhMucList = danhMucServices.CNShow(); // Lấy danh sách danh mục từ dịch vụ
                var danhMuc = danhMucList.FirstOrDefault(dm => dm.TenDanhMuc.Equals(tenDanhMuc, StringComparison.OrdinalIgnoreCase));
                return danhMuc?.IdDanhMuc; // Trả về null nếu không tìm thấy
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return null; // Trả về null nếu có lỗi
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
                // Lấy tên thương hiệu từ dòng được chọn
                string tenThuongHieu = rowData.Cells[2].Value?.ToString() ?? string.Empty;

                // Lấy id thương hiệu từ tên thương hiệu
                Guid? thuongHieuId = GetThuongHieuIdByName(tenThuongHieu);

                // Thiết lập SelectedValue của ComboBox thương hiệu
                if (thuongHieuId.HasValue)
                {
                    cb_ThuongHieu_SanPham.SelectedValue = thuongHieuId.Value;
                }
                else
                {
                    cb_ThuongHieu_SanPham.SelectedIndex = -1; // Nếu không tìm thấy, bỏ chọn
                }


                // Lấy tên danh mục từ dòng được chọn
                string tenDanhMuc = rowData.Cells[3].Value?.ToString() ?? string.Empty;

                // Lấy id danh mục từ tên danh mục
                Guid? danhMucId = GetDanhMucIdByName(tenDanhMuc);

                // Thiết lập SelectedValue của ComboBox danh mục
                if (danhMucId.HasValue)
                {
                    cb_DanhMuc_SanPham.SelectedValue = danhMucId.Value;
                }
                else
                {
                    cb_DanhMuc_SanPham.SelectedIndex = -1; // Nếu không tìm thấy, bỏ chọn
                }
                tb_TenSanPham_SanPham.Text = rowData.Cells[4].Value?.ToString() ?? string.Empty;

                tb_MoTa_SanPham.Text = rowData.Cells[5].Value?.ToString() ?? string.Empty;

                // Chuyển đổi trạng thái sản phẩm từ chuỗi sang giá trị bool
                string trangThai = rowData.Cells[6].Value?.ToString() ?? string.Empty;
                cb_TrangThaiSP_SanPham.SelectedValue = trangThai == "Đang kinh doanh" ? true : false;
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

      
        private void btn_Sua_SP_Click(object sender, EventArgs e)
        {
            if (ValidateNotEmpty(tb_MaSP_SP, tb_TenSanPham_SanPham))
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
                    LoadSanPhamTimKiem();
                    LoadSanPhamSPCT();
                    return;

                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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









        // sản phẩm chi tiết



        private void LoadMauSacTimKiem()
        {
            try
            {
                List<MauSac> mauSacs = mauSacServices.CNShow();

                cb_MauSac_SPCT_Loc.DataSource = mauSacs;
                cb_MauSac_SPCT_Loc.DisplayMember = "TenMauSac"; // Thuộc tính tên để hiển thị
                cb_MauSac_SPCT_Loc.ValueMember = "IdMauSac"; // Thuộc tính giá trị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadMauSac()
        {
            try
            {
                List<MauSac> mauSacs = mauSacServices.CNShow();
                cb_MauSac_SanPhamChiTiet.DataSource = mauSacs;
                cb_MauSac_SanPhamChiTiet.DisplayMember = "TenMauSac"; // Thuộc tính tên để hiển thị
                cb_MauSac_SanPhamChiTiet.ValueMember = "IdMauSac"; // Thuộc tính giá trị

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadKichCoTimKiem()
        {
            try
            {
                List<KichCo> kichCos = kichCoServices.CNShow();

                cb_KíchThuoc_SPCT_Loc.DataSource = kichCos;
                cb_KíchThuoc_SPCT_Loc.DisplayMember = "KichCo1"; // Thuộc tính tên để hiển thị
                cb_KíchThuoc_SPCT_Loc.ValueMember = "IdKichCo"; // Thuộc tính giá trị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadKichCo()
        {
            try
            {
                List<KichCo> kichCos = kichCoServices.CNShow();

                cb_KichThuoc_SanPhamChiTiet.DataSource = kichCos;
                cb_KichThuoc_SanPhamChiTiet.DisplayMember = "KichCo1"; // Thuộc tính tên để hiển thị
                cb_KichThuoc_SanPhamChiTiet.ValueMember = "IdKichCo"; // Thuộc tính giá trị

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


        private void LoadSanPhamCT()
        {
            try
            {
                List<SanPhamChiTiet> sanPhamChiTiets = sanPhamChiTietServices.CNShow();
                dgv_SanPhamChiTiet.Rows.Clear();
                dgv_SanPhamChiTiet.ColumnCount = 7;
                int stt = 1;
                dgv_SanPhamChiTiet.Columns[0].HeaderText = "Số thứ tự";
                dgv_SanPhamChiTiet.Columns[1].HeaderText = "Mã sản phẩm chi tiết";
                dgv_SanPhamChiTiet.Columns[2].HeaderText = "Tên sản phẩm";
                dgv_SanPhamChiTiet.Columns[3].HeaderText = "Màu sắc";
                dgv_SanPhamChiTiet.Columns[4].HeaderText = "Kích cỡ";
                dgv_SanPhamChiTiet.Columns[5].HeaderText = "Số lượng";
                dgv_SanPhamChiTiet.Columns[6].HeaderText = "Giá";

                dgv_SanPhamChiTiet.Columns[0].Visible = false;
                dgv_SanPhamChiTiet.Columns[1].Visible = false;

                dgv_SanPhamChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                    dgv_SanPhamChiTiet.Rows.Add(stt++, item.IdSanphamChitiet, tenSanPham, mausac, kichco, item.SoLuong, item.Gia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


        public void ShowSanPhamCT(List<SanPhamChiTiet> sanPhamChiTiets)
        {
            dgv_SanPhamChiTiet.Rows.Clear();
            dgv_SanPhamChiTiet.ColumnCount = 7;
            int stt = 1;
            dgv_SanPhamChiTiet.Columns[0].HeaderText = "Số thứ tự";
            dgv_SanPhamChiTiet.Columns[1].HeaderText = "Mã sản phẩm chi tiết";
            dgv_SanPhamChiTiet.Columns[2].HeaderText = "Tên sản phẩm";
            dgv_SanPhamChiTiet.Columns[3].HeaderText = "Màu sắc";
            dgv_SanPhamChiTiet.Columns[4].HeaderText = "Kích cỡ";
            dgv_SanPhamChiTiet.Columns[5].HeaderText = "Số lượng";
            dgv_SanPhamChiTiet.Columns[6].HeaderText = "Giá";

            dgv_SanPhamChiTiet.Columns[0].Visible = false;
            dgv_SanPhamChiTiet.Columns[1].Visible = false;

            dgv_SanPhamChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                dgv_SanPhamChiTiet.Rows.Add(stt++, item.IdSanphamChitiet, tenSanPham, mausac, kichco, item.SoLuong, item.Gia);
            }
        }
        // Hàm để lấy Id màu sắc từ tên màu sắc
        private Guid? GetMauSacIdByName(string tenMauSac)
        {
            try
            {
                List<MauSac> mauSacList = mauSacServices.CNShow(); // Lấy danh sách màu sắc từ dịch vụ
                var mauSac = mauSacList.FirstOrDefault(ms => ms.TenMauSac.Equals(tenMauSac, StringComparison.OrdinalIgnoreCase));
                return mauSac?.IdMauSac; // Trả về null nếu không tìm thấy
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return null; // Trả về null nếu có lỗi
            }
        }
        // Hàm để lấy Id kích cỡ từ tên kích cỡ
        private Guid? GetKichCoIdByName(string tenKichCo)
        {
            try
            {
                List<KichCo> kichCoList = kichCoServices.CNShow(); // Lấy danh sách kích cỡ từ dịch vụ
                var kichCo = kichCoList.FirstOrDefault(kc => kc.KichCo1.Equals(tenKichCo, StringComparison.OrdinalIgnoreCase));
                return kichCo?.IdKichCo; // Trả về null nếu không tìm thấy
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return null; // Trả về null nếu có lỗi
            }
        }







        private void dgv_SanPhamChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
                // Lấy dữ liệu từ dòng được chọn để điền vào form
                int row = e.RowIndex;
                var rowData = dgv_SanPhamChiTiet.Rows[row]; // Lấy dữ liệu từ dòng đó ra

                // Điền dữ liệu vào các trường trên form
                tb_MaSPCT.Text = rowData.Cells[1].Value?.ToString() ?? string.Empty;
                string idSanPham = rowData.Cells[2].Value?.ToString() ?? string.Empty;
                // Lấy danh sách thương hiệu từ dịch vụ
                Dictionary<Guid, string> sanphamDict = sanPhamServices.GetSanPhamDict();

                // Thiết lập SelectedValue của ComboBox sanpham
                if (!string.IsNullOrEmpty(idSanPham) && Guid.TryParse(idSanPham, out Guid sanphamGuid))
                {
                    if (sanphamDict.ContainsKey(sanphamGuid))
                    {
                        cb_SanPham_SanPhamChiTiet.SelectedItem = sanphamDict[sanphamGuid];
                    }
                    else
                    {
                        cb_SanPham_SanPhamChiTiet.SelectedIndex = -1; // Nếu không tìm thấy, bỏ chọn
                    }
                }


                // Lấy tên màu sắc từ dòng được chọn
                string tenMauSac = rowData.Cells[3].Value?.ToString() ?? string.Empty;

                // Lấy id màu sắc từ tên màu sắc
                Guid? mauSacId = GetMauSacIdByName(tenMauSac);

                // Thiết lập SelectedValue của ComboBox màu sắc
                if (mauSacId.HasValue)
                {
                    cb_MauSac_SanPhamChiTiet.SelectedValue = mauSacId.Value;
                }
                else
                {
                    cb_MauSac_SanPhamChiTiet.SelectedIndex = -1; // Nếu không tìm thấy, bỏ chọn
                }

                // Lấy tên kích cỡ từ dòng được chọn
                string tenKichCo = rowData.Cells[4].Value?.ToString() ?? string.Empty;

                // Lấy id kích cỡ từ tên kích cỡ
                Guid? kichCoId = GetKichCoIdByName(tenKichCo);

                // Thiết lập SelectedValue của ComboBox kích cỡ
                if (kichCoId.HasValue)
                {
                    cb_KichThuoc_SanPhamChiTiet.SelectedValue = kichCoId.Value;
                }
                else
                {
                    cb_KichThuoc_SanPhamChiTiet.SelectedIndex = -1; // Nếu không tìm thấy, bỏ chọn
                }

                tb_SoLuong_SanPham.Text = rowData.Cells[5].Value?.ToString() ?? string.Empty;

                tb_Gia_SanPhamCT.Text = rowData.Cells[6].Value?.ToString() ?? string.Empty;
            }
        }



        private void btn_Them_SanPhamChiTiet_Click(object sender, EventArgs e)
        {




            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ValidateNotEmpty(tb_SoLuong_SanPham, tb_Gia_SanPhamCT))
                {
                    if (ValidateNumeric(tb_SoLuong_SanPham, tb_Gia_SanPhamCT))
                    {
                        if (ValidateNumericInt(tb_SoLuong_SanPham))
                        {
                            if (ValidatePositiveInteger(tb_SoLuong_SanPham, tb_Gia_SanPhamCT))
                            {
                            string idSanPham = cb_SanPham_SanPhamChiTiet.SelectedValue.ToString();
                            string idMauSac = cb_MauSac_SanPhamChiTiet.SelectedValue.ToString();
                            string idKichCo = cb_KichThuoc_SanPhamChiTiet.SelectedValue.ToString();
                            int soLuong = Convert.ToInt32(tb_SoLuong_SanPham.Text);
                            decimal gia = Convert.ToDecimal(tb_Gia_SanPhamCT.Text);
                            string kq = sanPhamChiTietServices.CNThem(idSanPham, idMauSac, idKichCo, soLuong, gia);
                            MessageBox.Show(kq);
                            List<SanPhamChiTiet> sanPhamChiTiets = sanPhamChiTietServices.CNShow();
                            ShowSanPhamCT(sanPhamChiTiets);
                            return;
                            }
                            else
                            {
                                MessageBox.Show("Dữ liệu nhập phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số lượng sản phẩm phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Số lượng và giá sản phẩm phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

       



        private void LoadSanPhamTimKiem()
        {
            try
            {
                List<SanPham> sanPhams = sanPhamServices.CNShow();

                cb_SanPham_SPCT_Loc.DataSource = sanPhams;
                cb_SanPham_SPCT_Loc.DisplayMember = "TenSanPham"; // Thuộc tính tên để hiển thị
                cb_SanPham_SPCT_Loc.ValueMember = "IdSanPham"; // Thuộc tính giá trị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadSanPhamSPCT()
        {
            try
            {
                List<SanPham> sanPhams = sanPhamServices.CNShow();

                cb_SanPham_SanPhamChiTiet.DataSource = sanPhams;
                cb_SanPham_SanPhamChiTiet.DisplayMember = "TenSanPham"; // Thuộc tính tên để hiển thị
                cb_SanPham_SanPhamChiTiet.ValueMember = "IdSanPham"; // Thuộc tính giá trị

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }


        }

        private void btn_Sua_SanPhamChiTiet_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ValidateNotEmpty(tb_SoLuong_SanPham, tb_Gia_SanPhamCT))
                {
                    if (ValidateNumeric(tb_SoLuong_SanPham, tb_Gia_SanPhamCT))
                    {
                        if (ValidateNumericInt(tb_SoLuong_SanPham))
                        {

                            if (ValidatePositiveInteger(tb_SoLuong_SanPham, tb_Gia_SanPhamCT))
                            {
                                string maspct = tb_MaSPCT.Text.ToString();
                                string idSP = cb_SanPham_SanPhamChiTiet.SelectedValue.ToString();
                                string idMauSac = cb_MauSac_SanPhamChiTiet.SelectedValue.ToString();
                                string idKichCo = cb_KichThuoc_SanPhamChiTiet.SelectedValue.ToString();
                                int soLuong = Convert.ToInt32(tb_SoLuong_SanPham.Text);
                                decimal gia = Convert.ToDecimal(tb_Gia_SanPhamCT.Text);
                                string kq = sanPhamChiTietServices.CNSua(maspct, idSP, idMauSac, idKichCo, soLuong, gia);
                                MessageBox.Show(kq);
                                List<SanPhamChiTiet> sanPhamChiTiets = sanPhamChiTietServices.CNShow();
                                ShowSanPhamCT(sanPhamChiTiets);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Dữ liệu nhập phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số lượng sản phẩm phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Số lượng và giá sản phẩm phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }



        private void btn_LamMoi_SanPhamChiTiet_Click(object sender, EventArgs e)
        {
            tb_MaSPCT.Clear();
            tb_SoLuong_SanPham.Clear();
            tb_Gia_SanPhamCT.Clear();
            LoadSanPhamCT();
            return;
        }

        private void cb_KíchThuoc_SPCT_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_SanPhamChiTiet.Rows.Clear();

            // Kiểm tra nếu SelectedValue không null và có kiểu Guid
            if (cb_KíchThuoc_SPCT_Loc.SelectedValue != null && cb_KíchThuoc_SPCT_Loc.SelectedValue is Guid)
            {
                Guid maKichThuoc = (Guid)cb_KíchThuoc_SPCT_Loc.SelectedValue;
                List<SanPhamChiTiet> sanPhamChiTiets = sanPhamChiTietServices.GetSPCTByKichCo(maKichThuoc);
                ShowSanPhamCT(sanPhamChiTiets);
            }
        }

        private void cb_MauSac_SPCT_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_SanPhamChiTiet.Rows.Clear();

            // Kiểm tra nếu SelectedValue không null và có kiểu Guid
            if (cb_MauSac_SPCT_Loc.SelectedValue != null && cb_MauSac_SPCT_Loc.SelectedValue is Guid)
            {
                Guid maMauSac = (Guid)cb_MauSac_SPCT_Loc.SelectedValue;
                List<SanPhamChiTiet> sanPhamChiTiets = sanPhamChiTietServices.GetSPCTByMauSac(maMauSac);
                ShowSanPhamCT(sanPhamChiTiets);
            }
        }

        private void cb_SanPham_SPCT_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_SanPhamChiTiet.Rows.Clear();

            // Kiểm tra nếu SelectedValue không null và có kiểu Guid
            if (cb_SanPham_SPCT_Loc.SelectedValue != null && cb_SanPham_SPCT_Loc.SelectedValue is Guid)
            {
                Guid maSP = (Guid)cb_SanPham_SPCT_Loc.SelectedValue;
                List<SanPhamChiTiet> sanPhamChiTiets = sanPhamChiTietServices.GetSPCTBySanPham(maSP);
                ShowSanPhamCT(sanPhamChiTiets);
            }
        }

        //validates

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


        public static bool ValidatePositiveInteger(params TextBox[] textboxes)
        {
            foreach (var textbox in textboxes)
            {
                if (!IsPositiveInteger(textbox.Text))
                {
                    return false; // Trả về false nếu bất kỳ TextBox nào không chứa giá trị số nguyên dương
                }
            }
            return true; // Trả về true nếu tất cả các TextBox đều chứa giá trị số nguyên dương
        }

        // Hàm kiểm tra xem chuỗi có phải là số nguyên dương không
        private static bool IsPositiveInteger(string value)
        {
            if (float.TryParse(value, out float number))
            {
                return number > 0; // Kiểm tra xem số nguyên có lớn hơn 0 không
            }
            return false; // Không phải số nguyên dương
        }





        private void btn_TaoMaQR_Click(object sender, EventArgs e)
        {
            //lay noi dung tu textbox
            string sanphamCode = tb_MaSPCT.Text;
            // Kiểm tra nội dung không rỗng
            if (string.IsNullOrWhiteSpace(sanphamCode))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Hiển thị hộp thoại chọn thư mục
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn thư mục
                    string selectedPath = folderDialog.SelectedPath;

                    // Tạo QR code
                    using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                    {
                        QRCodeData qrCodeData = qrGenerator.CreateQrCode(sanphamCode, QRCodeGenerator.ECCLevel.Q);
                        using (QRCode qrCode = new QRCode(qrCodeData))
                        {
                            using (Bitmap qrCodeImage = qrCode.GetGraphic(20))
                            {
                                // Đặt tên file QR code
                                string qrCodeFileName = $"{sanphamCode}.png";
                                string qrCodeFilePath = Path.Combine(selectedPath, qrCodeFileName);

                                // Lưu hình ảnh QR code vào thư mục đã chọn
                                qrCodeImage.Save(qrCodeFilePath, System.Drawing.Imaging.ImageFormat.Png);

                                MessageBox.Show($"QR code đã được lưu tại: {qrCodeFilePath}");
                            }
                        }
                    }
                }
            }
        }
    }
}
