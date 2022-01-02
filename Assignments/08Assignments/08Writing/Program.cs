using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08Writing
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

                string[] words = Console.ReadLine().Split(' ');

                Dictionary<string, int> wordDict = new Dictionary<string, int>();

                for (int i = 0; i < words.Length; i++)
                {
                    if (!wordDict.ContainsKey(words[i]))
                    {
                        wordDict.Add(words[i], 0);
                    }
                }

                string cleantext = "";
                for (int i = 0; i < tekst.Length; i++)
                {
                    if ("abcdefghijklmnopqrstuvwxyz ".Contains(tekst[i]))
                    {
                        cleantext += tekst[i];
                    }
                    else if ("\n".Contains(tekst[i]))
                    {
                        cleantext += " ";
                    }
                }

                string[] cleanArray = cleantext.Split(' ');

                for (int i = 0; i < cleanArray.Length; i++)
                {
                    if (wordDict.ContainsKey(cleanArray[i]))
                    {
                        wordDict[cleanArray[i]]++;
                    }
                }

                string[] keys = wordDict.Keys.ToArray();
                Array.Sort(keys);

                foreach (var item in keys)
                {
                    if (wordDict[item] > 0)
                    {
                        Console.WriteLine(item + ": " + wordDict[item]);
                    }
                }

                Console.Write("Not used: ");
                foreach (var item in keys)
                {
                    if (wordDict[item] == 0)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
            catch
            {
                Console.WriteLine("crazy input");
            }           
        }
    }
}
