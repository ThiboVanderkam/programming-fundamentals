using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 5;

            int[] getallen = new int[3];
            string[] namen = { "tuur", "jan", "mies", "bob" };
            Console.WriteLine($"{getallen[0]} {getallen[1]} {getallen[2]}");
            Console.WriteLine($"{namen[0]} {namen[1]} {namen[2]} {namen[3]}");

            getallen[0] = 8;
            getallen[1] = getal;
            Console.WriteLine($"{getallen[0]} {getallen[1]} {getallen[2]}");


            Console.WriteLine(namen.Length);
            Console.WriteLine(namen);

            //namen[4] = "vijfde kind";  //index out of range!

            for (int i = 0; i < namen.Length; i++)
            {
                Console.Write(namen[i] + " ");
            }

            Console.WriteLine();
            foreach (string item in namen)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            int index = 0;
            while (index < namen.Length)
            {
                Console.Write(namen[index] + " ");
                index++; //niet vergeten!!
            }
            Console.WriteLine();

            Console.WriteLine("Geef aantal studenten in: ");
            int aantal = Convert.ToInt32(Console.ReadLine());
            double[] punten;
            punten = new double[aantal];

            //punten ingeven
            for (int i = 0; i < aantal; i++)
            {
                Console.Write($"Geef punt voor student {i + 1}: ");
                punten[i] = Convert.ToDouble(Console.ReadLine());
            }

            //punten printen
            foreach (var item in punten)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("Geef aantal stukken fruit in, gescheiden door een komma: ");
            string[] fruit = Console.ReadLine().Split(',');
            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nGeef een aantal getallen in gescheiden door een spatie");
            string[] strGetallen = Console.ReadLine().Split(" ");
            int[] array = new int[strGetallen.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(strGetallen[i]);
            }
            int som = 0;
            foreach (var item in array)
            {
                som += item;
            }
            Console.WriteLine($"De som is {som}");

            Console.WriteLine("\nGeef nog een aantal getallen in gescheiden door een spatie");
            array = Array.ConvertAll(strGetallen, Convert.ToInt32);
        }
    }
}
