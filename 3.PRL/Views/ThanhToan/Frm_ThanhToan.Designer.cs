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
            cbgiamgia = new ComboBox();
            label4 = new Label();
            dgvDSSP = new DataGridView();
            txdongia = new TextBox();
            label3 = new Label();
            btnThem = new Button();
            txsoluong = new TextBox();
            txsanpham = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnTinhTien = new Button();
            label5 = new Label();
            dgvHoaDon = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
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
            groupBox1.Controls.Add(cbgiamgia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dgvDSSP);
            groupBox1.Controls.Add(txdongia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txsoluong);
            groupBox1.Controls.Add(txsanpham);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(286, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1584, 351);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tạo đơn hàng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbgiamgia
            // 
            cbgiamgia.FormattingEnabled = true;
            cbgiamgia.Location = new Point(1152, 78);
            cbgiamgia.Name = "cbgiamgia";
            cbgiamgia.Size = new Size(151, 33);
            cbgiamgia.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1041, 81);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 7;
            label4.Text = "Giảm giá";
            // 
            // dgvDSSP
            // 
            dgvDSSP.BackgroundColor = SystemColors.ActiveCaption;
            dgvDSSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSSP.Location = new Point(6, 141);
            dgvDSSP.Name = "dgvDSSP";
            dgvDSSP.RowHeadersWidth = 51;
            dgvDSSP.RowTemplate.Height = 29;
            dgvDSSP.Size = new Size(1563, 204);
            dgvDSSP.TabIndex = 4;
            // 
            // txdongia
            // 
            txdongia.Location = new Point(858, 78);
            txdongia.Name = "txdongia";
            txdongia.Size = new Size(136, 32);
            txdongia.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(765, 81);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 5;
            label3.Text = "Đơn giá";
            // 
            // btnThem
            // 
            btnThem.ForeColor = SystemColors.Highlight;
            btnThem.Location = new Point(1390, 66);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(188, 54);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txsoluong
            // 
            txsoluong.Location = new Point(580, 78);
            txsoluong.Name = "txsoluong";
            txsoluong.Size = new Size(136, 32);
            txsoluong.TabIndex = 3;
            // 
            // txsanpham
            // 
            txsanpham.Location = new Point(129, 78);
            txsanpham.Name = "txsanpham";
            txsanpham.Size = new Size(327, 32);
            txsanpham.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(487, 81);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Số lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 81);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Sản phẩm";
            // 
            // btnTinhTien
            // 
            btnTinhTien.BackColor = Color.White;
            btnTinhTien.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnTinhTien.ForeColor = Color.OrangeRed;
            btnTinhTien.Location = new Point(292, 833);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(1578, 85);
            btnTinhTien.TabIndex = 6;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(301, 420);
            label5.Name = "label5";
            label5.Size = new Size(104, 30);
            label5.TabIndex = 5;
            label5.Text = "Hóa Đơn";
            label5.Click += label5_Click;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.BackgroundColor = SystemColors.ActiveCaption;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(292, 470);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 29;
            dgvHoaDon.Size = new Size(1572, 299);
            dgvHoaDon.TabIndex = 7;
            dgvHoaDon.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(309, 788);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 9;
            label6.Text = "TổngTiền:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(433, 791);
            label7.Name = "label7";
            label7.Size = new Size(199, 25);
            label7.TabIndex = 10;
            label7.Text = "0";
            // 
            // Frm_ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1882, 953);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvHoaDon);
            Controls.Add(btnTinhTien);
            Controls.Add(label5);
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
            ((System.ComponentModel.ISupportInitialize)dgvDSSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
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
        private Button btnThem;
        private TextBox txsoluong;
        private TextBox txsanpham;
        private Label label2;
        private Label label1;
        private ComboBox cbgiamgia;
        private Label label4;
        private TextBox txdongia;
        private Label label3;
        private DataGridView dgvDSSP;
        private Button btnTinhTien;
        private Label label5;
        private DataGridView dgvHoaDon;
        private Label label6;
        private Label label7;
    }
}