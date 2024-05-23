#region array   

////int[] ints = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
////int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
////int[] nums1 = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];
////int[] nums2 = new int[10];

////int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

////nums[5] = 2;

////for (int i = 0; i < nums.Length; i++)
////{
////    Console.Write($"{nums[i]} ");
////}
////int a = 2;
////foreach (int i in nums)
////{
////    a++;
////    i = 2; // error, iterasiya deyishenidir
////}

////foreach (int i in nums)
////{
////    Console.Write($"{i} ");
////}


////int[] nums = [1, 25, 433, 74, 35];
////Array.Resize(ref nums, 10);
//////Array.Fill(nums, 6);
////Array.Fill(array: nums, 
////            value: 10, 
////            count: 5,
////            startIndex: 5
////            );

////foreach (int i in nums)
////    Console.Write($"{i} ");

////Console.WriteLine();

////Array.Sort(nums);
////foreach (int i in nums)
////    Console.Write($"{i} ");

////for (int i = 0; i < nums.Length; i++)
////{
////    Console.Write($"{nums[i]} ");
////}


////string[] names = ["Hakuna", "John"];

////// Multidimentional Array
//// Rectangular Array
//// Jagged Array

////// Rectangular Array

////int[,] nums = new int[2, 4]
////{
////    { 1, 2, 3, 4},
////    {11, 12, 13, 14},
////};

////nums[1, 1] = 2;

////foreach (int i in nums)
////{
////    Console.WriteLine(i);
////}


//// Jagged Array
///*
// [1,2]
// [1,2,3,4]
// */

//int[][] jaggedArray = new int[3][];

////jaggedArray[0] = [1, 2, 3];
////jaggedArray[1] = [4, 5, 6, 7, 8, 9, 10];
////jaggedArray[2] = [11, 12, 432, 564, 67, 255]; // .net 8.0

//jaggedArray[0] = new int[3] { 1, 2, 3 };
//jaggedArray[1] = new int[] { 4, 5, 6, 7, 8, 9, 10 };
//jaggedArray[2] = new int[] { 11, 12, 432, 564, 67, 255 };

//foreach (var arr in jaggedArray)
//{
//    foreach (var num in arr)
//    {
//        Console.Write($"{num} ");
//    }
//    Console.WriteLine();
//}


#endregion

#region String

// string (String class)

//string str = "1111011101111ha111111kuna11111110111110110111";
//Console.WriteLine(str[2]);

//string trim = str.Trim('1', '0');
//string trim = str.Trim(); // default boshluqlari temizleyir
//var ltrim = str.TrimStart('1', '0');
//var rtrim = str.TrimEnd('1', '0');

//Console.WriteLine(trim);
//Console.WriteLine(ltrim);
//Console.WriteLine(rtrim);

//var newStr = str.Replace('1', 'A');
//var newStr = str.Replace("kuna", "KUNA");
//Console.WriteLine(newStr);

//var text = "Ladyship it daughter securing procured or am moreover mr Put sir she exercise vicinity cheerful wondered. Continual say suspicion provision you neglected sir curiosity unwilling. Simplicity end themselves increasing led day sympathize yet. General windows effects not are drawing man garrets. Common indeed garden you his ladies out yet. Preference imprudence contrasted to remarkably in on. Taken now you him trees tears any. Her object giving end sister except oppose.";

//var arr = text.Split(' '); // separator'a esases arraya chevirir
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

//var sentences = text.Split('.', '?', '!');
//Console.WriteLine(sentences.Length);

//string str = "Hakuna          matata 42";
//// [Hakuna, null, matata, 42]
//var arr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//Console.WriteLine(arr.Length);

//const string user = "namiqrasul";

//var username = Console.ReadLine();

//if(username?.Trim() == user)
//{
//    Console.WriteLine("xosh gelmisen");
//}
//else
//    Console.WriteLine("sevh username");

//var txt = "Hakuna Matata";

////if (txt.Contains("unaa"))
////    Console.WriteLine("var");

//char[] chars = new char[txt.Length];
//txt.CopyTo(0, chars, 0, txt.Length);


//foreach (char c in chars )
//    Console.WriteLine(c);


//var txt = "Hakuna Matata";
//var result = txt.EndsWith("ta");
//txt = txt.Insert(2, "kamil");
//Console.WriteLine(txt);

//var txt = "Hakuna Matata";

//txt = txt.Remove(6, 2);
//Console.WriteLine(txt);

//var subStr = txt.Substring(0, 3);
//Console.WriteLine(subStr);


//string str = "";
//string str1 = string.Empty;
//string str2 = null;
//string str3 = " ";

//if (string.IsNullOrWhiteSpace(str))
//{
//    Console.WriteLine("boshdur");
//}

//if(string.IsNullOrEmpty(str3))
//{
//    Console.WriteLine("boshdur");
//}


#endregion

#region DateTime


//DateTime dt1 = new DateTime(2024, 02, 22);


//DateTime dt = DateTime.Now;

//Console.WriteLine(dt.ToLongDateString());
//Console.WriteLine(dt.ToShortDateString());
//Console.WriteLine(dt.ToShortTimeString());
//Console.WriteLine(dt.ToLongTimeString());

//Console.WriteLine(dt.DayOfWeek);
//Console.WriteLine(dt.DayOfYear);

//Random rnd = new Random();
//Console.WriteLine(rnd.Next(1, 10));








#endregion