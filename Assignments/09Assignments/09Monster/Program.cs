using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Monster
{
    class Program
    {
        //returns the next leap year
        static int NextLeapYear(int year)
        {
            bool leapYearFound = false;
            while (!leapYearFound)
            {
                year += 1;
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        leapYearFound = !leapYearFound;
                        return year;
                    }
                }
                else
                {
                    if (year % 4 == 0)
                    {
                        leapYearFound = !leapYearFound;
                        return year;
                    }
                }
            }
            return year;
        }

        //keeps adding the digits of a number until the number is just 1 digit
        static int SumOfDigits(int nr)
        {
            string stringNumber = Convert.ToString(nr);
            int newNumber = Convert.ToInt32(stringNumber);
            while (stringNumber.Length > 1)
            {
                newNumber = 0;
                for (int i = 0; i < stringNumber.Length; i++)
                {
                    int digit = (int)stringNumber[i] - (int)'0';
                    
                    newNumber += digit;
                }
                stringNumber = Convert.ToString(newNumber);
            }
            return newNumber;
        }

        //determines whether a number is part of the Fibonacci sequence or not
        static bool IsFibonacci(int number)
        {           
            int fib1 = 0;
            int fib2 = 1;
            int temp = 0;
            if (number == fib1 || number == fib2)
            {
                return true;
            }
            while (fib2 < number)
            {
                temp = fib1 + fib2;
                fib1 = fib2;
                fib2 = temp;
                if (number == fib2)
                {
                    return true;
                }
            }
            return false;
        }

        //returns the next prime number
        static int NextPrime(int number)
        {
            bool primeFound = false;
            while (!primeFound)
            {
                number++;
                bool prime = true;
                for (int i = 1; i < number; i++)
                {
                    if ((number % i == 0) && (i != 1))
                    {
                        prime = false;
                    }
                }

                if (prime)
                {
                    return number;
                }
            }
            return number;
        }

        //Reverses the case of a text
        static string ReverseCase(string text)
        {
            string reverseCaseText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if ("azertyuiopqsdfghjklmwxcvbn".Contains(text[i]))
                {
                    reverseCaseText += Char.ToUpper(text[i]);
                }
                else if ("AZERTYUIOPQSDFGHJKLMWXCVBN".Contains(text[i]))
                {
                    reverseCaseText += Char.ToLower(text[i]);
                }
                else
                {
                    reverseCaseText += text[i];
                }
            }          
            return reverseCaseText;
        }

        //determines whether a given text is a palindrome or not
        static bool Palindrome(string text)
        {
            text = text.ToLower();
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    newText += text[i];
                }
            }

            for (int i = 0; i < newText.Length; i++)
            {
                
                if (!(newText[i] == newText[newText.Length - 1 - i]))
                {
                    return false;                   
                }
            }
            return true;
        }

        //determines whether 2 inputted texts are anagrams of each other
        static bool Anagram(string text1, string text2)
        {
            text1 = text1.ToLower();
            text2 = text2.ToLower();
            Dictionary<char, int> letters1 = new Dictionary<char, int>();
            for (int i = 0; i < text1.Length; i++)
            {
                if (letters1.ContainsKey(text1[i]))
                {
                    letters1[text1[i]]++;
                }
                else if (text1[i] != ' ')
                {
                    letters1.Add(text1[i], 1);
                }
            }

            Dictionary<char, int> letters2 = new Dictionary<char, int>();
            for (int i = 0; i < text2.Length; i++)
            {
                if (letters2.ContainsKey(text2[i]))
                {
                    letters2[text2[i]]++;
                }
                else if (text2[i] != ' ')
                {
                    letters2.Add(text2[i], 1);
                }
            }

            int counter = 0;
            foreach (var item1 in letters1)
            {
                foreach (var item2 in letters2)
                {
                    if (item1.Key == item2.Key && item1.Value == item2.Value)
                    {
                        counter++;
                    }
                }
            }
            if (counter == letters1.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //calculates the sum of the positions of the letters in the alphabet
        static int AlphabetSum(string text)
        {
            text = text.ToLower();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ("azertyuiopqsdfghjklmwxcvbn".Contains(text[i]))
                {
                    sum += (int)text[i] - ((int)'a' - 1); //(int)'a' - 1 is the ASCII-value of the character before 'a'
                }
            }
            return sum;
        }

        //returns the lowest common multiplier of 2 numbers
        static int LCM(int a, int b)
        {
            int mult = 0;
            if (a > b)
            {
                mult = a - 1; //-1 because the loop adds 1 at start
            }
            else
            {
                mult = b - 1;
            }

            bool multFound = false;
            do
            {
                mult++;
                if (mult % a == 0 && mult % b == 0)
                {
                    multFound = true;
                }
            } while (!multFound);

            return mult;
            
        }

        //returns the greatest common divisor of 2 numbers
        static int GCD(int a, int b)
        {
            int div = 0;
            int min = 0;
            if (a < b)
            {
                min = a;
            }
            else
            {
                min = b;
            }

            for (int i = 1; i <= min; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    div = i;
                }
            }
            return div;
        }

        static void Main(string[] args)
        {
            try
            {
                string methode = Console.ReadLine();
                switch (methode)
                {
                    case "1":
                        int input1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(NextLeapYear(input1));
                        break;
                    case "2":
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(SumOfDigits(input2));
                        break;
                    case "3":
                        int input3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(IsFibonacci(input3));
                        break;
                    case "4":
                        int input4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(NextPrime(input4));
                        break;
                    case "5":
                        string input5 = Console.ReadLine();
                        Console.WriteLine(ReverseCase(input5));
                        break;
                    case "6":
                        string input6 = Console.ReadLine();
                        Console.WriteLine(Palindrome(input6));
                        break;
                    case "7":
                        string input7 = Console.ReadLine();
                        string[] words = input7.Split(',');
                        Console.WriteLine(Anagram(words[0], words[1]));
                        break;
                    case "8":
                        string input8 = Console.ReadLine();
                        Console.WriteLine(AlphabetSum(input8));
                        break;
                    case "9":
                        string input9 = Console.ReadLine();
                        string[] strNumbers = input9.Split(',');
                        int[] numbers = new int[2];
                        numbers[0] = Convert.ToInt32(strNumbers[0]);
                        numbers[1] = Convert.ToInt32(strNumbers[1]);
                        Console.WriteLine(LCM(numbers[0], numbers[1]));
                        break;
                    case "10":
                        string input10 = Console.ReadLine();
                        string[] strNumbers1 = input10.Split(',');
                        int[] numbers1 = new int[2];
                        numbers1[0] = Convert.ToInt32(strNumbers1[0]);
                        numbers1[1] = Convert.ToInt32(strNumbers1[1]);
                        Console.WriteLine(GCD(numbers1[0], numbers1[1]));
                        break;
                    default:
                        Console.WriteLine("crazy input");
                        break;
                }
               
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
