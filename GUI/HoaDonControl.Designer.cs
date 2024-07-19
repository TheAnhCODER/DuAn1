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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
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
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(-2, 10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "    Tìm kiếm tại đây ...";
            textBox1.Size = new Size(234, 28);
            textBox1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBox1);
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
            label3.Size = new Size(125, 20);
            label3.TabIndex = 9;
            label3.Text = "Ngày thanh toán";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 31);
            comboBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(263, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 30);
            dateTimePicker1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(4, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 226);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hoá đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(845, 198);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(6, 383);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(859, 242);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hoá đơn chi tiết";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(8, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(845, 214);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(comboBox1);
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
            // HoaDonControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "HoaDonControl";
            Size = new Size(868, 628);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private TextBox textBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}
