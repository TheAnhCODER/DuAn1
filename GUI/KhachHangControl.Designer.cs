namespace GUI
{
    partial class KhachHangControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            btn_lammoi_KhachHang = new Button();
            btn_sua_KhachHang = new Button();
            btn_them_KhachHang = new Button();
            tb_diachi_KhachHang = new TextBox();
            tb_sdt_KhachHang = new TextBox();
            tb_tenkhachhang_KhachHang = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            tb_timkiem_KhachHang = new TextBox();
            groupBox2 = new GroupBox();
            dgv_danhsach_KhachHang = new DataGridView();
            tabPage2 = new TabPage();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            textBox5 = new TextBox();
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_danhsach_KhachHang).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(399, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 41);
            label1.TabIndex = 0;
            label1.Text = "Khách Hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(938, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 135, 209);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 59);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(135, 47);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(715, 1);
            panel4.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(tb_diachi_KhachHang);
            groupBox1.Controls.Add(tb_sdt_KhachHang);
            groupBox1.Controls.Add(tb_tenkhachhang_KhachHang);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 81);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(985, 288);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thiết lập thông tin khách hàng";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_lammoi_KhachHang);
            panel2.Controls.Add(btn_sua_KhachHang);
            panel2.Controls.Add(btn_them_KhachHang);
            panel2.Location = new Point(149, 135);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 114);
            panel2.TabIndex = 6;
            // 
            // btn_lammoi_KhachHang
            // 
            btn_lammoi_KhachHang.BackColor = Color.FromArgb(29, 135, 209);
            btn_lammoi_KhachHang.Cursor = Cursors.Hand;
            btn_lammoi_KhachHang.FlatStyle = FlatStyle.Flat;
            btn_lammoi_KhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_lammoi_KhachHang.ForeColor = Color.White;
            btn_lammoi_KhachHang.Image = (Image)resources.GetObject("btn_lammoi_KhachHang.Image");
            btn_lammoi_KhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoi_KhachHang.Location = new Point(466, 31);
            btn_lammoi_KhachHang.Margin = new Padding(3, 4, 3, 4);
            btn_lammoi_KhachHang.Name = "btn_lammoi_KhachHang";
            btn_lammoi_KhachHang.Size = new Size(146, 51);
            btn_lammoi_KhachHang.TabIndex = 2;
            btn_lammoi_KhachHang.Text = "     Làm mới";
            btn_lammoi_KhachHang.UseVisualStyleBackColor = false;
            btn_lammoi_KhachHang.Click += btn_lammoi_KhachHang_Click;
            // 
            // btn_sua_KhachHang
            // 
            btn_sua_KhachHang.BackColor = Color.FromArgb(29, 135, 209);
            btn_sua_KhachHang.Cursor = Cursors.Hand;
            btn_sua_KhachHang.FlatStyle = FlatStyle.Flat;
            btn_sua_KhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_sua_KhachHang.ForeColor = Color.White;
            btn_sua_KhachHang.Image = (Image)resources.GetObject("btn_sua_KhachHang.Image");
            btn_sua_KhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua_KhachHang.Location = new Point(262, 31);
            btn_sua_KhachHang.Margin = new Padding(3, 4, 3, 4);
            btn_sua_KhachHang.Name = "btn_sua_KhachHang";
            btn_sua_KhachHang.Size = new Size(146, 51);
            btn_sua_KhachHang.TabIndex = 1;
            btn_sua_KhachHang.Text = "   Sửa";
            btn_sua_KhachHang.UseVisualStyleBackColor = false;
            btn_sua_KhachHang.Click += btn_sua_KhachHang_Click;
            // 
            // btn_them_KhachHang
            // 
            btn_them_KhachHang.BackColor = Color.FromArgb(29, 135, 209);
            btn_them_KhachHang.Cursor = Cursors.Hand;
            btn_them_KhachHang.FlatStyle = FlatStyle.Flat;
            btn_them_KhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_them_KhachHang.ForeColor = Color.White;
            btn_them_KhachHang.Image = (Image)resources.GetObject("btn_them_KhachHang.Image");
            btn_them_KhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them_KhachHang.Location = new Point(54, 29);
            btn_them_KhachHang.Margin = new Padding(3, 4, 3, 4);
            btn_them_KhachHang.Name = "btn_them_KhachHang";
            btn_them_KhachHang.Size = new Size(146, 52);
            btn_them_KhachHang.TabIndex = 0;
            btn_them_KhachHang.Text = "   Thêm";
            btn_them_KhachHang.UseVisualStyleBackColor = false;
            btn_them_KhachHang.Click += btn_them_KhachHang_Click;
            // 
            // tb_diachi_KhachHang
            // 
            tb_diachi_KhachHang.Location = new Point(670, 73);
            tb_diachi_KhachHang.Margin = new Padding(3, 4, 3, 4);
            tb_diachi_KhachHang.Name = "tb_diachi_KhachHang";
            tb_diachi_KhachHang.Size = new Size(207, 27);
            tb_diachi_KhachHang.TabIndex = 5;
            // 
            // tb_sdt_KhachHang
            // 
            tb_sdt_KhachHang.Location = new Point(81, 77);
            tb_sdt_KhachHang.Margin = new Padding(3, 4, 3, 4);
            tb_sdt_KhachHang.Name = "tb_sdt_KhachHang";
            tb_sdt_KhachHang.Size = new Size(207, 27);
            tb_sdt_KhachHang.TabIndex = 4;
            // 
            // tb_tenkhachhang_KhachHang
            // 
            tb_tenkhachhang_KhachHang.Location = new Point(374, 76);
            tb_tenkhachhang_KhachHang.Margin = new Padding(3, 4, 3, 4);
            tb_tenkhachhang_KhachHang.Name = "tb_tenkhachhang_KhachHang";
            tb_tenkhachhang_KhachHang.Size = new Size(207, 27);
            tb_tenkhachhang_KhachHang.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(670, 48);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 2;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 52);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 1;
            label3.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(374, 48);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 392);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(983, 441);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(975, 408);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Danh sách khách hàng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(830, 29);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(tb_timkiem_KhachHang);
            panel3.Location = new Point(552, 29);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 51);
            panel3.TabIndex = 1;
            // 
            // tb_timkiem_KhachHang
            // 
            tb_timkiem_KhachHang.BorderStyle = BorderStyle.None;
            tb_timkiem_KhachHang.Location = new Point(3, 11);
            tb_timkiem_KhachHang.Margin = new Padding(3, 4, 3, 4);
            tb_timkiem_KhachHang.Multiline = true;
            tb_timkiem_KhachHang.Name = "tb_timkiem_KhachHang";
            tb_timkiem_KhachHang.PlaceholderText = "Tìm kiếm tại đây ...";
            tb_timkiem_KhachHang.Size = new Size(234, 39);
            tb_timkiem_KhachHang.TabIndex = 0;
            tb_timkiem_KhachHang.TextChanged += tb_timkiem_KhachHang_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_danhsach_KhachHang);
            groupBox2.Location = new Point(6, 89);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(961, 307);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dgv_danhsach_KhachHang
            // 
            dgv_danhsach_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_danhsach_KhachHang.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_danhsach_KhachHang.Location = new Point(7, 32);
            dgv_danhsach_KhachHang.Margin = new Padding(3, 4, 3, 4);
            dgv_danhsach_KhachHang.Name = "dgv_danhsach_KhachHang";
            dgv_danhsach_KhachHang.ReadOnly = true;
            dgv_danhsach_KhachHang.RowHeadersWidth = 51;
            dgv_danhsach_KhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_danhsach_KhachHang.Size = new Size(947, 267);
            dgv_danhsach_KhachHang.TabIndex = 0;
            dgv_danhsach_KhachHang.CellClick += dgv_danhsach_KhachHang_CellClick;
            dgv_danhsach_KhachHang.CellContentDoubleClick += dgv_danhsach_KhachHang_CellContentDoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(975, 408);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lịch sử mua hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(831, 25);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Window;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(textBox5);
            panel5.Location = new Point(551, 25);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 51);
            panel5.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(3, 11);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Tìm kiếm tại đây ...";
            textBox5.Size = new Size(234, 39);
            textBox5.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Location = new Point(6, 85);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(961, 311);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(7, 32);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(947, 271);
            dataGridView2.TabIndex = 0;
            // 
            // KhachHangControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KhachHangControl";
            Size = new Size(992, 837);
            Load += KhachHangControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_danhsach_KhachHang).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel4;
        private GroupBox groupBox1;
        private TextBox tb_diachi_KhachHang;
        private TextBox tb_sdt_KhachHang;
        private TextBox tb_tenkhachhang_KhachHang;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Button btn_lammoi_KhachHang;
        private Button btn_sua_KhachHang;
        private Button btn_them_KhachHang;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel3;
        private GroupBox groupBox2;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private PictureBox pictureBox2;
        private TextBox tb_timkiem_KhachHang;
        private DataGridView dgv_danhsach_KhachHang;
        private Panel panel5;
        private TextBox textBox5;
        private PictureBox pictureBox3;
        private DataGridView dataGridView2;
    }
}
