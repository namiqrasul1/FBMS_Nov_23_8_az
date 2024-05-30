using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4StructClass
{
    internal class Counter
    {
        private int min;
        private int max;
        private int current;

        public Counter(int min, int max)
        {
            this.min = min;
            this.max = max;
            current = min;
        }

        public int Current { get => current; }

        public void Increment()
        { 
            current = current == max ? min : current + 1;
        }
    }
}
