using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Card CreditCard { get; set; }

        public User(string name, string surname, decimal amount, int year)
        {
            Name = name;
            Surname = surname;
            CreditCard = new Card(amount, year);
        }
    }
}
