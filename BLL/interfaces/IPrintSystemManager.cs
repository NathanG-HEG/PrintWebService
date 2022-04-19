using DTO;

namespace BLL.interfaces
{
    public interface IPrintSystemManager
    {
        User GetUserByCardId(int cardId);

    }
}