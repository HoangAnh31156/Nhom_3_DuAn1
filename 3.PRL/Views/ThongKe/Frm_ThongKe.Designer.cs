namespace _3.PRL.Views.ThongKe
{
    partial class Frm_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThongKe));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            panel2 = new Panel();
            panel7 = new Panel();
            pictureBox7 = new PictureBox();
            btnThanhToan = new Button();
            rbtnNgay = new RadioButton();
            rbtnThang = new RadioButton();
            rbtnNam = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            txtDoanhThu = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            mtbDenNgay = new MaskedTextBox();
            mtbTuNgay = new MaskedTextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txtDT = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            dgvThongKe = new DataGridView();
            groupBox5 = new GroupBox();
            btnThongKe = new Button();
            cmbItems = new ComboBox();
            rdbTatCa = new RadioButton();
            rdbSanPham = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            groupBox5.SuspendLayout();
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
            panel1.TabIndex = 2;
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
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(btnThanhToan);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 893);
            panel2.TabIndex = 22;
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
            btnThanhToan.Text = "Thống kê";
            btnThanhToan.TextAlign = ContentAlignment.MiddleLeft;
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // rbtnNgay
            // 
            rbtnNgay.AutoSize = true;
            rbtnNgay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnNgay.Location = new Point(33, 49);
            rbtnNgay.Name = "rbtnNgay";
            rbtnNgay.Size = new Size(99, 24);
            rbtnNgay.TabIndex = 23;
            rbtnNgay.TabStop = true;
            rbtnNgay.Text = "Theo ngày";
            rbtnNgay.UseVisualStyleBackColor = true;
            rbtnNgay.CheckedChanged += rbtnNgay_CheckedChanged;
            // 
            // rbtnThang
            // 
            rbtnThang.AutoSize = true;
            rbtnThang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnThang.Location = new Point(190, 49);
            rbtnThang.Name = "rbtnThang";
            rbtnThang.Size = new Size(105, 24);
            rbtnThang.TabIndex = 24;
            rbtnThang.TabStop = true;
            rbtnThang.Text = "Theo tháng";
            rbtnThang.UseVisualStyleBackColor = true;
            rbtnThang.CheckedChanged += rbtnThang_CheckedChanged;
            // 
            // rbtnNam
            // 
            rbtnNam.AutoSize = true;
            rbtnNam.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnNam.Location = new Point(359, 49);
            rbtnNam.Name = "rbtnNam";
            rbtnNam.Size = new Size(96, 24);
            rbtnNam.TabIndex = 25;
            rbtnNam.TabStop = true;
            rbtnNam.Text = "Theo năm";
            rbtnNam.UseVisualStyleBackColor = true;
            rbtnNam.CheckedChanged += rbtnNam_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 44);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 27;
            label1.Text = "Từ Ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 86);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 28;
            label2.Text = "Doanh thu (VNĐ)";
            // 
            // txtDoanhThu
            // 
            txtDoanhThu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoanhThu.Location = new Point(190, 79);
            txtDoanhThu.Name = "txtDoanhThu";
            txtDoanhThu.ReadOnly = true;
            txtDoanhThu.Size = new Size(265, 27);
            txtDoanhThu.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(mtbDenNgay);
            groupBox1.Controls.Add(mtbTuNgay);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(286, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(945, 92);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(436, 44);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 35;
            label3.Text = "Đến Ngày";
            // 
            // mtbDenNgay
            // 
            mtbDenNgay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            mtbDenNgay.InsertKeyMode = InsertKeyMode.Overwrite;
            mtbDenNgay.Location = new Point(543, 32);
            mtbDenNgay.Mask = "00/00/0000 90:00";
            mtbDenNgay.Name = "mtbDenNgay";
            mtbDenNgay.Size = new Size(265, 38);
            mtbDenNgay.TabIndex = 34;
            mtbDenNgay.ValidatingType = typeof(DateTime);
            // 
            // mtbTuNgay
            // 
            mtbTuNgay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            mtbTuNgay.InsertKeyMode = InsertKeyMode.Overwrite;
            mtbTuNgay.Location = new Point(133, 32);
            mtbTuNgay.Mask = "00/00/0000 90:00";
            mtbTuNgay.Name = "mtbTuNgay";
            mtbTuNgay.Size = new Size(265, 38);
            mtbTuNgay.TabIndex = 33;
            mtbTuNgay.ValidatingType = typeof(DateTime);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDoanhThu);
            groupBox2.Controls.Add(rbtnNgay);
            groupBox2.Controls.Add(rbtnThang);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(rbtnNam);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(1352, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(518, 147);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Doanh thu";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDT);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(286, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1584, 636);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống Kê";
            // 
            // txtDT
            // 
            txtDT.ForeColor = Color.Red;
            txtDT.Location = new Point(386, 65);
            txtDT.Name = "txtDT";
            txtDT.Size = new Size(355, 41);
            txtDT.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 68);
            label4.Name = "label4";
            label4.Size = new Size(143, 35);
            label4.TabIndex = 1;
            label4.Text = "Doanh Thu";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvThongKe);
            groupBox4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(6, 144);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1572, 486);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            // 
            // dgvThongKe
            // 
            dgvThongKe.AllowUserToAddRows = false;
            dgvThongKe.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(0, 12);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersVisible = false;
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.RowTemplate.Height = 29;
            dgvThongKe.Size = new Size(1572, 578);
            dgvThongKe.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnThongKe);
            groupBox5.Controls.Add(cmbItems);
            groupBox5.Controls.Add(rdbTatCa);
            groupBox5.Controls.Add(rdbSanPham);
            groupBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(286, 164);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1040, 147);
            groupBox5.TabIndex = 33;
            groupBox5.TabStop = false;
            groupBox5.Text = "Doanh thu";
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.Highlight;
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(828, 37);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(147, 57);
            btnThongKe.TabIndex = 27;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // cmbItems
            // 
            cmbItems.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbItems.FormattingEnabled = true;
            cmbItems.Location = new Point(479, 54);
            cmbItems.Name = "cmbItems";
            cmbItems.Size = new Size(288, 31);
            cmbItems.TabIndex = 26;
            // 
            // rdbTatCa
            // 
            rdbTatCa.AutoSize = true;
            rdbTatCa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdbTatCa.Location = new Point(33, 49);
            rdbTatCa.Name = "rdbTatCa";
            rdbTatCa.Size = new Size(72, 24);
            rdbTatCa.TabIndex = 23;
            rdbTatCa.TabStop = true;
            rdbTatCa.Text = "Tất Cả";
            rdbTatCa.UseVisualStyleBackColor = true;
            rdbTatCa.CheckedChanged += rdbTatCa_CheckedChanged;
            // 
            // rdbSanPham
            // 
            rdbSanPham.AutoSize = true;
            rdbSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdbSanPham.Location = new Point(170, 49);
            rdbSanPham.Name = "rdbSanPham";
            rdbSanPham.Size = new Size(132, 24);
            rdbSanPham.TabIndex = 24;
            rdbSanPham.TabStop = true;
            rdbSanPham.Text = "Theo Sản Phẩm";
            rdbSanPham.UseVisualStyleBackColor = true;
            rdbSanPham.CheckedChanged += rdbTatCa_CheckedChanged;
            // 
            // Frm_ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1882, 953);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_ThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_ThongKe";
            WindowState = FormWindowState.Maximized;
            Load += Frm_ThongKe_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbBack;
        private PictureBox pbDangXuat;
        private Panel panel2;
        private Panel panel7;
        private PictureBox pictureBox7;
        private Button btnThanhToan;
        private RadioButton rbtnNgay;
        private RadioButton rbtnThang;
        private RadioButton rbtnNam;
        private Label label1;
        private Label label2;
        private TextBox txtDoanhThu;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dgvThongKe;
        private Label label3;
        private MaskedTextBox mtbDenNgay;
        private MaskedTextBox mtbTuNgay;
        private GroupBox groupBox5;
        private Button btnThongKe;
        private ComboBox cmbItems;
        private RadioButton rdbTatCa;
        private RadioButton rdbSanPham;
        private TextBox txtDT;
        private Label label4;
    }
}