using System;
using System.Linq;
using System.IO;

namespace inlezen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\\n\n\nINPUT - READ TO END\n\n\n");
            StreamReader stream = File.OpenText("Rapunzel.txt");
            string tekst = stream.ReadToEnd();
            //Console.WriteLine(tekst);
            //stream.Close();



            /*
            Console.WriteLine("\\n\n\nINPUT - READ LINE BY LINE\n\n\n");
            StreamReader stream = File.OpenText("Rapunzel.txt");
            while (!stream.EndOfStream)
            {
                string line = stream.ReadLine();
                Console.WriteLine(line);
            }
            stream.Close();
            */


            /*
            Console.WriteLine("\\n\n\nINPUT - READ LINE BY LINE\n\n\n");
            StreamReader stream = File.OpenText("Rapunzel.txt");
            string line;
            do
            {
                line = stream.ReadLine();
                Console.WriteLine(line);
            } while (line != null);
            stream.Close();
            */


            /*
            Console.WriteLine("\\n\n\nINPUT - READ CHAR BY CHAR\n\n\n");
            StreamReader stream = File.OpenText("Rapunzel.txt");
            while (!stream.EndOfStream)
            {
                Console.WriteLine((char)stream.Read());
            }
            stream.Close();
            */

            /*
            Console.WriteLine("\\n\n\nINPUT - READ USING FOREACH\n\n\n");
            foreach (char item in tekst)
            {
                Console.WriteLine(item);
            }
            */


            /*
            for (int i = 0; i < tekst.Length; i++)
            {
                Console.WriteLine(tekst.ElementAt(i));
            }
            */

            
            stream.Close();
        }
    }
}
    