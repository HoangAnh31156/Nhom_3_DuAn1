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
        public Frm_NhanVien()
        {
            InitializeComponent();
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
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadGrid(null);
        }
    }
}
