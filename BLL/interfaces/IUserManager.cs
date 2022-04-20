namespace BLL.interfaces
{
    public interface IUserManager
    {
        decimal GetBalanceByUserId(int userId);
        bool Charge(int userId, decimal amount);
        bool Deposit(int userId, decimal amount);
    }
}