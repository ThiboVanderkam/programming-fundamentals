using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruit = new List<string>();

            fruit.Add("appel");
            fruit.Add("citroen");
            fruit.Insert(1, "banaan");
            fruit.Insert(0, "aardbei");
            fruit.Add("appel");
            fruit.Add("appel");
            fruit.Add("appel");


            fruit.RemoveAt(0);
            fruit.RemoveAll(w => w == "appel");
            Console.WriteLine("citroen" + fruit.Contains("banaan"));
            Console.WriteLine("banaan op plaats: " + fruit.IndexOf("appel")) ;


            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }

            //array = fruit.ToArray();
            //fruit.AddRange(array);
            fruit.Sort();
            fruit.Reverse();
        }
    }
}
