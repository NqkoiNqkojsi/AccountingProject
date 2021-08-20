using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProject.Models
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string wholeName { get; set; }
        //public int id;

        public static List<Person> allPeople = new List<Person>();

        public static int counter=0;

        public void ChangeName(bool f, string name)
        {
            if (f)
            {
                firstName = name;
                wholeName = firstName + lastName;
            }
            else
            {
                lastName = name;
                wholeName = firstName + lastName;
            }
        }

        public static List<string> GetAllNames()
        {
            List<string> names = new List<string>();
            foreach(Person a in allPeople)
            {
                names.Add(a.wholeName);
            }
            return names;
        }
        public string GetWholeName()
        {
            return wholeName;
        }

        public static Person FindByName(string name)
        {
            return allPeople.Find(x => x.wholeName == name);
        }
    }
}
