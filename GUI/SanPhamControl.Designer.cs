namespace GUI
{
    partial class SanPhamControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPhamControl));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            button4 = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button6 = new Button();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox5 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 135, 209);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 44);
            panel1.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(122, 35);
            panel6.Name = "panel6";
            panel6.Size = new Size(626, 1);
            panel6.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(354, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 5;
            label1.Text = "Sản Phẩm";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(862, 564);
            tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(854, 536);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sản phẩm";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(842, 524);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý sản phẩm";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(63, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(697, 69);
            panel2.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(29, 135, 209);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(535, 17);
            button3.Name = "button3";
            button3.Size = new Size(123, 36);
            button3.TabIndex = 2;
            button3.Text = "Làm mới";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(29, 135, 209);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(287, 17);
            button2.Name = "button2";
            button2.Size = new Size(123, 36);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(29, 135, 209);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(34, 17);
            button1.Name = "button1";
            button1.Size = new Size(123, 36);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(568, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(216, 25);
            comboBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(568, 52);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 4;
            label4.Text = "Thương hiệu";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(308, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 25);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(308, 52);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 2;
            label3.Text = "Danh mục";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(38, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 25);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 52);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(854, 536);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Sản phẩm chi tiết";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(854, 536);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Thuộc tính sản phẩm";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(comboBox6);
            groupBox3.Controls.Add(comboBox5);
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(842, 524);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sản phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 44);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 1;
            label5.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 120);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 1;
            label6.Text = "Trạng thái";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(275, 44);
            label7.Name = "label7";
            label7.Size = new Size(72, 17);
            label7.TabIndex = 1;
            label7.Text = "Kích thước";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(275, 120);
            label8.Name = "label8";
            label8.Size = new Size(58, 17);
            label8.TabIndex = 1;
            label8.Text = "Màu sắc";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(537, 18);
            label9.Name = "label9";
            label9.Size = new Size(64, 17);
            label9.TabIndex = 1;
            label9.Text = "Hình ảnh";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(22, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(22, 140);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(173, 23);
            comboBox3.TabIndex = 3;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(275, 63);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(173, 23);
            comboBox4.TabIndex = 4;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(275, 140);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(173, 23);
            comboBox5.TabIndex = 5;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(508, 38);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(508, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 99);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(688, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(130, 183);
            panel3.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(29, 135, 209);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 17);
            button4.Name = "button4";
            button4.Size = new Size(104, 36);
            button4.TabIndex = 0;
            button4.Text = "Thêm";
            button4.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(8, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(828, 293);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(812, 262);
            dataGridView1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(29, 135, 209);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 72);
            button5.Name = "button5";
            button5.Size = new Size(104, 36);
            button5.TabIndex = 1;
            button5.Text = "Sửa";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(29, 135, 209);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(12, 126);
            button6.Name = "button6";
            button6.Size = new Size(104, 36);
            button6.TabIndex = 2;
            button6.Text = "Làm mới";
            button6.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(6, 223);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(830, 295);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách sản phẩm";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 20);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(818, 269);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(9, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(842, 524);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thuộc tính";
            // 
            // SanPhamControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "SanPhamControl";
            Size = new Size(868, 628);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel6;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private GroupBox groupBox3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel3;
        private PictureBox pictureBox2;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private TextBox textBox2;
        private Label label9;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button button4;
        private GroupBox groupBox4;
        private Button button6;
        private Button button5;
        private DataGridView dataGridView2;
        private GroupBox groupBox5;
    }
}
