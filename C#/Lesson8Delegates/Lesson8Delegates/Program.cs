//using System.Security.AccessControl;

//internal class Program
//{
//    public delegate void MyDelegate();
//    internal delegate bool MyDel(int x);
//    private static void Main(string[] args)
//    {
//        //MyDelegate md = new MyDelegate(Foo);
//        //MyDelegate md = Foo;
//        //md += Boo;
//        //md -= Foo;
//        //md.Invoke();

//        // += // subscribe
//        // -= // unsubscribe
//        // =

//        //MyDel my = Goo;
//        //var result = my(65);


//        MyDe my = Method1;
//        my += Method2;
//        my += Method3;
//        my += Method4;

//        var r = my.Invoke(1);

//        foreach (var x in my.GetInvocationList())
//        {
//            Console.WriteLine(x.Method.IsStatic);
//            Console.WriteLine(x.Method.Name);
//            var paramInfos =  x.Method.GetParameters();
//            foreach (var item in paramInfos)
//            {
//                Console.WriteLine(item.Name);
//            }
//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine();
//        }



//    }
//    static void Foo() { Console.WriteLine("Foo()"); }
//    static void Boo() { Console.WriteLine("Boo()"); }

//    static bool Goo(int a) { return a > 0; }

//    delegate int MyDe(int x);

//    static int Method1(int a) { return a + 1; }
//    static int Method2(int b) { return b + 2; }
//    static int Method3(int ad) { return ad + 3; }
//    static int Method4(int a431) { return a431 + 4; }
//}



//// Function pointer
//// Pointer to function


//// int[] ints = [1,2,36,456,34,4,1241,23,6,67,4];
//// person[] people = [...]
//// void sort(T[] arr, funcPointer){
////  if(funcPointer()])
////
//// }

