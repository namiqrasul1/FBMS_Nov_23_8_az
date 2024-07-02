using Serilog;
using System.Text.RegularExpressions;

#region RegEx


//string pattern = "^The";
//string pattern = "^[a-z]";
//string pattern = "@gmail.com$";
//string pattern = @"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+";
//string pattern = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";


//var regex = new Regex(pattern);

//var str = Console.ReadLine();

//if (regex.IsMatch(str!))
//{
//    Console.WriteLine("matched");
//}
//else
//{
//    Console.WriteLine("unmatched");
//}



#endregion



#region Log

//var logFile = "app.log";
//try
//{
//    var str = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(str)) throw new Exception("argument is null");
//}
//catch (Exception ex)
//{
//    File.AppendAllText(logFile, ex.Message + " " + DateTime.Now + "\n");

//}

#endregion

// Nlog
// Log4Net
// Serilog


#region Serilog

var template = "[{Timestamp:HH:mm} {Level:u3}] {Message}{NewLine}{Exception}";
Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console(outputTemplate: template)
                .WriteTo.File(path: "myapp.log", outputTemplate: template)
                .CreateLogger();



Log.Information("some info");
Log.Warning("some warn");
Log.Error("some error");




#endregion


// S => Single Responsibility Principle
// O => Open-Closed Principle
// L => Liskov Substitution Principle 
// I => Interface Segregation Principle
// D => Dependency Inversion Principle


