using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Interfaces
{
    interface IA
    {
        void Foo();
    }

    interface IB : IA
    {
        void Boo();
    }
    internal class FileName : IA, IB
    {
        public void Foo() { }
        public void Boo() { }
    }
}
