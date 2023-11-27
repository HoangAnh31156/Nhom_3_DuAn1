using _1.DAL.Model2s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class SanPhamRepos
    {
        private OnlyFansContext _onFansContext = new OnlyFansContext();
        public SanPhamRepos(OnlyFansContext onFansContext)
        {
            _onFansContext = onFansContext;
        }
        public SanPhamRepos()
        {

        }
        public bool CreateSanPham(SanPham SanPham)
        {
            try
            {
                var obj = _onFansContext.SanPhams.Add(SanPham);
                _onFansContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<SanPham> GetSanPham(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _onFansContext.SanPhams.ToList();
            }
            return _onFansContext.SanPhams.Where(x => x.Ten.ToLower().Contains(name.ToLower())).ToList();
        }

        public bool UpdateSanPham(SanPham SanPham)
        {
            try
            {
                var obj = _onFansContext.SanPhams.Update(SanPham);
                _onFansContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
