using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingProject.Models;


namespace AccountingProject.Controls
{
    class Searching
    {
        public static List<string> MakeRecommendation(string input)
        {
            List<string> searchedPeople = new List<string>();
            input = input.ToLower();
            foreach(Worker worker in Worker.allWorkers.FindAll(person => person.wholeName.ToLower().StartsWith(input)))
            {
                searchedPeople.Add(worker.wholeName);
            }
            return searchedPeople;
        }
    }
}
