using ConsoleApp1.Enums;
using ConsoleApp1.Helpers;

namespace ConsoleApp1.Models
{
    internal class Card
    {
        public string Pin { get; init; }
        public string Pan { get; init; }
        public string Cvc { get; init; }
        public string ExpireDate { get; init; }
        public decimal Balance { get; set; }

        public Card(decimal balance, int year)
        {
            Pin = RandomGenerator.GenerateString(4, RandomStringType.Numeric);
            Pan = RandomGenerator.GenerateString(16, RandomStringType.Numeric);
            Cvc = RandomGenerator.GenerateString(3, RandomStringType.Numeric);
            Balance = balance;
            ExpireDate = DateTime.Now.AddYears(year).ToString("MM/yy");
        }
        
    }
}
