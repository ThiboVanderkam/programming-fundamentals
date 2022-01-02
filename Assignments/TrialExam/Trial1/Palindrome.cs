using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial1
{
    class Palindrome
    {
        private string _InputNumber { get; set; }
        public Palindrome(string number)
        {
            _InputNumber = number;
        }

        public bool CheckPalindrome(int number)
        {
            string stringNumber = Convert.ToString(number);
            for (int i = 0; i < stringNumber.Length; i++)
            {
                if (!(stringNumber[i] == stringNumber[stringNumber.Length - 1 - i]))
                {
                    return false;
                }
            }
            return true;
        }

        public int FindNext()
        {
            int number = Convert.ToInt32(_InputNumber);
            bool found = false;
            while (!found)
            {
                number++;
                found = CheckPalindrome(number);
            }

            return number;
        }
    }
}
