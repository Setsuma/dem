using System.Data.SqlClient;

namespace OnlineCinemaDB.utility
{
    public class Database
    {
        public static SqlConnection getConnection()
        {
            return new SqlConnection("Data Source=LAPTOP-VOR249IO;Initial Catalog=cinema_online;Integrated Security=True");
        }
    }
}