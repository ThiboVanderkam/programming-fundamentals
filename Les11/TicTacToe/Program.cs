using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe ttt = new TicTacToe();
            Console.WriteLine(ttt);

            Console.Write("Position? ");
            int position = Convert.ToInt32(Console.ReadLine());

            bool X = true;
            while (ttt.Winner() == ' ' || !ttt.Full())
            {
                if (X)
                {
                    ttt.MakeMove(position, 'X');
                }
                else
                {
                    ttt.MakeMove(position, 'O');
                }
                X = !X;

                Console.WriteLine(ttt);

                Console.Write("Position? ");
                position = Convert.ToInt32(Console.ReadLine());
                
            }
        }
    }
}
