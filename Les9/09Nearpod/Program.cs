using System;
using System.Collections.Generic;

namespace _09Nearpod
{
    class Program
    {
        static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        static void Print(double[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        static void Print(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        static int MeestVoorkomend(int[] array)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!numbers.ContainsKey(array[i]))
                {
                    numbers[array[i]] = 1;
                }
                else
                {
                    numbers[array[i]]++;
                }
            }
            int max = 0;
            int resultaat = 0;
            foreach (var item in numbers)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    resultaat = item.Key;
                }
            }
            return resultaat;
        }


        static int[] RandomVullen(int min = 1, int max = 10)
        {
            Random rd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(min, max);
            }
            return array;
        }


        static void Main(string[] args)
        {
            int[] array1 = RandomVullen();
            /*int[] array2 = { 69, 69, 69, 69, 69, 69, 69, 69, 69, 69, 69, 69, 69, 69 };
            double[] array3 = { 6.9, 6.9, 6.9, 6.9, 6.9, 6.9, 6.9, 6.9, 6.9 };
            string[] array4 = { "appel", "peer", "banaan", "kiwi" };

            Print(array1);
            Print(array2);
            Print(array3);
            Print(array4);
            Print(array1);
            Print(array2);
            */

            Console.WriteLine(MeestVoorkomend(array1));
            Print(array1);
            
        }
    }
}