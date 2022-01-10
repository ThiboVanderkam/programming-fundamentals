using System;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string answer = Console.ReadLine();
                Words words = new Words(answer.Split(' '));

                words.Sort();
                Console.WriteLine(words.ToString());
                words.Occurrences();
                words.Unique();
                words.MostOccurrences();
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
