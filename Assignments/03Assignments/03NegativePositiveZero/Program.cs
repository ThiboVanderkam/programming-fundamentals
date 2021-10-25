using System;

namespace _03NegativePositiveZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine("negative");
            }
            else if (input > 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }
    }
}
