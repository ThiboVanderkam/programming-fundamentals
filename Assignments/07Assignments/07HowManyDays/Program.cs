using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace _07HowManyDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("nl-BE");
            
            try
            {
                string startInput = Console.ReadLine();
                DateTime startDate;
                string month = "";
                if (startInput.Contains('a') || startInput.Contains('e') || startInput.Contains('e') || startInput.Contains('o') || startInput.Contains('A') || startInput.Contains('u'))
                {

                    for (int i = 0; i < startInput.Length; i++)
                    {
                        if ("azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN".Contains(startInput[i]))
                        {
                            month += startInput[i];
                        }
                    }
                    month = month.ToLower();
                    int monthNumber = 0;
                    switch (month)
                    {
                        case "january":
                            monthNumber = 1;
                            break;
                        case "februari":
                            monthNumber = 2;
                            break;
                        case "march":
                            monthNumber = 3;
                            break;
                        case "april":
                            monthNumber = 4;
                            break;
                        case "may":
                            monthNumber = 5;
                            break;
                        case "june":
                            monthNumber = 6;
                            break;
                        case "july":
                            monthNumber = 7;
                            break;
                        case "august":
                            monthNumber = 8;
                            break;
                        case "september":
                            monthNumber = 9;
                            break;
                        case "october":
                            monthNumber = 10;
                            break;
                        case "november":
                            monthNumber = 11;
                            break;
                        case "december":
                            monthNumber = 12;
                            break;
                    }
                    bool monthAdded = false;
                    string startInput2 = "";
                    for (int i = 0; i < startInput.Length; i++)
                    {
                        if ("0123456789".Contains(startInput[i]))
                        {
                            startInput2 += startInput[i];
                        }
                        else if (startInput[i] == ' ')
                        {
                            startInput2 += "/";
                        }
                        else if (!monthAdded && "azertyuiopqsdfghjklmwxcvbnAERTYUIOPQSDFGHJKLMWXCVBN".Contains(startInput[i]))
                        {
                            startInput2 += monthNumber;
                            monthAdded = !monthAdded;
                        }
                    }
                    startDate = Convert.ToDateTime(startInput2);
                }
                else
                {
                    startDate = Convert.ToDateTime(startInput);
                }



                string endInput = Console.ReadLine();
                DateTime endDate;
                month = "";
                if (endInput.Contains('a') || endInput.Contains('e') || endInput.Contains('e') || endInput.Contains('o') || endInput.Contains('A') || endInput.Contains('u'))
                {

                    for (int i = 0; i < endInput.Length; i++)
                    {
                        if ("azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN".Contains(endInput[i]))
                        {
                            month += endInput[i];
                        }
                    }
                    month = month.ToLower();
                    int monthNumber = 0;
                    switch (month)
                    {
                        case "january":
                            monthNumber = 1;
                            break;
                        case "februari":
                            monthNumber = 2;
                            break;
                        case "march":
                            monthNumber = 3;
                            break;
                        case "april":
                            monthNumber = 4;
                            break;
                        case "may":
                            monthNumber = 5;
                            break;
                        case "june":
                            monthNumber = 6;
                            break;
                        case "july":
                            monthNumber = 7;
                            break;
                        case "august":
                            monthNumber = 8;
                            break;
                        case "september":
                            monthNumber = 9;
                            break;
                        case "october":
                            monthNumber = 10;
                            break;
                        case "november":
                            monthNumber = 11;
                            break;
                        case "december":
                            monthNumber = 12;
                            break;
                    }
                    bool monthAdded = false;
                    string endInput2 = "";
                    for (int i = 0; i < endInput.Length; i++)
                    {
                        if ("0123456789".Contains(endInput[i]))
                        {
                            endInput2 += endInput[i];
                        }
                        else if (endInput[i] == ' ')
                        {
                            endInput2 += "/";
                        }
                        else if (!monthAdded && "azertyuiopqsdfghjklmwxcvbnAERTYUIOPQSDFGHJKLMWXCVBN".Contains(endInput[i]))
                        {
                            endInput2 += monthNumber;
                            monthAdded = !monthAdded;
                        }
                    }
                    endDate = Convert.ToDateTime(endInput2);
                }
                else
                {
                    endDate = Convert.ToDateTime(endInput);
                }
                int days = (endDate - startDate).Days;
                Console.WriteLine(days + " days");
            }
            catch(Exception e)
            {
                Console.WriteLine("crazy input");
                Console.WriteLine(e);
            }

            

           
            


            






        }
    }
}
