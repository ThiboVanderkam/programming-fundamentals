using System;
using System.Collections.Generic;

namespace _08Greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                int number = 0;
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("crazy input");
                    return;
                }


                List<string> inputStrings = new List<string>();
                for (int i = 0; i < number; i++)
                {
                    inputStrings.Add(Console.ReadLine());
                }


                List<string[]> stringList = new List<string[]>();
                foreach (var item in inputStrings)
                {
                    stringList.Add(item.Split(' '));
                }


                List<int[]> intList = new List<int[]>();
                foreach (var item in stringList)
                {
                    int[] temp = new int[item.Length];
                    for (int i = 0; i < item.Length; i++)
                    {
                        temp[i] = Convert.ToInt32(item[i]);
                    }
                    intList.Add(temp);
                }

                int[] maxArray = new int[number];
                for (int i = 0; i < intList.Count; i++)
                {
                    int max = 0;
                    for (int j = 0; j < intList[i].Length; j++)
                    {
                        if (intList[i][j] > max)
                        {
                            max = intList[i][j];
                        }
                    }
                    maxArray[i] = max;
                }

                for (int i = 0; i < maxArray.Length; i++)
                {
                    for (int j = 0; j < maxArray.Length - 1; j++)
                    {
                        if (maxArray[j] > maxArray[j + 1])
                        {
                            int temp = maxArray[j];
                            maxArray[j] = maxArray[j + 1];
                            maxArray[j + 1] = temp;
                        }
                    }
                }
                
                foreach (var item in maxArray)
                {
                    Console.Write(item + " ");
                }
            }
            catch
            {
                Console.WriteLine("crazy input");
            }



        }
    }
}
