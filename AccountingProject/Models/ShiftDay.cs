using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AccountingProject.Models
{
    class ShiftDay
    {
        public string type { get; set; } //1-work; 2-weekend; 3-holliday
        public string date { get; set; }
        public int weekDay { get; set; }//0-Monday, 1-Tuesday ... 6-Sunday
        public string id { get; set; }

        public string[] Summary = new string[4];

        public static List<ShiftDay> allDays = new List<ShiftDay>();
        

        public ShiftDay(string type, string date, int weekDay)
        {
            this.type = type;
            this.date = date;
            this.weekDay = weekDay;
            id = Counter.counterShiftDays.ToString();
            Counter.Increase(3);
            MakeSummary();
        }

        public static string GetWeekDay(int index)
        {
            switch (index)
            {
                case 0: return "Понеделник";
                case 1: return "Вторник"; 
                case 2: return "Сряда";
                case 3: return "Четвъртък";
                case 4: return "Петък";
                case 5: return "Събота";
                case 6: return "Неделя";
                default: return "Грешка";
            }
        }

        public string TranslateType()
        {
            switch (type)
            {
                case "work":return "Работен";
                case "weekend": return "Почивен";
                case "holliday": return "Празничен";
                default:return "Error";
            }
        }

        public int IndexType()
        {
            switch (type)
            {
                case "work": return 0;
                case "weekend": return 1;
                case "holliday": return 2;
                default: return 0;
            }
        }

        public void MakeSummary()
        {
            Summary[0] = id;
            Summary[1] = TranslateType();
            Summary[2] = date;
            Summary[3] = GetWeekDay(weekDay);
        }

        public DateTime ReturnDate() 
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("de-DE");
            try
            {
                return DateTime.ParseExact(date, "d.M.yyyy", culture);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Date Exception=" + ex + "\n id= "+id+"\n");
            }
            return DateTime.MinValue;
        }



        /*void GetPeriod()
        {
            TimeSpan days = DateTime.Parse(end) - DateTime.Parse(start);
            period = (int)days.TotalDays;
        }*/
    }
}
