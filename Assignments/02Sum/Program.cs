using System;

namespace _02Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            double input1 = Convert.ToDouble(Console.ReadLine());
            double input2 = Convert.ToDouble(Console.ReadLine());
            double input3 = Convert.ToDouble(Console.ReadLine());

            double doublesum = input1 + input2 + input3;
            int sum = (int)doublesum;

            Console.WriteLine(sum);
        }
    }
}
