using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6ExceptionHandlingReadonlyOperatorOverloadingIndexer.Models
{
    internal class SomeClass
    {
        public const int constInt = 1;
        public readonly int readonlyInt;
        //public const Int @int = new Int();
        //public readonly Int @int1 = new Int();
        public SomeClass(int a)
        {
            //constInt = 2;
            readonlyInt = a;
        }

        //void Foo() { readonlyInt = 2; }

    }
}
