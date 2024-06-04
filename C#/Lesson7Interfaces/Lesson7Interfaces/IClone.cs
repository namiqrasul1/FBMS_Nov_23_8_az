using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Interfaces
{
    internal interface IClone
    {
        IClone Clone();
        public int MyProperty { get; set; }

        static int staticField;
        const int constField = 2;
        static IClone() { }
        void Foo();

    }
}
