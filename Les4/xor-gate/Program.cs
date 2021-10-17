using System;

namespace xor_gate
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = Convert.ToBoolean(Console.ReadLine());
            bool b = Convert.ToBoolean(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine('0');            }
            else
            {
                Console.WriteLine('1');
            }
        }
    }
}
