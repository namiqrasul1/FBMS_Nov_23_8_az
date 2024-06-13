using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Streams.Models
{
    internal class Book : IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Jenre { get; set; }
        public string Author { get; set; }
        public string Desc { get; set; }

        public void Dispose()
        {
            Console.WriteLine("Salam");
        }

      

        public override string ToString() => $"{Id} {Name} {Author} {Jenre}";
    }
}
