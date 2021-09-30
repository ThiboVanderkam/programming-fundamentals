using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.Write("Hallo");
            //Console.WriteLine("Nog eens Hello");

            string name = "Thibo";
            name = "Jan";

            string stad = "Mechelen";
            
            Console.WriteLine(name);

            Console.WriteLine("Ik ben " + name + ", ik woon in " + stad);


            string color;
            Console.Write("Geef je lievelingskleur in: ");
            color = Console.ReadLine();
            Console.WriteLine("Jij koos voor " + color);
            string dier;
            Console.WriteLine("Geef je lievelingsdier in: ");
            dier = Console.ReadLine();
            Console.WriteLine("Jij koos voor ", dier);
        }
    }
}
