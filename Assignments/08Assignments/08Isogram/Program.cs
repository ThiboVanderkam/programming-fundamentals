using System;
using System.Collections.Generic;

namespace _08Isogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (char item in input)
            {
                if (!Char.IsLetter(item))
                {
                    Console.WriteLine("crazy input");
                    return;
                }
            }

            Dictionary<char, int> alphanumerical = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                
                if (alphanumerical.ContainsKey(input[i]))
                {
                    alphanumerical[input[i]]++;
                }
                else 
                {
                    alphanumerical.Add(input[i], 1);
                }
            }

            int counter = 0;
            foreach (var item in alphanumerical)
            {
                if (item.Value > 1)
                {
                    counter++;
                }
            }
            bool result = (counter == 0);
            Console.WriteLine(result);
        }
    }
}
