using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05FindDobby
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            StreamReader stream = File.OpenText("Harry Potter and the Sorcerer.txt");
            string text = stream.ReadToEnd();
            stream.Close();

            Regex regex = new Regex(name, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine("" + name + ": " + matches.Count + " occurrences");
        }
    }
}
