using Lesson13LoginRegister.Models;
using System.Text.Json;

namespace Lesson13LoginRegister.Services
{
    internal static class UserManager
    {
        private static List<User> Users { get; set; } 
        public static User? User { get; set; }

        static UserManager()
        {
            if (File.Exists("users.json"))
            {
                var json = File.ReadAllText("users.json");
                var listOfUser = JsonSerializer.Deserialize<List<User>>(json);
                if(listOfUser is not null) Users = listOfUser;
            }
            Users ??= [];
        }

        public static bool Register(string name, string email, string pass, string date)
        {
            email = email.ToLower().Trim();
            var user = Users.FirstOrDefault(u => u.Email == email);
            if (user is null)
            {
                user = new User
                {
                    Name = name,
                    Email = email,
                    Password = pass,
                    DateOfBirth = DateOnly.ParseExact(date, "dd.MM.yyyy")

                };
                Users.Add(user);

                var json = JsonSerializer.Serialize(Users);
                File.WriteAllText("users.json", json);

                return true;
            }

            throw new Exception("User already exist");
        }

        public static bool Login(string email, string password)
        {
            User = Users.FirstOrDefault(u => u.Email == email.ToLower().Trim() && u.Password == password);

            return User is not null;
        }

        public static void Logout()
        {
            User = null;
        }

    }
}
