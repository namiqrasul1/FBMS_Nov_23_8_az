using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4StructClass
{
    class Car(int year, string vendor, string model)
    {
        public int Year { get; set; } = year;
        public string Vendor { get; set; } = vendor;
        public string Model { get; set; } = model;
        public void Show() => Console.WriteLine($"{Year} {Vendor} {Year}");
        public const int i = 2;

        public static int staticField = 0;
        public static int MyProperty { get; set; }
        public static void Foo()
        {
            MyProperty++;
            staticField++;
            Console.WriteLine(i);
        }

        static Car()
        {
            Console.WriteLine("Static Constructor");
        }
    }
}
