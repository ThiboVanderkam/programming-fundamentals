using System;

namespace _03Quarter
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime input = Convert.ToDateTime(Console.ReadLine());
            int month = input.Month;
            if (month <= 3)
            {
                Console.WriteLine("1");
            }
            else if (month <= 6)
            {
                Console.WriteLine("2");
            }
            else if (month <= 9)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("4");
            }


        }
    }
}
