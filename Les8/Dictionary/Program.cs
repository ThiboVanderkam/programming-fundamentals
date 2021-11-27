using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> fruit= new Dictionary<char, string>();

            fruit.Add('a', "appel");
            fruit.Add('k', "kiwi");
            fruit['a'] = "aardbei";
            fruit['c'] = "citroen";
            fruit['A'] = "appel";

            fruit.Remove('a');
            foreach (var item in fruit)
            {
                if (item.Value == "appel")
                {
                    fruit.Remove(item.Key);
                }
            }

            fruit['a'] = "appel";
            fruit['b'] = "banaan";

            char[] keys = fruit.Keys.ToArray();
            Array.Sort(keys);
            foreach (var item in keys)
            {
                Console.WriteLine(item + ": " + fruit[item]);
            }
            //fruit.ContainsValue();
            //fruit.ContainsKey();

            for (int i = 0; i < fruit.Count; i++)
            {
                Console.WriteLine($"{i} --> {fruit.ElementAt(i).Value}");
            }


            
            Console.WriteLine("\n\n\n////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            foreach (var item in fruit)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }


        }
    }
}
