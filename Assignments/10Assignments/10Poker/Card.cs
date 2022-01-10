using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Poker
{
    class Card
    {
        public char Suit { get; set; }
        public string Value { get; set; }

        public Card(string cardstring)
        {
            Suit = cardstring[cardstring.Length - 1];
            if (cardstring.Length == 2)
            {
                Value = "";
                Value += cardstring[0];
            }
            else
            {
                Value = "";
                Value += cardstring[0];
                Value += cardstring[1];
            }
        }
    }
}
