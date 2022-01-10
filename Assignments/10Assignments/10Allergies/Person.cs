using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Allergies
{
    class Person
    {
        private string _Name { get; set; }
        public int _Allergyscore { get; set; }


        public Person(string name)
        {
            _Name = name;
            _Allergyscore = 0;
        }
        public Person(string name, int allergyscore)
        {
            _Name = name;
            _Allergyscore = allergyscore;
        }
        public Person(string name, string allergies)
        {
            _Name = name;

            string[] allergyArray = allergies.Split(' ');
            foreach (var item in allergyArray)
            {
                switch (item)
                {
                    case "Eggs":
                        _Allergyscore += 1;
                        break;
                    case "Peanuts":
                        _Allergyscore += 2;
                        break;
                    case "Shellfish":
                        _Allergyscore += 4;
                        break;
                    case "Strawberries":
                        _Allergyscore += 8;
                        break;
                    case "Tomatoes":
                        _Allergyscore += 16;
                        break;
                    case "Chocolate":
                        _Allergyscore += 32;
                        break;
                    case "Pollen":
                        _Allergyscore += 64;
                        break;
                    case "Cats":
                        _Allergyscore += 128;
                        break;
                }   
            }
        }

        public void AddAllergy(int value)
        {
            _Allergyscore += value;
        }

        public void AddAllergy(string allergy)
        {
            switch (allergy)
            {
                case "Eggs":
                    _Allergyscore += 1;
                    break;
                case "Peanuts":
                    _Allergyscore += 2;
                    break;
                case "Shellfish":
                    _Allergyscore += 4;
                    break;
                case "Strawberries":
                    _Allergyscore += 8;
                    break;
                case "Tomatoes":
                    _Allergyscore += 16;
                    break;
                case "Chocolate":
                    _Allergyscore += 32;
                    break;
                case "Pollen":
                    _Allergyscore += 64;
                    break;
                case "Cats":
                    _Allergyscore += 128;
                    break;
            }
        }

        public void DeleteAllergy(int value)
        {
            _Allergyscore -= value;
        }

        public void DeleteAllergy(string allergy)
        {
            switch (allergy)
            {
                case "Eggs":
                    _Allergyscore -= 1;
                    break;
                case "Peanuts":
                    _Allergyscore -= 2;
                    break;
                case "Shellfish":
                    _Allergyscore -= 4;
                    break;
                case "Strawberries":
                    _Allergyscore -= 8;
                    break;
                case "Tomatoes":
                    _Allergyscore -= 16;
                    break;
                case "Chocolate":
                    _Allergyscore -= 32;
                    break;
                case "Pollen":
                    _Allergyscore -= 64;
                    break;
                case "Cats":
                    _Allergyscore -= 128;
                    break;
            }
        }

        public bool IsAllergic(string allergie)
        {
            List<string> Allergies = new List<string>();
            int Allergyscore = _Allergyscore;

            if (Allergyscore >= 128)
            {
                Allergies.Add("Cats");
                Allergyscore -= 128;
            }
            if (Allergyscore >= 64)
            {
                Allergies.Add("Pollen");
                Allergyscore -= 64;
            }
            if (Allergyscore >= 32)
            {
                Allergies.Add("Chocolate");
                Allergyscore -= 32;
            }
            if (Allergyscore >= 16)
            {
                Allergies.Add("Tomatoes");
                Allergyscore -= 16;
            }
            if (Allergyscore >= 8)
            {
                Allergies.Add("Strawberries");
                Allergyscore -= 8;
            }
            if (Allergyscore >= 4)
            {
                Allergies.Add("Shellfish");
                Allergyscore -= 4;
            }
            if (Allergyscore >= 2)
            {
                Allergies.Add("Peanuts");
                Allergyscore -= 2;
            }
            if (Allergyscore >= 1)
            {
                Allergies.Add("Eggs");
                Allergyscore -= 1;
            }

            if (Allergies.Contains(allergie))
            {
                return true;
            }
            return false;
        }

        public bool IsAllergic(int value)
        {
            string allergy = "";
            if (value == 1)
            {
                allergy = "Eggs";
            }
            else if (value == 2)
            {
                allergy = "Peanuts";
            }
            else if (value == 4)
            {
                allergy = "Shellfish";
            }
            else if (value == 8)
            {
                allergy = "Strawberries";
            }
            else if (value == 16)
            {
                allergy = "Tomatoes";
            }
            else if (value == 32)
            {
                allergy = "Chocolate";
            }
            else if (value == 64)
            {
                allergy = "Pollen";
            }
            else if (value == 128)
            {
                allergy = "Cats";
            }

            int Allergyscore = _Allergyscore;
            List<string> Allergies = new List<string>();

            if (Allergyscore >= 128)
            {
                Allergies.Add("Cats");
                Allergyscore -= 128;
            }
            if (Allergyscore >= 64)
            {
                Allergies.Add("Pollen");
                Allergyscore -= 64;
            }
            if (Allergyscore >= 32)
            {
                Allergies.Add("Chocolate");
                Allergyscore -= 32;
            }
            if (Allergyscore >= 16)
            {
                Allergies.Add("Tomatoes");
                Allergyscore -= 16;
            }
            if (Allergyscore >= 8)
            {
                Allergies.Add("Strawberries");
                Allergyscore -= 8;
            }
            if (Allergyscore >= 4)
            {
                Allergies.Add("Shellfish");
                Allergyscore -= 4;
            }
            if (Allergyscore >= 2)
            {
                Allergies.Add("Peanuts");
                Allergyscore -= 2;
            }
            if (Allergyscore >= 1)
            {
                Allergies.Add("Eggs");
                Allergyscore -= 1;
            }

            if (Allergies.Contains(allergy))
            {
                return true;
            }
            return false;

        }

        public override string ToString()
        {
            string s = _Name;
            if (_Allergyscore == 0)
            {
                s += " has no allergies!";
                return s;
            }
            else
            {
                List<string> Allergies = new List<string>();
                int Allergyscore = _Allergyscore;
                
                if (Allergyscore >= 128)
                {
                    Allergies.Add("Cats");
                    Allergyscore -= 128;
                }
                if (Allergyscore >= 64)
                {
                    Allergies.Add("Pollen");
                    Allergyscore -= 64;
                }
                if (Allergyscore >= 32)
                {
                    Allergies.Add("Chocolate");
                    Allergyscore -= 32;
                }
                if (Allergyscore >= 16)
                {
                    Allergies.Add("Tomatoes");
                    Allergyscore -= 16;
                }
                if (Allergyscore >= 8)
                {
                    Allergies.Add("Strawberries");
                    Allergyscore -= 8;
                }
                if (Allergyscore >= 4)
                {
                    Allergies.Add("Shellfish");
                    Allergyscore -= 4;
                }
                if (Allergyscore >= 2)
                {
                    Allergies.Add("Peanuts");
                    Allergyscore -= 2;
                }
                if (Allergyscore >= 1)
                {
                    Allergies.Add("Eggs");
                    Allergyscore -= 1;
                }

                s += " is allergic to " + Allergies[Allergies.Count - 1];

                for (int i = 1; i < Allergies.Count - 1; i++)
                {                                       
                    s += ", " + Allergies[Allergies.Count - 1 - i];
                }

                if (Allergies.Count > 1)
                {
                    s += " and " + Allergies[0];
                }
                s += ".";
                
            }
            return s;
        }
    }
}
