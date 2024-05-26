using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4StructClass
{
    internal class Some
    {
        public int Id { get; init; } = 42;
        public int Any { get; set; }
        public string Str { get; set; } = "Hakuna";

        public int field;

        public Some(int id, int any, string str, int field)
        {
            Id = id;
            Any = any;
            Str = str;
            this.field = field;
        }

        public Some Clone()
        {
            //return new Some{ Id = Id, Any = Any, Str = Str }; 
            return new Some(Id, Any, Str, field);
        }
    }
}
