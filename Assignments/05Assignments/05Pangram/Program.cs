using System;
using System.Linq;

namespace _05Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            input = input.ToLower();
            int count = 0;

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (input.Contains(alphabet.ElementAt(i)))
                {
                    count++;
                }
            }
            if (count == 26)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
