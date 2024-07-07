using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Builder : IHouseBuilder
    {
        public House House { get; set; } = new();

        public void BuildDoors(int count)
        {
            House.Doors = count;
        }

        public void BuildGarden()
        {
            House.HasGarrage = true;
        }

        public void BuildGarrage()
        {
            House.HasGarrage = true;
        }

        public void BuildPool()
        {
            House.HasPool = true;
        }

        public void BuildRoof()
        {
            House.HasRoof = true;
        }

        public void BuildWalls(int count)
        {
            House.Walls = count;
        }

        public void BuildWindows(int count)
        {
            House.Windows = count;
        }

        public House GetHouse()
        {
            return House;
        }

        public void Reset()
        {
            House = new();
        }
    }
}
