using System;

namespace CeasarCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string antwoord = Console.ReadLine();
                int number;
                if (!Int32.TryParse(antwoord, out number))
                {
                    Console.WriteLine("crazy input");
                    return;
                }

                string word = Console.ReadLine();
                int counter = 0;
                if (word.Length == 0)
                {
                    Console.WriteLine("crazy input");
                    return;
                }
                for (int i = 0; i < word.Length; i++)
                {
                    if ("azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN".Contains(word[i]))
                    {
                        counter++;
                    }
                }
                if (counter != word.Length)
                {
                    Console.WriteLine("crazy input");
                    return;
                }




                string encryptedString = "";
                int encrIndex;
                int length = word.Length;
                for (int i = 0; i < length; i++)
                {
                    encrIndex = i + number;

                    if (encrIndex >= length)
                    {
                        encrIndex %= length;
                    }
                    else if (encrIndex < 0)
                    {
                        encrIndex = length + encrIndex;
                    }

                    encryptedString += word[encrIndex];
                }
                Console.WriteLine(encryptedString);
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
