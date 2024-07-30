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
            pictureBox3 = new PictureBox();
            txt_timkiemtheongay_HoaDon = new TextBox();
            groupBox6 = new GroupBox();
            pictureBox4 = new PictureBox();
            txt_timkiemtheothang_HoaDon = new TextBox();
            groupBox7 = new GroupBox();
            pictureBox5 = new PictureBox();
            txt_timkiemtheonam_HoaDon = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 59);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(137, 47);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(715, 1);
            panel4.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(411, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 5;
            label1.Text = "Hoá đơn";
            // 
            // txt_timkiem_HoaDon
            // 
            txt_timkiem_HoaDon.BorderStyle = BorderStyle.None;
            txt_timkiem_HoaDon.Location = new Point(-2, 13);
            txt_timkiem_HoaDon.Margin = new Padding(3, 4, 3, 4);
            txt_timkiem_HoaDon.Multiline = true;
            txt_timkiem_HoaDon.Name = "txt_timkiem_HoaDon";
            txt_timkiem_HoaDon.PlaceholderText = "    Tìm kiếm tại đây ...";
            txt_timkiem_HoaDon.Size = new Size(267, 37);
            txt_timkiem_HoaDon.TabIndex = 5;
            txt_timkiem_HoaDon.TextChanged += txt_timkiem_HoaDon_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txt_timkiem_HoaDon);
            panel2.Location = new Point(25, 48);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 51);
            panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(317, 48);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 25);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 8;
            label2.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(362, 25);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 9;
            label3.Text = "Ngày tạo hoá đơn";
            // 
            // cb_trangthai_HoaDon
            // 
            cb_trangthai_HoaDon.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_trangthai_HoaDon.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_trangthai_HoaDon.FormattingEnabled = true;
            cb_trangthai_HoaDon.Location = new Point(17, 59);
            cb_trangthai_HoaDon.Margin = new Padding(3, 4, 3, 4);
            cb_trangthai_HoaDon.Name = "cb_trangthai_HoaDon";
            cb_trangthai_HoaDon.Size = new Size(244, 38);
            cb_trangthai_HoaDon.TabIndex = 10;
            cb_trangthai_HoaDon.SelectedIndexChanged += cb_trangthai_HoaDon_SelectedIndexChanged;
            // 
            // dateTime_ngaytaohoadon_HoaDon
            // 
            dateTime_ngaytaohoadon_HoaDon.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTime_ngaytaohoadon_HoaDon.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTime_ngaytaohoadon_HoaDon.Location = new Point(301, 60);
            dateTime_ngaytaohoadon_HoaDon.Margin = new Padding(3, 4, 3, 4);
            dateTime_ngaytaohoadon_HoaDon.Name = "dateTime_ngaytaohoadon_HoaDon";
            dateTime_ngaytaohoadon_HoaDon.Size = new Size(263, 36);
            dateTime_ngaytaohoadon_HoaDon.TabIndex = 11;
            dateTime_ngaytaohoadon_HoaDon.ValueChanged += dateTime_ngaytaohoadon_HoaDon_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_hoadon_HoaDon);
            groupBox1.Location = new Point(7, 306);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(984, 252);
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
            dgv_hoadon_HoaDon.Location = new Point(11, 29);
            dgv_hoadon_HoaDon.Margin = new Padding(3, 4, 3, 4);
            dgv_hoadon_HoaDon.Name = "dgv_hoadon_HoaDon";
            dgv_hoadon_HoaDon.ReadOnly = true;
            dgv_hoadon_HoaDon.RowHeadersWidth = 51;
            dgv_hoadon_HoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_hoadon_HoaDon.Size = new Size(966, 215);
            dgv_hoadon_HoaDon.TabIndex = 0;
            dgv_hoadon_HoaDon.CellClick += dgv_hoadon_HoaDon_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_hoadonchitiet_HoaDon);
            groupBox2.Location = new Point(7, 566);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(982, 267);
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
            dgv_hoadonchitiet_HoaDon.Location = new Point(9, 29);
            dgv_hoadonchitiet_HoaDon.Margin = new Padding(3, 4, 3, 4);
            dgv_hoadonchitiet_HoaDon.Name = "dgv_hoadonchitiet_HoaDon";
            dgv_hoadonchitiet_HoaDon.ReadOnly = true;
            dgv_hoadonchitiet_HoaDon.RowHeadersWidth = 51;
            dgv_hoadonchitiet_HoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_hoadonchitiet_HoaDon.Size = new Size(966, 229);
            dgv_hoadonchitiet_HoaDon.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dateTime_ngaytaohoadon_HoaDon);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cb_trangthai_HoaDon);
            groupBox3.Location = new Point(7, 80);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(586, 121);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lọc hoá đơn";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel2);
            groupBox4.Controls.Add(pictureBox2);
            groupBox4.Location = new Point(600, 80);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(391, 121);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(pictureBox3);
            groupBox5.Controls.Add(txt_timkiemtheongay_HoaDon);
            groupBox5.Location = new Point(36, 220);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(288, 68);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tìm kiếm theo ngày";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(216, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // txt_timkiemtheongay_HoaDon
            // 
            txt_timkiemtheongay_HoaDon.Location = new Point(6, 30);
            txt_timkiemtheongay_HoaDon.Name = "txt_timkiemtheongay_HoaDon";
            txt_timkiemtheongay_HoaDon.PlaceholderText = "Tìm kiếm ...";
            txt_timkiemtheongay_HoaDon.Size = new Size(204, 27);
            txt_timkiemtheongay_HoaDon.TabIndex = 0;
            txt_timkiemtheongay_HoaDon.TextChanged += txt_timkiemtheongay_HoaDon_TextChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(pictureBox4);
            groupBox6.Controls.Add(txt_timkiemtheothang_HoaDon);
            groupBox6.Location = new Point(358, 220);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(281, 68);
            groupBox6.TabIndex = 17;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tìm kiếm theo tháng";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(216, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // txt_timkiemtheothang_HoaDon
            // 
            txt_timkiemtheothang_HoaDon.Location = new Point(6, 30);
            txt_timkiemtheothang_HoaDon.Name = "txt_timkiemtheothang_HoaDon";
            txt_timkiemtheothang_HoaDon.PlaceholderText = "Tìm kiếm ...";
            txt_timkiemtheothang_HoaDon.Size = new Size(204, 27);
            txt_timkiemtheothang_HoaDon.TabIndex = 0;
            txt_timkiemtheothang_HoaDon.TextChanged += txt_timkiemtheothang_HoaDon_TextChanged;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(pictureBox5);
            groupBox7.Controls.Add(txt_timkiemtheonam_HoaDon);
            groupBox7.Location = new Point(678, 220);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(286, 68);
            groupBox7.TabIndex = 18;
            groupBox7.TabStop = false;
            groupBox7.Text = "Tìm kiếm theo năm";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(217, 18);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // txt_timkiemtheonam_HoaDon
            // 
            txt_timkiemtheonam_HoaDon.Location = new Point(7, 30);
            txt_timkiemtheonam_HoaDon.Name = "txt_timkiemtheonam_HoaDon";
            txt_timkiemtheonam_HoaDon.PlaceholderText = "Tìm kiếm ...";
            txt_timkiemtheonam_HoaDon.Size = new Size(204, 27);
            txt_timkiemtheonam_HoaDon.TabIndex = 0;
            txt_timkiemtheonam_HoaDon.TextChanged += txt_timkiemtheonam_HoaDon_TextChanged;
            // 
            // HoaDonControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HoaDonControl";
            Size = new Size(992, 837);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private PictureBox pictureBox3;
        private TextBox txt_timkiemtheongay_HoaDon;
        private GroupBox groupBox6;
        private TextBox txt_timkiemtheothang_HoaDon;
        private GroupBox groupBox7;
        private TextBox txt_timkiemtheonam_HoaDon;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
