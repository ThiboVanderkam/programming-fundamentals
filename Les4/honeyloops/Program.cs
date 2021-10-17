using System;

namespace honeyloops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            Console.WriteLine("Geef een getal in:");
            int getal = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i <= 10; i++)
            {
                int result = i * getal;
                Console.WriteLine(getal + " * " + i + " = " + result);
            }
            */

            /*
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            */

            Console.WriteLine("2 FOR LOOPS OMG!!! \n");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}
