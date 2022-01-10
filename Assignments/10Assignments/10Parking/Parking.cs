using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Parking
{
    class Parking
    {
        public List<Car> Cars { get; set; }
        public int FreePlaces { get; set; }
        public double MaxHeight { get; set; }
        public string Name { get; set; }

        public Parking(string name, int freeplaces, double height)
        {
            Name = name;
            FreePlaces = freeplaces;
            MaxHeight = height;
        }

        public override string ToString()
        {
            string s = Name + "(" + MaxHeight + " m) ";
            if (FreePlaces == 0)
            {
                s += "FULL";
            }
            else
            {
                s += "" + FreePlaces + " places";
            }
            return s;
        }
    }
}
