namespace _3.PRL.Views.ThanhToan
{
    partial class Frm_HoaDonBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HoaDonBanHang));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            rdbChuaThanhToan = new RadioButton();
            rdbDaThanhToan = new RadioButton();
            cmbVanChuyen = new ComboBox();
            label1 = new Label();
            cmbKhachHang = new ComboBox();
            label2 = new Label();
            cmbNhanVien = new ComboBox();
            dtpNgayTao = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            dgvHoaDon = new DataGridView();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            cmbGiamGia = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtTenSP = new TextBox();
            label8 = new Label();
            cmbBienThe = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            dgvHDCT = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 99, 223);
            panel1.Controls.Add(pbBack);
            panel1.Controls.Add(pbDangXuat);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1882, 60);
            panel1.TabIndex = 4;
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(106, 7);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(50, 50);
            pbBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBack.TabIndex = 2;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // pbDangXuat
            // 
            pbDangXuat.Cursor = Cursors.Hand;
            pbDangXuat.Image = (Image)resources.GetObject("pbDangXuat.Image");
            pbDangXuat.Location = new Point(32, 7);
            pbDangXuat.Name = "pbDangXuat";
            pbDangXuat.Size = new Size(50, 50);
            pbDangXuat.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDangXuat.TabIndex = 0;
            pbDangXuat.TabStop = false;
            pbDangXuat.Click += pbDangXuat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(cmbVanChuyen);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbKhachHang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbNhanVien);
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(41, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(913, 733);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(673, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 33);
            comboBox1.TabIndex = 38;
            // 
            // btnLamMoi
            // 
            btnLamMoi.ForeColor = SystemColors.Highlight;
            btnLamMoi.Location = new Point(673, 304);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(188, 54);
            btnLamMoi.TabIndex = 37;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.ForeColor = SystemColors.Highlight;
            btnSua.Location = new Point(673, 210);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(188, 54);
            btnSua.TabIndex = 36;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.ForeColor = SystemColors.Highlight;
            btnThem.Location = new Point(673, 114);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(188, 54);
            btnThem.TabIndex = 35;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdbChuaThanhToan);
            groupBox3.Controls.Add(rdbDaThanhToan);
            groupBox3.Location = new Point(18, 259);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(557, 108);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Text = "Trạng thái";
            // 
            // rdbChuaThanhToan
            // 
            rdbChuaThanhToan.AutoSize = true;
            rdbChuaThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdbChuaThanhToan.Location = new Point(339, 45);
            rdbChuaThanhToan.Name = "rdbChuaThanhToan";
            rdbChuaThanhToan.Size = new Size(174, 29);
            rdbChuaThanhToan.TabIndex = 1;
            rdbChuaThanhToan.TabStop = true;
            rdbChuaThanhToan.Text = "Chưa thanh toán";
            rdbChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdbDaThanhToan
            // 
            rdbDaThanhToan.AutoSize = true;
            rdbDaThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDaThanhToan.Location = new Point(47, 45);
            rdbDaThanhToan.Name = "rdbDaThanhToan";
            rdbDaThanhToan.Size = new Size(153, 29);
            rdbDaThanhToan.TabIndex = 0;
            rdbDaThanhToan.TabStop = true;
            rdbDaThanhToan.Text = "Đã thanh toán";
            rdbDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // cmbVanChuyen
            // 
            cmbVanChuyen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbVanChuyen.FormattingEnabled = true;
            cmbVanChuyen.Location = new Point(197, 210);
            cmbVanChuyen.Name = "cmbVanChuyen";
            cmbVanChuyen.Size = new Size(380, 33);
            cmbVanChuyen.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 217);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 32;
            label1.Text = "Phí vận chuyển";
            // 
            // cmbKhachHang
            // 
            cmbKhachHang.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbKhachHang.FormattingEnabled = true;
            cmbKhachHang.Location = new Point(197, 154);
            cmbKhachHang.Name = "cmbKhachHang";
            cmbKhachHang.Size = new Size(378, 33);
            cmbKhachHang.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 159);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 30;
            label2.Text = "Tên khách hàng";
            // 
            // cmbNhanVien
            // 
            cmbNhanVien.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbNhanVien.FormattingEnabled = true;
            cmbNhanVien.Location = new Point(197, 92);
            cmbNhanVien.Name = "cmbNhanVien";
            cmbNhanVien.Size = new Size(380, 33);
            cmbNhanVien.TabIndex = 29;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTao.Location = new Point(197, 37);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(380, 32);
            dtpNgayTao.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 43);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 27;
            label4.Text = "Ngày tạo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 101);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 26;
            label3.Text = "Nhân viên";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = SystemColors.ActiveCaption;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(6, 16);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 29;
            dgvHoaDon.Size = new Size(907, 330);
            dgvHoaDon.TabIndex = 38;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(cmbGiamGia);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtDonGia);
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtTenSP);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cmbBienThe);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(966, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(904, 733);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn chi tiết";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(663, 585);
            button1.Name = "button1";
            button1.Size = new Size(188, 54);
            button1.TabIndex = 54;
            button1.Text = "Làm Mới";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(663, 488);
            button2.Name = "button2";
            button2.Size = new Size(188, 54);
            button2.TabIndex = 53;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(663, 397);
            button3.Name = "button3";
            button3.Size = new Size(188, 54);
            button3.TabIndex = 52;
            button3.Text = "Thêm";
            button3.UseVisualStyleBackColor = true;
            // 
            // cmbGiamGia
            // 
            cmbGiamGia.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGiamGia.FormattingEnabled = true;
            cmbGiamGia.Location = new Point(164, 661);
            cmbGiamGia.Name = "cmbGiamGia";
            cmbGiamGia.Size = new Size(383, 33);
            cmbGiamGia.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(553, 664);
            label7.Name = "label7";
            label7.Size = new Size(28, 25);
            label7.TabIndex = 50;
            label7.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(553, 603);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 49;
            label6.Text = "VND";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(27, 667);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 48;
            label9.Text = "Giảm giá";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonGia.Location = new Point(164, 596);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(383, 32);
            txtDonGia.TabIndex = 47;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(164, 531);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(383, 32);
            txtSoLuong.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(27, 601);
            label10.Name = "label10";
            label10.Size = new Size(80, 25);
            label10.TabIndex = 45;
            label10.Text = "Đơn Giá";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(27, 535);
            label11.Name = "label11";
            label11.Size = new Size(91, 25);
            label11.TabIndex = 44;
            label11.Text = "Số Lượng";
            // 
            // txtTenSP
            // 
            txtTenSP.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenSP.Location = new Point(164, 466);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(383, 32);
            txtTenSP.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(27, 469);
            label8.Name = "label8";
            label8.Size = new Size(130, 25);
            label8.TabIndex = 42;
            label8.Text = "Tên Sản Phẩm";
            // 
            // cmbBienThe
            // 
            cmbBienThe.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBienThe.FormattingEnabled = true;
            cmbBienThe.Location = new Point(164, 400);
            cmbBienThe.Name = "cmbBienThe";
            cmbBienThe.Size = new Size(383, 33);
            cmbBienThe.TabIndex = 41;
            cmbBienThe.SelectedIndexChanged += cmbBienThe_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 403);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 40;
            label5.Text = "Mã Biến Thể";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1396, 76);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm.....";
            textBox1.Size = new Size(474, 27);
            textBox1.TabIndex = 41;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvHoaDon);
            groupBox4.Location = new Point(41, 496);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(913, 346);
            groupBox4.TabIndex = 38;
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvHDCT);
            groupBox5.Location = new Point(966, 144);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(904, 346);
            groupBox5.TabIndex = 56;
            groupBox5.TabStop = false;
            // 
            // dgvHDCT
            // 
            dgvHDCT.AllowUserToAddRows = false;
            dgvHDCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHDCT.BackgroundColor = SystemColors.ActiveCaption;
            dgvHDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDCT.Location = new Point(6, 16);
            dgvHDCT.Name = "dgvHDCT";
            dgvHDCT.ReadOnly = true;
            dgvHDCT.RowHeadersVisible = false;
            dgvHDCT.RowHeadersWidth = 51;
            dgvHDCT.RowTemplate.Height = 29;
            dgvHDCT.Size = new Size(898, 324);
            dgvHDCT.TabIndex = 38;
            dgvHDCT.CellClick += dgvHDCT_CellClick;
            // 
            // Frm_HoaDonBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1882, 953);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(textBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Frm_HoaDonBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_HoaDonBanHang";
            WindowState = FormWindowState.Maximized;
            Load += Frm_HoaDonBanHang_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pbBack;
        private PictureBox pbDangXuat;
        private GroupBox groupBox1;
        private DataGridView dgvHoaDon;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox3;
        private RadioButton rdbChuaThanhToan;
        private RadioButton rdbDaThanhToan;
        private ComboBox cmbVanChuyen;
        private Label label1;
        private ComboBox cmbKhachHang;
        private Label label2;
        private ComboBox cmbNhanVien;
        private DateTimePicker dtpNgayTao;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox cmbGiamGia;
        private Label label7;
        private Label label6;
        private Label label9;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private Label label10;
        private Label label11;
        private TextBox txtTenSP;
        private Label label8;
        private ComboBox cmbBienThe;
        private Label label5;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private DataGridView dgvHDCT;
        private ComboBox comboBox1;
    }
}