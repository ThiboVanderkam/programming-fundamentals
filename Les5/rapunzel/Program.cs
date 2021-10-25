using System;
using System.IO;
using System.Text.RegularExpressions;

namespace rapunzel
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = File.OpenText("Rapunzel.txt");
            string text = stream.ReadToEnd().ToLower();
            stream.Close();
            int count = 0;
            string woord = "";
            foreach (char item in text)
            {
                if ((int)item >= 97 && (int)item <= 122)
                {
                    woord += item;
                }
                else
                {
                    if (woord == "rapunzel")
                    {
                        count++;
                    }
                    woord = "";
                }
                
            }
            Console.WriteLine(count);

            Regex regex = new Regex(@"rapunzel", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine($"Rapunzel komt {matches.Count} keer voor in de tekst!");

        }
    }
}
