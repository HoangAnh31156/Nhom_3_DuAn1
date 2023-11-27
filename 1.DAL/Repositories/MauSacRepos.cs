using _1.DAL.Model2s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class MauSacRepos
    {
        private OnlyFansContext _onFansContext = new OnlyFansContext();
        public MauSacRepos(OnlyFansContext onFansContext)
        {
            _onFansContext = onFansContext;
        }
        public MauSacRepos()
        {

        }
        public bool CreateMau(Mau Mau)
        {
            var obj = _onFansContext.Maus.Add(Mau);
            if (obj != null)
            {
                return true;
            }
            return false;
        }

        public List<Mau> GetMau(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _onFansContext.Maus.ToList();
            }
            return _onFansContext.Maus.Where(x => x.TenMau.ToLower().Contains(name.ToLower())).ToList();
        }

        public bool UpdateMau(Mau Mau)
        {
            var obj = _onFansContext.Maus.Update(Mau);
            if (obj != null)
            {
                return true;
            }
            return false;
        }
    }
}
