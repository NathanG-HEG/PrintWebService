using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OnlinePayementSystemDBA : IOnlinePayementSystemDBA
    {
        private string connectionString = null;
        public OnlinePayementSystemDBA()
        {
            connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }

        public User GetUserByUsername(string username)
        {
            User user = null;
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM OnlinePayementSystemTable WHERE username = @username;";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);
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
                Console.WriteLine("Exception caught while accessing online payement system user " + e.Message);
            }
            return user;
        }
    }
}
