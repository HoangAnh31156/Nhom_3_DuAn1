using _3.PRL.Views;
using _3.PRL.Views.BaoHanh;
using _3.PRL.Views.DangNhap;
using _3.PRL.Views.KhachHang;
using _3.PRL.Views.NhanVien;
using _3.PRL.Views.SanPham;

namespace _3.PRL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Frm_DangNhap2());

            // Source Tree
        }
    }
}