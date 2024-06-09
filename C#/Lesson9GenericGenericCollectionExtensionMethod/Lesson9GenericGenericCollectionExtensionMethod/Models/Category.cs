using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9GenericGenericCollectionExtensionMethod.Models
{
    class Trousers { }
    class TShirt { }
    class Shoes
    {

        
    }
    internal class Category<T> : ApplicationException, IInterface where T : class
    {
        public T Product { get; set; }
    }
}
