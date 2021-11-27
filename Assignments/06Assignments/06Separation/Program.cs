using System;

namespace _06Separation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            int length = input.Length;
            string even = "";
            string odd = "";

            for (int i = 0; i < length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    even += input[i] + " ";
                }
                else
                {
                    odd += input[i] + " ";
                }
            }

            Console.WriteLine("even: " + even);
            Console.WriteLine("odd: " + odd);
        }
    }
}
