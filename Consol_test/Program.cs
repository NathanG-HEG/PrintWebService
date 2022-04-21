using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consol_test.PrintWebService;
using DTO;
using User = Consol_test.PrintWebService.User;

namespace Consol_test
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            localPrint.PrintWebServiceClient printWb = new localPrint.PrintWebServiceClient();
            printWb.DebitAccount(1, "A4BW", 123456789);
            



        }
    }
}
