using System;

namespace _06Rotate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            int rotateAmount = Convert.ToInt32(Console.ReadLine());
            int length = input.Length;

            int temp = 0;

            for (int i = 0; i < rotateAmount; i++)
            {
                temp = input[0];
                input[0] = input[length - 1];
                for (int j = 1; j < length; j++)
                {
                    input[length - j] = input[length - j - 1];
                }
                input[1] = temp;
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
