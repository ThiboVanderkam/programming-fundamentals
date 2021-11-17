using System;
using System.Linq;

namespace _05Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int length = password.Length;
            int uppercase = 0;
            int lowercase = 0;
            int symbols = 0;
            int numbers = 0;

            if (length >= 7)
            {
                for (int i = 0; i < length; i++)
                {
                    if ("1234567890".Contains(password.ElementAt(i)))
                    {
                        numbers++;
                    }
                    else if ("abcdefhjklmnopqrstuvwxyz".Contains(password.ElementAt(i)))
                    {
                        lowercase++;
                    }
                    else if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(password.ElementAt(i)))
                    {
                        uppercase++;
                    }
                    else
                    {
                        symbols++;
                    }
                }
                if (uppercase > 0 && lowercase > 0 && numbers > 0 && symbols > 0)
                {
                    Console.WriteLine("strong");
                }
            }
            else
            {
                Console.WriteLine("weak");
            }
            
        }
    }
}
