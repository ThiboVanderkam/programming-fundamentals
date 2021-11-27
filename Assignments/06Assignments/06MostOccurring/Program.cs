using System;

namespace _06MostOccurring
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int length = input.Length;
            string[] currentHighest = {"§", "0"}; //§ is used as a placeholder 

            for (int i = 0; i < length; i++)
            {
                int counter = 0;
                string currentWord = input[i];
                if (currentWord != currentHighest[0]) //If the word is already the highest, we don't have to count it again
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (input[j] == currentWord)
                        {
                            counter++;
                        }
                    }
                }

                if (counter > Convert.ToInt32(currentHighest[1]))
                {
                    currentHighest[0] = currentWord;
                    currentHighest[1] = Convert.ToString(counter);
                }
            }
            Console.WriteLine(currentHighest[0]);
        }
    }
}
