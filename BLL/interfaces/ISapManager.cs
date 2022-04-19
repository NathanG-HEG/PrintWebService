using DTO;

namespace BLL.interfaces
{
    public interface ISapManager
    {
        User GetUserByUsername(string username);
        User GetUserByCardId(int cardId);
    }
}