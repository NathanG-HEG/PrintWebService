using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.interfaces;
using DTO;
using DAL;

namespace BLL.managers
{
    public class OnlinePaymentSystemManager : IOnlinePaymentSystemManager
    {
        private  IOnlinePayementSystemDBA OnlinePayementSystemDBA { get; }
        public OnlinePaymentSystemManager(IOnlinePayementSystemDBA onlinePayementSystemDBA)
        {
            OnlinePayementSystemDBA = onlinePayementSystemDBA;
        }
        public User GetUserByUsername(string username)
        {
            return OnlinePayementSystemDBA.GetUserByUsername(username);
        }
    }
}
