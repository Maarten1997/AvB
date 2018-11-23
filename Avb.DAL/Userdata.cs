using System;
using System.Data.SqlClient;

namespace Avb.DAL
{
    public class Userdata
    {
        public bool Login(string username, string password)
        {
            string connectionstring = "Server = tcp:avb.database.windows.net,1433; Initial Catalog = AvB-Database; Persist Security Info = False; User ID=Maarten; Password = Tommy2004!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
            SqlConnection conn = new SqlConnection(connectionstring);
            string query = "select * from [User] where Username = @username and Password = @password";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            string databaseUsername = "";
            string databasePassword = "";
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    databaseUsername = reader.GetString(0);
                    databasePassword = reader.GetString(1);
                }
            }
            conn.Close();
            if (username == databaseUsername && password == databasePassword)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
