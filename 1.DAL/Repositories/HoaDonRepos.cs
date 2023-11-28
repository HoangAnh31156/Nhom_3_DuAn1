using _1.DAL.IRepositories;
using _1.DAL.Model2s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonRepos : HoaDon_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public HoaDonRepos()
        {
            
        }

        public HoaDonRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public bool CreateHoaDon(HoaDon hoaDon)
        {
            try
            {
                _context.HoaDons.Add(hoaDon);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<HoaDon> GetHoaDon(string input)
        {
            if(input == null)
            {
                return _context.HoaDons.ToList();
            }
            var hoaDon = from a in _context.HoaDons
                         join b in _context.KhachHangs on a.IdKh equals b.IdKh
                         where a.IdKhNavigation.TenKh.Contains(input)
                         select a;

            return hoaDon.ToList();
        }

        public bool UpdateHoaDon(HoaDon hoaDon)
        {
            try
            {
                var updateHoaDon = _context.HoaDons.Find(hoaDon.IdHoaDon);

                updateHoaDon.TrangThai = hoaDon.TrangThai;

                _context.HoaDons.Update(updateHoaDon);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
