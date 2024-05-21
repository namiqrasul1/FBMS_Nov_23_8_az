//string[] arr = { "1. Home", "2. About", "3. Exit", "4. Contact" };

//var index = 0;

//while (true)
//{
//    Console.Clear();
//    for (var i = 0; i < arr.Length; i++)
//    {
//        if (index == i)
//            Console.ForegroundColor = ConsoleColor.Green;
//        else
//            Console.ForegroundColor = ConsoleColor.White;
//        Console.WriteLine(arr[i]);
//    }

//    ConsoleKeyInfo key = Console.ReadKey();
//    switch (key.Key)
//    {
//        case ConsoleKey.UpArrow:
//            index = index == 0 ? arr.Length - 1 : index - 1;
//            break;
//        case ConsoleKey.DownArrow:
//            index = index == arr.Length - 1 ? 0 : index + 1;

//            break;
//        default:
//            break;


//    }

//    //index = index == arr.Length - 1 ? 0 : index == 0 ? 5 : 140;

//}





//enum EmailStatus
//{
//    Read,
//    Unread,
//    Draft,
//    Sent
//}


//int? a = null; // ? => nullable operator
//string s = null;
//s?.First(); // null conditional

//var s = $@"{2}";


//void change(int a)
//{
//    a = 42;
//}

//int a = 2;

//Console.WriteLine($"Before Function: {a}");
//change(a); //kopyasi gonderilir 
//Console.WriteLine($"After Function: {a}");


// ref => 

//void change(ref int a)
//{
//    a = 42;
//}

//int a = 2; // mutleq initalize olumalidir

////Console.WriteLine($"Before Function: {a}");
//change(ref a);
//Console.WriteLine($"After Function: {a}");

// out => funksiya hemin parametere mutleq deyer assing olunmalidir
//void change(out int a)
//{
//    a = 42;
//}

//int a = 2;

//Console.WriteLine($"Before Function: {a}");
//change(out a);
//Console.WriteLine($"After Function: {a}");


// in 
//void change(in int a)
//{
//    a = 42; // readonly
//}

//int a = 2;

//Console.WriteLine($"Before Function: {a}");
//change(a);
//Console.WriteLine($"After Function: {a}");



//int a = int.MaxValue;
//checked
//{
//    a++;
//}
//Console.WriteLine(a);

// type safe nezaret edir ve yoxlayir
// checked => Typelar uzerinde data itkisi olma ehtimalini yoxlayir ve arardan qaldirir. Data itkisi olarsa OverflowException atir
//int a = int.MaxValue + 1;



// TypeCasting
// Implicit (Q/Ashkar) => Upcast zamani bash verir
// Explicit (Ashkar)

//int a = 42;
//double d = a;

//double e = 4.2;
//int f = e;

//double d = 4.2;
//int a = int.Parse();
//int a = Convert.ToInt32();

// Parse => Type-n oz daxilinde olan methoddur ve string qebul edir. Chevire bilirse chevirir, chevire bilmese FormatException atir;

// TryParse => cast ede bilir true eks halda false qaytarir

//while (true)
//{

//    if (int.TryParse(Console.ReadLine(), out int a))
//        Console.WriteLine(a);
//    else
//        Console.WriteLine("Duz emelli daxil et");
//}
class Program
{
    static void Foo() { }
    static void Main(string[] args)
    {
        Foo();
        // DR | DRY
        // KISS 
        // SOLID
    }
}