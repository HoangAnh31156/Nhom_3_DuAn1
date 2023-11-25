﻿using _2.BUS.Services;
using _3.PRL.Views.DangNhap;
using _3.PRL.Views.KhachHang;
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
    public partial class Frm_KhachHang : Form
    {
        KhachHangService _khachService;
        Guid _id;
        public Frm_KhachHang()
        {
            _khachService = new KhachHangService();
            InitializeComponent();
            LoadGrid(null);
        }

        private void pbDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TrangChu fTC = new Frm_TrangChu();
            fTC.Show();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemKH frm_ThemKH = new Frm_ThemKH();
            frm_ThemKH.Show();
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            LoadGrid(null);
        }

        public void LoadGrid(string input)
        {
            int stt = 1;
            dgvDSKH.ColumnCount = 9;
            dgvDSKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSKH.Columns[0].Name = "ID";
            dgvDSKH.Columns[0].Visible = false;
            dgvDSKH.Columns[1].Name = "STT";
            dgvDSKH.Columns[2].Name = "ID_TaiKhoan";
            dgvDSKH.Columns[3].Name = "Tên khách hàng";
            dgvDSKH.Columns[4].Name = "Ngày sinh";
            dgvDSKH.Columns[5].Name = "SDT";
            dgvDSKH.Columns[6].Name = "Email";
            dgvDSKH.Columns[7].Name = "Giới tính";
            dgvDSKH.Columns[8].Name = "Địa chỉ";
            dgvDSKH.Rows.Clear();
            foreach (var item in _khachService.GetKhach(input))
            {
                dgvDSKH.Rows.Add(item.IdKh, stt++, null, item.TenKh, item.NgaySinh, item.Sdt, item.Email, item.GioiTinh, item.DiaChi);
            }

        }

        private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var selectedKhach = dgvDSKH.Rows[rowIndex];
            txtTenKH.Text = selectedKhach.Cells[3].Value.ToString();
            txtNgaySinh.Text = selectedKhach.Cells[4].Value.ToString();
            txtSDT.Text = selectedKhach.Cells[5].Value.ToString();
            txtEmail.Text = selectedKhach.Cells[6].Value.ToString();
            _id = Guid.Parse(selectedKhach.Cells[0].Value.ToString());
            if (selectedKhach.Cells[7].Value.ToString().Equals("Nam"))
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;
            }
            txtDiaChi.Text = selectedKhach.Cells[8].Value.ToString();
        }

        private void txtTimKhach_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(txtTimKhach.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenKH.Text;
            string ngaySinh = txtNgaySinh.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            bool gioiTinh = rbtnNam.Checked;
            string diaChi = txtDiaChi.Text;
            bool add = _khachService.AddKhach(ten, Convert.ToDateTime(ngaySinh), sdt, email, gioiTinh, diaChi);
            if (add)
            {
                MessageBox.Show("Thêm khách thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!!!!!!!");
            }
            LoadGrid(null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ten = txtTenKH.Text;
            string ngaySinh = txtNgaySinh.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            bool gioiTinh = rbtnNam.Checked;
            string diaChi = txtDiaChi.Text;
            bool add = _khachService.UpdateKhach(ten, Convert.ToDateTime(ngaySinh), sdt, email, gioiTinh, diaChi);
            if (add)
            {
                MessageBox.Show("Sửa khách thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!!!!!!!");
            }
            Guid id = _id;
            LoadGrid(null);
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var selectedKhach = dgvDSKH.Rows[rowIndex];
            txtTenKH.Text = selectedKhach.Cells[3].Value.ToString();
            txtNgaySinh.Text = selectedKhach.Cells[4].Value.ToString();
            txtSDT.Text = selectedKhach.Cells[5].Value.ToString();
            txtEmail.Text = selectedKhach.Cells[6].Value.ToString();
            _id = Guid.Parse(selectedKhach.Cells[0].Value.ToString());
            if (selectedKhach.Cells[7].Value.ToString().Equals("Nam"))
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;
            }
            txtDiaChi.Text = selectedKhach.Cells[8].Value.ToString();
        }
    }
}
