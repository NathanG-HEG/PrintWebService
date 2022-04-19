using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.dba
{
    public class PrintSystemDBA : IPrintSystemDBA
    {

        private string connectionString = null;
        public PrintSystemDBA()
        {
            connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }

        public User GetUserByCardId(int cardId)
        {
            User user = null;
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM PrintSystemTable WHERE  card_id = @cardId;";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@cardId", cardId);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            user = new User();
                            user.UserId = (int)dr["User_id"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while accessing payement system user " + e.Message);
            }
            return user;
        }
    }
}
