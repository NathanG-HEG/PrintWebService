using BLL.interfaces;
using DAL;
using DAL.dba;

namespace BLL.managers
{
    public class UserManager:IUserManager
    {
        private IUserDBA userDba;

        public UserManager(IUserDBA userDba)
        {
            this.userDba = userDba;
        }


        public float GetBalanceByUserId(int userId)
        {
            return userDba.GetBalanceByUserId(userId);
        }

        public bool Charge(int userId, float amount)
        {
            float balance = GetBalanceByUserId(userId);
            if (amount <= balance)
            {
                return userDba.SetBalance(userId, balance - amount);
            }
            return false;
        }

        public bool Deposit(int userId, float amount)
        {
            float balance = GetBalanceByUserId(userId);
            return userDba.SetBalance(userId, balance + amount);
        }
    }
}