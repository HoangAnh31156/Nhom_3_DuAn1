using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface NhanVien_IRepos
    {
        List<NhanVien> GetAllNhanVien();
        List<NhanVien> GetNVByName(string name);
        bool CreateNhanVien(NhanVien nhanVien);
        bool UpdateNhanVien(NhanVien nhanVien);
    }
}
