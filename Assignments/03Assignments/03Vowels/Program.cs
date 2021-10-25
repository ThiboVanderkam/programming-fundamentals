using System;

namespace _03Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = Convert.ToChar(Console.ReadLine());
            int inputnumber = (int)input;
            if (inputnumber >= 48 && inputnumber <= 57)
            {
                Console.WriteLine("number");
            }
            else if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u' || input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}
