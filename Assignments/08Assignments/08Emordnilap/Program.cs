using System;
using System.IO;

namespace _08Emordnilap
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                StreamReader stream = File.OpenText("english.txt");
                string tekst = stream.ReadToEnd();
                tekst = tekst.ToLower();
                stream.Close();

                string reverseInput = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverseInput += input[i];
                }
                Console.WriteLine(reverseInput);

                string[] words = tekst.Split('\n');
                foreach (var item in words)
                {
                    if (item == reverseInput)
                    {
                        Console.WriteLine(true);
                        return;
                    }
                }
                Console.WriteLine(false);
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
