using System;
using System.IO;

namespace _05TheAinApple
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = Convert.ToChar(Console.ReadLine());
            StreamReader stream = File.OpenText("fruit.txt");
            string line = "";
            bool found = false;

            while (!stream.EndOfStream)
            {
                line = stream.ReadLine();
                if (line.Contains(input))
                {
                    Console.WriteLine(line);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("nothing found");
            }
        }
    }
}
