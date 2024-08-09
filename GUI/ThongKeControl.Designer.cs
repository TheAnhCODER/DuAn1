namespace GUI
{
    partial class ThongKeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeControl));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            txt_doanhthu_ThongKe = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            txt_hoadon_ThongKe = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            txt_sanpham_ThongKe = new TextBox();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            txt_khachhang_ThongKe = new TextBox();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            pn_timtheokhoang_ThongKe = new Panel();
            label6 = new Label();
            label7 = new Label();
            btn_timKiem_ThongKe = new Button();
            date_ngaybatdau_ThongKe = new DateTimePicker();
            date_ngayketthuc_ThongKe = new DateTimePicker();
            groupBox2 = new GroupBox();
            dgv_loadsanpham_ThongKe = new DataGridView();
            cb_Nam = new ComboBox();
            cb_Thang = new ComboBox();
            rb_timtheokhoang_ThongKe = new RadioButton();
            rb_nam_ThongKe = new RadioButton();
            rb_thang_ThongKe = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox1.SuspendLayout();
            pn_timtheokhoang_ThongKe.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_loadsanpham_ThongKe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(368, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 0;
            label1.Text = "Thống Kê";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(821, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 135, 209);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 44);
            panel1.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(117, 35);
            panel6.Name = "panel6";
            panel6.Size = new Size(626, 1);
            panel6.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 135, 209);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txt_doanhthu_ThongKe);
            panel2.Location = new Point(27, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(182, 119);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(63, 19);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 7;
            label2.Text = "Doanh thu";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // txt_doanhthu_ThongKe
            // 
            txt_doanhthu_ThongKe.BackColor = Color.FromArgb(29, 135, 209);
            txt_doanhthu_ThongKe.BorderStyle = BorderStyle.None;
            txt_doanhthu_ThongKe.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txt_doanhthu_ThongKe.ForeColor = Color.White;
            txt_doanhthu_ThongKe.Location = new Point(14, 73);
            txt_doanhthu_ThongKe.Name = "txt_doanhthu_ThongKe";
            txt_doanhthu_ThongKe.ReadOnly = true;
            txt_doanhthu_ThongKe.Size = new Size(149, 26);
            txt_doanhthu_ThongKe.TabIndex = 8;
            txt_doanhthu_ThongKe.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(29, 135, 209);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(txt_hoadon_ThongKe);
            panel3.Location = new Point(235, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(182, 119);
            panel3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 19);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 8;
            label3.Text = "Hoá đơn";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // txt_hoadon_ThongKe
            // 
            txt_hoadon_ThongKe.BackColor = Color.FromArgb(29, 135, 209);
            txt_hoadon_ThongKe.BorderStyle = BorderStyle.None;
            txt_hoadon_ThongKe.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txt_hoadon_ThongKe.ForeColor = Color.White;
            txt_hoadon_ThongKe.Location = new Point(16, 73);
            txt_hoadon_ThongKe.Name = "txt_hoadon_ThongKe";
            txt_hoadon_ThongKe.ReadOnly = true;
            txt_hoadon_ThongKe.Size = new Size(149, 26);
            txt_hoadon_ThongKe.TabIndex = 9;
            txt_hoadon_ThongKe.TextAlign = HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(29, 135, 209);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txt_sanpham_ThongKe);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(443, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(182, 119);
            panel4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, 19);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 9;
            label4.Text = "Sản phẩm đã bán";
            // 
            // txt_sanpham_ThongKe
            // 
            txt_sanpham_ThongKe.BackColor = Color.FromArgb(29, 135, 209);
            txt_sanpham_ThongKe.BorderStyle = BorderStyle.None;
            txt_sanpham_ThongKe.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txt_sanpham_ThongKe.ForeColor = Color.White;
            txt_sanpham_ThongKe.Location = new Point(17, 73);
            txt_sanpham_ThongKe.Name = "txt_sanpham_ThongKe";
            txt_sanpham_ThongKe.ReadOnly = true;
            txt_sanpham_ThongKe.Size = new Size(149, 26);
            txt_sanpham_ThongKe.TabIndex = 10;
            txt_sanpham_ThongKe.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(8, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(29, 135, 209);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txt_khachhang_ThongKe);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(655, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(182, 119);
            panel5.TabIndex = 6;
            // 
            // txt_khachhang_ThongKe
            // 
            txt_khachhang_ThongKe.BackColor = Color.FromArgb(29, 135, 209);
            txt_khachhang_ThongKe.BorderStyle = BorderStyle.None;
            txt_khachhang_ThongKe.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txt_khachhang_ThongKe.ForeColor = Color.White;
            txt_khachhang_ThongKe.Location = new Point(19, 73);
            txt_khachhang_ThongKe.Name = "txt_khachhang_ThongKe";
            txt_khachhang_ThongKe.ReadOnly = true;
            txt_khachhang_ThongKe.Size = new Size(149, 26);
            txt_khachhang_ThongKe.TabIndex = 11;
            txt_khachhang_ThongKe.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(10, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(55, 19);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 10;
            label5.Text = "Lượt khách mua";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(pn_timtheokhoang_ThongKe);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cb_Nam);
            groupBox1.Controls.Add(cb_Thang);
            groupBox1.Controls.Add(rb_timtheokhoang_ThongKe);
            groupBox1.Controls.Add(rb_nam_ThongKe);
            groupBox1.Controls.Add(rb_thang_ThongKe);
            groupBox1.Location = new Point(9, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 409);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kê theo thời gian";
            // 
            // pn_timtheokhoang_ThongKe
            // 
            pn_timtheokhoang_ThongKe.Controls.Add(label6);
            pn_timtheokhoang_ThongKe.Controls.Add(label7);
            pn_timtheokhoang_ThongKe.Controls.Add(btn_timKiem_ThongKe);
            pn_timtheokhoang_ThongKe.Controls.Add(date_ngaybatdau_ThongKe);
            pn_timtheokhoang_ThongKe.Controls.Add(date_ngayketthuc_ThongKe);
            pn_timtheokhoang_ThongKe.Location = new Point(275, 22);
            pn_timtheokhoang_ThongKe.Name = "pn_timtheokhoang_ThongKe";
            pn_timtheokhoang_ThongKe.Size = new Size(408, 91);
            pn_timtheokhoang_ThongKe.TabIndex = 12;
            pn_timtheokhoang_ThongKe.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 20);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 6;
            label6.Text = "Ngày bắt đầu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 58);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 7;
            label7.Text = "Ngày kết thúc";
            // 
            // btn_timKiem_ThongKe
            // 
            btn_timKiem_ThongKe.BackColor = Color.FromArgb(29, 135, 209);
            btn_timKiem_ThongKe.FlatStyle = FlatStyle.Flat;
            btn_timKiem_ThongKe.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_timKiem_ThongKe.ForeColor = Color.White;
            btn_timKiem_ThongKe.Location = new Point(316, 31);
            btn_timKiem_ThongKe.Name = "btn_timKiem_ThongKe";
            btn_timKiem_ThongKe.Size = new Size(90, 34);
            btn_timKiem_ThongKe.TabIndex = 10;
            btn_timKiem_ThongKe.Text = "Tìm kiếm";
            btn_timKiem_ThongKe.UseVisualStyleBackColor = false;
            btn_timKiem_ThongKe.Click += btn_timKiem_ThongKe_Click;
            // 
            // date_ngaybatdau_ThongKe
            // 
            date_ngaybatdau_ThongKe.Location = new Point(115, 14);
            date_ngaybatdau_ThongKe.Name = "date_ngaybatdau_ThongKe";
            date_ngaybatdau_ThongKe.Size = new Size(181, 23);
            date_ngaybatdau_ThongKe.TabIndex = 9;
            // 
            // date_ngayketthuc_ThongKe
            // 
            date_ngayketthuc_ThongKe.Location = new Point(115, 52);
            date_ngayketthuc_ThongKe.Name = "date_ngayketthuc_ThongKe";
            date_ngayketthuc_ThongKe.Size = new Size(181, 23);
            date_ngayketthuc_ThongKe.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_loadsanpham_ThongKe);
            groupBox2.Location = new Point(6, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(844, 273);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm";
            // 
            // dgv_loadsanpham_ThongKe
            // 
            dgv_loadsanpham_ThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_loadsanpham_ThongKe.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_loadsanpham_ThongKe.Location = new Point(9, 21);
            dgv_loadsanpham_ThongKe.Name = "dgv_loadsanpham_ThongKe";
            dgv_loadsanpham_ThongKe.ReadOnly = true;
            dgv_loadsanpham_ThongKe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_loadsanpham_ThongKe.Size = new Size(829, 246);
            dgv_loadsanpham_ThongKe.TabIndex = 0;
            // 
            // cb_Nam
            // 
            cb_Nam.BackColor = Color.White;
            cb_Nam.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Nam.FormattingEnabled = true;
            cb_Nam.Location = new Point(148, 33);
            cb_Nam.Name = "cb_Nam";
            cb_Nam.Size = new Size(121, 23);
            cb_Nam.TabIndex = 4;
            cb_Nam.Visible = false;
            cb_Nam.SelectedIndexChanged += cb_Nam_SelectedIndexChanged;
            // 
            // cb_Thang
            // 
            cb_Thang.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Thang.FormattingEnabled = true;
            cb_Thang.Location = new Point(148, 33);
            cb_Thang.Name = "cb_Thang";
            cb_Thang.Size = new Size(121, 23);
            cb_Thang.TabIndex = 3;
            cb_Thang.Visible = false;
            cb_Thang.SelectedIndexChanged += cb_Thang_SelectedIndexChanged;
            // 
            // rb_timtheokhoang_ThongKe
            // 
            rb_timtheokhoang_ThongKe.AutoSize = true;
            rb_timtheokhoang_ThongKe.Location = new Point(34, 81);
            rb_timtheokhoang_ThongKe.Name = "rb_timtheokhoang_ThongKe";
            rb_timtheokhoang_ThongKe.Size = new Size(115, 19);
            rb_timtheokhoang_ThongKe.TabIndex = 2;
            rb_timtheokhoang_ThongKe.TabStop = true;
            rb_timtheokhoang_ThongKe.Text = "Tìm theo khoảng";
            rb_timtheokhoang_ThongKe.UseVisualStyleBackColor = true;
            rb_timtheokhoang_ThongKe.CheckedChanged += rb_timtheokhoang_ThongKe_CheckedChanged;
            // 
            // rb_nam_ThongKe
            // 
            rb_nam_ThongKe.AutoSize = true;
            rb_nam_ThongKe.Location = new Point(34, 56);
            rb_nam_ThongKe.Name = "rb_nam_ThongKe";
            rb_nam_ThongKe.Size = new Size(51, 19);
            rb_nam_ThongKe.TabIndex = 1;
            rb_nam_ThongKe.TabStop = true;
            rb_nam_ThongKe.Text = "Năm";
            rb_nam_ThongKe.UseVisualStyleBackColor = true;
            rb_nam_ThongKe.CheckedChanged += rb_nam_ThongKe_CheckedChanged;
            // 
            // rb_thang_ThongKe
            // 
            rb_thang_ThongKe.AutoSize = true;
            rb_thang_ThongKe.Location = new Point(33, 33);
            rb_thang_ThongKe.Name = "rb_thang_ThongKe";
            rb_thang_ThongKe.Size = new Size(58, 19);
            rb_thang_ThongKe.TabIndex = 0;
            rb_thang_ThongKe.TabStop = true;
            rb_thang_ThongKe.Text = "Tháng";
            rb_thang_ThongKe.UseVisualStyleBackColor = true;
            rb_thang_ThongKe.CheckedChanged += rb_thang_ThongKe_CheckedChanged;
            // 
            // ThongKeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ThongKeControl";
            Size = new Size(868, 628);
            Load += ThongKeControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pn_timtheokhoang_ThongKe.ResumeLayout(false);
            pn_timtheokhoang_ThongKe.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_loadsanpham_ThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel6;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label5;
        private GroupBox groupBox1;
        private Button btn_timKiem_ThongKe;
        private DateTimePicker date_ngaybatdau_ThongKe;
        private DateTimePicker date_ngayketthuc_ThongKe;
        private Label label7;
        private Label label6;
        private ComboBox cb_Nam;
        private ComboBox cb_Thang;
        private RadioButton rb_timtheokhoang_ThongKe;
        private RadioButton rb_nam_ThongKe;
        private RadioButton rb_thang_ThongKe;
        private GroupBox groupBox2;
        private DataGridView dgv_loadsanpham_ThongKe;
        private TextBox txt_doanhthu_ThongKe;
        private TextBox txt_hoadon_ThongKe;
        private TextBox txt_sanpham_ThongKe;
        private TextBox txt_khachhang_ThongKe;
        private Panel pn_timtheokhoang_ThongKe;
    }
}
