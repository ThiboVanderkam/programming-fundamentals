using System;

namespace Trial1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ask for question
                string question = Console.ReadLine();
                if (question == "trial1")
                {
                    string name = Console.ReadLine();
                    Trial1 t1 = new Trial1(name.ToUpper());
                    t1.FindNames();
                    Console.WriteLine(t1);
                }
                else if (question == "trial2")
                {
                    string number = Console.ReadLine();
                    if (Convert.ToInt32(number) < 0)
                    {
                        Console.WriteLine("crazy input");
                        return;
                    }
                    Palindrome pal = new Palindrome(number);
                    Console.WriteLine(pal.FindNext());

                }
                else
                {
                    Console.WriteLine("crazy input");
                }
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
