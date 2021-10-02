using System;

namespace _02Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int dif = number1 - number2;
            int mul = number1 * number2;
            int dev = number1 / number2;
            int rem = number1 % number2;

            Console.WriteLine("" + number1 + " + " + number2 + " = " + sum);
            Console.WriteLine("" + number1 + " - " + number2 + " = " + dif);
            Console.WriteLine("" + number1 + " x " + number2 + " = " + mul);
            Console.WriteLine("" + number1 + " / " + number2 + " = " + dev + " remainder " + rem);
        }
    }
}
