using System;
using System.Linq;

namespace _04TestCodeGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            int length = binary.Length;
            int value = 0;

            for (int i = 0; i < length; i++)
            {
                
                if (binary.ElementAt(i) == '1')
                {
                    value += (int)Math.Pow(2, length - 1 - i);
                }
            }
            Console.WriteLine(value);
        }
    }
}
