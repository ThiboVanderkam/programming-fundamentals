using System;

namespace _04DecimalToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            while(input >= 1000)
            {
                Console.Write("M");
                input -= 1000;
            }

            while (input >= 500)
            {
                Console.Write("D");
                input -= 500;
            }

            while (input >= 100)
            {
                Console.Write("C");
                input -= 100;
            }

            while (input >= 50)
            {
                Console.Write("L");
                input -= 50;
            }

            while (input >= 10)
            {
                Console.Write("X");
                input -= 10;
            }

            while (input >= 5)
            {
                Console.Write("V");
                input -= 5;
            }

            while (input >= 1)
            {
                Console.Write("I");
                input -= 1;
            }
        }
    }
}
