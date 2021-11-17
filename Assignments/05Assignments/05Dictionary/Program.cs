using System;
using System.IO;

namespace _05Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StreamReader stream = File.OpenText("english.txt");
            string line = "";
            int linenumber = 0;
            while(!stream.EndOfStream)
            {
                linenumber++;
                line = stream.ReadLine();
                if (line == input)
                {
                    Console.WriteLine(linenumber);
                    return;
                }
            }
            Console.WriteLine("not found!");
        }
    }
}
