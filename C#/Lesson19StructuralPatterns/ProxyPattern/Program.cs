using ProxyPattern;
using System.Collections;
using System.Diagnostics;

//BankAccountProxy proxy = new(new BankAccount(), "guest");

//proxy.Deposit(1000);
//proxy.Withdraw(500);

Stopwatch stopwatch = new();
ArrayList arrayList = new();
stopwatch.Start();
for (int i = 0; i < 10000000; i++)
{
    arrayList.Add(i);
}

for (int i = 0; i < arrayList.Count; i++)
{
    int a = (int)(arrayList[i]);
}

stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);
var list = new List<int>();

stopwatch.Restart();
for (int i = 0; i < 10000000; i++)
{
    list.Add(i);
}

for (int i = 0; i < arrayList.Count; i++)
{
    int a = list[i];
}

stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);