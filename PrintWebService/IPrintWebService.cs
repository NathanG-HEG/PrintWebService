using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;

namespace PrintWebService
{
    [ServiceContract]
    public interface IPrintWebService
    {
        [OperationContract]
        bool IsRegistered(string userName);

        [OperationContract]
        bool Print(int nbCopies, string productName, int cardId);

        [OperationContract]
        void TransferMoneyWithCardId(int cardId, float quota);

        [OperationContract]
        void TransferMoneyWithUsername(string userName, float quota);

        [OperationContract]
        User GetUserByCardId(int cardId);

        [OperationContract]
        void DebitAccount(int userId, float amount);
        
        

    }
}
