using System;
using System.Collections.Generic;

namespace Akari
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //setup
                string input = Console.ReadLine();
                string[] components = input.Split(' ');
                int rows = Convert.ToInt32(components[0]);
                int cols = Convert.ToInt32(components[1]);
                List<(int, int)> blackCells = new List<(int, int)>();

                for (int i = 2; i < components.Length; i++)
                {
                    string[] item = components[i].Split(',');
                    int r = Convert.ToInt32(item[0]);
                    int c = Convert.ToInt32(item[1]);
                    blackCells.Add((r, c));
                }

                Akari akari = new Akari(rows, cols, blackCells);

                bool stop = false;
                while (!stop)
                {
                    input = Console.ReadLine();
                    if (input == "print")
                    {
                        Console.WriteLine(akari);
                    }
                    else if (input.Contains("add"))
                    {
                        string[] item = input.Split(' ');
                        string[] coords = item[1].Split(',');

                        int r = Convert.ToInt32(coords[0]);
                        int c = Convert.ToInt32(coords[1]);
                        akari.AddLight(r, c);
                    }
                    else if (input == "solved")
                    {
                        Console.WriteLine(akari.isSolved());
                    }
                    else if (input == "stop")
                    {
                        stop = true;
                    }
                }
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
