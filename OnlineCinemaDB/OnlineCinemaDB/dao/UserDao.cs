using OnlineCinemaDB.entity;
using OnlineCinemaDB.utility;
using System;
using System.Data;
using System.Data.SqlClient;

namespace OnlineCinemaDB.dao
{
    public class UserDao
    {
        public User findByLogin(string login)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select * from users where login = @login";
            using (var connection = Database.getConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    return new User(
                        row["login"].ToString(),
                         row["name"].ToString(),
                          row["password"].ToString(),
                           row["salt"].ToString(),
                             (Access)Enum.Parse(typeof(Access), row["role"].ToString()));
                }
                else throw new Exception();
            }

        }

        public void addUser(User user)
        {
            try
            {
                using (var connection = Database.getConnection())
                {
                    connection.Open();
                    string query = "insert into users (login, name, password, salt, role) values (@login, @name, @password, @salt, @role)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@login", user.Login);
                    command.Parameters.AddWithValue("@name", user.Name);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@salt", user.Salt);
                    command.Parameters.AddWithValue("@role", user.Role.ToString());
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}