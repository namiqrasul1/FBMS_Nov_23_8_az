using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Bank
    {
        private static List<User> users = new()
        {
            new User("Hakuna", "Matata", 420, 3),
            new User("John", "Doe", 100, 3),
            new User("Kamil", "Kamilli", 150, 3),
            new User("Fazil", "Fazilli", 300, 3),
            new User("Nazim", "Nazimli", 5, 3),
        };
        public User? _user = null;

        public void Login(string pan, string pin)
        {
            foreach (var user in users)
            {
                if (user.CreditCard.Pan == pan && user.CreditCard.Pin == pin)
                {
                    _user = user;
                    return;
                }
            }
            throw new Exception("Invalid pan or pin");
        }

        public void Logout() => _user = null;

        public void Deposit(decimal amount)
        {
            if (_user is null)
                throw new Exception("User is null");
            if (amount < 0)
                throw new ArgumentException("Amount is negative");
            _user.CreditCard.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (_user is null) 
                throw new Exception("User is null");
            if (_user.CreditCard.Balance < amount)
                throw new ArgumentException("Not enough money");
            _user.CreditCard.Balance -= amount;
        }

        public void ShowAllCards()
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name} {user.CreditCard.Pan} {user.CreditCard.Pin}");
            }
        }
    }
}
