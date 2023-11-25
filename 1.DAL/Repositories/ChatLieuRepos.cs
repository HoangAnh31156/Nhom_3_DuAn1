using _1.DAL.Model2s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChatLieuRepos
    {
        private OnlyFansContext _onFansContext;
        public ChatLieuRepos(OnlyFansContext onFansContext)
        {
            _onFansContext = onFansContext;
        }
        public ChatLieuRepos()
        {

        }

        public List<ChatLieu> GetChatLieu(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _onFansContext.ChatLieus.ToList();
            }
            return _onFansContext.ChatLieus.Where(x => x.TenChatLieu.ToLower().Contains(name.ToLower())).ToList();
        }

        public bool CreateChatLieu(ChatLieu chatlieu)
        {
            var obj = _onFansContext.ChatLieus.Add(chatlieu);
            if (obj != null)
            {
                return true;
            }
            return false;
        }


        public bool UpdateChatLieu(ChatLieu chatlieu)
        {
            var obj = _onFansContext.ChatLieus.Update(chatlieu);
            if (obj != null)
            {
                return true;
            }
            return false;
        }
    }
}
