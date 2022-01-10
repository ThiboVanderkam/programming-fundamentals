using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Parking
{
    class Car
    {
        public double Height { get; set; }
        public string LicencePlate { get; set; }

        public string Parked { get; set; }

        public Car(string licenseplate, double height)
        {
            LicencePlate = licenseplate;
            Height = height;
            Parked = "no";
        }

        public override string ToString()
        {
            string s = LicencePlate + " ";
            if (Parked == "no")
            {
                s += "not parked!";
            }
            else
            {
                s += Parked;
            }
            return s;
        }
    }
}
