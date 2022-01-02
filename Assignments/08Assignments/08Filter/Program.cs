using System;
using System.Collections.Generic;

namespace _08Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(',');
                List<string> filteredList = new List<string>();
                for (int i = 0; i < inputArray.Length; i++)
                {
                    bool correct = true;
                    string temp = "";
                    for (int j = 0; j < inputArray[i].Length; j++)
                    {
                        if ("0123456798.".Contains(inputArray[i][j]))
                        {
                            temp += inputArray[i][j];
                        }
                        else
                        {
                            correct = false;
                        }
                    }
                    if (correct)
                    {
                        filteredList.Add(temp);
                    }
                }

                foreach (var item in filteredList)
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
