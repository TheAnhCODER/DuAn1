namespace GUI
{
    partial class GiamGiaSanPham
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
            btn_BoChon = new Button();
            btn_chon = new Button();
            dgv_DanhSachSPKhuyenMai = new DataGridView();
            button1 = new Button();
            rb_vnd = new RadioButton();
            rb_phantram = new RadioButton();
            tb_giatrigiam = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachSPKhuyenMai).BeginInit();
            SuspendLayout();
            // 
            // btn_BoChon
            // 
            btn_BoChon.BackColor = Color.FromArgb(29, 135, 209);
            btn_BoChon.FlatStyle = FlatStyle.Flat;
            btn_BoChon.ForeColor = Color.White;
            btn_BoChon.Location = new Point(118, 23);
            btn_BoChon.Name = "btn_BoChon";
            btn_BoChon.Size = new Size(93, 42);
            btn_BoChon.TabIndex = 22;
            btn_BoChon.Text = "Bỏ chọn tất cả";
            btn_BoChon.UseVisualStyleBackColor = false;
            btn_BoChon.Click += btn_BoChon_Click;
            // 
            // btn_chon
            // 
            btn_chon.BackColor = Color.FromArgb(29, 135, 209);
            btn_chon.FlatStyle = FlatStyle.Flat;
            btn_chon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_chon.ForeColor = Color.White;
            btn_chon.Location = new Point(12, 23);
            btn_chon.Name = "btn_chon";
            btn_chon.Size = new Size(90, 42);
            btn_chon.TabIndex = 21;
            btn_chon.Text = "Chọn tất cả";
            btn_chon.UseVisualStyleBackColor = false;
            btn_chon.Click += btn_chon_Click;
            // 
            // dgv_DanhSachSPKhuyenMai
            // 
            dgv_DanhSachSPKhuyenMai.AllowUserToAddRows = false;
            dgv_DanhSachSPKhuyenMai.BackgroundColor = Color.White;
            dgv_DanhSachSPKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachSPKhuyenMai.GridColor = SystemColors.ActiveBorder;
            dgv_DanhSachSPKhuyenMai.Location = new Point(3, 95);
            dgv_DanhSachSPKhuyenMai.Name = "dgv_DanhSachSPKhuyenMai";
            dgv_DanhSachSPKhuyenMai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhSachSPKhuyenMai.Size = new Size(567, 343);
            dgv_DanhSachSPKhuyenMai.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(482, 12);
            button1.Name = "button1";
            button1.Size = new Size(88, 64);
            button1.TabIndex = 23;
            button1.Text = "Cập nhật sản phẩm khuyến mại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rb_vnd
            // 
            rb_vnd.AutoSize = true;
            rb_vnd.Location = new Point(277, 23);
            rb_vnd.Name = "rb_vnd";
            rb_vnd.Size = new Size(49, 19);
            rb_vnd.TabIndex = 24;
            rb_vnd.TabStop = true;
            rb_vnd.Text = "VND";
            rb_vnd.UseVisualStyleBackColor = true;
            // 
            // rb_phantram
            // 
            rb_phantram.AutoSize = true;
            rb_phantram.Location = new Point(342, 23);
            rb_phantram.Name = "rb_phantram";
            rb_phantram.Size = new Size(35, 19);
            rb_phantram.TabIndex = 25;
            rb_phantram.TabStop = true;
            rb_phantram.Text = "%";
            rb_phantram.UseVisualStyleBackColor = true;
            // 
            // tb_giatrigiam
            // 
            tb_giatrigiam.Location = new Point(277, 53);
            tb_giatrigiam.Name = "tb_giatrigiam";
            tb_giatrigiam.Size = new Size(100, 23);
            tb_giatrigiam.TabIndex = 26;
            // 
            // GiamGiaSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 443);
            Controls.Add(tb_giatrigiam);
            Controls.Add(rb_phantram);
            Controls.Add(rb_vnd);
            Controls.Add(button1);
            Controls.Add(btn_BoChon);
            Controls.Add(btn_chon);
            Controls.Add(dgv_DanhSachSPKhuyenMai);
            Name = "GiamGiaSanPham";
            Text = "GiamGiaSanPham";
            Load += GiamGiaSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachSPKhuyenMai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_BoChon;
        private Button btn_chon;
        private DataGridView dgv_DanhSachSPKhuyenMai;
        private Button button1;
        private RadioButton rb_vnd;
        private RadioButton rb_phantram;
        private TextBox tb_giatrigiam;
    }
}