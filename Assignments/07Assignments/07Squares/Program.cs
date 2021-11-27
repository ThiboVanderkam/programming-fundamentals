using System;

namespace _07Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string antwoord = Console.ReadLine();
            int n;

            int counter = 0;
            for (int i = 0; i < antwoord.Length; i++)
            {
                if ("0123456789".Contains(antwoord[i]))
                {
                    counter++;
                }

            }
            if (counter != antwoord.Length)
            {
                Console.WriteLine("crazy input");
                return;
            }

            n = Convert.ToInt32(antwoord);
            /*
            if (!Int32.TryParse(antwoord, out n))
            {
                Console.WriteLine("crazy input");
                return;
            }
            */
            int n = 0;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("crazy input");
                return;
            }

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i * i + " ");
                sum += i * i;
            }
            Console.WriteLine("\nsum = " + sum);
        }
    }
}
