namespace BLL.interfaces
{
    public interface IUserManager
    {
        float GetBalanceByUserId(int userId);
        bool Charge(int userId, float amount);
        bool Deposit(int userId, float amount);
    }
}