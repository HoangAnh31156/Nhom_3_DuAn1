using _2.BUS.Services;
using _3.PRL.Views.DangNhap;
using _3.PRL.Views.SanPham;
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
    public partial class Frm_SanPham : Form
    {
        SanPhamService _SanphamService;
        BienTheService _BienTheService;
        List<Panel> panels = new List<Panel>();
        int sd = 0;
        int sc = 9;
        int st = 1;
        public Frm_SanPham()
        {
            InitializeComponent();
            _BienTheService = new BienTheService();
            _SanphamService = new SanPhamService();
            LoadSP(sd, sc);
            if (st < 2)
            {
                button1.Enabled = false;
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

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemSP fThemSP = new Frm_ThemSP();
            fThemSP.Show();
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
            Frm_ThemBienThe frm_ThemBienThe = new Frm_ThemBienThe();
            frm_ThemBienThe.Show();
        }

        private void LoadSP(int sodau, int socuoi)
        {
            var lst = (from b in _SanphamService.GetSanPham(null)
                       join a in _BienTheService.GetBienThe(null)
                       on b.IdSanPham equals a.IdSanPham
                       group a by b into g
                       select new
                       {
                           Ten = g.Key.Ten,
                           Gia = g.Select(x => x.GiaTien).ToArray(),
                           Hinh = g.Select(x => x.HinhAnh).ToArray()
                       }).ToArray();
            if (txtSearch.Text != null)
            {
                lst = lst.Where(x => x.Ten.ToLower().Contains(txtSearch.Text.ToLower())).ToArray();
            }
            int d = 0;
            int cardWidth = 456; // Kích thước chiều rộng của card
            int cardHeight = 200; // Kích thước chiều cao của card
            int cardSpacingX = 60; // Khoảng cách giữa các card theo chiều ngang
            int cardSpacingY = 30; // Khoảng cách giữa các card theo chiều dọc
            int cardsPerRow = 3; // Số lượng card trên mỗi dòng
            int startX = this.Width - cardWidth - 90; // Vị trí x ban đầu, tính từ lề phải
            int startY = 150 + 45; // Vị trí y ban đầu, dịch xuống 45px
            int pictureOffsetX = 10; // Khoảng cách giữa PictureBox và thành phải của card
            int labelPriceOffsetY = 5; // Khoảng cách giữa Label giá và thành dưới của card
            int max = lst.Count() > socuoi ? socuoi : lst.Count();
            for (int i = sodau; i < max; i++)
            {
                if (i < lst.Count())
                {
                    var priceMin = (lst[i].Gia.Length > 0) ? lst[i].Gia.Min() : 0;
                    var priceMax = (lst[i].Gia.Length > 0) ? lst[i].Gia.Max() : 0;
                    Panel cardPanel = new Panel();
                    cardPanel.BackColor = Color.White;
                    cardPanel.BorderStyle = BorderStyle.FixedSingle;
                    cardPanel.Size = new Size(cardWidth, cardHeight);

                    int row = d / cardsPerRow;
                    int col = d % cardsPerRow;

                    int cardPosX = startX - col * (cardWidth + cardSpacingX);
                    int cardPosY = startY + row * (cardHeight + cardSpacingY);

                    cardPanel.Location = new Point(cardPosX, cardPosY);

                    Label lbl = new Label();
                    lbl.Text = lst[i].Ten;
                    lbl.Font = new Font(lbl.Font.FontFamily, 12, FontStyle.Bold);
                    lbl.Size = new Size(180, 60);
                    lbl.Location = new Point(20, 20);

                    Label label = new Label();
                    if (priceMax > priceMin)
                    {
                        label.Text = "Giá: " + string.Format("{0:0.00}", priceMin) + " - " + string.Format("{0:0.00}", priceMax) + "VND";
                    }
                    else
                    {
                        label.Text = "Giá: " + string.Format("{0:0.00}", priceMin) + "VND";
                    }
                    label.Font = new Font(label.Font.FontFamily, 10);
                    label.Size = new Size(360, 80);
                    label.ForeColor = Color.Red;
                    label.Location = new Point(20, cardHeight - label.Height - labelPriceOffsetY + 45); // Đặt vị trí cố định cho label

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(190, 170);
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.Location = new Point(cardWidth - pictureBox.Width - pictureOffsetX, 15); // Đặt vị trí cố định cho pictureBox
                    if (lst[i].Hinh[0] != null)
                    {
                        using (MemoryStream ms = new MemoryStream(lst[i].Hinh[0]))
                        {
                            Image img = Image.FromStream(ms);
                            pictureBox.Image = img;
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        pictureBox.Image = null;
                    }

                    cardPanel.Controls.Add(lbl);
                    cardPanel.Controls.Add(label);
                    cardPanel.Controls.Add(pictureBox);
                    panels.Add(cardPanel);
                    this.Controls.Add(cardPanel);
                    cardPanel.BringToFront();
                    lbl.BringToFront();
                    label.BringToFront();
                    pictureBox.BringToFront();
                    d++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lst = (from b in _SanphamService.GetSanPham(null)
                       join a in _BienTheService.GetBienThe(null)
                       on b.IdSanPham equals a.IdSanPham
                       group a by b into g
                       select new
                       {
                           Ten = g.Key.Ten,
                           Gia = g.Select(x => x.GiaTien).ToArray(),
                           Hinh = g.Select(x => x.HinhAnh).ToArray()
                       }).ToArray();
            if (lst.Count() > st * 9)
            {
                for (int i = 0; i < panels.Count; i++)
                {
                    this.Controls.Remove(panels[i]);
                }
                sd += 9;
                sc += 9;
                st += 1;
                if (st < 2)
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
                LoadSP(sd, sc);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < panels.Count; i++)
            {
                this.Controls.Remove(panels[i]);
            }
            if (st > 1)
            {
                sd -= 9;
                sc -= 9;
                st -= 1;
                if (st < 2)
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
                LoadSP(sd, sc);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < panels.Count; i++)
            {
                this.Controls.Remove(panels[i]);
            }
            LoadSP(sd, sc);
        }
    }
}
