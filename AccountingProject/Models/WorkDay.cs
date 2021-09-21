using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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

        public string[] Summary = new string[5];

        public static List<WorkDay> allDays = new List<WorkDay>();

        public static int Year;

        public WorkDay(string type, string start, string end, string note="", string vacationType="")
        {
            this.type = type;
            this.start = start;
            this.end = end;
            this.note = note;
            this.vacationType = vacationType;
            this.id = Counter.counterWorkDays.ToString();
            Counter.Increase(2);
            period=GetPeriod();
            MakeSummary();
        }
        int GetPeriod()
        {
            TimeSpan days=ReturnDate(end).AddDays(1) - ReturnDate(start);
            int period1 = (int)days.TotalDays;
            DateTime checkDate = ReturnDate(start);
            int endDate = ReturnDate(end).DayOfYear;
            while (checkDate.DayOfYear <= endDate)
            {
                if ((int)checkDate.DayOfWeek == 6 || (int)checkDate.DayOfWeek == 0)
                {
                    period1--;
                }
                checkDate= checkDate.AddDays(1);
            }
            return period1;
        }

        public void Period()
        {
            TimeSpan days = ReturnDate(end).AddDays(1) - ReturnDate(start);
            int period1 = (int)days.TotalDays;
            DateTime checkDate = ReturnDate(start);
            int endDate = ReturnDate(end).DayOfYear;
            while (checkDate.DayOfYear <= endDate)
            {
                if ((int)checkDate.DayOfWeek == 6 || (int)checkDate.DayOfWeek == 0)
                {
                    period1--;
                }
                checkDate = checkDate.AddDays(1);
            }
            period = period1;
        }

        public string TranslateType()
        {
            switch (type)
            {
                case "vacation": return "отпуска";
                case "ill": return "болничен";
                case "seminar": return "Семинар";
                default: return "Error";
            }
        }

        public int IndexType()
        {
            switch (type)
            {
                case "vacation": return 0;
                case "ill": return 1;
                case "seminar": return 2;
                default: return 0;
            }
        }

        public void MakeSummary()
        {
            Summary[0] = id;
            Summary[1] = TranslateType();
            Summary[2] = start;
            Summary[3] = end;
            Summary[4] = period.ToString();
        }

        static public DateTime ReturnDate(string date)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("de-DE");
            try
            {
                return DateTime.ParseExact(date, "d.M.yyyy", culture);
            }catch(Exception ex)
            {
                Console.WriteLine("Date Exception="+ ex+"\n");
            }
            return DateTime.MinValue;
        }

    }
}
