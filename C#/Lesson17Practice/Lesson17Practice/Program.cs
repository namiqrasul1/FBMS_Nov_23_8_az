//var questions = new string[]
//{
//    "Azerbaycanin paytaxti haradir",
//    "Sual 2",
//    "Sual 3"
//};

//var answers = new string[][]
//{
//    ["Baki", "Gence", "Lenkeran"],
//    ["Cavab 1", "Cavab 2", "Cavab 3"],
//    ["Cavab 1", "Cavab 2", "Cavab 3"],
//};

//var correctAnswers = new string[]
//{
//    "Baki",
//    "Cavab 2",
//    "Cavab 3"
//};

//var rnd = new Random(); 

//for (int i = 0; i < questions.Length; i++)
//{
//    Console.WriteLine(questions[i]);
//    rnd.Shuffle(answers[i]);
//    Console.WriteLine($"A. {answers[i][0]}");
//    Console.WriteLine($"B. {answers[i][1]}");
//    Console.WriteLine($"C. {answers[i][2]}");
//    ConsoleKey ch = Console.ReadKey().Key;
//    int index = ch - ConsoleKey.A;
//    if (correctAnswers[i] == answers[i][index])
//        Console.WriteLine("duzdu");
//    else Console.WriteLine("sehvdi");
//}


using System.Configuration;

var filePath = ConfigurationManager.AppSettings["filePath"];

var data = Console.ReadLine();
File.AppendAllText(filePath, data);
