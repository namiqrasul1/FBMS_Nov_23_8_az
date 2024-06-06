using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Delegates
{
    internal class Class
    {
        //public delegate void MyDelegate(int arg, int arg1);
        //public void Foo(MyDelegate myDelegate)
        //{

        //}

        // Action    => return type is void
        // Func      => return type is some type (without void)
        // Predicate => return type is bool  (only one parameter)
        static void Main(string[] args)
        {
            //Action action = new Action(Foo);
            //action.Invoke();

            //Action<int> action = FooWithInt;
            //action.Invoke(4);

            //Action<string> a = FooWithString;
            //a("asjdas");

            //Action<bool, string, double, float, Electronic> some = FooWithParams;



            //Func<int> func = SomeMethod;
            //var r = func.Invoke();

            //Func<int, int, bool> func = Equal;
            //var r = func(1, 2);

            //Predicate<int> predicate = Any;


            //List<int> list = [1, 2, 4, 5, 6, 5432, 123, 123];
            //list.RemoveAll(Any);

            //list.FirstOrDefault()

            //list.ForEach(FooWithInt);


            // anonymous functions
            //Action<int> action = delegate (int a)
            //{
            //    // body
            //    Console.WriteLine(a);
            //};

            //action.Invoke(42);

            //List<int> list = [1, 2, 4, 5, 6, 5432, 123, 123];
            //int max = 42;
            //list.FindAll(delegate(int x) { return x < max; });

            //list.RemoveAll(delegate (int x) { return x < 10; });

            //list.ForEach(delegate (int x) { Console.Write($"{x} "); });


            /////////////////////////////////////
            /// lambda expression

            //(/*parameter list*/) =>
            //{
            //    //body
            //};

            //() => body;
            //Func<int, bool> func = x => x > 0;
            Predicate<int> predicate = x => { return x > 0; };
            List<int> list = [1, 2, 4, 5, 6, 5432, 123, 123];
            list.RemoveAll(i => 100 < i && i < 200);
            list.ForEach(i => Console.Write($"{i} "));

        }

        static bool Match(int x) {  return x < 50; }
        static bool Match1(int x) {  return x < 100; }

        static int SomeMethod() { return 0; }
        static bool Equal(int a, int b) { return a == b; }

        static bool Any(int x)
        {
            return x > 100;
        }

        static void Foo() { Console.WriteLine("Foo()"); }
        static void FooWithInt(int s) { Console.WriteLine($"FooWithInt({s})"); }
        static void FooWithString(string s) { Console.WriteLine("FooWithString(string)"); }
        static void FooWithParams(bool b, string s, double d, float f, Electronic electronic) { Console.WriteLine("FooWithParams(bool b, string s, double d, float f, Electronic electronic)"); }


    }
}
