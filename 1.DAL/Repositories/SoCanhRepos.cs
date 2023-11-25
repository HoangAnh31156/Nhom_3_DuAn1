using _1.DAL.Model2s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class SoCanhRepos
    {
        private OnlyFansContext _onFansContext;
        public SoCanhRepos(OnlyFansContext onFansContext)
        {
            _onFansContext = onFansContext;
        }
        public SoCanhRepos()
        {

        }
        public bool CreateSoCanh(SoCanh SoCanh)
        {
            var obj = _onFansContext.SoCanhs.Add(SoCanh);
            if (obj != null)
            {
                return true;
            }
            return false;
        }

        public List<SoCanh> GetSoCanh(int name)
        {
            if (name == null)
            {
                return _onFansContext.SoCanhs.ToList();
            }
            return _onFansContext.SoCanhs.Where(x => x.SoCanh1 == name).ToList();
        }

        public bool UpdateSoCanh(SoCanh SoCanh)
        {
            var obj = _onFansContext.SoCanhs.Update(SoCanh);
            if (obj != null)
            {
                return true;
            }
            return false;
        }

    }
}
