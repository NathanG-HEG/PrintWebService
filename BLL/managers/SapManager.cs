using BLL.interfaces;
using DAL;
using DTO;

namespace BLL.managers
{
    public class SapManager:ISapManager
    {
        private ISAP_DBA sapDba;

        public SapManager(ISAP_DBA sapDba)
        {
            this.sapDba = sapDba;
        }

        public User GetUserByUsername(string username)
        {
            return sapDba.GetUserByUsername(username);
        }

        public User GetUserByCardId(int cardId)
        {
            return sapDba.GetUserByCardId(cardId);
        }
    }
}