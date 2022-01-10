using System;
using System.Collections.Generic;

namespace Words
{
    class Words
    {
        private string[] _OriginalWords { get; set; }
        public Words(string[] input)
        {
            _OriginalWords = input;
        }

        public void Sort()
        {
            string[] sortedWords = new string[_OriginalWords.Length];
            for (int i = 0; i < sortedWords.Length; i++)
            {
                sortedWords[i] = _OriginalWords[i];
            }

            Array.Sort(sortedWords);
            Console.Write(sortedWords[0]);
            for (int i = 1; i < sortedWords.Length; i++)
            {
                Console.Write(" " + sortedWords[i]);
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            string s = _OriginalWords[0];

            for (int i = 1; i < _OriginalWords.Length; i++)
            {
                s += " " + _OriginalWords[i];
            }
            
            
            return s;
        }
        
        public void Occurrences()
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < _OriginalWords.Length; i++)
            {
                if (words.ContainsKey(_OriginalWords[i]))
                {
                    words[_OriginalWords[i]]++;
                }
                else
                {
                    words.Add(_OriginalWords[i], 1);
                }
            }

            foreach (var item in words)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }

        public void Unique() //I copied the code from Occurrences, because it also kinda does this function
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < _OriginalWords.Length; i++)
            {
                if (words.ContainsKey(_OriginalWords[i]))
                {
                    words[_OriginalWords[i]]++;
                }
                else
                {
                    words.Add(_OriginalWords[i], 1);
                }
            }

            foreach (var item in words)
            {
                Console.Write(item.Key + " ");
            }
            Console.WriteLine();
        }

        public void MostOccurrences()
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < _OriginalWords.Length; i++)
            {
                if (words.ContainsKey(_OriginalWords[i]))
                {
                    words[_OriginalWords[i]]++;
                }
                else
                {
                    words.Add(_OriginalWords[i], 1);
                }
            }

            string winnerS = "";
            int winnerI = 0;

            foreach (var item in words)
            {
                if (item.Value > winnerI)
                {
                    winnerS = item.Key;
                    winnerI = item.Value;
                }
            }

            Console.WriteLine(winnerS);
        }

    }
}