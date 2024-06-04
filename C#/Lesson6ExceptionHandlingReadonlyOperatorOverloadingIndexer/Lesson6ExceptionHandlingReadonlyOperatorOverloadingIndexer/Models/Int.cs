using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6ExceptionHandlingReadonlyOperatorOverloadingIndexer.Models
{
    internal class Int
    {
        public int Value { get; set; }

        public static Int operator +(Int left, Int right)
        {
            return new Int { Value = left.Value + right.Value };
        }

        public static Int operator +(Int left, int right)
        {
            return new Int { Value = left.Value + right };
        }

        public static bool operator==(Int left, Int right)
        {
            return left.Value == right.Value;
        }

        public static bool operator!=(Int left, Int right)
        {
            return left.Value != right.Value;
        }
    }
}