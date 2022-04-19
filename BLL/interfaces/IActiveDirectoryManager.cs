using DTO;

namespace BLL.interfaces
{
    public interface IActiveDirectoryManager
    {
        User GetUserByUsername(string username);

    }
}
