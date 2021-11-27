using System;

namespace _06SoUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    
                    if (String.Compare(input[j], input[j + 1]) > 0)
                    {
                        string swap = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = swap;
                    }
                }
            }


            Console.Write(input[0] + " ");
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
