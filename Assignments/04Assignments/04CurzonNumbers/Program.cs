using System;

namespace _04CurzonNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int pownumber = 0;
            int multnumber = 0;
            bool found = false;
            while (!found)
            {
                number++;
                pownumber = (int)Math.Pow(2, number) + 1;
                multnumber = 2 * number + 1;

                if (pownumber % multnumber == 0)
                {
                    found = true;
                }
            }
            Console.WriteLine(number);
        }
    }
}
