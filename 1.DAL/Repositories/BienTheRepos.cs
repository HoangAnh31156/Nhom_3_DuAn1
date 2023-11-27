using _1.DAL.Model2s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class BienTheRepos
    {
        private OnlyFansContext _onFansContext = new OnlyFansContext();
        public BienTheRepos(OnlyFansContext onFansContext)
        {
            _onFansContext = onFansContext;
        }
        public BienTheRepos()
        {

        }
        public bool CreateBienThe(BienThe BienThe)
        {
            var obj = _onFansContext.BienThes.Add(BienThe);
            if (obj != null)
            {
                return true;
            }
            return false;
        }

        public List<BienThe> GetBienThe(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _onFansContext.BienThes.ToList();
            }
            return _onFansContext.BienThes.Where(x => x.MaBienThe.ToLower().Contains(name.ToLower())).ToList();
        }

        public bool UpdateBienThe(BienThe BienThe)
        {
            var obj = _onFansContext.BienThes.Update(BienThe);
            if (obj != null)
            {
                return true;
            }
            return false;
        }
    }
}
