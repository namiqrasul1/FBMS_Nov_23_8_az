//Console.Write("hakuna");
//Console.WriteLine("Matata");
//Console.ForegroundColor = ConsoleColor.Magenta;
//Console.WriteLine("42");
//Console.BackgroundColor = ConsoleColor.Yellow;
//var s = Console.ReadLine();

//int a = 2;
//if (a == 0)
//{

//}

//for (int i = 0; i < a; i++)
//{

//}

//foreach (var i in args) { 
//}

//var a = 1;
//dynamic d = 42;
//d.ToString();

//Console.WriteLine(a);

//float f = 4.2f;
//byte b = 256;

//sbyte b = -2;
//uint ui = 2;

//decimal d = 4.2m;

//int num = 42;
//switch (num)
//{
//    case 1:
//    case 2:
//    case 3:
//        Console.WriteLine(); break;
//    default:
//        break;
//}

//Console.WriteLine(num);

//var input = Console.ReadLine();
////int num = int.Parse(input);
//int num = Convert.ToInt32(input);
//int a = int.MaxValue;
//Console.WriteLine(num);

//while (true)
//{
//    var key = Console.ReadKey();
//    switch (key.Key)
//    {
//        case ConsoleKey.UpArrow:
//            Console.WriteLine("yuxari"); break;
//        case ConsoleKey.DownArrow:
//            Console.WriteLine("ashagi"); break;
//        default:
//            break;
//    }
//}


//Console.Title = "FBMS_Nov_23_8_az";


//Console.WriteLine();


//int age = int.Parse(Console.ReadLine()!);
////age < 65 ? Console.WriteLine("-") : Console.WriteLine("+");
//Console.WriteLine(age < 65 ? "-" : "+");

//daxiletme:
//// bla
//// bla
//// bla
//Console.WriteLine("daxiletme");
//hesablama:
////bla
////bla
////bla
//Console.WriteLine("hesablama");


//goto daxiletme;
//daxiletme:
//try
//{
//    Console.Write("yashinizi daxil edin: ");
//    int age = int.Parse(Console.ReadLine()!);
//    Console.WriteLine(age < 65 ? "-" : "+");
//}
//catch (Exception)
//{
//    Console.WriteLine("yashini duzgun daxil et!");
//    goto daxiletme;
//}

//string str = "hakuna";
//string str1 = "matata";

//// concatenation
////string result = str + " " + str1;
////Console.WriteLine(result);

//// interpolation
//var result = $"{str} {str1}";

//Console.WriteLine(result);

// for multiline string => @ (escape sequence istifade edile bilmez)

//string s = @"
//asd
//asd
//as
//dsa
//das
//d
//asd
//as
//d \n \
//";

//string path = @"C:\Users\namiqrasullu\Desktop\Инструкция_Microsoft_365.pdf";

// Data types:
// 1. Value type      => dataya gore
// 2. Reference type  => adrese gore

//void change(int arg)
//{
//    arg = 2;
//}

//void changeByRef(Step arg)
//{
//    arg.num = 2;
//}

//int num = 42;
//Console.WriteLine($"Before Function: {num}");
//change(num);
//Console.WriteLine($"After Function: {num}");

//Step obj = new Step();
//obj.num = 42;
//Console.WriteLine($"Before Function: {obj.num}");
//changeByRef(obj);
//Console.WriteLine($"After Function: {obj.num}");
//class Step
//{
//    public int num;
//}


//int a = 2;

//a.ToString();
//Console.Clear();


// Task. 
// Oxlar ile ishleyen 3 elementden ibaret Menu yaratmali. yuxari ox basildiqda menu elementi yuxaridaki, ashagi ox basilanda ashagidaki element sechilir