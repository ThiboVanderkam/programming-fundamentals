using System;

namespace _03Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            double kelvin = Convert.ToDouble(Console.ReadLine());
            double celcius = kelvin - 273.15;

            
            if (celcius < 0)
            {
                Console.WriteLine("Very Cold");
            }
            else if (celcius >= 0 && celcius < 10)
            {
                Console.WriteLine("Cold");
            }
            else if (celcius >= 10 && celcius < 20)
            {
                Console.WriteLine("Normal");
            }
            else if (celcius >= 20 && celcius < 30)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("Very Hot");
            }
            

        }
    }
}
