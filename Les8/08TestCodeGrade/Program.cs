using System;
using System.Collections.Generic;

namespace _08TestCodeGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> alphanumerical = new Dictionary<char, int>(); //<letter, aantal keer dat de letter voorkomt>
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if ("azertyuiopqsdfghjklmwwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN1234567890".Contains(input[i]))
                {
                    if (alphanumerical.ContainsKey(input[i])) //Als de letter al in de dictionary staat, zet he aantal keer dat de letter voorkomt +1
                    {
                        alphanumerical[input[i]]++;
                    }
                    else //Als de letter nog niet voorkwam, zet dan een nieuwe value in de array met aantal 1
                    {
                        alphanumerical.Add(input[i], 1);
                    }
                }
                
            }

            int counter = 0;
            foreach (var item in alphanumerical) //Tel hoeveel letters meer dan 1 keer voorkwamen
            {
                if(item.Value > 1)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
