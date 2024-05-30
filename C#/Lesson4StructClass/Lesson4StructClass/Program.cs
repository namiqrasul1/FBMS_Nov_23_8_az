//using Student1 = AnotherLibrary.Student;
//using AnotherLibrary;
using Lesson4StructClass;

#region Class Vs Struct

// dynamic link library
//Student1 student = new Student1();
//Student student = new AnotherLibrary.Student();

//PointStruct p = new PointStruct(12, 42);
//var p1 = new PointStruct(12, 42);
//PointStruct p2 = new(1, 2);
//Console.WriteLine($"{p.x} {p.y}");

//PointStruct p = new(1, 2);
//PointStruct p1 = p;
//p1.x = 42;
//p1.y = 12;
//p.Print();
//Console.WriteLine($"{p.x} {p.y}");


//PointClass pc = new PointClass(1, 2); 
//var pc1 = new PointClass(1, 2); 
//PointClass pc2 = new(1, 2); 
//pc.Print();

//PointClass pc = new(x: 42, y: 12);
//PointClass p = pc;
//p.x = 100;

//pc.Print();

#endregion


//Student st = new(17, "kamil", "fazil", 1.2f);
//Console.WriteLine(st);

////st.SetAge(18);
////st.Name = "Kamil";
//Console.WriteLine(st.Name);
//Console.WriteLine(st.GetAge());

//Counter counter = new(0, 100);
//counter.Increment();
//Console.WriteLine(counter.Current);
//counter.Increment();
//Console.WriteLine(counter.Current);

//Some obj = new() { Id = 42, Any = 12 };
//Console.WriteLine(obj.Id);


//Some o = obj.Clone();
//o.Str = "Matata";

//Console.WriteLine(obj.Str);

//string str = "h";

//string s = str;
//s = "k";
//Console.WriteLine(str);
//Console.WriteLine(s);

//str[0] = '[';

//int[] arr = [1,2,3];
//int[] a = arr;
//a[1] = 42;

//foreach (var item in arr)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();
//Console.WriteLine();
//foreach (var item in a)
//{
//    Console.Write($"{item} ");
//}

//Car.MyProperty = 1;
//Console.WriteLine("s");
//Car car = new(1999, "nissan", "skyline R34");

//car.Show();
//Car.Foo();