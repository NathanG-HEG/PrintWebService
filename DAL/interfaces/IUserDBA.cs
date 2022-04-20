using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUserDBA
    {
        decimal GetBalanceByUserId(int userId);
        bool SetBalance(int userId, decimal balance);
    }
}
