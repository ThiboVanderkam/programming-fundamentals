using System;

namespace _04Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            bool prime = true;

            for (int i = 1; i <= number; i++)
            {
                if ((number % i == 0) && (i != 1) && (i != number))
                {
                    if (prime)
                    {
                        Console.Write("false 1 ");
                        prime = false;
                    }
                    Console.Write(i + " ");
                }
            }

            if (prime)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.Write(number + " ");
            }
        }
    }
}
