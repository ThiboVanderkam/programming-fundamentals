using System;

namespace _07Polynomial
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

            antwoord = Console.ReadLine();
            double x;
            if (!Double.TryParse(antwoord, out x))
            {
                Console.WriteLine("crazy input");
                return;
            }

            bool plus = true;
            int power = 1;
            double f = 0;
            for (int i = 0; i < n; i++)
            {
                if (plus)
                {
                    f += Math.Pow(x, power);                   
                }
                else
                {
                    f -= Math.Pow(x, power);                    
                }
                power += 2;
                plus = !plus;
            }
            Console.WriteLine(Math.Round(f, 2));
        }
    }
}
