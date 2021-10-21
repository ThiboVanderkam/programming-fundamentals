using System;

namespace _02BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / (Math.Pow(height, 2));
            double BMISinglePrecision = Math.Round(BMI, 1);

            Console.WriteLine(BMISinglePrecision);
        }
    }
}
