using BuilderPattern;
using System.Diagnostics;
using System.Text;

//IHouseBuilder builder = new Builder();

//builder.BuildWindows(3);
//builder.BuildDoors(4);
//builder.BuildRoof();
//builder.BuildPool();

//var house = builder.GetHouse();

//Console.WriteLine(house.Doors);

//builder.Reset();

//builder.BuildGarden();
//var home = builder.GetHouse();
//Console.WriteLine(home.Windows);


//Stopwatch sw = new();
//sw.Start();
//StringBuilder sb = new();
//for (int i = 0; i < 10000000; i++)
//{
//    sb.Append(i);
//}
//sw.Stop();
//Console.WriteLine(sb.ToString());
//Console.WriteLine(sw.Elapsed);

Stopwatch sw = new();
sw.Start();
string str = string.Empty;
for (int i = 0; i < 10000000; i++)
{
    str += i;
}
sw.Stop();
Console.WriteLine(str);
Console.WriteLine(sw.Elapsed);