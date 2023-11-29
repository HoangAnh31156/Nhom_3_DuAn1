namespace _3.PRL.Views
{
    partial class Frm_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HoaDon));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            panel2 = new Panel();
            btnHoaDonCT = new Button();
            pictureBox10 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnHoaDon = new Button();
            panel7 = new Panel();
            pictureBox7 = new PictureBox();
            btnThanhToan = new Button();
            groupBox1 = new GroupBox();
            cmbPTTT = new ComboBox();
            label5 = new Label();
            cmbVanChuyen = new ComboBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            rdbChuaThanhToan = new RadioButton();
            rdbDaThanhToan = new RadioButton();
            cmbKhachHang = new ComboBox();
            btnSua = new Button();
            btnLamMoi = new Button();
            cmbNhanVien = new ComboBox();
            dtpNgayTao = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            btnThem = new Button();
            label2 = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            dgvDSHD = new DataGridView();
            button2 = new Button();
            txtTimKiem = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSHD).BeginInit();
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
            panel2.Controls.Add(btnHoaDonCT);
            panel2.Controls.Add(pictureBox10);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnHoaDon);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(btnThanhToan);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 893);
            panel2.TabIndex = 21;
            // 
            // btnHoaDonCT
            // 
            btnHoaDonCT.FlatAppearance.BorderSize = 0;
            btnHoaDonCT.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnHoaDonCT.FlatStyle = FlatStyle.Flat;
            btnHoaDonCT.ForeColor = Color.FromArgb(3, 43, 118);
            btnHoaDonCT.Location = new Point(70, 302);
            btnHoaDonCT.Name = "btnHoaDonCT";
            btnHoaDonCT.Size = new Size(171, 64);
            btnHoaDonCT.TabIndex = 29;
            btnHoaDonCT.Text = "Hóa Đơn Chi Tiết";
            btnHoaDonCT.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDonCT.UseVisualStyleBackColor = true;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(49, 324);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(15, 17);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 28;
            pictureBox10.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(49, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 17);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.FromArgb(183, 209, 255);
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.ForeColor = Color.FromArgb(3, 43, 118);
            btnHoaDon.Location = new Point(70, 173);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(171, 64);
            btnHoaDon.TabIndex = 26;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(183, 209, 255);
            panel7.Location = new Point(8, 67);
            panel7.Name = "panel7";
            panel7.Size = new Size(18, 64);
            panel7.TabIndex = 21;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPTTT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbVanChuyen);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(cmbKhachHang);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(cmbNhanVien);
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(292, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1578, 301);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // cmbPTTT
            // 
            cmbPTTT.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPTTT.FormattingEnabled = true;
            cmbPTTT.Location = new Point(765, 110);
            cmbPTTT.Name = "cmbPTTT";
            cmbPTTT.Size = new Size(283, 33);
            cmbPTTT.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(581, 113);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 19;
            label5.Text = "PTTT";
            // 
            // cmbVanChuyen
            // 
            cmbVanChuyen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbVanChuyen.FormattingEnabled = true;
            cmbVanChuyen.Location = new Point(176, 155);
            cmbVanChuyen.Name = "cmbVanChuyen";
            cmbVanChuyen.Size = new Size(285, 33);
            cmbVanChuyen.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 158);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 17;
            label1.Text = "Phí vận chuyển";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdbChuaThanhToan);
            groupBox3.Controls.Add(rdbDaThanhToan);
            groupBox3.Location = new Point(1146, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(389, 125);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Trạng thái";
            // 
            // rdbChuaThanhToan
            // 
            rdbChuaThanhToan.AutoSize = true;
            rdbChuaThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdbChuaThanhToan.Location = new Point(209, 45);
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
            cmbKhachHang.Location = new Point(765, 49);
            cmbKhachHang.Name = "cmbKhachHang";
            cmbKhachHang.Size = new Size(283, 33);
            cmbKhachHang.TabIndex = 14;
            // 
            // btnSua
            // 
            btnSua.ForeColor = SystemColors.Highlight;
            btnSua.Location = new Point(416, 230);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(188, 54);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.ForeColor = SystemColors.Highlight;
            btnLamMoi.Location = new Point(726, 230);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(188, 54);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // cmbNhanVien
            // 
            cmbNhanVien.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbNhanVien.FormattingEnabled = true;
            cmbNhanVien.Location = new Point(176, 101);
            cmbNhanVien.Name = "cmbNhanVien";
            cmbNhanVien.Size = new Size(285, 33);
            cmbNhanVien.TabIndex = 11;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTao.Location = new Point(176, 46);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(285, 32);
            dtpNgayTao.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 46);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 7;
            label4.Text = "Ngày tạo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 102);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 5;
            label3.Text = "Nhân viên";
            // 
            // btnThem
            // 
            btnThem.ForeColor = SystemColors.Highlight;
            btnThem.Location = new Point(115, 230);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(188, 54);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(581, 52);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(292, 384);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1578, 407);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Hóa Đơn";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvDSHD);
            groupBox4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(4, 31);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1568, 388);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            // 
            // dgvDSHD
            // 
            dgvDSHD.BackgroundColor = SystemColors.ActiveCaption;
            dgvDSHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSHD.Location = new Point(2, 12);
            dgvDSHD.Name = "dgvDSHD";
            dgvDSHD.RowHeadersWidth = 51;
            dgvDSHD.RowTemplate.Height = 29;
            dgvDSHD.Size = new Size(1566, 364);
            dgvDSHD.TabIndex = 7;
            dgvDSHD.CellClick += dgvDSHD_CellClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Highlight;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(732, 856);
            button2.Name = "button2";
            button2.Size = new Size(194, 60);
            button2.TabIndex = 24;
            button2.Text = "Tìm kiếm";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(498, 871);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(208, 32);
            txtTimKiem.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(326, 874);
            label6.Name = "label6";
            label6.Size = new Size(146, 25);
            label6.TabIndex = 26;
            label6.Text = "Tên Khách hàng";
            // 
            // Frm_HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1882, 953);
            Controls.Add(button2);
            Controls.Add(txtTimKiem);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_HoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_ThanhToan";
            WindowState = FormWindowState.Maximized;
            Load += Frm_ThanhToan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSHD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pbDangXuat;
        private PictureBox pbBack;
        private Panel panel2;
        private Button btnHoaDonCT;
        private PictureBox pictureBox10;
        private PictureBox pictureBox2;
        private Button btnHoaDon;
        private Panel panel7;
        private PictureBox pictureBox7;
        private Button btnThanhToan;
        private GroupBox groupBox1;
        private ComboBox cmbPTTT;
        private Label label5;
        private ComboBox cmbVanChuyen;
        private Label label1;
        private GroupBox groupBox3;
        private RadioButton rdbChuaThanhToan;
        private RadioButton rdbDaThanhToan;
        private ComboBox cmbKhachHang;
        private Button btnSua;
        private Button btnLamMoi;
        private ComboBox cmbNhanVien;
        private DateTimePicker dtpNgayTao;
        private Label label4;
        private Label label3;
        private Button btnThem;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private DataGridView dgvDSHD;
        private Button button2;
        private TextBox txtTimKiem;
        private Label label6;
    }
}