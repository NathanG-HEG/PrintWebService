using BLL.interfaces;
using DTO;

namespace BLL.managers
{
    public class PrintSystemManager:IPrintSystemManager
    {
        private IPrintSystemManager printSystemManager;

        public PrintSystemManager(IPrintSystemManager printSystemManager)
        {
            this.printSystemManager = printSystemManager;
        }


        public User GetUserByCardId(int cardId)
        {
            return printSystemManager.GetUserByCardId(cardId);
        }
    }
}