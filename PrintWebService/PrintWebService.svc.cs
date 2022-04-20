using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;
using BLL;
using BLL.interfaces;
using BLL.managers;
using DAL;
using DAL.dba;

namespace PrintWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PrintWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PrintWebService.svc or PrintWebService.svc.cs at the Solution Explorer and start debugging.
    public class PrintWebService : IPrintWebService
    {

        public bool Print(int nbCopies, string productName, int cardId)
        {
            ISapManager sapManager = new SapManager(new SAP_DBA());
            User user = sapManager.GetUserByCardId(cardId);
            PrintPriceManager printPriceManager = new PrintPriceManager(new PrintPriceDBA());
            float price = printPriceManager.GetPriceByProductName(productName) * nbCopies;
            return price <= user.Balance;

        }

        public void TransferMoneyWithCardId(int cardId, float quota)
        {
            IPaymentSystemManager paymentSystemManager = new PaymentSystemManager(new PayementSystemDBA());
            User user = paymentSystemManager.GetUserByCardId(cardId);
            IUserManager userManager = new UserManager(new UserDBA());
            userManager.Deposit(user.UserId, quota);
        }

        public void TransferMoneyWithUsername(string userName, float quota)
        {
            //first look for a user in the online payment database
            IOnlinePaymentSystemManager onlinePaymentMgr =
                new OnlinePaymentSystemManager(new OnlinePayementSystemDBA());
            User user = onlinePaymentMgr.GetUserByUsername(userName);
            if (user != null)
            {
                //deposit money
                IUserManager userManager = new UserManager(new UserDBA());
                userManager.Deposit(user.UserId, quota);
                return;
            }

            //if no user where found, look in the faculties database
            IFacultyManager facultyManager =
                new FacultyManager(new FacultyDBA());
            user = facultyManager.GetUserByUsername(userName);
            if (user != null)
            {
                //deposit money
                IUserManager userManager = new UserManager(new UserDBA());
                userManager.Deposit(user.UserId, quota);
            }

        }

        public User GetUserByCardId(int cardId)
        {
            ISapManager sapManager = new SapManager(new SAP_DBA());
            return sapManager.GetUserByCardId(cardId);
        }

        //pass the actual number of printed copies (in case not all copies were printed)
        public void DebitAccount(int nbCopies, string productName, int cardId)
        {
            ISapManager sapManager = new SapManager(new SAP_DBA());
            User user = sapManager.GetUserByCardId(cardId);
            PrintPriceManager printPriceManager = new PrintPriceManager(new PrintPriceDBA());
            float price = printPriceManager.GetPriceByProductName(productName) * nbCopies;
            IUserManager userManager = new UserManager(new UserDBA());
            userManager.Charge(user.UserId, price);
        }
    }
}
