using System;
using System.Collections.Generic;

namespace bababooey
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var item in list)
            {
                if (item == 3)
                {
                    list.Remove(item);
                }
                Console.WriteLine(item);
            }
        }
    }
}
