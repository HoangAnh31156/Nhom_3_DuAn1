namespace _3.PRL.Views
{
    partial class Frm_ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThanhToan));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            panel2 = new Panel();
            pictureBox7 = new PictureBox();
            btnThanhToan = new Button();
            panel5 = new Panel();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            rdbChuaThanhToan = new RadioButton();
            rdbDaThanhToan = new RadioButton();
            cmbKhachHang = new ComboBox();
            btnSua = new Button();
            btnLuu = new Button();
            cmbNhanVien = new ComboBox();
            dtpNgayTao = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            btnThem = new Button();
            txtMaHD = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox7 = new TextBox();
            label13 = new Label();
            txtThanhTien = new TextBox();
            label12 = new Label();
            label11 = new Label();
            txtGiamGia = new TextBox();
            txtDonGia = new TextBox();
            label10 = new Label();
            txtSoLuong = new TextBox();
            txtTenSP = new TextBox();
            cmbBienThe = new ComboBox();
            cmbSanPham = new ComboBox();
            label9 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            dgvHoaDonCT = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonCT).BeginInit();
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
            panel1.TabIndex = 1;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(btnThanhToan);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 893);
            panel2.TabIndex = 2;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(32, 67);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(64, 64);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // btnThanhToan
            // 
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.ForeColor = Color.FromArgb(3, 43, 118);
            btnThanhToan.Location = new Point(106, 67);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(171, 64);
            btnThanhToan.TabIndex = 15;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.TextAlign = ContentAlignment.MiddleLeft;
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(183, 209, 255);
            panel5.Location = new Point(12, 67);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 64);
            panel5.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(cmbKhachHang);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(cmbNhanVien);
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(292, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1578, 231);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdbChuaThanhToan);
            groupBox3.Controls.Add(rdbDaThanhToan);
            groupBox3.Location = new Point(580, 93);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(441, 125);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Trạng thái";
            // 
            // rdbChuaThanhToan
            // 
            rdbChuaThanhToan.AutoSize = true;
            rdbChuaThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdbChuaThanhToan.Location = new Point(261, 45);
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
            rdbDaThanhToan.Location = new Point(6, 45);
            rdbDaThanhToan.Name = "rdbDaThanhToan";
            rdbDaThanhToan.Size = new Size(153, 29);
            rdbDaThanhToan.TabIndex = 0;
            rdbDaThanhToan.TabStop = true;
            rdbDaThanhToan.Text = "Đã thanh toán";
            rdbDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // cmbKhachHang
            // 
            cmbKhachHang.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbKhachHang.FormattingEnabled = true;
            cmbKhachHang.Location = new Point(738, 37);
            cmbKhachHang.Name = "cmbKhachHang";
            cmbKhachHang.Size = new Size(283, 33);
            cmbKhachHang.TabIndex = 14;
            // 
            // btnSua
            // 
            btnSua.ForeColor = SystemColors.Highlight;
            btnSua.Location = new Point(1087, 113);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(188, 54);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.Highlight;
            btnLuu.Location = new Point(1340, 31);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(188, 54);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // cmbNhanVien
            // 
            cmbNhanVien.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbNhanVien.FormattingEnabled = true;
            cmbNhanVien.Location = new Point(148, 148);
            cmbNhanVien.Name = "cmbNhanVien";
            cmbNhanVien.Size = new Size(310, 33);
            cmbNhanVien.TabIndex = 11;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTao.Location = new Point(148, 93);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(310, 32);
            dtpNgayTao.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 95);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 7;
            label4.Text = "Ngày tạo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 151);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 5;
            label3.Text = "Nhân viên";
            // 
            // btnThem
            // 
            btnThem.ForeColor = SystemColors.Highlight;
            btnThem.Location = new Point(1087, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(188, 54);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtMaHD
            // 
            txtMaHD.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHD.Location = new Point(148, 40);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(310, 32);
            txtMaHD.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(580, 40);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 43);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtThanhTien);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtGiamGia);
            groupBox2.Controls.Add(txtDonGia);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(txtTenSP);
            groupBox2.Controls.Add(cmbBienThe);
            groupBox2.Controls.Add(cmbSanPham);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dgvHoaDonCT);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(292, 314);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1578, 547);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(1240, 476);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(210, 41);
            textBox7.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(1037, 479);
            label13.Name = "label13";
            label13.Size = new Size(120, 35);
            label13.TabIndex = 25;
            label13.Text = "Tổng tiền";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(1340, 147);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(210, 32);
            txtThanhTien.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(1198, 150);
            label12.Name = "label12";
            label12.Size = new Size(102, 25);
            label12.TabIndex = 23;
            label12.Text = "Thành tiền";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(770, 150);
            label11.Name = "label11";
            label11.Size = new Size(113, 25);
            label11.TabIndex = 22;
            label11.Text = " Giảm giá %";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(916, 143);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(210, 32);
            txtGiamGia.TabIndex = 21;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(514, 143);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(189, 32);
            txtDonGia.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(386, 146);
            label10.Name = "label10";
            label10.Size = new Size(78, 25);
            label10.TabIndex = 19;
            label10.Text = "Đơn giá";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(148, 143);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(189, 32);
            txtSoLuong.TabIndex = 18;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(1062, 73);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(210, 32);
            txtTenSP.TabIndex = 17;
            // 
            // cmbBienThe
            // 
            cmbBienThe.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBienThe.FormattingEnabled = true;
            cmbBienThe.Location = new Point(514, 73);
            cmbBienThe.Name = "cmbBienThe";
            cmbBienThe.Size = new Size(284, 33);
            cmbBienThe.TabIndex = 16;
            // 
            // cmbSanPham
            // 
            cmbSanPham.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSanPham.FormattingEnabled = true;
            cmbSanPham.Location = new Point(148, 73);
            cmbSanPham.Name = "cmbSanPham";
            cmbSanPham.Size = new Size(189, 33);
            cmbSanPham.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(916, 76);
            label9.Name = "label9";
            label9.Size = new Size(128, 25);
            label9.TabIndex = 11;
            label9.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 146);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 10;
            label5.Text = "Số lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(386, 76);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 9;
            label7.Text = "Mã biến thể";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 76);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 8;
            label8.Text = "Mã sản phẩm";
            // 
            // dgvHoaDonCT
            // 
            dgvHoaDonCT.BackgroundColor = SystemColors.ActiveCaption;
            dgvHoaDonCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonCT.Location = new Point(0, 201);
            dgvHoaDonCT.Name = "dgvHoaDonCT";
            dgvHoaDonCT.RowHeadersWidth = 51;
            dgvHoaDonCT.RowTemplate.Height = 29;
            dgvHoaDonCT.Size = new Size(1578, 247);
            dgvHoaDonCT.TabIndex = 7;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Highlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(650, 881);
            button2.Name = "button2";
            button2.Size = new Size(194, 60);
            button2.TabIndex = 18;
            button2.Text = "     Tìm kiếm";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(416, 896);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 32);
            textBox1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(296, 899);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 20;
            label6.Text = "Mã hóa đơn";
            // 
            // Frm_ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1882, 953);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_ThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_ThanhToan";
            WindowState = FormWindowState.Maximized;
            Load += Frm_ThanhToan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pbDangXuat;
        private Panel panel2;
        private PictureBox pictureBox7;
        private Button btnThanhToan;
        private Panel panel5;
        private PictureBox pbBack;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private RadioButton rdbChuaThanhToan;
        private RadioButton rdbDaThanhToan;
        private ComboBox cmbKhachHang;
        private Button btnSua;
        private Button btnLuu;
        private ComboBox cmbNhanVien;
        private DateTimePicker dtpNgayTao;
        private Label label4;
        private Label label3;
        private Button btnThem;
        private TextBox txtMaHD;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBox7;
        private Label label13;
        private TextBox txtThanhTien;
        private Label label12;
        private Label label11;
        private TextBox txtGiamGia;
        private TextBox txtDonGia;
        private Label label10;
        private TextBox txtSoLuong;
        private TextBox txtTenSP;
        private ComboBox cmbBienThe;
        private ComboBox cmbSanPham;
        private Label label9;
        private Label label5;
        private Label label7;
        private Label label8;
        private DataGridView dgvHoaDonCT;
        private Button button2;
        private TextBox textBox1;
        private Label label6;
    }
}