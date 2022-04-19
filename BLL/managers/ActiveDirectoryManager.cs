using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.interfaces;

namespace BLL.managers
{
    public class ActiveDirectoryManager : IActiveDirectoryManager
    {
        private IActiveDirectoryDBA AD_DBA { get; }
        public ActiveDirectoryManager(IActiveDirectoryDBA adDba)
        {
            AD_DBA = adDba;
        }

        public User GetUserByUsername(string username)
        {
            return AD_DBA.GetUserByUsername(username);
        }
    }
}
