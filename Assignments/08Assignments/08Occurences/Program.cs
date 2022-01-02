using System;
using System.Collections.Generic;
using System.Linq;

namespace _08Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');
                Dictionary<string, int> words = new Dictionary<string, int>();

                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (words.ContainsKey(inputArray[i]))
                    {
                        words[inputArray[i]]++;
                    }
                    else
                    {
                        words.Add(inputArray[i], 1);
                    }
                }

                string[] keys = words.Keys.ToArray();
                Array.Sort(keys);

                foreach (var item in keys)
                {
                    Console.WriteLine(item + ": " + words[item]);
                }
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
