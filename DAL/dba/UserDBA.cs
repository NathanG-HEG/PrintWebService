using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL.dba
{
    public class UserDBA : IUserDBA
    {
        private string connectionString = null;
        public UserDBA()
        {
            connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }

        public decimal GetBalanceByUserId(int userId)
        {
            decimal balance = 0;
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Users WHERE User_Id = @userId;";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            balance = (decimal)dr["Balance"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while accessing MS-SQL user " + e.Message);
            }
            return balance;
        }

        public bool SetBalance(int userId, decimal balance)
        {
            int result = 0;
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users " +
                                   "SET balance = @balance " +
                                   "WHERE user_id = @userId;";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@balance", balance);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    cn.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while setting order status: " + e.Message);
            }

            //result is the number of line affected
            return result != 0;
        }
    }
}
