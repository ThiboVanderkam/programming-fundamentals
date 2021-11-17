using System;

namespace _05UbbiDubbi
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";

            foreach (char item in input)
            {
                if ("aeiouyAEIOUY".Contains(item))
                {
                    output += "ub" + item;
                }
                else
                {
                    output += item;
                }
            }
            Console.WriteLine(output);
        }
    }
}
