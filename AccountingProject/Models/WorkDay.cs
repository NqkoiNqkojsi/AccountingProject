using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProject.Models
{
    class WorkDay 
    {
        public string type;//1-vacation; 2-ill; 3-seminar
        public string note { get; set; }
        public string vacationType { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public int period;
        public string id;
        public static int counter = 0;

        public static List<WorkDay> allDays = new List<WorkDay>();

        public WorkDay(string type, string start, string end, string note="", string vacationType="")
        {
            this.type = type;
            this.start = start;
            this.end = end;
            this.note = note;
            this.vacationType = vacationType;
            this.id = counter.ToString();
            counter++;
            GetPeriod();
        }
        void GetPeriod()
        {
            TimeSpan days=DateTime.Parse(end) - DateTime.Parse(start);
            period = (int)days.TotalDays;
        }

        
    }
}
