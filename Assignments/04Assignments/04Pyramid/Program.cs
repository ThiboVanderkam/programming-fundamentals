using System;

namespace _04Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j <= number - i; j++)
                {
                    Console.Write(" ");
                }
                
                for (int j = 1; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("*");
                Console.WriteLine();
            }  
        }
    }
}
