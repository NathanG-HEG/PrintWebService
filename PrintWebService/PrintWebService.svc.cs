using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;

namespace PrintWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PrintWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PrintWebService.svc or PrintWebService.svc.cs at the Solution Explorer and start debugging.
    public class PrintWebService : IPrintWebService
    {
        public bool IsRegistered(string userName)
        {
            throw new NotImplementedException();
        }

        public bool Print(int nbCopies, string productName, int cardId)
        {
            throw new NotImplementedException();
        }

        public void TransferMoneyWithUserId(int userId, float quota)
        {
            throw new NotImplementedException();
        }

        public void TransferMoneyWithUsername(string userName, float quota)
        {
            throw new NotImplementedException();
        }

        public User GetUserByCardId(int cardId)
        {
            throw new NotImplementedException();
        }

        public void DebitAccount(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
