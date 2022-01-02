using System;
using System.Collections.Generic;
using System.IO;

namespace _08VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filename = Console.ReadLine();
                StreamReader stream = File.OpenText(filename);
                string tekst = stream.ReadToEnd();
                tekst = tekst.ToLower();
                stream.Close();

                Dictionary<char, int> vowels = new Dictionary<char, int>();
                Dictionary<char, int> consonants = new Dictionary<char, int>();

                for (int i = 0; i < tekst.Length; i++)
                {
                    if ("aeiouy".Contains(tekst[i]))
                    {
                        if (vowels.ContainsKey(tekst[i]))
                        {
                            vowels[tekst[i]]++;
                        }
                        else
                        {
                            vowels.Add(tekst[i], 1);
                        }
                    }
                    else if ("bcdfghjklmnpqrstvwxz".Contains(tekst[i]))
                    {
                        if (consonants.ContainsKey(tekst[i]))
                        {
                            consonants[tekst[i]]++;
                        }
                        else
                        {
                            consonants.Add(tekst[i], 1);
                        }
                    }
                }

                char maxVowel = ' ';
                int maxVNumber = 0;
                foreach (var item in vowels)
                {
                    if (item.Value > maxVNumber)
                    {
                        maxVowel = item.Key;
                        maxVNumber = item.Value;
                    }
                }

                char maxConsonant = ' ';
                int maxCNumber = 0;
                foreach (var item in consonants)
                {
                    if (item.Value > maxCNumber)
                    {
                        maxConsonant = item.Key;
                        maxCNumber = item.Value;
                    }
                }

                Console.WriteLine(maxVowel + " " + maxConsonant);
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
            
        }
    }
}
