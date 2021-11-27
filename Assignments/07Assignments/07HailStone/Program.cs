using System;

namespace _07HailStone
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string antwoord = Console.ReadLine();
            int n;
            if (!Int32.TryParse(antwoord, out n))
            {
                Console.WriteLine("crazy input");
                return;
            }
            Console.Write(n + " ");
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    Console.Write(n + " ");
                }
                else
                {
                    n = 3 * n + 1;
                    Console.Write(n + " ");
                }
            }
        }
    }
}
