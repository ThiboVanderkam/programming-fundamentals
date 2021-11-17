using System;
using System.IO;

namespace _05Fruit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StreamReader stream = File.OpenText("fruit.txt");
            string line = "";

            while(!stream.EndOfStream)
            {
                line = stream.ReadLine();
                if (input == line)
                {
                    Console.WriteLine("true");
                    return;
                }
            }
            Console.WriteLine("false");
        }
    }
}
