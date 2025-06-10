namespace OnlineCinemaDB.entity
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public Access Role { get; set; }


        public User(string login, string name, string password, string salt, Access role)
        {
            Login = login;
            Name = name;
            Password = password;
            Salt = salt;
            Role = role;
        }
    }

    public enum Access { admin, moderator }
}
