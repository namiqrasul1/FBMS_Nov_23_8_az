using Lesson6ExceptionHandlingReadonlyOperatorOverloadingIndexer.Models;


//double foo(int i) => 1 / i;

//try
//{
//    var result = foo(0);

//    Console.WriteLine(result);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//string[] arr = ["hakuna", "matata", "300"];

//try
//{
//    byte b = byte.Parse(arr[2]);

//}
//catch (OverflowException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (FormatException fe)
//{
//    Console.WriteLine(fe.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//checked
//{
//    int a = int.MaxValue;
//    a++;
//}

//////////////////////////////////////////////////////////////////////////////////////


//// Empty Catch

//string[] arr = ["hakuna", "matata", "300"];

//try
//{
//    byte b = byte.Parse(arr[2]);

//}
//catch
//{
//    Console.WriteLine();
//}

//void foo(string data, string arg)
//{
//    if (data is null)
//        throw new ArgumentNullException(nameof(data), "gonderdiyin argumente diqqet et!");

//    // logic
//}

//try
//{
//    try
//    {
//        foo(null, "arg");

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//        throw;
//    }
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    throw new Exception();
//}
//catch (ArgumentNullException)
//{
//    Console.WriteLine("catch");
//}
//finally
//{
//    Console.WriteLine("Kamil");
//    // close
//}

///////////////////////////////////////////////////////////////////

//int getValue(int[] arr, int index)
//{
//	try
//	{
//        return arr[index];
//    }
//    catch (IndexOutOfRangeException) when (index < 0)
//	{
//		throw new ArgumentOutOfRangeException(nameof(index), "Index cannot be negative");
//	}
//    catch (IndexOutOfRangeException) when (index >= arr.Length)
//	{
//		throw new ArgumentOutOfRangeException(nameof(index), "Index cannot be equal or greater then length of arr");
//	}
//}

//int[] ints = [1, 2, 3, 4, 5, 6, 7, 8, 9];
//try
//{
//    int result = getValue(ints, 14);
//    Console.WriteLine(result);

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}



//Int o = new() { Value = 5 };
//Int o1 = new() { Value = 10 };
//var o2 = o + 1;
//var result = o + o1;
//Console.WriteLine(result.Value);

//const int a = 1;
//readonly int b = 2;



//int @int = 246_546_456;


// length => hemin uzunluqda reqemlerden ibaret random string qaytarmalidir
//       4 =>  "9371"


string RandomGenerator(int len)
{
    Random rnd = new();
    string result = string.Empty;
    for (int i = 0; i < len; i++)
        result += rnd.Next(0, 10);
    return result;
}

var str = RandomGenerator(10);
Console.WriteLine(str);
Console.WriteLine(RandomGenerator(3));
Console.WriteLine(RandomGenerator(2));
Console.WriteLine(RandomGenerator(5));