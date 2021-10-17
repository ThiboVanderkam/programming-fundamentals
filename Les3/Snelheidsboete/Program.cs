using System;
//Dit is een comment:P
namespace Snelheidsboete
{
    class Program
    {
        static void Main(string[] args)
        {
            int zone = Convert.ToInt32(Console.ReadLine());
            int snelheid = Convert.ToInt32(Console.ReadLine());

            if (snelheid > zone + 27)
            {
                Console.WriteLine("RECHTBANK");
            }
            else if (snelheid > zone + 17)
            {
                Console.WriteLine("160 euro boete");
            }
            else if (snelheid > zone + 7)
            {
                Console.WriteLine("53 euro boete");
            }
            else
            {
                Console.WriteLine("Geen boete:)");
            }
        }
    }
}
