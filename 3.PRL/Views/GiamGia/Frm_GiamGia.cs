using _2.BUS.Services;
using _3.PRL.Views.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _3.PRL.Views.GiamGia
{
    public partial class Frm_GiamGia : Form
    {
        GiamGiaService _giamGiaService = new GiamGiaService();
        Guid _id;
        public Frm_GiamGia()
        {
            InitializeComponent();
        }

        private void Frm_GiamGia_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TrangChu frm_TrangChu = new Frm_TrangChu();
            frm_TrangChu.Show();
        }

        private void pbDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap2 frm_DangNhap = new Frm_DangNhap2();
            frm_DangNhap.Show();
        }

        public void LoadGrid()
        {
            int stt = 1;
            dgvDSGiamGia.ColumnCount = 6;
            dgvDSGiamGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSGiamGia.Columns[0].Name = "ID";
            dgvDSGiamGia.Columns[0].Visible = false;
            dgvDSGiamGia.Columns[1].Name = "STT";
            dgvDSGiamGia.Columns[2].Name = "Giá trị (%)";
            dgvDSGiamGia.Columns[3].Name = "Điều kiện";
            dgvDSGiamGia.Columns[4].Name = "Ngày bắt đầu";
            dgvDSGiamGia.Columns[5].Name = "Ngày kết thúc";
            dgvDSGiamGia.Rows.Clear();

            foreach (var item in _giamGiaService.GetGiamGia())
            {
                dgvDSGiamGia.Rows.Add(item.IdGiamGia, stt++, item.GiaTri, item.DieuKien, item.NgayBatDau, item.NgayKetThuc);
            }
        }

        private void dgvDSGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex > dgvDSGiamGia.RowCount)
                return;

            var selectedGiamGia = dgvDSGiamGia.Rows[rowIndex];

            //_id = Guid.Parse(selectedGiamGia.Cells[0].Value.ToString());

            txtGiaTri.Text = selectedGiamGia.Cells[2].Value.ToString();
            txtDieuKien.Text = selectedGiamGia.Cells[3].Value.ToString();

            dtpNgayBD.Value = DateTime.Parse(selectedGiamGia.Cells[4].Value.ToString());
            dtpNgayKT.Value = DateTime.Parse(selectedGiamGia.Cells[5].Value.ToString());


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string giaTri = txtGiaTri.Text;
            string dieuKien = txtDieuKien.Text;
            string ngayBD = dtpNgayBD.Text;
            string ngayKT = dtpNgayKT.Text;
            bool add = _giamGiaService.AddGiamGia(Convert.ToDateTime(ngayBD), Convert.ToDateTime(ngayKT), Convert.ToDouble(giaTri), dieuKien);

            if (add)
            {
                MessageBox.Show("Thêm giảm giá thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm giảm giá thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadGrid();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Guid id = _id;
            string giaTri = txtGiaTri.Text;
            string dieuKien = txtDieuKien.Text;
            string ngayBD = dtpNgayBD.Text;
            string ngayKT = dtpNgayKT.Text;
            bool update = _giamGiaService.UpdateGiamGia(id, Convert.ToDateTime(ngayBD), Convert.ToDateTime(ngayKT), Convert.ToDouble(giaTri), dieuKien);

            if (update)
            {
                MessageBox.Show("Sửa giảm giá thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Sửa giảm giá thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadGrid();
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            txtGiaTri.Text = string.Empty;
            txtDieuKien.Text = string.Empty;
            dtpNgayBD.Text = Convert.ToString(DateTime.Today);
            dtpNgayKT.Text = Convert.ToString(DateTime.Today);

        }
    }
}
