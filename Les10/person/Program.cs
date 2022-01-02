using System;
using System.Collections.Generic;

namespace person
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person thibo = new Person("Thibo Vanderkam", new DateTime(2001, 11, 29));
            Person alex = new Person();

            Console.WriteLine("Geef naam in: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Geef geboortedatum in: ");
            DateTime datum = Convert.ToDateTime(Console.ReadLine());

            Person persoon = new Person(naam, datum);

            List<Person> personen = new List<Person>();
            personen.Add(thibo);
            personen.Add(alex);
            personen.Add(persoon);

            Student jarne = new Student("Jarne Schoolmeesters", new DateTime(1999, 5, 17), "Thomas More");
            personen.Add(jarne);

            alex.Name = "Alexia Van Mechelen";

            Console.WriteLine("\n--PERSONEN IN LIJST--");
            foreach (var item in personen)
            {
                Console.WriteLine(item.Name + " is " + item.Age() + " jaar oud!");
            }
            */

            Teacher collin = new Teacher("Collin", new DateTime(1991, 5, 1));
            Teacher elke = new Teacher("Collin", new DateTime(1980, 5, 1));
            Course programming = new Course("Programming", elke, 4, new Time(8, 30), Weekday.Friday);
            Course web = new Course("Web", collin, 3, new Time(13, 45), Weekday.Wednesday);
            List<Course> courses = new List<Course>();
            courses.Add(programming);
            courses.Add(web);


        }
    }
}
