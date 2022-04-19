    using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class ActiveDirectoryDBA : IActiveDirectoryDBA
    {
        private string connectionString = null;
        public ActiveDirectoryDBA()
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
                    string query = "SELECT * FROM ActiveDirectoryTable WHERE  username = @username;";
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
                Console.WriteLine("Exception caught while accessing active diretroy user " + e.Message);
            }
            return user;
        }
    }
}
