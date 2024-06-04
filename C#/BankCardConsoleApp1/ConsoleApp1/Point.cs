using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            x = 0; 
            y = 0;   
        }

        public void ShowData()
        {
            Console.WriteLine($"{x} {y}");
        }
    }
}
