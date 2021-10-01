using System;

namespace Les_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VIARIABELEN DECLAREREN */
            int getal;
            byte eenByte;
            double decimaal;
            char c;

            /* VARIABELEN INITIALISEREN */
            getal = 69420;
            //eenByte = getal; gaat nooit lukken
            eenByte = 10;
            getal = eenByte; //iets klein in iets groter steken lukt wel!

            decimaal = 89.67;
            //getal = decimaal; gaat nooit lukken, want integer is geen decimaal getal!

            decimaal = getal; //iets zonder komma in iets met komma steken lukt wel!

            c = 'c';
            c = '6';
            c = '^';


            /* VARIABELE DECLAREREN & INITIALISEREN */
            string text = "a"; //van zodra we dubbele quotes gebruiken, ook al is het maar één karakter, het is en blijft een string!

            text = "Dit is tekst";

            /* REKENKUNDIGE OPERATOREN */
            Console.WriteLine("REKENKUNDIGE OPERATOREN");
            Console.WriteLine(getal);
            getal++;
            Console.WriteLine(getal);
            --getal;
            Console.WriteLine(getal);

            /* VERSCHIL TUSSEN PRE- & POSTFIX */
            Console.WriteLine(getal++);
            Console.WriteLine(++getal);
            Console.WriteLine(getal--);
            Console.WriteLine(--getal);

            /* BINARY OPERATORS */
            Console.WriteLine(10 + 3);
            Console.WriteLine(10 - 3);
            Console.WriteLine(10 * 3);
            Console.WriteLine(10 / 3);
            Console.WriteLine(10.0 / 3);
            Console.WriteLine(10 % 3);

            Console.WriteLine(10 - (10 / 3) * 3); // == modulo operator
        }
    }
}
