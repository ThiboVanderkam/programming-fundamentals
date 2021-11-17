using System;

namespace _04Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;


            for (int i = input1; i <= input2; i++)
            {
                if (i % 2 == 1)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
