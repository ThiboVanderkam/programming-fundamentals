using System;

namespace SwitchStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            int dag = (int)DateTime.Now.DayOfWeek;

            /*
            if (dag == 1)
            {
                Console.WriteLine("Maandag");
            }
            else if (dag == 2)
            {
                Console.WriteLine("Dinsdag");
            }
            else if (dag == 3)
            {
                Console.WriteLine("Woensdag");
            }
            else if (dag == 4)
            {
                Console.WriteLine("Donderdag");
            }
            else if (dag == 5)
            {
                Console.WriteLine("Vrijdag");
            }
            else if (dag == 6)
            {
                Console.WriteLine("Zaterdag");
            }
            else if (dag == 7)
            {
                Console.WriteLine("Zondag");
            }
            */

            switch (dag)
            {
                case 1: 
                    Console.WriteLine("Maandag"); 
                    break;
                case 2: 
                    Console.WriteLine("Dinsdag"); 
                    break;
                case 3: 
                    Console.WriteLine("Woensdag"); 
                    break;
                case 4: 
                    Console.WriteLine("Donderdag"); 
                    break;
                case 5: 
                    Console.WriteLine("Vrijdag"); 
                    break;
                case 6: 
                    Console.WriteLine("Zaterdag"); 
                    break;
                case 7: 
                    Console.WriteLine("Zondag"); 
                    break;
                default: 
                    Console.WriteLine("Visual Studio geeft geen fuck"); 
                    break;

            }

        }
    }
}
