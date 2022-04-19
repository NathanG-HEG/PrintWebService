using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.interfaces;
using DAL;
using DTO;

namespace BLL.managers
{
    public class PaymentSystemManager: IPaymentSystemManager
    {
        private IPayementSystemDBA PayementSystemDBA { get; }
        public PaymentSystemManager(IPayementSystemDBA payementSystemDBA)
        {
            PayementSystemDBA = payementSystemDBA;
        }

        public User GetUserByCardId(int cardId)
        {
            return PayementSystemDBA.GetUserByCardId(cardId);
        }
    }
}
