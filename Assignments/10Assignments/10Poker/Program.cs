using System;
using System.Collections.Generic;

namespace _10Poker
{
    class Program
    {
        static int Winner(List<PokerHand> Players)
        {
            int winnerNumber = 0;
            int winnerScore = 0;
            for (int i = 0; i < Players.Count; i++)
            {
                string ranking = Players[i].Ranking();
                int rating = 0;
                if (ranking == "High Card")
                {
                    rating = 0;
                }
                else if (ranking == "1 Pair")
                {
                    rating = 1;
                }
                else if (ranking == "2 Pairs")
                {
                    rating = 2;
                }
                else if (ranking == "3 Of A Kind")
                {
                    rating = 3;
                }
                else if (ranking == "Straight")
                {
                    rating = 4;
                }
                else if (ranking == "Flush")
                {
                    rating = 5;
                }
                else if (ranking == "Full House")
                {
                    rating = 6;
                }
                else if (ranking == "4 Of A Kind")
                {
                    rating = 7;
                }
                else if (ranking == "Straight Flush")
                {
                    rating = 8;
                }
                else if (ranking == "Royal Flush")
                {
                    rating = 9;
                }
                
                if (rating >= winnerScore)
                {
                    winnerNumber = i;
                    winnerScore = rating;
                }
            }

            return winnerNumber + 1;
        }
        
        static void Main(string[] args)
        {
            try
            {
                List<PokerHand> Players = new List<PokerHand>();
                bool stop = false;
                while (!stop)
                {
                    string input = Console.ReadLine();
                    if (input.Contains("hand"))
                    {
                        string[] splitInput = input.Split(' ');
                        string[] cleanInput = new string[5];
                        for (int i = 1; i < splitInput.Length; i++)
                        {
                            cleanInput[i - 1] = splitInput[i];
                        }
                        PokerHand Player = new PokerHand(cleanInput);
                        Players.Add(Player);
                    }
                    else if (input.Contains("ranking"))
                    {
                        string[] splitInput = input.Split(' ');
                        int playerNumber = Convert.ToInt32(splitInput[1]) - 1;
                        Console.WriteLine(Players[playerNumber].Ranking());
                    }
                    else if (input == "winner")
                    {
                        int winnerNumber = Winner(Players);
                        Console.WriteLine("Hand " + winnerNumber + " wins!");
                    }
                    else if (input == "stop")
                    {
                        stop = true;
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
