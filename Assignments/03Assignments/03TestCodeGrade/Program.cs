using System;

namespace _03TestCodeGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int year;
            bool succes = Int32.TryParse(input, out year);
            bool isleapyear;

            if (!succes)
            {
                Console.WriteLine("crazy input");
                return;
            }
            if (year % 4 != 0)
            {//Nice try Phaedra:P
                isleapyear = false;
            }
            else if (year % 100 != 0)
            {
                isleapyear = true;
            }
            else if (year % 400 != 0)
            {
                isleapyear = false;
            }
            else
            {
                isleapyear = true;
            }

            Console.WriteLine(isleapyear);

        }
    }
}
