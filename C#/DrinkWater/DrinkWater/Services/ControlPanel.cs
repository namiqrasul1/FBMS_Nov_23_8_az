using DrinkWater.Models;
using System.Text.Json;

namespace DrinkWater.Services
{
    internal class ControlPanel
    {
        public User? User { get; set; }

        public ControlPanel()
        {
            if (File.Exists("user.json"))
            {
                var text = File.ReadAllText("user.json");
                User = JsonSerializer.Deserialize<User>(text);
            }
            if (User is null)
            {
                Console.WriteLine("Name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Weight: ");
                double.TryParse(Console.ReadLine(), out var weight);
                User = new User
                {
                    CurrentDate = DateTime.Now,
                    Weight = weight,
                    Name = name,
                    CurrentLitr = 0,
                    History = new()
                };
            }
        }

        public void DrinkWater()
        {
            if (User is null) throw new Exception("user not found");
            Console.WriteLine("Litr: ");
            _ = double.TryParse(Console.ReadLine(), out double litr);
            User.CurrentLitr += litr;
        }

        public void EndDate()
        {
            if (User is null) throw new Exception("user not found");

            var item = new HistoryItem(User.CurrentDate.ToString("dd.MM.yyyy"), User.CurrentLitr);
            User.History.Add(item);

            User.CurrentDate = User.CurrentDate.AddDays(1);
        }

        public void ShowHistory()
        {
            if (User is null) throw new Exception("user not found");

            Console.Clear();
            Console.WriteLine("Date      | Litr");
            foreach (var item in User.History)
            {
                Console.WriteLine($"{item.Date} | {item.Litr}");
            }
        }

        public bool Exit()
        {
            SaveChanges();
            return true;
        }

        public void SaveChanges()
        {
            var json = JsonSerializer.Serialize(User);
            File.WriteAllText("user.json", json);
        }
    }
}
