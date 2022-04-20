using System;
using DTO;

namespace Console_app_test
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintWebService.PrintWebServiceClient printWs = new PrintWebService.PrintWebServiceClient();
            User user =  printWs.GetUserByCardId(123456789);
            Console.WriteLine(user.Balance);
            Console.WriteLine("hello world");
        }
    }
}
