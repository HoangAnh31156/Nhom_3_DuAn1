using _2.BUS.Services;
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

        private void LoadGrid(string input)
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
                dgvDSKH.Rows.Add(stt++, null, item.TenKh, item.NgaySinh, item.Sdt, item.Email, item.GioiTinh, item.DiaChi);
            }

        }

        private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
