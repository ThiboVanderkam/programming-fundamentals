using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akari
{
    class Akari
    {
        private (int, int) _blackCells { get; set; }
        private (int, int) _lightBulbs { get; set; }
        public char[,] Board { get; set; }


        public Akari(int rows, int cols, List<(int, int)> blackCells)
        {
            CreateBoard(rows, cols);

            //Add black cells
            foreach (var item in blackCells)
            {
                Board[item.Item1, item.Item2] = '#';
            }
        }

        private void CreateBoard(int rows, int cols)
        {
            Board = new char[rows, cols];
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = '_';
                }
            }
        }

        private void PlaceRays(int r, int c)
        {
            List<(int, int)> rayCells = Rays(r, c);
            foreach (var item in rayCells)
            {
                Board[item.Item1, item.Item2] = '*';
            }
        }

        private List<(int,int)> Rays(int r, int c)
        {
            List<(int, int)> illuminated = new List<(int, int)>();

            //Check ray to the right
            for (int i = c + 1; i < Board.GetLength(1); i++)
            {
                if (Board[r, i] == '#')
                {
                    break;
                }
                else
                {
                    illuminated.Add((r, i)); 
                }
            }

            //Check ray to the left
            for (int i = c - 1; i >= 0; i--)
            {
                if (Board[r, i] == '#')
                {
                    break;
                }
                else
                {
                    illuminated.Add((r, i));
                }
            }

            //Check ray to the bottom
            for (int i = r + 1; i < Board.GetLength(0); i++)
            {
                if (Board[i, c] == '#')
                {
                    break;
                }
                else
                {
                    illuminated.Add((i, c));
                }
            }

            //Check ray to the bottom
            for (int i = r - 1; i >= 0; i--)
            {
                if (Board[i, c] == '#')
                {
                    break;
                }
                else
                {
                    illuminated.Add((i, c));
                }
            }

            return illuminated;
        }

        private List<(int, int)> Illuminated()
        {
            List<(int, int)> illuminated = new List<(int, int)>();
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    if (Board[i,j] == 'L')
                    {
                        List<(int, int)> rays = Rays(i, j);
                        foreach (var item in rays)
                        {
                            illuminated.Add(item);
                        }
                    }
                }
            }
            return illuminated;
        }

        public void AddLight(int r, int c) 
        {
            //Check if the coördinates are valid on the board
            if (r < 0 || r >= Board.GetLength(0) || c < 0 || c >= Board.GetLength(1))
            {
                Console.WriteLine("invalid position");
            }
            else if (Board[r, c] != '*' && Board[r, c] != '#')
            {
                Board[r, c] = 'L';
                PlaceRays(r, c);
            }
            else
            {
                Console.WriteLine("invalid position");
            }
        }

        public bool isSolved()
        {
            bool result = true;
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    if (Board[i,j] == '_')
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    s += Board[i, j];
                }
                s += "\n";
            }
            return s;
        }
    }
}
