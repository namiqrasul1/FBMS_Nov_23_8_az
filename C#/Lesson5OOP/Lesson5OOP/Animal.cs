using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5OOP
{
    internal abstract class Animal
    {
        protected Animal(int age, Gender gender)
        {
            Age = age;
            Gender = gender;
        }

        public int Age { get; set; }
        public Gender Gender { get; set; }

        public abstract void WhoAreYou();

        public void NormalMethod() { }
        public static void StaticMethod() { }
        public virtual void VirtualMethod() { }
        public abstract int AbstractMethod();

    }
}
