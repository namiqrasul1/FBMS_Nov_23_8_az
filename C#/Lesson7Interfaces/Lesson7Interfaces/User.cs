using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Interfaces
{
    internal class User : IClone
    {
        public int MyProperty { get; set; }

        public IClone Clone()
        {
            return new User();
        }

        public void Foo()
        {
            throw new NotImplementedException();
        }
    }
}
