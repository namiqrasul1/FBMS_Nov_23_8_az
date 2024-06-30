using System;
using System.Windows.Forms;

namespace Lesson15GarbageCollection
{
    class Some : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Son ish goruldu");
            GC.SuppressFinalize(this);
        }
        ~Some()
        {
            Dispose();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                var s = new Some();
                Console.WriteLine(GC.GetGeneration(s));
                //s.Dispose();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();


            Button btn = new Button();
            
        }
    }
}
