using System;

namespace _06ItsMagic
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowAmount = Convert.ToInt32(Console.ReadLine());
            int[][] rows = new int[rowAmount][];

            for (int i = 0; i < rowAmount; i++)
            {
                rows[i] = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            }

            int columnamount = rows[0].Length;
            int[] sums = new int[columnamount];

            for (int i = 0; i < rowAmount; i++)
            {
                for (int j = 0; j < columnamount; j++)
                {
                    sums[j] += rows[i][j];
                }
            }

            for (int i = 1; i < columnamount; i++)
            {
                if (sums[i] != sums[i-1])
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            Console.WriteLine("true");
        }
    }
}
