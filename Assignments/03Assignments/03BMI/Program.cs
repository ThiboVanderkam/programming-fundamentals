using System;

namespace _03BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = Convert.ToDouble(Console.ReadLine());
            double length = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / Math.Pow(length, 2);

            if (bmi < 18.5)
            {
                Console.WriteLine("underweight");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("normal");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine("overweight");
            }
            else if (bmi >= 30 && bmi <= 34.9)
            {
                Console.WriteLine("obese");
            }
            else
            {
                Console.WriteLine("extremely obese");
            }
        }
    }
}
