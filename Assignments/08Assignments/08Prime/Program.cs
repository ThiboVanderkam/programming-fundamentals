using System;

namespace _08Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');
                int[] numberArray = new int[inputArray.Length];

                for (int i = 0; i < inputArray.Length; i++)
                {
                    numberArray[i] = Convert.ToInt32(inputArray[i]);
                }

                int sum = 0;
                for (int i = 0; i < numberArray.Length; i++)
                {
                    bool prime = true;

                    for (int j = 1; j < numberArray[i]; j++)
                    {
                        if ((numberArray[i] % j == 0) && (j != 1))
                        {

                            prime = false;

                        }
                    }

                    if (prime)
                    {
                        sum += numberArray[i];
                    }

                }
                Console.WriteLine(sum);
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
