using System;

namespace frootloops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Geef een Y/y in om verder te gaan: ");
            string verder = Console.ReadLine();

            while (verder == "y" || verder == "Y")
            {
                Console.Write("Geef een Y/y in om verder te gaan: ");
                verder = Console.ReadLine();
            }
            */


            /*
            Console.Write("Geef een getal in: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            if(getal <= 1)
            {
                Console.WriteLine("Faggot");
                return;
            }

            int result = 1;

            while (result <= 10000)
            {
                Console.Write(result + " ");
                result *= getal;
            }

            do
            {
                Console.WriteLine("DO WHILE --> Shoot first, ask questions later");
            } while (false);
            */

            Console.WriteLine("MAALTAFELS \n\n");

            int getal = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            int i = 0;

            while (i <= 10)
            {
                result = getal * i;
                Console.WriteLine(getal + " * " + i + " = " + result);
                i++;
            }

            


        }
    }
}
