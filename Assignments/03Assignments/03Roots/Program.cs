using System;

namespace _03Roots
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double d = b * b - 4 * a * c;

            if (d >= 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("" + x1 + " " + x2);
            }
            else
            {
                Console.WriteLine("No real solutions");
            }
        }
    }
}
