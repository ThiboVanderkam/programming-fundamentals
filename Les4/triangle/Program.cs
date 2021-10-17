using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n\n");

            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
