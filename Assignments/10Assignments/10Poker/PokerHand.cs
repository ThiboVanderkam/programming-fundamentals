using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Poker
{
    
    class PokerHand
    {
        private List<Card> _hand { get; set; }

        public PokerHand(string[] input)
        {
            List<Card> temp = new List<Card>();
            foreach (var item in input)
            {
                Card card = new Card(item);
                
                temp.Add(card);
            }
            _hand = temp;
        }


        private bool RoyalFlush()
        {
            char suit = _hand[0].Suit;
            foreach (var item in _hand)
            {
                if (item.Suit != suit)
                {
                    return false;
                }
            }

            bool ace = false;
            bool king = false;
            bool queen = false;
            bool jack = false;
            bool ten = false;
            foreach (var item in _hand)
            {
                if (item.Value == "A")
                {
                    ace = true;
                }
                else if (item.Value == "K")
                {
                    king = true;
                }
                else if (item.Value == "Q")
                {
                    queen = true;
                }
                else if (item.Value == "J")
                {
                    jack = true;
                }
                else if (item.Value == "10")
                {
                    ten = true;
                }
            }

            bool result = ace && king && queen && jack && ten;
            return result;            
        }
        private bool StraightFlush()
        {
            if (Straight() && Flush())
            {
                return true;
            }
            return false;          
        }
        private bool FourOfAKind()
        {
            List<string> presentValues = new List<string>();
            foreach (var item in _hand)
            {
                if (!(presentValues.Contains(item.Value)))
                {
                    presentValues.Add(item.Value);
                }
            }

            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var item in presentValues)
            {
                count.Add(item, 0);
            }

            foreach (var item in _hand)
            {
                count[item.Value]++;
            }

            foreach (var item in count)
            {
                if (item.Value == 4)
                {
                    return true;
                }
            }
            return false;
        }
        private bool FullHouse()
        {
            List<string> presentValues = new List<string>();
            foreach (var item in _hand)
            {
                if (!(presentValues.Contains(item.Value)))
                {
                    presentValues.Add(item.Value);
                }
            }

            if (presentValues.Count != 2)
            {
                return false;
            }

            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var item in presentValues)
            {
                count.Add(item, 0);
            }

            foreach (var item in _hand)
            {
                count[item.Value]++;
            }

            bool three = false;
            bool two = false;
            foreach (var item in count)
            {
                if (item.Value == 2)
                {
                    two = true;
                }
                if (item.Value == 3)
                {
                    three = true;
                }
            }
            bool endresult = two && three;
            return endresult;
        }
        private bool Flush()
        {
            char suit = _hand[0].Suit;
            foreach (var item in _hand)
            {
                if (item.Suit != suit)
                {
                    return false;
                }
            }
            return true;
        }
        private bool Straight()
        {
            int[] indexes = new int[5];
            string[] sequence = { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
            for (int i = 0; i < 5; i++)
            {
                indexes[i] = Array.IndexOf(sequence, _hand[i].Value);
            }

            for (int i = 0; i < indexes.Length - 1; i++)
            {
                for (int j = i + 1; j < indexes.Length; j++)
                {
                    if (indexes[i] > indexes[j])
                    {
                        int temp = indexes[i];
                        indexes[i] = indexes[j];
                        indexes[j] = temp;
                    }
                }
            }

            for (int i = 0; i < indexes.Length - 1; i++)
            {
                if (indexes[i] == 0 || indexes[i + 1] == 0)
                {
                    //Do nothing
                }
                else
                {
                    if (!(indexes[i] + 1 == indexes[i + 1]))
                    {
                        return false;
                    }
                }
            }

            //the Ace is a special case because it can be used as a '13' or '1'
            if (indexes[0] == 0)
            {
                for (int i = 0; i < indexes.Length; i++)
                {
                    if (indexes[i] == 1 || indexes[i] == 12)
                    {
                        return true;
                    }
                }
                return false;
            }
            return true;
        }
        private bool ThreeOfAKind()
        {
            List<string> presentValues = new List<string>();
            foreach (var item in _hand)
            {
                if (!(presentValues.Contains(item.Value)))
                {
                    presentValues.Add(item.Value);
                }
            }

            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var item in presentValues)
            {
                count.Add(item, 0);
            }

            foreach (var item in _hand)
            {
                count[item.Value]++;
            }

            foreach (var item in count)
            {
                if (item.Value == 3)
                {
                    return true;
                }
            }
            return false;
        }
        private bool TwoPair()
        {
            List<string> presentValues = new List<string>();
            foreach (var item in _hand)
            {
                if (!(presentValues.Contains(item.Value)))
                {
                    presentValues.Add(item.Value);
                }
            }

            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var item in presentValues)
            {
                count.Add(item, 0);
            }

            foreach (var item in _hand)
            {
                count[item.Value]++;
            }

            int pairCount = 0;
            foreach (var item in count)
            {
                if (item.Value == 2)
                {
                    pairCount++;
                }
            }

            if (pairCount == 2)
            {
                return true;
            }
            return false;

        }
        private bool OnePair()
        {
            List<string> presentValues = new List<string>();
            foreach (var item in _hand)
            {
                if (!(presentValues.Contains(item.Value)))
                {
                    presentValues.Add(item.Value);
                }
            }

            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var item in presentValues)
            {
                count.Add(item, 0);
            }

            foreach (var item in _hand)
            {
                count[item.Value]++;
            }

            foreach (var item in count)
            {
                if (item.Value == 2)
                {
                    return true;
                }
            }

            return false;
           
        }
        public string Ranking()
        {
            string ranking = "";
            if (RoyalFlush())
            {
                ranking = "Royal Flush";
            }
            else if (StraightFlush())
            {
                ranking = "Straight Flush";
            }
            else if (FourOfAKind())
            {
                ranking = "4 Of A Kind";
            }
            else if (FullHouse())
            {
                ranking = "FullHouse";
            }
            else if (Flush())
            {
                ranking = "Flush";
            }
            else if (Straight())
            {
                ranking = "Straight";
            }
            else if (ThreeOfAKind())
            {
                ranking = "3 Of A Kind";
            }
            else if (TwoPair())
            {
                ranking = "2 Pairs";
            }
            else if (OnePair())
            {
                ranking = "1 Pair";
            }
            else
            {
                ranking = "High Card";
            }

            return ranking;
        }
    }
}
