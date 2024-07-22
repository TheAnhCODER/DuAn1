namespace GUI
{
    partial class FormKhachHang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            btn_lammoi = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            tb_diachi = new TextBox();
            tb_ten = new TextBox();
            tb_sdt = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            tb_timkiem = new TextBox();
            dgv_danhsach = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_danhsach).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 135, 209);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 44);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(121, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(626, 1);
            panel4.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(331, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 1;
            label1.Text = "Khách Hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(tb_diachi);
            groupBox1.Controls.Add(tb_ten);
            groupBox1.Controls.Add(tb_sdt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(0, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(852, 225);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thiết lập thông tin khách hàng";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_lammoi);
            panel2.Controls.Add(btn_sua);
            panel2.Controls.Add(btn_them);
            panel2.Location = new Point(134, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 86);
            panel2.TabIndex = 6;
            // 
            // btn_lammoi
            // 
            btn_lammoi.BackColor = Color.FromArgb(29, 135, 209);
            btn_lammoi.Cursor = Cursors.Hand;
            btn_lammoi.FlatStyle = FlatStyle.Flat;
            btn_lammoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_lammoi.ForeColor = Color.White;
            btn_lammoi.Image = (Image)resources.GetObject("btn_lammoi.Image");
            btn_lammoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoi.Location = new Point(406, 25);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(128, 39);
            btn_lammoi.TabIndex = 2;
            btn_lammoi.Text = "     Làm mới";
            btn_lammoi.UseVisualStyleBackColor = false;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // btn_sua
            // 
            btn_sua.BackColor = Color.FromArgb(29, 135, 209);
            btn_sua.Cursor = Cursors.Hand;
            btn_sua.FlatStyle = FlatStyle.Flat;
            btn_sua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_sua.ForeColor = Color.White;
            btn_sua.Image = (Image)resources.GetObject("btn_sua.Image");
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(221, 25);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(128, 39);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "  Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.BackColor = Color.FromArgb(29, 135, 209);
            btn_them.Cursor = Cursors.Hand;
            btn_them.FlatStyle = FlatStyle.Flat;
            btn_them.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_them.ForeColor = Color.White;
            btn_them.Image = (Image)resources.GetObject("btn_them.Image");
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(47, 25);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(128, 39);
            btn_them.TabIndex = 0;
            btn_them.Text = "  Thêm";
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // tb_diachi
            // 
            tb_diachi.Location = new Point(575, 55);
            tb_diachi.Name = "tb_diachi";
            tb_diachi.Size = new Size(182, 23);
            tb_diachi.TabIndex = 5;
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(331, 55);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(182, 23);
            tb_ten.TabIndex = 4;
            // 
            // tb_sdt
            // 
            tb_sdt.Location = new Point(89, 55);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(182, 23);
            tb_sdt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(575, 35);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 2;
            label4.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(331, 35);
            label2.Name = "label2";
            label2.Size = new Size(29, 17);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 35);
            label3.Name = "label3";
            label3.Size = new Size(31, 17);
            label3.TabIndex = 2;
            label3.Text = "SĐT";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(dgv_danhsach);
            groupBox2.Location = new Point(6, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(846, 290);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(737, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(tb_timkiem);
            panel3.Location = new Point(494, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 39);
            panel3.TabIndex = 1;
            // 
            // tb_timkiem
            // 
            tb_timkiem.BorderStyle = BorderStyle.None;
            tb_timkiem.Location = new Point(3, 8);
            tb_timkiem.Multiline = true;
            tb_timkiem.Name = "tb_timkiem";
            tb_timkiem.PlaceholderText = "Tìm kiếm tại đây ...";
            tb_timkiem.Size = new Size(205, 29);
            tb_timkiem.TabIndex = 0;
            tb_timkiem.TextChanged += tb_timkiem_TextChanged;
            // 
            // dgv_danhsach
            // 
            dgv_danhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_danhsach.Location = new Point(6, 77);
            dgv_danhsach.Name = "dgv_danhsach";
            dgv_danhsach.Size = new Size(834, 207);
            dgv_danhsach.TabIndex = 0;
            dgv_danhsach.CellClick += dgv_danhsach_CellClick;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 589);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormKhachHang";
            Text = "FormKhachHang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_danhsach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private GroupBox groupBox1;
        private TextBox tb_diachi;
        private TextBox tb_ten;
        private TextBox tb_sdt;
        private Label label4;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Button btn_lammoi;
        private Button btn_sua;
        private Button btn_them;
        private GroupBox groupBox2;
        private Panel panel3;
        private DataGridView dgv_danhsach;
        private TextBox tb_timkiem;
        private PictureBox pictureBox1;
    }
}