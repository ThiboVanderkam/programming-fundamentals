using System;

namespace _07PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();     
            if (input.Length == 0)
            {
                Console.WriteLine("crazy input");
                return;
            }

            string[] words = input.Split(' ');
            string[] latin = new string[words.Length];
            string newWord = "";
            for (int i = 0; i < words.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if ("azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN".Contains(words[i][j]))
                    {
                        counter++;
                    }
                }

                if (counter != words[i].Length)
                {
                    newWord = words[i];
                }
                else
                {
                    if (!"aeiouy".Contains(words[i][0]))
                    {
                        //Rotate letters
                        char temp = words[i][0];
                        for (int j = 1; j < words[i].Length; j++)
                        {
                            newWord += words[i][j];
                        }
                        newWord += temp;
                    }
                    else
                    {
                        newWord = words[i];
                        newWord += 'w';
                    }
                    newWord += "ay";
                }

                latin[i] = newWord;
                newWord = "";
            }

            for (int i = 0; i < latin.Length; i++)
            {
                Console.Write(latin[i] + " ");
            }
        }
    }
}
