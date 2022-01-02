using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial1
{
    class Trial1
    {
        private string _InputName{ get; set; }

        private string _Names { get; set; } //Stores the names that need to be outputted

        public Trial1(string name)
        {
            _InputName = name;
            _Names = "";
        }

        //Removes the " from the given string
        private string cleanText(string text)
        {
            string cleantext = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '"')
                {
                    cleantext += text[i];
                }
            }
            return cleantext;
        }

        //Checks if a name contains the letters of the input word
        private bool checkName(string name, List<char> letters)
        {
            foreach (var item in letters)
            {
                if (!name.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }


        //Finds all the names that meet the criteria
        public void FindNames()
        {
            StreamReader stream = File.OpenText("names.txt");
            string text = stream.ReadToEnd();
            string cleantext = cleanText(text);
            string[] names = cleantext.Split(',');
            List<char> letters = new List<char>();

            
            
            for (int i = 0; i < _InputName.Length; i++)
            {
                if (!letters.Contains(_InputName[i]))
                {
                    letters.Add(_InputName[i]);
                }
            }

            foreach (var item in names)
            {
                bool correct = checkName(item, letters);
                if (correct)
                {
                    _Names += item + " ";
                }
            }

        }

        public override string ToString()
        {
            if (_Names.Length == 0)
            {
                return "not found";
            }
            else
            {
                
                string cleanNames = "";
                //Remove last space character
                for (int i = 0; i < _Names.Length - 1; i++)
                {
                    cleanNames += _Names[i];
                }

                string[] nameArray = cleanNames.Split(' ');
                for (int i = 0; i < nameArray.Length - 1; i++)
                {
                    for (int j = i + 1; j < nameArray.Length; j++)
                    {
                        if (String.Compare(nameArray[i], nameArray[j]) > 0)
                        {
                            string temp = nameArray[i];
                            nameArray[i] = nameArray[j];
                            nameArray[j] = temp;
                        }
                    }
                }

                string s = "";
                foreach (var item in nameArray)
                {
                    s += item + " ";
                }

                return s;
            }
            
        }

    }
}
