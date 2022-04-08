using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;

namespace PrintWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPrintWebService" in both code and config file together.
    [ServiceContract]
    public interface IPrintWebService
    {
        [OperationContract]
        bool IsRegisterd(string userName);

        [OperationContract]
        bool Print(int nbCopies, string productName, int cardId);

        [OperationContract]
        void TransferMoney(int userId, float quota);

        [OperationContract]
        void TransferMoney(string userName, float quota);

        [OperationContract]
        User GetUserByCardId(int cardId);

        [OperationContract]
        void DebitAccount(int userId);
        
        

    }
}
