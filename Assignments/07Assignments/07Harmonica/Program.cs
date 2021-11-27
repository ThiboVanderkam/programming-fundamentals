using System;

namespace _07Harmonica
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


            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += (double)1 / i;
            }

            double final = Math.Round(result, 4);
            Console.WriteLine(final);
        }
    }
}
