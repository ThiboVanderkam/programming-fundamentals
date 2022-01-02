using System;

namespace _08SortLastNames
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(", ");
                string[][] nameSplit = new string[inputArray.Length][];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    string firstName = "";
                    string lastName = "";
                    bool spaceFound = false;
                    for (int j = 0; j < inputArray[i].Length; j++)
                    {
                        if (spaceFound)
                        {
                            lastName += inputArray[i][j];
                        }
                        else
                        {
                            if (inputArray[i][j] != ' ')
                            {
                                firstName += inputArray[i][j];
                            }
                            else if (inputArray[i][j] == ' ')
                            {
                                spaceFound = true;
                            }
                        }
                    }
                    string[] temp = { firstName, lastName };
                    nameSplit[i] = temp;
                }

                for (int i = 0; i < nameSplit.Length; i++)
                {
                    for (int j = 0; j < nameSplit.Length - 1; j++)
                    {
                        if (String.Compare(nameSplit[j][1], nameSplit[j + 1][1]) == 1)
                        {
                            string[] temp = nameSplit[j];
                            nameSplit[j] = nameSplit[j + 1];
                            nameSplit[j + 1] = temp;
                        }
                    }
                }


                foreach (var item in nameSplit)
                {
                    foreach (var subitem in item)
                    {
                        Console.Write(subitem + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
            
        }
    }
}
