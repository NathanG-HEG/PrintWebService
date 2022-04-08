using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ISAP_DBA
    {
        User GetUserByUsername(string username);
        User GetUserByCardId(int cardId);
    }
}
