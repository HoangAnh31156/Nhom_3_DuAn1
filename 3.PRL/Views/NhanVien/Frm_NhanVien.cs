using _2.BUS.Services;
using _3.PRL.Views.DangNhap;
using _3.PRL.Views.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PRL.Views
{
    public partial class Frm_NhanVien : Form
    {
        NhanVienService _service;
        Guid _id;

        public Frm_NhanVien()
        {
            _service = new NhanVienService();
            InitializeComponent();
            LoadGrid(null);
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

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemNV frm_ThemNV = new Frm_ThemNV();
            frm_ThemNV.Show();
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {


        }
        private void LoadGrid(string input)
        {
            int stt = 1;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnCount = 8;
            dgvNhanVien.Columns[0].Name = "STT";
            dgvNhanVien.Columns[1].Name = "ID nhân viên";
            dgvNhanVien.Columns[1].Visible = false;
            dgvNhanVien.Columns[2].Name = "Tên nhân viên";
            dgvNhanVien.Columns[3].Name = "SDT";
            dgvNhanVien.Columns[4].Name = "Địa chỉ";
            dgvNhanVien.Columns[5].Name = "Ngày sinh";
            dgvNhanVien.Columns[6].Name = "Giới tính";
            dgvNhanVien.Columns[7].Name = "Trạng thái";
            dgvNhanVien.Rows.Clear();
            foreach (var item in _service.GetNhanVien(input))
            {
                dgvNhanVien.Rows.Add(stt++, item.IdNv, item.Ten, item.Sdt, item.DiaChi, item.NgaySinh, ((bool)item.GioiTinh ? "Nam" : "Nữ"), (bool)item.TrangThai ? "Hoạt động" : "Dừng hoạt động");
            }
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadGrid(null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenNV.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string ngaySinh = txtNgaySinh.Text;
            bool gioiTinh = rbtnNam.Checked;
            bool trangThai = rbtnYES.Checked;
            bool add = _service.AddNhanVien(ten, sdt, diaChi, Convert.ToDateTime(ngaySinh), gioiTinh, trangThai);
            if (add)
            {
                MessageBox.Show("Thêm nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!!!!!!!");
            }
            LoadGrid(null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ten = txtTenNV.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string ngaySinh = txtNgaySinh.Text;
            bool gioiTinh = rbtnNam.Checked;
            bool trangThai = rbtnYES.Checked;
            Guid id = _id;
            bool update = _service.UpdateNV(id, ten, sdt, diaChi, Convert.ToDateTime(ngaySinh), gioiTinh, trangThai);
            if (update)
            {
                MessageBox.Show("Sửa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!!!!!!!");
            }
            LoadGrid(null);
        }

        private void txtTimNV_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(txtTimNV.Text);
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            var selectedNV = dgvNhanVien.Rows[rowIndex];
            txtTenNV.Text = selectedNV.Cells[2].Value.ToString();
            txtNgaySinh.Text = selectedNV.Cells[5].Value.ToString();
            txtSDT.Text = selectedNV.Cells[3].Value.ToString();
            txtDiaChi.Text = selectedNV.Cells[4].Value.ToString();
            _id = Guid.Parse(selectedNV.Cells[1].Value.ToString());
            if (selectedNV.Cells[6].Value.ToString().Equals("Nam"))
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;
            }
            if (selectedNV.Cells[7].Value.ToString().Equals("Hoạt động"))
            {
                rbtnYES.Checked = true;
            }
            else
            {
                rbtnNO.Checked = true;
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            var selectedNV = dgvNhanVien.Rows[rowIndex];
            txtTenNV.Text = selectedNV.Cells[2].Value.ToString();
            txtNgaySinh.Text = selectedNV.Cells[5].Value.ToString();
            txtSDT.Text = selectedNV.Cells[3].Value.ToString();
            txtDiaChi.Text = selectedNV.Cells[4].Value.ToString();
            _id = Guid.Parse(selectedNV.Cells[1].Value.ToString());
            if (selectedNV.Cells[6].Value.ToString().Equals("Nam"))
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;
            }
            if (selectedNV.Cells[7].Value.ToString().Equals("Hoạt động"))
            {
                rbtnYES.Checked = true;
            }
            else
            {
                rbtnNO.Checked = true;
            }
        }
    }
}
