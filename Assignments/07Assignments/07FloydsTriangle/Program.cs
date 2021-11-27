using System;

namespace _07FloydsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string antwoord = Console.ReadLine();
            int input;
            if (!Int32.TryParse(antwoord, out input))
            {
                Console.WriteLine("crazy input");
                return;
            }
            

            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < input - i; j++)
                {
                    Console.Write(" ");
                }
                
                bool OneZero;
                if (i % 2 == 1)
                {
                    OneZero = true;  
                }
                else
                {
                    OneZero = false;
                }
                for (int j = 0; j < i; j++)
                {
                    if (OneZero)
                    {
                        Console.Write("1");
                        OneZero = !OneZero;
                    }
                    else
                    {
                        Console.Write("0");
                        OneZero = !OneZero;
                    }
                }
            Console.WriteLine();
            }
        }
    }
}
