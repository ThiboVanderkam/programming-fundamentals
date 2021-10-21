using System;

namespace _02ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = Convert.ToChar(Console.ReadLine());

            --input; //Used to get the int value for the previous ASCII char

            Console.WriteLine(input);
        }
    }
}
