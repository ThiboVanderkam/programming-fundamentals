using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace _07RLE
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();
            if (!File.Exists(filename))
            {
                Console.WriteLine("crazy input");
                return;
            }
            StreamReader file = File.OpenText(filename);
            string[] text = file.ReadToEnd().Split("\n");
            foreach (string item in text)
            {
                string itemre = item.Replace("\r", "");

                int[] nrs = Array.ConvertAll(item.Split(','), Convert.ToInt32);

                for (int i = 0; i < nrs.Length; i++)
                {
                    int nr = nrs[i];
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < nr; j++)
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        for (int j = 0; j < nr; j++)
                        {
                            Console.Write("*");
                        }

                    }

                }
                Console.WriteLine();
            }
        }
    }
}
