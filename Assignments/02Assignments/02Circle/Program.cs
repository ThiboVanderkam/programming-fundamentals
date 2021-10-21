using System;

namespace _02Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine()); //Ask for radius
            double c = 2 * Math.PI * r; //Calculate circumference
            double a = Math.PI * r * r; //Calculate area

            Console.WriteLine(Math.Round(c, 1));
            Console.WriteLine(Math.Round(a, 1));

        }
    }
}
