using _2.BUS.Services;
using _3.PRL.Views.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PRL.Views.SanPham
{
    public partial class Frm_ThemSP : Form
    {
        private SanPhamService _SanPhamService;
        private LoaiSPService _LoaiSPService;
        Guid MaLoaiSanPham = Guid.Empty;
        public Frm_ThemSP()
        {
            InitializeComponent();
            _SanPhamService = new SanPhamService();
            _LoaiSPService = new LoaiSPService();
            LoadGridviewSp(null);
            LoadAttribute();
        }
        private void LoadAttribute()
        {
            var lst = (from i in _LoaiSPService.GetLoaiSanPham(null)
                       select i.TenLoai).ToArray();
            cboLoaiSp.Items.AddRange(lst);
        }
        private void LoadGridviewSp(string name)
        {
            GirdSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int stt = 1;
            GirdSp.Rows.Clear();
            GirdSp.ColumnCount = 5;
            GirdSp.Columns[0].Name = "STT";
            GirdSp.Columns[1].Name = "Mã Sản Phẩm";
            GirdSp.Columns[2].Name = "Tên";
            GirdSp.Columns[3].Name = "Số Lượng";
            GirdSp.Columns[4].Name = "Loại Sản Phẩm";
            var lst = from i in _SanPhamService.GetSanPham(null)
                      join y in _LoaiSPService.GetLoaiSanPham(null)
                      on i.IdLoaiSanPham equals y.IdLoaiSanPham
                      select new
                      {
                          MaSp = i.MaSanPham,
                          ten = i.Ten,
                          soluong = i.SoLuong,
                          Loai = y.TenLoai
                      };
            if (txtSearch.Text != null)
            {
                lst = lst.Where(x => x.ten.ToLower().Contains(txtSearch.Text.ToLower()));
            }
            foreach (var i in lst)
            {
                GirdSp.Rows.Add(stt, i.MaSp, i.ten, i.soluong, i.Loai);
                stt++;
            }
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

        private void btnTCSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_SanPham frm_SanPham = new Frm_SanPham();
            frm_SanPham.Show();
        }

        private void btnThemCTKhac_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemCTKhac frm_ThemCTKhac = new Frm_ThemCTKhac();
            frm_ThemCTKhac.Show();
        }

        private void btnThemBienThe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemBienThe frm_ThemBien = new Frm_ThemBienThe();
            frm_ThemBien.Show();
        }

        private void cboLoaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lst = (from i in _LoaiSPService.GetLoaiSanPham(null) select i.IdLoaiSanPham).ToArray();
            MaLoaiSanPham = lst[cboLoaiSp.SelectedIndex];
        }
        private void AddSP()
        {
            GirdSp.ClearSelection();
            var obj = new _1.DAL.Model2s.SanPham()
            {
                IdSanPham = Guid.NewGuid(),
                Ten = txtTen.Text,
                IdLoaiSanPham = MaLoaiSanPham,
                MaSanPham = txtMaSP.Text,
                SoLuong = int.Parse(txtSoLuong.Text)
            };
            var result = _SanPhamService.CreateSanPham(obj);
            if (result)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadGridviewSp(null);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetMa()
        {
            int CurrentRow = GirdSp.CurrentRow.Index;
            if (CurrentRow >= 0 && CurrentRow <= GirdSp.Rows.Count - 2)
            {
                return GirdSp.CurrentRow.Cells[1].Value.ToString();
            }
            return null;
        }
        private void GetInfor()
        {
            var lst = from i in _SanPhamService.GetSanPham(null)
                      join y in _LoaiSPService.GetLoaiSanPham(null)
                      on i.IdLoaiSanPham equals y.IdLoaiSanPham
                      select new
                      {
                          ten = i.Ten,
                          loai = y.TenLoai,
                          soluong = i.SoLuong,
                          masp = i.MaSanPham
                      };
            var obj = lst.FirstOrDefault(x => x.masp == GetMa());
            txtTen.Text = obj.ten;
            cboLoaiSp.Text = obj.loai;
            txtSoLuong.Text = obj.soluong.ToString();
            txtMaSP.Text = obj.masp;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGridviewSp(txtSearch.Text);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTen.Text = string.Empty;
            txtMaSP.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            cboLoaiSp.Text = string.Empty;
        }

        private void GirdSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SuaSP()
        {
            GirdSp.ClearSelection();
            var lst = _SanPhamService.GetSanPham(null);
            var obj = lst.FirstOrDefault(x => x.MaSanPham == GetMa());
            obj.Ten = txtTen.Text;
            obj.IdLoaiSanPham = MaLoaiSanPham;
            obj.MaSanPham = txtMaSP.Text;
            obj.SoLuong = int.Parse(txtSoLuong.Text);
            var result = _SanPhamService.UpdateSanPham(obj);
            if (result)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadGridviewSp(null);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckEmpty()
        {
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Chưa nhập tên");
                return false;
            }
            if (cboLoaiSp.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn loại sản phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Chưa nhập mã sản phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Chưa nhập số lượng");
                return false;
            }
            return true;
        }
        private bool CheckExists()
        {
            var lst = _SanPhamService.GetSanPham(null);
            if (txtMaSP.Text != null)
            {
                if (lst.FirstOrDefault(x => x.MaSanPham == txtMaSP.Text) == null)
                {
                    return true;
                }
                MessageBox.Show("Sản phẩm đã tồn tại");
                return false;
            }
            return false;
        }
        private bool CheckExistsUD()
        {
            var lst = _SanPhamService.GetSanPham(null);
            if (txtMaSP.Text != null)
            {
                if (lst.Where(x => x.MaSanPham == txtMaSP.Text).Count() <= 1)
                {
                    return true;
                }
                MessageBox.Show("Sản phẩm đã tồn tại");
                return false;
            }
            return false;
        }
        private bool CheckFormat()
        {
            string regexx = @"^[A-Z0-9]+$";
            if (!Regex.IsMatch(txtMaSP.Text, regexx))
            {
                MessageBox.Show("Mã sản phẩm chỉ chứa kí tự hoa và số");
                return false;
            }
            else if (!Regex.IsMatch(txtSoLuong.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Số lượng phải là số");
                return false;
            }
            if (!Regex.IsMatch(txtTen.Text, @"^[A-Za-z0-9\p{L} ]+$"))
            {
                MessageBox.Show("Tên chỉ chứa chữ cái và số");
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(CheckEmpty() && CheckExists() && CheckFormat())
            {
                AddSP();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckEmpty() && CheckExistsUD() && CheckFormat())
            {
                Update();
            }
        }

        private void GirdSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfor();
        }
    }
}

