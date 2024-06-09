using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9GenericGenericCollectionExtensionMethod.Models
{
    internal interface IInterface
    {
    }

    class A : IInterface { }
    public class B : IInterface { }

    // T ancaq IInerfaceden implement etmish class ola biler
    class C<T> where T : class ,IInterface, new()
    {

    }

    struct MyStruct : IInterface
    {

    }

    //public class D
    //{
    //    void Foo()
    //    {
    //        C<MyStruct> ojb = null;
    //    }
    //}

}
