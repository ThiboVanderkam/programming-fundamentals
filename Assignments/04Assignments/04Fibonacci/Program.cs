using System;

namespace _04Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int fib1 = 0;
            int fib2 = 1;
            int temp = 0;

            Console.Write(fib1 + " ");
            Console.Write(fib2 + " ");

            for (int i = 1; i < input; i++)
            {
                temp = fib1 + fib2;
                fib1 = fib2;
                fib2 = temp;
                Console.Write(temp + " ");
                
            }
        }
    }
}
