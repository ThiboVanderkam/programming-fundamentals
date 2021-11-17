using System;
using System.Linq;

namespace _05CountCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            int length = input.Length;
            int vowels = 0;
            int consonants = 0;
            int other = 0;

            for (int i = 0; i < length; i++)
            {
                if ("aeiouy".Contains(input.ElementAt(i)))
                {
                    vowels++;
                }
                else if ("bcdfghjklmnpqrstvwxz".Contains(input.ElementAt(i)))
                {
                    consonants++;
                }
                else
                {
                    other++;
                }
            }
            Console.WriteLine("vowels: " + vowels);
            Console.WriteLine("consonants: " + consonants);
            Console.WriteLine("other: " + other);
        }
    }
}
