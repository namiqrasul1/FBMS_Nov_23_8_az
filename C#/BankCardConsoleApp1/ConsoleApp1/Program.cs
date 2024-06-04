using ConsoleApp1;
using ConsoleApp1.Helpers;
using ConsoleApp1.Models;

// public              
// private            
// protected
// internal
// protected internal
// private protected
//Console.WriteLine("{0} {1}", 4,5);

//Card card = new(2, 2);

//Console.WriteLine(card.Pan);
//Console.WriteLine(card.Pin);
//Console.WriteLine(card.Cvc);
//Console.WriteLine(card.ExpireDate);


//var str = RandomGenerator.GenerateString(16, ConsoleApp1.Enums.RandomStringType.AlphaNumeric);
//Console.WriteLine(str);

Bank bank = new();
bank.ShowAllCards();

while (true)
{
    login:
    if(bank._user is null)
    {
        try
        {
            Console.Write("pan: ");
            var pan = Console.ReadLine();
            Console.Write("pin: ");
            var pin = Console.ReadLine();
            bank.Login(pan!, pin!);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Thread.Sleep(1000);
            goto login;
        }
       
    }
    


}
