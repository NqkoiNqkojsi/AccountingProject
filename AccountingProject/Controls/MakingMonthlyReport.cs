using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingProject.Models;

namespace AccountingProject.Controls
{
    class MakingMonthlyReport
    {
        public string name;
        public string id;
        public char[,] dayly = new char[13, 32];
        public int[,] sum = new int[13, 10];//indexes are shown in GetIndex(); 3-WorkDay; 7-ShiftDay
        public static List<MakingMonthlyReport> Report = new List<MakingMonthlyReport>();


        private static char GetSymbol(string type)
        {
            switch (type)
            {
                case "vacation":return 'O';
                case "ill": return 'Б';
                case "seminar": return 'С';
                case "work": return 'Д';
                case "weekend": return 'Д';
                case "holliday": return 'Д';
                default: return 'E';
            }
        }
        private static int GetIndex(string type)
        {
            switch (type)
            {
                case "vacation": return 0;
                case "ill": return 1;
                case "seminar": return 2;
                case "work": return 4;
                case "weekend": return 5;
                case "holliday": return 6;
                default: return 8;
            }
        }

        public MakingMonthlyReport(Worker person)
        {
            for(int i = 0; i < 13; i++)
            {
                for(int j = 0; j < 32; j++)
                {
                    dayly[i, j] = ' ';
                }
                for(int j = 0; j < 10; j++)
                {
                    sum[i, j] = 0;
                }
            }
            id = person.id;
            name = person.wholeName;
            foreach (WorkDay day in person.daysLeaves)
            {
                DateTime startTime = WorkDay.ReturnDate(day.start);
                int addWeekends = 0;
                for(int i = 0; i < day.period+addWeekends; i++)
                {
                    if ((int)startTime.DayOfWeek == 6 || (int)startTime.DayOfWeek == 0)
                    {
                        addWeekends++;
                        Console.WriteLine("index= " + (int)startTime.DayOfWeek + " day=" + startTime.DayOfWeek + "\n");
                    }
                    
                    dayly[startTime.Month, startTime.Day] = GetSymbol(day.type);
                    startTime = startTime.AddDays(1);
                }
                sum[startTime.Month, GetIndex(day.type)]+=day.period;
                sum[startTime.Month, 3]+=day.period;
            }
            foreach (ShiftDay day in person.daysShift)
            {
                DateTime startTime = day.ReturnDate();
                dayly[startTime.Month, startTime.Day] = GetSymbol(day.type);
                sum[startTime.Month, GetIndex(day.type)]++;
                sum[startTime.Month, 7]++;
            }
            Report.Add(this);
        }
        public static void GenerateReport()
        {
            Report.Clear();
            foreach(Worker person in Worker.allWorkers)
            {
                MakingMonthlyReport a = new MakingMonthlyReport(person);
            }
        }
    }
}
