using System;

namespace _03LowercaseUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = Convert.ToChar(Console.ReadLine());
            int inputnumber = (int)input;

            if (inputnumber >= 65 && inputnumber <= 90)
            {
                Console.WriteLine("uppercase");
            }
            else
            {
                Console.WriteLine("lowercase");
            }
        }
    }
}
