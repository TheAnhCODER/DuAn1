namespace GUI
{
    partial class DanhSachSpGiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachSpGiamGia));
            btn_XoaSp = new Button();
            btn_XoaLuaChon = new Button();
            btn_ChonTatCa = new Button();
            groupBox1 = new GroupBox();
            dgv_DanhSachSp = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachSp).BeginInit();
            SuspendLayout();
            // 
            // btn_XoaSp
            // 
            btn_XoaSp.BackColor = Color.FromArgb(29, 135, 209);
            btn_XoaSp.FlatStyle = FlatStyle.Flat;
            btn_XoaSp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_XoaSp.ForeColor = Color.White;
            btn_XoaSp.Location = new Point(532, 5);
            btn_XoaSp.Name = "btn_XoaSp";
            btn_XoaSp.Size = new Size(122, 53);
            btn_XoaSp.TabIndex = 7;
            btn_XoaSp.Text = "Bỏ khỏi chương trình khuyến mại";
            btn_XoaSp.UseVisualStyleBackColor = false;
            btn_XoaSp.Click += btn_XoaSp_Click;
            // 
            // btn_XoaLuaChon
            // 
            btn_XoaLuaChon.BackColor = Color.FromArgb(29, 135, 209);
            btn_XoaLuaChon.FlatStyle = FlatStyle.Flat;
            btn_XoaLuaChon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_XoaLuaChon.ForeColor = Color.White;
            btn_XoaLuaChon.Location = new Point(104, 6);
            btn_XoaLuaChon.Name = "btn_XoaLuaChon";
            btn_XoaLuaChon.RightToLeft = RightToLeft.No;
            btn_XoaLuaChon.Size = new Size(97, 53);
            btn_XoaLuaChon.TabIndex = 6;
            btn_XoaLuaChon.Text = "Bỏ tất cả";
            btn_XoaLuaChon.UseVisualStyleBackColor = false;
            btn_XoaLuaChon.Click += btn_XoaLuaChon_Click;
            // 
            // btn_ChonTatCa
            // 
            btn_ChonTatCa.BackColor = Color.FromArgb(29, 135, 209);
            btn_ChonTatCa.FlatStyle = FlatStyle.Flat;
            btn_ChonTatCa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ChonTatCa.ForeColor = Color.White;
            btn_ChonTatCa.Location = new Point(1, 6);
            btn_ChonTatCa.Name = "btn_ChonTatCa";
            btn_ChonTatCa.Size = new Size(97, 53);
            btn_ChonTatCa.TabIndex = 5;
            btn_ChonTatCa.Text = "Chọn tất cả";
            btn_ChonTatCa.UseVisualStyleBackColor = false;
            btn_ChonTatCa.Click += btn_ChonTatCa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_DanhSachSp);
            groupBox1.Location = new Point(1, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 397);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgv_DanhSachSp
            // 
            dgv_DanhSachSp.BackgroundColor = Color.White;
            dgv_DanhSachSp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachSp.Location = new Point(6, 22);
            dgv_DanhSachSp.Name = "dgv_DanhSachSp";
            dgv_DanhSachSp.Size = new Size(647, 369);
            dgv_DanhSachSp.TabIndex = 0;
            // 
            // DanhSachSpGiamGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(661, 466);
            Controls.Add(btn_XoaSp);
            Controls.Add(btn_XoaLuaChon);
            Controls.Add(btn_ChonTatCa);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DanhSachSpGiamGia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Danh sách sản phẩm";
            Load += DanhSachSpGiamGia_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachSp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_XoaSp;
        private Button btn_XoaLuaChon;
        private Button btn_ChonTatCa;
        private GroupBox groupBox1;
        private DataGridView dgv_DanhSachSp;
    }
}