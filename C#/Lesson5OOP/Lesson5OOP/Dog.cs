using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5OOP
{
    internal class Dog : Animal
    {
        public Dog(int age, Gender gender) : base(age, gender)
        {
        }

        public override int AbstractMethod()
        {
            throw new NotImplementedException();
        }

        public override void WhoAreYou()
        {
            Console.WriteLine("I am dog");
        }
    }
}
