using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PrintPriceDBA : IPrintPriceDBA
    {

        private string connectionString = null;
        public PrintPriceDBA()
        {
            connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }

        public decimal GetPriceByProductName(string productName)
        {
            int price = 0;
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM PrintPrices WHERE Product_Name = @productName;";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            price = (int)dr["priceInCents"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while accessing print prices " + e.Message);
            }
            return ((decimal)price) / 100;
        }
    }
}
