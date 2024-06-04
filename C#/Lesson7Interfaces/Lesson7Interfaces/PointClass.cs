using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Interfaces
{
    internal class PointClass : IClone
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IClone Clone() => new PointClass { X = X, Y = Y };

        public void Foo()
        {
            throw new NotImplementedException();
        }
    }
}
