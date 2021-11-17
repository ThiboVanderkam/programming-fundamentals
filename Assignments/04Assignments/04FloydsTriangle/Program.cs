using System;

namespace _04FloydsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int lastnum = 1;
            
            for (int i = 1; i <= number; i++)
            {
                bool space = false;
                for (int j = 0; j < i; j++)
                {
                    string lastnumstr = Convert.ToString(lastnum);
                    if (lastnumstr.Length == 1 && space)
                    {
                        Console.Write(" " + lastnum);
                    }
                    else if (lastnumstr.Length == 1)
                    {
                        Console.Write(lastnum);
                    }
                    else
                    {
                        Console.Write(lastnum);
                    }
                    lastnum++;

                    space = true;
                }
                Console.WriteLine();
            }
        }
    }
}
