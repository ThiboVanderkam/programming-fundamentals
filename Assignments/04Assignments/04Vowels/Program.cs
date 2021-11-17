using System;
using System.Linq;

namespace _04Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;
            int total = 0;

            for (int i = 0; i < length; i++)
            {
                if (input.ElementAt(i) == 'a' || input.ElementAt(i) == 'e' || input.ElementAt(i) == 'i' || input.ElementAt(i) == 'o' || input.ElementAt(i) == 'u' || input.ElementAt(i) == 'y')
                {
                    total++;
                }
            }
            Console.WriteLine(total);
        }
    }
}
