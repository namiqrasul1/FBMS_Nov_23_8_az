using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9GenericGenericCollectionExtensionMethod.Extensions
{
    internal static class ExtensionMethod
    {
        public static int WordCount(this string str)
        {
            var s = "as, b";

            var count = str.Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return count;
        }

        public static bool IsPositive(this int arg)
        {
            return arg > 0;
        }

        public static int Sum(this int arg, int arg1) { return arg + arg1; }
    }
}
