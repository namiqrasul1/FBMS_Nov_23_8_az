using Lesson9GenericGenericCollectionExtensionMethod.Extensions;
using Lesson9GenericGenericCollectionExtensionMethod.Models;
using System.Collections;
// Action
// Func
// Predicate

class Program
{
    //static int Foo(int a)
    //{
    //    return a;
    //}

    static int WordCount(string str)
    {
        var s = "as, b";

        var count = str.Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        return count;
    }

    static void Print<T>(T[] a)
    {
        foreach (var i in a)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    //static int Divide<T>(T left, T right)
    //{
    //    return left * right;
    //}

    static int Foo<T, T1>(T a)
    {
        return 1;
    }

    static void SomeMethod<T>(T arg) where T : struct
    {
        // amazing codes
    }
    static void SomeMethod1<T>(T arg) where T : class, new()
    {
        // amazing codes
    }

    static void SomeMethod2<T>() where T : Exception
    {
        // amazing codes
    }

    //static void Main(string[] args)
    //{
    //    SomeMethod2<Category<string>>();

    //    //IInterface i = null;
    //    //SomeMethod(2);
    //    //SomeMethod("string");
    //    //SomeMethod(new Shoes());
    //    //SomeMethod(i);
    //    //Foo<int, double>(2);
    //    //var r = Divide(1, 2);
    //    //Console.WriteLine(r);
    //    //float[] arr = [1, 2, 4, 53, 64, 1, 2, 12];
    //    //Print(arr);


    //    //int x = 12;
    //    //int localFunc(int a) { return a + x; }
    //    //Func<int, int> func = Foo;
    //    //Func<int, int> func1 = delegate (int a) { return a + x; };
    //    //Func<int, int> func2 = a => { return a + x; };
    //    //Func<int, int> func3 = localFunc;

    //    //string str = "jfkjfsf s DSAD S";
    //    //str.WordCount();

    //    //string s = "daskjdaskljd sadas dsa";
    //    //s.WordCount();

    //    //int a = 42;
    //    //var r = a.IsPositive();


    //    Category<Trousers> category = new() { Product = new Trousers() };
    //}


    static void Main(string[] args)
    {
        //ArrayList al = new();
        //al.Add(1);
        //al.Add("hakuna");
        //var shoes = new Shoes();
        //al.Add(shoes);

        //foreach (var item in al)
        //{
        //    Console.WriteLine(item);
        //}

        //al.Remove("hakuna");
        //al.Remove(shoes);
        //Console.WriteLine("************************");
        //foreach (var item in al)
        //{
        //    Console.WriteLine(item);
        //}

        //Shoes ob = new();
        //Shoes o = ob;
        //ob.Equals(o);

        //al[0];

        //// boxing => value typein reference type kechmesi
        //object obj = 42;
        //// unboxing => reference typein value type kechmesi
        //int i = (int)obj;

        //Stack stack = new();
        //Stack<int> st = new();
        //stack.Pop();
        //st.Pop();

        List<string> strings = ["hakuna", "matata", "john", "kamil"];

        //var name =  strings.Find(s => s.Contains('a'));
        //Console.WriteLine(name);

        //var list = strings.FindAll(s => s.Contains('h'));

        //foreach (var item in list)
        //{
        //    Console.WriteLine(item);
        //}

        // linq
        //var s = strings.First(x => x.Contains('q'));
        //var s = strings.FirstOrDefault(x => x.Contains('q'));
        //Console.WriteLine(s);

        //var s = strings.OrderBy(x => x).ToList();
        //s.ForEach(s => Console.WriteLine(s));

        //var r = strings.Single(x => x.Contains('o'));
        //var r = strings.Single(x => x.Contains('a'));
        //var r = strings.Single(x => x.Contains('Q'));
        //var r = strings.SingleOrDefault(x => x.Contains('a'));
        //Console.WriteLine(r);

        //int a = 2;
        //a.Sum(3);

        //var obj = new { Ad = "hakuna", Soyad = "matata" };
        //Console.WriteLine(obj);
    }
}