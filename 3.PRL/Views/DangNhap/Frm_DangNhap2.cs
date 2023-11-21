using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PRL.Views.DangNhap
{
    public partial class Frm_DangNhap2 : Form
    {
        public Frm_DangNhap2()
        {
            InitializeComponent();
        }

        private void linkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Frm_QuenMK frm_QuenMK = new Frm_QuenMK();
            frm_QuenMK.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TrangChu frm_TrangChu = new Frm_TrangChu();
            frm_TrangChu.Show();
        }
    }
}
