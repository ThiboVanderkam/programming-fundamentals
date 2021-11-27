using System;

namespace _06OnlyEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            int length = input.Length;
            int[] evennumbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (input[i] % 2 == 1)
                {
                    evennumbers[i] = input[i] + 1;
                }
                else
                {
                    evennumbers[i] = input[i];
                }
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write(evennumbers[i] + " ");
            }
        }
    }
}
