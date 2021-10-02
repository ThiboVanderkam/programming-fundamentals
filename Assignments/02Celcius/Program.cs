using System;

namespace _02Celcius
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celcius = (fahrenheit - 32) * 5 / 9;
	    Console.WriteLine(Math.Round(celcius, 2));   	
        }
    }
}
