namespace GUI
{
    partial class HoaDonControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            txt_timkiem_HoaDon = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            cb_trangthai_HoaDon = new ComboBox();
            dateTime_ngaytaohoadon_HoaDon = new DateTimePicker();
            groupBox1 = new GroupBox();
            dgv_hoadon_HoaDon = new DataGridView();
            groupBox2 = new GroupBox();
            dgv_hoadonchitiet_HoaDon = new DataGridView();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            btn_TimKiem = new Button();
            dtp_NgayKetThuc = new DateTimePicker();
            dtp_NgayBatDau = new DateTimePicker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_hoadon_HoaDon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_hoadonchitiet_HoaDon).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(821, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 135, 209);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 44);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(120, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(626, 1);
            panel4.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(360, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 5;
            label1.Text = "Hoá đơn";
            // 
            // txt_timkiem_HoaDon
            // 
            txt_timkiem_HoaDon.BorderStyle = BorderStyle.None;
            txt_timkiem_HoaDon.Location = new Point(-2, 10);
            txt_timkiem_HoaDon.Multiline = true;
            txt_timkiem_HoaDon.Name = "txt_timkiem_HoaDon";
            txt_timkiem_HoaDon.PlaceholderText = "    Tìm kiếm tại đây ...";
            txt_timkiem_HoaDon.Size = new Size(234, 28);
            txt_timkiem_HoaDon.TabIndex = 5;
            txt_timkiem_HoaDon.TextChanged += txt_timkiem_HoaDon_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txt_timkiem_HoaDon);
            panel2.Location = new Point(22, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 39);
            panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(277, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 19);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(317, 19);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 9;
            label3.Text = "Ngày tạo hoá đơn";
            // 
            // cb_trangthai_HoaDon
            // 
            cb_trangthai_HoaDon.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_trangthai_HoaDon.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_trangthai_HoaDon.FormattingEnabled = true;
            cb_trangthai_HoaDon.Location = new Point(15, 44);
            cb_trangthai_HoaDon.Name = "cb_trangthai_HoaDon";
            cb_trangthai_HoaDon.Size = new Size(214, 31);
            cb_trangthai_HoaDon.TabIndex = 10;
            cb_trangthai_HoaDon.SelectedIndexChanged += cb_trangthai_HoaDon_SelectedIndexChanged;
            // 
            // dateTime_ngaytaohoadon_HoaDon
            // 
            dateTime_ngaytaohoadon_HoaDon.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTime_ngaytaohoadon_HoaDon.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTime_ngaytaohoadon_HoaDon.Location = new Point(263, 45);
            dateTime_ngaytaohoadon_HoaDon.Name = "dateTime_ngaytaohoadon_HoaDon";
            dateTime_ngaytaohoadon_HoaDon.Size = new Size(231, 30);
            dateTime_ngaytaohoadon_HoaDon.TabIndex = 11;
            dateTime_ngaytaohoadon_HoaDon.ValueChanged += dateTime_ngaytaohoadon_HoaDon_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_hoadon_HoaDon);
            groupBox1.Location = new Point(6, 230);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 189);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hoá đơn";
            // 
            // dgv_hoadon_HoaDon
            // 
            dgv_hoadon_HoaDon.AllowUserToAddRows = false;
            dgv_hoadon_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_hoadon_HoaDon.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_hoadon_HoaDon.Location = new Point(10, 22);
            dgv_hoadon_HoaDon.Name = "dgv_hoadon_HoaDon";
            dgv_hoadon_HoaDon.ReadOnly = true;
            dgv_hoadon_HoaDon.RowHeadersWidth = 51;
            dgv_hoadon_HoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_hoadon_HoaDon.Size = new Size(845, 161);
            dgv_hoadon_HoaDon.TabIndex = 0;
            dgv_hoadon_HoaDon.CellClick += dgv_hoadon_HoaDon_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_hoadonchitiet_HoaDon);
            groupBox2.Location = new Point(6, 424);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(859, 200);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hoá đơn chi tiết";
            // 
            // dgv_hoadonchitiet_HoaDon
            // 
            dgv_hoadonchitiet_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_hoadonchitiet_HoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_hoadonchitiet_HoaDon.Location = new Point(8, 22);
            dgv_hoadonchitiet_HoaDon.Name = "dgv_hoadonchitiet_HoaDon";
            dgv_hoadonchitiet_HoaDon.ReadOnly = true;
            dgv_hoadonchitiet_HoaDon.RowHeadersWidth = 51;
            dgv_hoadonchitiet_HoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_hoadonchitiet_HoaDon.Size = new Size(845, 172);
            dgv_hoadonchitiet_HoaDon.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dateTime_ngaytaohoadon_HoaDon);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cb_trangthai_HoaDon);
            groupBox3.Location = new Point(6, 60);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(513, 91);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lọc hoá đơn";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel2);
            groupBox4.Controls.Add(pictureBox2);
            groupBox4.Location = new Point(525, 60);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(342, 91);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(btn_TimKiem);
            groupBox5.Controls.Add(dtp_NgayKetThuc);
            groupBox5.Controls.Add(dtp_NgayBatDau);
            groupBox5.Location = new Point(6, 157);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(678, 67);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tìm kiếm hóa đơn theo khoảng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 19);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 4;
            label5.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 19);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Ngày kết thúc";
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.BackColor = Color.FromArgb(29, 135, 209);
            btn_TimKiem.FlatStyle = FlatStyle.Flat;
            btn_TimKiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TimKiem.ForeColor = Color.White;
            btn_TimKiem.Location = new Point(563, 19);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(75, 39);
            btn_TimKiem.TabIndex = 2;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = false;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // dtp_NgayKetThuc
            // 
            dtp_NgayKetThuc.Location = new Point(311, 38);
            dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            dtp_NgayKetThuc.Size = new Size(200, 23);
            dtp_NgayKetThuc.TabIndex = 1;
            dtp_NgayKetThuc.ValueChanged += dtp_NgayKetThuc_ValueChanged;
            // 
            // dtp_NgayBatDau
            // 
            dtp_NgayBatDau.Location = new Point(51, 38);
            dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            dtp_NgayBatDau.Size = new Size(200, 23);
            dtp_NgayBatDau.TabIndex = 0;
            dtp_NgayBatDau.ValueChanged += dtp_NgayBatDau_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(29, 135, 209);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(725, 166);
            button1.Name = "button1";
            button1.Size = new Size(103, 58);
            button1.TabIndex = 16;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HoaDonControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "HoaDonControl";
            Size = new Size(868, 628);
            Load += HoaDonControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_hoadon_HoaDon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_hoadonchitiet_HoaDon).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private TextBox txt_timkiem_HoaDon;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private ComboBox cb_trangthai_HoaDon;
        private DateTimePicker dateTime_ngaytaohoadon_HoaDon;
        private GroupBox groupBox1;
        private DataGridView dgv_hoadon_HoaDon;
        private GroupBox groupBox2;
        private DataGridView dgv_hoadonchitiet_HoaDon;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label5;
        private Label label4;
        private Button btn_TimKiem;
        private DateTimePicker dtp_NgayKetThuc;
        private DateTimePicker dtp_NgayBatDau;
        private Button button1;
    }
}
