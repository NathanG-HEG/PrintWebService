using BLL.interfaces;
using DAL;
using DAL.dba;

namespace BLL.managers
{
    public class UserManager : IUserManager
    {
        private IUserDBA userDba;

        public UserManager(IUserDBA userDba)
        {
            this.userDba = userDba;
        }


        public decimal GetBalanceByUserId(int userId)
        {
            return userDba.GetBalanceByUserId(userId);
        }

        public bool Charge(int userId, decimal amount)
        {
            decimal balance = GetBalanceByUserId(userId);
            if (amount <= balance && amount > 0)
            {
                return userDba.SetBalance(userId, balance - amount);
            }
            return false;
        }

        public bool Deposit(int userId, decimal amount)
        {
            decimal balance = GetBalanceByUserId(userId);
            if (decimal.MaxValue - amount <= balance || amount < 0)
            {
                return false;
            }
            return userDba.SetBalance(userId, balance + amount);
        }
    }
}