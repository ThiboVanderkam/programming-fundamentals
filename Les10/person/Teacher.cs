using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    class Teacher : Person
    {
        public string School { get; set; }

        public Teacher(string name, DateTime birth) : base(name, birth)
        {

        }

        public override string ToString()
        {
            return "TEACHER " + Name;
        }
    }
}
