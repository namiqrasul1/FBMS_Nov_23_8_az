using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal interface IHouseBuilder
    {
        House House { get; set; }
        void BuildWalls(int count);
        void BuildDoors(int count);
        void BuildWindows(int count);
        void BuildGarrage();
        void BuildPool();
        void BuildGarden();
        void BuildRoof();
        void Reset();
        House GetHouse();
    }
}
