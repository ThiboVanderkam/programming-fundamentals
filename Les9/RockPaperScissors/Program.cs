using System;
using System.Linq;

namespace RockPaperScissors
{
    class Program
    {
        static string[] spel = { "blad", "steen", "schaar"};
        static int scoreComputer = 0;
        static int scoreGebruiker = 0;

        static string Computer()
        {
            Random rd = new Random();
            int index = rd.Next(0, spel.Length);
            return spel[index];
        }

        static void Score(string gebruiker, string computer)
        {
            if (gebruiker == computer)
            {
                return;
            }
            if ((gebruiker == "blad" && computer == "steen") || (gebruiker == "schaar" && computer == "blad") || (gebruiker == "steen" && computer == "schaar"))
            {
                scoreGebruiker++;
            }
            else
            {
                scoreComputer++;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("blad, steen of schaar? ");
            string gebruiker = Console.ReadLine();
            while (spel.Contains(gebruiker))
            {
                string computer = Computer();
                Score(gebruiker, computer);
                Console.WriteLine("Gebruiker: " + scoreGebruiker + "\nComputer: " + scoreComputer);

                Console.WriteLine("blad, steen of schaar? ");
                gebruiker = Console.ReadLine();
            }
        }
    }
}
