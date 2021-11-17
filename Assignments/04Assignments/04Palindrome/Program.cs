using System;
using System.Linq;

namespace _04Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                if (!(input.ElementAt(i) == input.ElementAt(length - 1 - i)))
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            Console.WriteLine("true");
        }
    }
}
