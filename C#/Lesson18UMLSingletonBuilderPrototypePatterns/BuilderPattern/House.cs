using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class House
    {
        //public House(int walls, int doors, int windows, bool hasGarrage, bool hasPool, bool hasGargen, bool hasRoof)
        //{
        //    Walls = walls;
        //    Doors = doors;
        //    Windows = windows;
        //    HasGarrage = hasGarrage;
        //    HasPool = hasPool;
        //    HasGargen = hasGargen;
        //    HasRoof = hasRoof;
        //}

        public int Walls { get; set; }
        public int Doors { get; set; }
        public int Windows { get; set; }
        public bool HasGarrage { get; set; }
        public bool HasPool { get; set; }
        public bool HasGargen { get; set; }
        public bool HasRoof { get; set; }

    }
}
