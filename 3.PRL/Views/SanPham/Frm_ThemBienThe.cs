using _2.BUS.Services;
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

namespace _3.PRL.Views.SanPham
{
    public partial class Frm_ThemBienThe : Form
    {
        private ChatLieuService _chatLieuService;
        private MauSacService _mauSacService;
        private SoCanhService _soCanhService;
        private SanPhamService _SanPhamService;
        private BienTheService _BienTheService;
        private LoaiSPService _LoaiSPService;
        public Frm_ThemBienThe()
        {
            InitializeComponent();
            _chatLieuService = new ChatLieuService();
            _mauSacService = new MauSacService();
            _soCanhService = new SoCanhService();
            _SanPhamService = new SanPhamService();
            _BienTheService = new BienTheService();
            _LoaiSPService = new LoaiSPService();
            LoadAttributes();
            LoadgridVariant(null);
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
        private void LoadAttributes()
        {
            var chatlieu = (from i in _chatLieuService.GetChatLieu(null)
                            select i.TenChatLieu).ToArray();
            cboChatLieu.Items.AddRange(chatlieu);

            var Mau = (from i in _mauSacService.GetMau(null)
                       select i.TenMau).ToArray();
            cboMau.Items.AddRange(Mau);

            var Socanh = (from i in _soCanhService.GetSoCanh(null)
                          select i.SoCanh1.ToString()).ToArray();
            cboSoCanh.Items.AddRange(Socanh);

            var sp = (from i in _SanPhamService.GetSanPham(null)
                      select i.MaSanPham).ToArray();
            cboMaSp.Items.AddRange(sp);
        }

        private void LoadgridVariant(string name)
        {
            GridVariant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int stt = 1;
            GridVariant.Rows.Clear();
            GridVariant.ColumnCount = 5;
            GridVariant.Columns[0].Name = "STT";
            GridVariant.Columns[1].Name = "Mã Sản Phẩm";
            GridVariant.Columns[2].Name = "Tên";
            GridVariant.Columns[3].Name = "Số Lượng";
            GridVariant.Columns[4].Name = "Loại Sản Phẩm";
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
            foreach (var i in lst)
            {
                GridVariant.Rows.Add(stt, i.MaSp, i.ten, i.soluong, i.Loai);
                stt++;
            }
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

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemSP frm_ThemSP = new Frm_ThemSP();
            frm_ThemSP.Show();
        }
    }
}
