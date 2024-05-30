using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5OOP
{
    internal class Cat : Animal
    {
        public Cat(int age, Gender gender): base(age, gender) { }

        public override int AbstractMethod()
        {
            return 1;
        }

        public override void WhoAreYou()
        {
            Console.WriteLine("I am Cat");
        }
    }
}
