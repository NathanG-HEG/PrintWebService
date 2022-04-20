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
        bool Print(int nbCopies, string productName, int cardId);

        [OperationContract]
        void TransferMoneyWithCardId(int cardId, decimal quota);

        [OperationContract]
        void TransferMoneyWithUsername(string userName, decimal quota);

        [OperationContract]
        User GetUserByCardId(int cardId);

        [OperationContract]
        void DebitAccount(int nbCopies, string productName, int cardId);
        
        

    }
}
