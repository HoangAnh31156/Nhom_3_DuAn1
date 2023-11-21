namespace _3.PRL.Views
{
    partial class Frm_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KhachHang));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnThemKH = new Button();
            btnDSKhachHang = new Button();
            panel7 = new Panel();
            dgvDSKH = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSKH).BeginInit();
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
            panel2.Controls.Add(button3);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnThemKH);
            panel2.Controls.Add(btnDSKhachHang);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 893);
            panel2.TabIndex = 3;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(3, 43, 118);
            button3.Location = new Point(105, 51);
            button3.Name = "button3";
            button3.Size = new Size(171, 64);
            button3.TabIndex = 22;
            button3.Text = "Khách hàng";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(35, 51);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 64);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
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
            // btnThemKH
            // 
            btnThemKH.FlatAppearance.BorderSize = 0;
            btnThemKH.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnThemKH.FlatStyle = FlatStyle.Flat;
            btnThemKH.ForeColor = Color.FromArgb(3, 43, 118);
            btnThemKH.Location = new Point(59, 263);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(217, 64);
            btnThemKH.TabIndex = 16;
            btnThemKH.Text = "Thêm khách hàng";
            btnThemKH.TextAlign = ContentAlignment.MiddleLeft;
            btnThemKH.UseVisualStyleBackColor = true;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // btnDSKhachHang
            // 
            btnDSKhachHang.BackColor = Color.FromArgb(183, 209, 255);
            btnDSKhachHang.FlatAppearance.BorderSize = 0;
            btnDSKhachHang.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnDSKhachHang.FlatStyle = FlatStyle.Flat;
            btnDSKhachHang.ForeColor = Color.FromArgb(3, 43, 118);
            btnDSKhachHang.Location = new Point(59, 160);
            btnDSKhachHang.Name = "btnDSKhachHang";
            btnDSKhachHang.Size = new Size(217, 64);
            btnDSKhachHang.TabIndex = 15;
            btnDSKhachHang.Text = "Danh sách khách hàng";
            btnDSKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnDSKhachHang.UseVisualStyleBackColor = false;
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
            dgvDSKH.Location = new Point(280, 220);
            dgvDSKH.Name = "dgvDSKH";
            dgvDSKH.RowHeadersWidth = 51;
            dgvDSKH.RowTemplate.Height = 29;
            dgvDSKH.Size = new Size(1602, 730);
            dgvDSKH.TabIndex = 4;
            dgvDSKH.CellContentClick += dgvDSKH_CellContentClick;
            // 
            // Frm_KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1882, 953);
            Controls.Add(dgvDSKH);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_KhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_KhachHang";
            WindowState = FormWindowState.Maximized;
            Load += Frm_KhachHang_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSKH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbBack;
        private PictureBox pbDangXuat;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btnThemKH;
        private Button btnDSKhachHang;
        private Panel panel7;
        private Button button3;
        private PictureBox pictureBox5;
        private DataGridView dgvDSKH;
    }
}