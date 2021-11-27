using System;

namespace _06Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string woord = Console.ReadLine();
            string[] input = Console.ReadLine().Split(' ');
            int counter = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == woord)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
