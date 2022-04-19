using DTO;

namespace BLL.interfaces
{
    public interface IPaymentSystemManager
    {
        User GetUserByCardId(int cardId);

    }
}