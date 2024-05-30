using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4StructClass
{
    internal class Student
    {
        private int age;
        public int GetAge() => age;  // return age;
        public void SetAge(int value)
        {
            age = 16 <= value ? value : throw new ArgumentException();
        }

        // Property 

        private string name;

        public string Name
        {
            get => name;
            set
            {
                name = !value.Contains("1") ? value : throw new ArgumentException();
            }
        }

        public string Surname { get; set; } // auto property

        public float Average { get; set; }


        public Student(int age, string name, string surname, float avg)
        {
            SetAge(age);
            Name = name;
            Surname = surname;
            Average = avg;
        }

        public override string ToString() => $"{Name} {Surname} {age} {Average}";

        //~Student() { } // finalizer
    }
}
