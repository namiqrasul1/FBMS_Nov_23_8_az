using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6ExceptionHandlingReadonlyOperatorOverloadingIndexer.Models
{
    internal class BaseDerived : Base
    {
        public void Boo() { }

        public sealed override int Foo()
        {
            throw new NotImplementedException();
        }
    }
}
