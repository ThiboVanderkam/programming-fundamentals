
using System;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabel = new int[4, 3];
            tabel[0, 1] = 1;
            tabel[3, 2] = 1;
            for (int i = 0; i < tabel.GetLength(0); i++)
            {
                for (int j = 0; j < tabel.GetLength(1); j++)
                {
                    Console.Write(tabel[i,j] + "\t");
                }
                Console.WriteLine();
            }

            string[,] maanden = { { "Dec", "Jan", "Feb" },
                                  { "Maa", "Apr", "Mei" },
                                  { "Jun", "Jul", "Aug" },
                                  { "Sep", "Okt", "Nov" } };

            foreach (var item in maanden)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            int kolom = 0;
            foreach (var item in maanden)
            {
                if (kolom == maanden.GetLength(1))
                {
                    Console.WriteLine();
                    kolom = 0;
                }
                Console.Write(item + " ");
                kolom++;
            }


        }
    }
}