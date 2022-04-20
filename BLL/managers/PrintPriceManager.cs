using BLL.interfaces;
using DAL;

namespace BLL.managers
{
    public class PrintPriceManager:IPrintPriceManager
    {
        private IPrintPriceDBA printPriceDba;

        public PrintPriceManager(IPrintPriceDBA printPriceDba)
        {
            this.printPriceDba = printPriceDba;
        }

        public decimal GetPriceByProductName(string productName)
        {
            return printPriceDba.GetPriceByProductName(productName);
        }

    }
}