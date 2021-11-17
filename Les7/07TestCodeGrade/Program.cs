using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _07_Test_CodeGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.OpenText("donkey.txt").ReadToEnd().ToLower();
            string[] chars = Console.ReadLine().Split(' ');



            if (chars.Length != 2)
            {
                Console.WriteLine("crazy input");
                return;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                if (!"azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN".Contains(Convert.ToChar(chars[i])))
                {
                    Console.WriteLine("crazy input");
                    return;
                }
            }

            Regex regex = new Regex(@"\b" + chars[0] + @"\w*" + chars[1] + @"\b");
            MatchCollection matches = regex.Matches(text);

            string[] words = new string[matches.Count];

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = matches[i].Value;
            }

            Array.Sort(words);

            string word = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (word != words[i])
                {
                    Console.Write(words[i] + " ");
                    word = words[i];
                }
                

            }
        }
    }
}