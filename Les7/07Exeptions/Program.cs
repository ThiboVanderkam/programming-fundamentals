using System;
using System.IO;

namespace _07Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXEPTION HANDLING MET IF-STRUCTUREN!!!
            /*
            Console.WriteLine("Geef aantal lijnen in: ");
            string antwoord = Console.ReadLine();
            int aantal;
            if (!Int32.TryParse(antwoord, out aantal))
            {
                Console.WriteLine("Verkeerd getal ingegeven!");
                return;
            }

            Console.Write("Geef een filenaam in: ");
            string filenaam = Console.ReadLine();
            if (!File.Exists(filenaam))
            {
                Console.WriteLine("File bestaat niet!");
                return;
            }

            StreamReader stream = File.OpenText(filenaam);

            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine(stream.ReadLine());
            }
            stream.Close();
            */

            try
            {
                Console.WriteLine("Geef aantal lijnen in: ");
                int aantal = Convert.ToInt32(Console.ReadLine());

                Console.Write("Geef een filenaam in: ");
                string filenaam = Console.ReadLine();

                StreamReader stream = File.OpenText(filenaam);

                for (int i = 0; i < aantal; i++)
                {
                    Console.WriteLine(stream.ReadLine());
                }
                stream.Close();
            }
            catch (FormatException)
            {
                Console.WriteLine("U gaf een verkeerd getal in!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Deze file bestaat niet!");
            }
            catch (Exception e)
            {
                Console.WriteLine("WHOOPIE!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("+-----------+");
                Console.WriteLine("|  THE END  |");
                Console.WriteLine("+-----------+");
            }






            /*Console.WriteLine("Geef aantal lijnen in: ");
            int aantal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef een filenaam in: ");
            string filenaam = Console.ReadLine();

            StreamReader stream = File.OpenText(filenaam);

            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine(stream.ReadLine());
            }
            stream.Close();*/
        }
    }
}
