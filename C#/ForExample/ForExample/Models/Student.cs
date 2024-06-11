using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForExample.Models
{
    public class Student
    {
        private static int _id = 1;
        public int Id { get; init; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public Student()
        {
            Id = _id++;
        }

        public override string ToString() => $"{Id} {Name} {Surname} {DateOfBirth}";
    }
}
