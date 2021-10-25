using System;
using System.IO;

namespace _05TestCodeGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = File.OpenText(@"Harry Potter and the Sorcerer.txt");
            int count = Convert.ToInt32(Console.ReadLine());
            StreamWriter writer = File.CreateText("harry-" + count + ".txt");

            for (int i = 0; i < count; i++)
            {
                string line = reader.ReadLine();
                writer.WriteLine(i + ": " + line);
            }
            reader.Close();
            writer.Close();

            
        }
    }
}
