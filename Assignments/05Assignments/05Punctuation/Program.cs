using System;
using System.Linq;

namespace _05Punctuation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            char prevpunct = '§'; //§ is used as a placeholder

            for (int i = 0; i < input.Length; i++)
            {
                if (input.ElementAt(i) != prevpunct)
                {
                    output += input.ElementAt(i);
                }

                if (",;:.!?'`\"-_/()[]*".Contains(input.ElementAt(i)))
                {
                    prevpunct = input.ElementAt(i);
                }
                else
                {
                    prevpunct = '§';
                }
            }
            Console.WriteLine(output);

        }
    }
}

