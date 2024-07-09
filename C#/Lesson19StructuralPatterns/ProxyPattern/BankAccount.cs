using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class BankAccount : IBankAccount
    {
        decimal _balance;
        public void Deposit(decimal amount)
        {
            _balance += amount;
            Console.WriteLine($"{amount} deposited. New balance {_balance}");
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Withdraw(decimal amount)
        {
            if(amount < _balance)
            {
                _balance -= amount;
                Console.WriteLine($"{amount} withdrawn. New balance {_balance}");
            }
        }
    }
}
