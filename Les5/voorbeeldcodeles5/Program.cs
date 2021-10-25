using System;
using System.IO;

namespace voorbeeldcodeles5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*StreamWriter stream = File.CreateText("file.txt");
            stream.WriteLine("Wajow tekst!!");
            stream.WriteLine("Wajow tekst!!");
            stream.WriteLine("Wajow tekst!!");

            stream.Close();
            */

            /*
            StreamWriter stream = File.CreateText(@"C:\Users\Thibo\Documents\IMS\Fase 1\Semester 1\programming-fundamentals\Les5\voorbeeldcodeles5\file1.txt");
            stream.WriteLine("wooooow");
            stream.Close();
            */


            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(folder, "file.txt");
            StreamWriter stream = File.CreateText(path);
            stream.WriteLine("gelukt");
            stream.Close();

            if (File.Exists(path))
            {
                stream = File.AppendText(path);
                stream.WriteLine("meer text!!!");
                stream.Close();
            }
            if (File.Exists(path))
            {
                Console.WriteLine("Wil je deze file verwijderen?");
                if (Console.ReadLine() == "ja")
                {
                    File.Delete(path);
                }
            }
        }
    }
}
