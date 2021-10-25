using System;

namespace _03Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double result1 = Convert.ToDouble(Console.ReadLine());
            double result2 = Convert.ToDouble(Console.ReadLine());
            double result3 = Convert.ToDouble(Console.ReadLine());
            double result4 = Convert.ToDouble(Console.ReadLine());
            double result5 = Convert.ToDouble(Console.ReadLine());

            double average = (result1 + result2 + result3 + result4 + result5) / 50;

            if (average >= 0.9)
            {
                Console.WriteLine("A");
            }
            else if (average >= 0.8)
            {
                Console.WriteLine("B");
            }
            else if (average >= 0.7)
            {
                Console.WriteLine("C");
            }
            else if (average >= 0.6)
            {
                Console.WriteLine("D");
            }
            else if (average >= 0.4)
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("F");
            }

        }
    }
}
