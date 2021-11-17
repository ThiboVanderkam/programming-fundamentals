using System;

namespace _04Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for (int i = 2; i <= input; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
