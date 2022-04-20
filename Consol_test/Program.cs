using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consol_test.PrintWebService;

namespace Consol_test
{
    public class Program
    {
        static void Main(string[] args)
        {
            localPrint.PrintWebServiceClient printWb = new localPrint.PrintWebServiceClient();
            printWb.TransferMoneyWithUsername("Benjamin", 10);
        }
    }
}
