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
            btnTinhTien = new Button();
            dgvHoaDonCT = new DataGridView();
            groupBox2 = new GroupBox();
            label5 = new Label();
            cmbTrangThaiHD = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonCT).BeginInit();
            groupBox2.SuspendLayout();
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
            groupBox1.Controls.Add(cmbTrangThaiHD);
            groupBox1.Controls.Add(label5);
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
            groupBox1.Location = new Point(286, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1584, 231);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // cmbKhachHang
            // 
            cmbKhachHang.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbKhachHang.FormattingEnabled = true;
            cmbKhachHang.Location = new Point(173, 92);
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
            cmbNhanVien.Location = new Point(713, 93);
            cmbNhanVien.Name = "cmbNhanVien";
            cmbNhanVien.Size = new Size(216, 33);
            cmbNhanVien.TabIndex = 11;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTao.Location = new Point(713, 40);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(310, 32);
            dtpNgayTao.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(580, 40);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 7;
            label4.Text = "Ngày tạo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(580, 95);
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
            txtMaHD.Location = new Point(173, 40);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(283, 32);
            txtMaHD.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 95);
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
            // btnTinhTien
            // 
            btnTinhTien.BackColor = Color.White;
            btnTinhTien.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnTinhTien.ForeColor = Color.OrangeRed;
            btnTinhTien.Location = new Point(292, 856);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(1578, 85);
            btnTinhTien.TabIndex = 6;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = false;
            // 
            // dgvHoaDonCT
            // 
            dgvHoaDonCT.BackgroundColor = SystemColors.ActiveCaption;
            dgvHoaDonCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonCT.Location = new Point(0, 31);
            dgvHoaDonCT.Name = "dgvHoaDonCT";
            dgvHoaDonCT.RowHeadersWidth = 51;
            dgvHoaDonCT.RowTemplate.Height = 29;
            dgvHoaDonCT.Size = new Size(1578, 599);
            dgvHoaDonCT.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHoaDonCT);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(292, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1578, 547);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(580, 151);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 15;
            label5.Text = "Trạng thái";
            // 
            // cmbTrangThaiHD
            // 
            cmbTrangThaiHD.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTrangThaiHD.FormattingEnabled = true;
            cmbTrangThaiHD.Location = new Point(713, 147);
            cmbTrangThaiHD.Name = "cmbTrangThaiHD";
            cmbTrangThaiHD.Size = new Size(216, 33);
            cmbTrangThaiHD.TabIndex = 16;
            // 
            // Frm_ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1882, 953);
            Controls.Add(groupBox2);
            Controls.Add(btnTinhTien);
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
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonCT).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button btnThem;
        private TextBox txtMaHD;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button btnTinhTien;
        private DataGridView dgvHoaDonCT;
        private Button btnSua;
        private Button btnLuu;
        private ComboBox cmbNhanVien;
        private DateTimePicker dtpNgayTao;
        private GroupBox groupBox2;
        private ComboBox cmbKhachHang;
        private ComboBox cmbTrangThaiHD;
        private Label label5;
    }
}