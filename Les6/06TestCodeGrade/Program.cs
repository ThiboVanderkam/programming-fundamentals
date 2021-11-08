using System;

namespace _06TestCodeGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            int min = getallen[0];
            foreach (int item in getallen)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            int max = getallen[0];
            foreach (int item in getallen)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            Console.WriteLine("Maximum is " + max);
            Console.WriteLine("Minimum is " + min);
        }
    }
}
