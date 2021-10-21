using System;

namespace _02Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            int year = input / 365;
            int yearRest = input % 365;
            int week = yearRest / 7;
            int weekRest = yearRest % 7; //The weekRest is the amount of days remaining

            Console.WriteLine("" + year + " year(s)");
            Console.WriteLine("" + week + " week(s)");
            Console.WriteLine("" + weekRest + " day(s)");
        }
    }
}
