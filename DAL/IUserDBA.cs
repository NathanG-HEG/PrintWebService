using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUserDBA
    {
        float GetBalanceByUserId(int userId);
        bool SetBalance(int userId);
    }
}
