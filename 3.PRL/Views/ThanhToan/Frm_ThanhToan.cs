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
            LoadGrid();
        }
        private void LoadGrid()
        {
            int stt = 1;
            dgvDSSP.ColumnCount = 5;
            dgvDSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSSP.Columns[0].Name = "STT";
            dgvDSSP.Columns[1].Name = "Tên sản phẩm";
            dgvDSSP.Columns[2].Name = "Số lượng";
            dgvDSSP.Columns[3].Name = "Giảm giá";
            dgvDSSP.Columns[4].Name = "Thành tiền";


        }
    }
}
