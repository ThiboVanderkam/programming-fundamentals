using System;

namespace _06FindTheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;
            string numbers = "";
            string tempnumber = "";

            for (int i = 0; i < length; i++)
            {
                if ("0123456789".Contains(input[i]))
                {
                    tempnumber += input[i];
                }
                else if (input[i] == ' ' && tempnumber.Length != 0)
                {
                    numbers += tempnumber + " ";
                    tempnumber = "";
                }
            }

            if(numbers.Length == 0)
            {
                return;
            }

            string cleannumbers = numbers.Remove(numbers.Length - 1);
            
            
            int[] numberArray = Array.ConvertAll(cleannumbers.Split(' '), Convert.ToInt32);
            int nlength = numberArray.Length;

            for (int i = 0; i < nlength; i++)
            {
                for (int j = 0; j < nlength - 1; j++)
                {
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        int swap = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j + 1] = swap;
                    }
                }
            }

            for (int i = 0; i < nlength; i++)
            {
                Console.Write(numberArray[i] + " ");
            }

        }
    }
}
