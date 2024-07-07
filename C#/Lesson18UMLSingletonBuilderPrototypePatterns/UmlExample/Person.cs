using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlExample
{
    internal class Person
    {
        private static int _id = 1;
        private int id;
        private string name;
        private int age;
        private float salary;

        public static int NextId() => _id++;
        public string Name { get => name; set => name = value; }
    }
}
