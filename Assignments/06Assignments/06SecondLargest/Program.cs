using System;

namespace _06SecondLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int swap = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = swap;
                    }
                }
            }


            int max = input[length - 1];
            int secondmax = 0;
            for (int i = 0; i < length; i++)
            {
                if (input[length - 1 - i] != max)
                {
                    secondmax = input[length - 1 - i];
                    Console.WriteLine(secondmax);
                    return;
                }
            }

        }
    }
}
