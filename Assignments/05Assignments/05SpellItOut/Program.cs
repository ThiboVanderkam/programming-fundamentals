using System;
using System.IO;

namespace _05SpellItOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            StreamReader stream = File.OpenText("spells.txt");
            string woord = "";
            
            while(!stream.EndOfStream)
            {
                string line = stream.ReadLine();
                string lowerline = line.ToLower();
                foreach (char item in lowerline)
                {
                    if ((int)item >= 97 && (int)item <= 122)
                    {
                        woord += item;
                    }
                    
                    if (woord == input)
                    {
                        Console.WriteLine(line);
                        woord = "";
                    }
                    else if (" ,.;".Contains(item))
                    {
                        woord = "";
                    }
                    
                
                }
            }


        }
    }
}
