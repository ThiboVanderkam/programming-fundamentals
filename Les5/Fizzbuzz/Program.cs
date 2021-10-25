using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 99; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("buzz");
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }
    }
}
