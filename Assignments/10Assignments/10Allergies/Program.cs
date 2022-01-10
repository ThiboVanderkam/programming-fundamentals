using System;

namespace _10Allergies
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person("empty");
                string input = Console.ReadLine();
                string[] splitInput = input.Split(' ');
                if (splitInput.Length > 3)
                {
                    string allergies = "";
                    for (int i = 2; i < splitInput.Length; i++)
                    {
                        allergies += splitInput[i] + " ";
                    }
                    allergies.Trim();
                    person = new Person(splitInput[1], allergies);
                }
                else if (splitInput.Length == 3)
                {
                    if (Char.IsDigit(splitInput[2][0]))
                    {
                        person = new Person(splitInput[1], Convert.ToInt32(splitInput[2]));
                    }
                    else
                    {
                        person = new Person(splitInput[1], splitInput[2]);
                    }
                    
                }
                else
                {
                    person = new Person(splitInput[1]);
                }

                bool stop = false;
                while (!stop)
                {
                    input = Console.ReadLine();
                    if (input == "print")
                    {
                        Console.WriteLine(person);
                    }
                    else if (input == "stop")
                    {
                        stop = true;
                    }
                    else if (input.Contains("add"))
                    {
                        splitInput = input.Split(' ');
                        if (Char.IsDigit(splitInput[1][0]))
                        {
                            person.AddAllergy(Convert.ToInt32(splitInput[1]));
                        }
                        else
                        {
                            person.AddAllergy(splitInput[1]);
                        }
                    }
                    else if (input.Contains("delete"))
                    {
                        splitInput = input.Split(' ');
                        if (Char.IsDigit(splitInput[1][0]))
                        {
                            person.DeleteAllergy(Convert.ToInt32(splitInput[1]));
                        }
                        else
                        {
                            person.DeleteAllergy(splitInput[1]);
                        }
                    }
                    else if (input == "score")
                    {
                        Console.WriteLine(person._Allergyscore);
                    }
                    else if (input.Contains("allergic"))
                    {
                        splitInput = input.Split(' ');
                        if (Char.IsDigit(splitInput[1][0]))
                        {
                            Console.WriteLine(person.IsAllergic(Convert.ToInt32(splitInput[1]))); 
                        }
                        else
                        {
                            Console.WriteLine(person.IsAllergic(splitInput[1]));
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
