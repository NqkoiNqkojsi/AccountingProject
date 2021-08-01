using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProject.Models
{
    class ShiftDay
    {
        public string type; //1-work; 2-weekend; 3-holliday
        public string date { get; set; }
        public int weekDay { get; set; }//0-Monday, 1-Tuesday ... 6-Sunday
        public string id { get; set; }
        public static int counter=0;
        public static List<ShiftDay> allDays = new List<ShiftDay>();

        public ShiftDay(string type, string date, int weekDay)
        {
            this.type = type;
            this.date = date;
            this.weekDay = weekDay;
            id = counter.ToString();
            counter++;
        }

        public static string GetWeekDay(int index)
        {
            switch (index)
            {
                case 0: return "Monday";
                case 1: return "Tuesday"; 
                case 2: return "Wensday";
                case 3: return "Thursday";
                case 4: return "Friday";
                case 5: return "Saturday";
                case 6: return "Sunday";
                default: return "";
            }
        }
        /*void GetPeriod()
        {
            TimeSpan days = DateTime.Parse(end) - DateTime.Parse(start);
            period = (int)days.TotalDays;
        }*/
    }
}
