using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Interfaces
{
    interface IAA
    {
        void Foo();
    }

    interface IBB
    {
        void Foo();
    }

    internal class FileName1 : IAA, IBB
    {
        void IAA.Foo()
        {
            Console.WriteLine("IAA.Foo()");
        }
        void IBB.Foo()
        {
            Console.WriteLine("IBB.Foo()");
        }

        public void Foo()
        {
            
        }

    }
}
