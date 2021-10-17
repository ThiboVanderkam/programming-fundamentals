using System;

namespace CentjesTellen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een bedrag in!");
            double bedrag = Convert.ToDouble(Console.ReadLine());

            int euro2 = (int)bedrag / 2;
            int euro1 = (int)bedrag % 1;
            // enzovoorts enzovoorts
        }
    }
}
