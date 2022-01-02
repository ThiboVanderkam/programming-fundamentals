using System;

namespace _08Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');
                int[] intArray = new int[inputArray.Length];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (!int.TryParse(inputArray[i], out intArray[i]))
                    {
                        Console.WriteLine("crazy input");
                        return;
                    }
                }


                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    for (int j = 0; j < intArray.Length - 1; j++)
                    {
                        if (intArray[j] > intArray[j + 1])
                        {
                            int temp = intArray[j];
                            intArray[j] = intArray[j + 1];
                            intArray[j + 1] = temp;
                        }
                    }
                }

                foreach (var item in intArray)
                {
                    Console.Write(item + " ");
                }

                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    if (!(intArray[i + 1] == intArray[i] + 1))
                    {
                        Console.WriteLine("\n" + "false");
                        return;
                    }
                }

                Console.WriteLine("\n" + "true");
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
