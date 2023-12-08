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
            dtpNgayThongKe = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtDoanhThu = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox1.SuspendLayout();
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
            // dtpNgayThongKe
            // 
            dtpNgayThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayThongKe.Location = new Point(190, 37);
            dtpNgayThongKe.Name = "dtpNgayThongKe";
            dtpNgayThongKe.Size = new Size(265, 27);
            dtpNgayThongKe.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 44);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 27;
            label1.Text = "Mời chọn ngày";
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
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpNgayThongKe);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(286, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 92);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn ngày";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDoanhThu);
            groupBox2.Controls.Add(rbtnNgay);
            groupBox2.Controls.Add(rbtnThang);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(rbtnNam);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(286, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(518, 147);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Doanh thu";
            // 
            // Frm_ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1882, 953);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_ThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_ThongKe";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private DateTimePicker dtpNgayThongKe;
        private Label label1;
        private Label label2;
        private TextBox txtDoanhThu;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}