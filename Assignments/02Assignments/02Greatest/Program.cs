using System;

namespace _02Greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            double input1 = Convert.ToDouble(Console.ReadLine());
            double input2 = Convert.ToDouble(Console.ReadLine());
            double input3 = Convert.ToDouble(Console.ReadLine());
            double greatest = Math.Max(Math.Max(input1, input2), input3);
            Console.WriteLine(greatest);
        }
    }
}
