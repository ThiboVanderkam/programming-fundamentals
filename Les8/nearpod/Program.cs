using System;
using System.Collections.Generic;
using System.Linq;

namespace nearpod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] todo_array = new string[10];
            for (int i = 0; i < todo_array.Length; i++)
            {
                Console.Write("TAAK: ");
                todo_array[i] = Console.ReadLine();

            }
            Console.WriteLine("TAKEN VOOR VANDAAG");
            foreach (var item in todo_array)
            {
                Console.WriteLine(item);
            }
            */

            /*
            List<string> todo_List = new List<string>();
            Console.Write("TAAK: ");

            string taak = Console.ReadLine();
            while (taak != "")
            {
                todo_List.Add(taak);
                taak = Console.ReadLine();
            }

            foreach (var item in todo_List)
            {
                Console.WriteLine(item);
            }
            */

            Dictionary<DateTime, List<string>> todo = new Dictionary<DateTime, List<string>>();

            Console.Write("TAAK: ");
            string taak = Console.ReadLine();
            while(taak != "")
            {
                string[] items = taak.Split(',');
                DateTime deadline = Convert.ToDateTime(items[0]);
                if (!todo.ContainsKey(deadline))
                {
                    todo[deadline] = new List<string>();
                    todo[deadline].Add(items[1]);
                }
                else
                {
                    todo[deadline].Add(items[1]);
                }
                Console.Write("TAAK: ");
                taak = Console.ReadLine();

            }

            DateTime[] data = todo.Keys.ToArray();
            Array.Sort(data);

            foreach (var datum in data)
            {
                Console.WriteLine("TAKEN TEGEN: " + datum);
                foreach (var item in todo[datum])
                {
                    Console.WriteLine("- " + item);
                }
            }

        }
    }
}
