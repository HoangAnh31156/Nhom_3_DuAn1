namespace _3.PRL.Views
{
    partial class Frm_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhanVien));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            panel2 = new Panel();
            btnNhanVien = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnThemNV = new Button();
            btnDSNV = new Button();
            panel7 = new Panel();
            dgvDSKH = new DataGridView();
            dgvNhanVien = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSKH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 99, 223);
            panel1.Controls.Add(pbBack);
            panel1.Controls.Add(pbDangXuat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1882, 60);
            panel1.TabIndex = 3;
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(106, 7);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(50, 50);
            pbBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBack.TabIndex = 1;
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
            panel2.Controls.Add(btnNhanVien);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnThemNV);
            panel2.Controls.Add(btnDSNV);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 893);
            panel2.TabIndex = 4;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.ForeColor = Color.FromArgb(3, 43, 118);
            btnNhanVien.Location = new Point(106, 51);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(171, 64);
            btnNhanVien.TabIndex = 21;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(32, 51);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(38, 290);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(15, 17);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 17);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnThemNV
            // 
            btnThemNV.FlatAppearance.BorderSize = 0;
            btnThemNV.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnThemNV.FlatStyle = FlatStyle.Flat;
            btnThemNV.ForeColor = Color.FromArgb(3, 43, 118);
            btnThemNV.Location = new Point(59, 263);
            btnThemNV.Name = "btnThemNV";
            btnThemNV.Size = new Size(217, 64);
            btnThemNV.TabIndex = 16;
            btnThemNV.Text = "Thêm / Sửa nhân viên";
            btnThemNV.TextAlign = ContentAlignment.MiddleLeft;
            btnThemNV.UseVisualStyleBackColor = true;
            btnThemNV.Click += btnThemNV_Click;
            // 
            // btnDSNV
            // 
            btnDSNV.BackColor = Color.FromArgb(183, 209, 255);
            btnDSNV.FlatAppearance.BorderSize = 0;
            btnDSNV.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnDSNV.FlatStyle = FlatStyle.Flat;
            btnDSNV.ForeColor = Color.FromArgb(3, 43, 118);
            btnDSNV.Location = new Point(59, 160);
            btnDSNV.Name = "btnDSNV";
            btnDSNV.Size = new Size(217, 64);
            btnDSNV.TabIndex = 15;
            btnDSNV.Text = "Danh sách nhân viên";
            btnDSNV.TextAlign = ContentAlignment.MiddleLeft;
            btnDSNV.UseVisualStyleBackColor = false;
            btnDSNV.Click += btnDSNV_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(183, 209, 255);
            panel7.Location = new Point(12, 51);
            panel7.Name = "panel7";
            panel7.Size = new Size(18, 64);
            panel7.TabIndex = 13;
            // 
            // dgvDSKH
            // 
            dgvDSKH.BackgroundColor = Color.WhiteSmoke;
            dgvDSKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSKH.GridColor = Color.LightGray;
            dgvDSKH.Location = new Point(280, 193);
            dgvDSKH.Name = "dgvDSKH";
            dgvDSKH.RowHeadersWidth = 51;
            dgvDSKH.RowTemplate.Height = 29;
            dgvDSKH.Size = new Size(1602, 757);
            dgvDSKH.TabIndex = 5;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(280, 193);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.Size = new Size(1602, 468);
            dgvNhanVien.TabIndex = 22;
            // 
            // Frm_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1882, 953);
            Controls.Add(dgvNhanVien);
            Controls.Add(dgvDSKH);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_NhanVien";
            WindowState = FormWindowState.Maximized;
            Load += Frm_NhanVien_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSKH).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbBack;
        private PictureBox pbDangXuat;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btnThemNV;
        private Button btnDSNV;
        private Panel panel7;
        private DataGridView dgvDSKH;
        private Button btnNhanVien;
        private PictureBox pictureBox4;
        private DataGridView dgvNhanVien;
    }
}