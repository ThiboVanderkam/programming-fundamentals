using System;
using System.IO;

namespace _07SelectWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Console.ReadLine();
            if (!File.Exists(fileName))
            {
                Console.WriteLine("crazy input");
                return;
            }
            StreamReader stream = File.OpenText(fileName);
            string text = stream.ReadToEnd().ToLower();
            stream.Close();
            string[] words = text.Split('\n');


            string input = Console.ReadLine().ToLower();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if ("azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN ".Contains(input[i]))
                {
                    counter++;
                }
            }
            if (counter != input.Length)
            {
                Console.WriteLine("crazy input");
                return;
            }
            string letters = input;
            

            input = Console.ReadLine();
            counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if ("0123456789".Contains(input[i]))
                {
                    counter++;
                }
            }
            if (counter != input.Length)
            {
                Console.WriteLine("crazy input");
                return;
            }
            int givenLength = Convert.ToInt32(input);
            

            counter = 0;
            bool letterFound = false;
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                counter = 0;
                for (int j = 0; j < letters.Length; j++)
                {
                    letterFound = false;
                    for (int k = 0; k < currentWord.Length; k++)
                    {
                        if (!letterFound && letters[j] == currentWord[k])
                        {
                            counter++;
                            letterFound = !letterFound;
                        }
                    }
                }
                if (counter == letters.Length && words[i].Length == givenLength)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
