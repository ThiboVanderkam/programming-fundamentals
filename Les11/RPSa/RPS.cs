using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSa
{
    class RPS
    {
        public int ScoreComputer{ get; set; }
        public int ScoreUser{ get; set; }
        private Random _random;

        public RPS()
        {
            _random = new Random();
            ScoreComputer = 0;
            ScoreUser = 0;
        }

        public Hand TurnComputer()
        {
            //random nummer tussen 0 en 3 --> 0, 1, 2
            //casten naar een Hand
            return (Hand)_random.Next(0, 3);
        }

        public void Score(Hand computer, Hand user)
        {

        }

        public override string ToString()
        {
            return $"USER {ScoreUser} - COMPUTER {ScoreComputer}";
        }
    }
}
