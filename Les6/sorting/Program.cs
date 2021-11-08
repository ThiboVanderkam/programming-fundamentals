using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een reeks getallen in, gescheiden door een spatie");
            double[] punten = Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToDouble);

            double min = punten[0];
            foreach (double item in punten)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine($"Het minimum is: {min}");

            for (int i = 0; i < punten.Length; i++)
            {
                for (int j = 0; j < punten.Length-1; j++)
                {
                    if (punten[j] > punten[j+1])
                    {
                        double swap = punten[j];
                        punten[j] = punten[j + 1];
                        punten[j + 1] = swap;
                    }
                }
            }

            foreach ( double item in punten)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            double som = 0;
            foreach (double item in punten)
            {
                som += item;
            }
            Console.WriteLine("Som: " + som);

            double average = som / punten.Length;
            Console.WriteLine("Gemiddelde: " + average);

            

        }
    }
}
