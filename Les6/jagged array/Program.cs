using System;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] klassen = new string[5][];
            klassen[0] = new string[] { "jan", "piet", "joris", "korneel"}; //die hebben baarden, die hebben baarden
            klassen[1] = new string[] { "karen", "kristel", "kathleen"};
            klassen[2] = new string[] { "tom", "jerry" };
            klassen[3] = new string[] { "ed", "edd", "eddy" };
            klassen[4] = new string[] { "mik", "mak", "mon" };

            for (int i = 0; i < klassen.GetLength(0); i++)
            {
                for (int j = 0; j < klassen[i].Length; j++)
                {
                    Console.Write(klassen[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}









































//Haha 69:P