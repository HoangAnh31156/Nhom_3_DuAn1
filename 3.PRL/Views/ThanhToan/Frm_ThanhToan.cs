using _3.PRL.Views.DangNhap;
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
    public partial class Frm_ThanhToan : Form
    {
        public Frm_ThanhToan()
        {
            InitializeComponent();
        }

        private void pbDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap2 frm_DangNhap = new Frm_DangNhap2();
            frm_DangNhap.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TrangChu frm_TrangChu = new Frm_TrangChu();
            frm_TrangChu.Show();
        }

        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            LoadGridDSSP();
            LoadGridHD();
        }
        private void LoadGridDSSP()
        {



        }
        private void LoadGridHD()
        {
            int stt = 1;
            dgvHoaDonCT.ColumnCount = 8;
            dgvHoaDonCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDonCT.Columns[0].Name = "ID";
            dgvHoaDonCT.Columns[0].Visible = false;
            dgvHoaDonCT.Columns[1].Name = "STT";
            dgvHoaDonCT.Columns[2].Name = "Mã Sản phẩm";
            dgvHoaDonCT.Columns[3].Name = "Mã Biến thể";
            dgvHoaDonCT.Columns[4].Name = "Tên";
            dgvHoaDonCT.Columns[5].Name = "Số lượng";
            dgvHoaDonCT.Columns[6].Name = "Giảm giá";
            dgvHoaDonCT.Columns[7].Name = "Thành tiền";



        }






    }
}
