using System;

namespace _02AGE
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            int birthyear = 2021 - age;
            Console.WriteLine(name + " was born in " + birthyear + "!");
        }
    }
}
