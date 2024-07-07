using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class President
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        //private static President _president;
        //private President() { }

        //public static President GetPresident()
        //{
        //    //_president = _president ?? new President();
        //    _president ??= new President();
        //    return _president;
        //}
    }
}
