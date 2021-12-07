using System;

namespace Parameters
{
    class Program
    {
        static void WijzigWaarde(int a)
        {
            Console.WriteLine("in methode voor wijziging: " + a);
            a *= 100;
            Console.WriteLine("in methode na wijziging: " + a);
        }

        static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void WijzigWaarde(int[] array)
        {
            Print(array);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 100;
            }
            Print(array);
        }

        static void Main(string[] args)
        {
            /*
            int variabele = 5;
            Console.WriteLine(variabele);
            WijzigWaarde(variabele);
            Console.WriteLine(variabele);
            */

            int[] array = { 1, 2, 3 };
            Print(array);
            WijzigWaarde(array);
            Print(array);
        }
    }
}
