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
        static char[,] daylyStuff = new char[12, 31];
        static int[,] sumStuff = new int[12, 9];//indexes are shown in GetIndex(); 6-WorkDay; 7-ShiftDay
        static Dictionary<string, char[,]> Report = new Dictionary<string, char[,]>();
        static Dictionary<string, int[,]> ReportSum = new Dictionary<string, int[,]>();

        static public List<string> MakeMothlyList(int monthIndex)
        {
            List<string> daysList = new List<string>();
            StringBuilder Sum = new StringBuilder();
            Sum.Append("Id".PadLeft(4));
            Sum.Append(" | ");
            Sum.Append("Име".PadLeft(55));
            Sum.Append(" |");
            if (monthIndex % 2 == 1)
            {
                for (int i = 1; i <= 31; i++)
                {
                    Sum.Append(i);
                    Sum.Append("|");
                }
            }else if (monthIndex == 2)
            {
                int n = 28;
                if (DateTime.Today.Year % 4 == 0)
                {
                    n = 29;
                }
                for (int i = 1; i <= n; i++)
                {
                    Sum.Append(i);
                    Sum.Append("|");
                }
            }
            else
            {
                for (int i = 1; i <= 30; i++)
                {
                    Sum.Append(i);
                    Sum.Append("|");
                }
            }
            daysList.Add(Sum.ToString());
            foreach (KeyValuePair<string, char[,]> person in Report)
            {
                Sum.Clear();
                Sum.Append(person.Key);
                Sum.Append(" |");
                if (monthIndex % 2 == 1)
                {
                    for (int i = 1; i <= 31; i++)
                    {
                        Sum.Append(person.Value[monthIndex, i]);
                        Sum.Append("|");
                    }
                }
                else if (monthIndex == 2)
                {
                    int n = 28;
                    if (DateTime.Today.Year % 4 == 0)
                    {
                        n = 29;
                    }
                    for (int i = 1; i <= n; i++)
                    {
                        Sum.Append(person.Value[monthIndex, i]);
                        Sum.Append("|");
                    }
                }
                else
                {
                    for (int i = 1; i <= 30; i++)
                    {
                        Sum.Append(person.Value[monthIndex, i]);
                        Sum.Append("|");
                    }
                }
                daysList.Add(Sum.ToString());
            }
            return daysList;
        }

        static public List<string> MakeSumList(int monthIndex)
        {
            List<string> daysList = new List<string>();
            StringBuilder Sum = new StringBuilder();
            Sum.Append("Name".PadLeft(55));
            Sum.Append("| ");
            Sum.Append("Отпуска");
            Sum.Append(" | ");
            Sum.Append("Болничен");
            Sum.Append(" | ");
            Sum.Append("Семинари");
            Sum.Append(" | ");
            Sum.Append("Общо");
            Sum.Append(" | ");
            Sum.Append("Работни");
            Sum.Append(" | ");
            Sum.Append("Почивни");
            Sum.Append(" | ");
            Sum.Append("Празнични");
            Sum.Append(" | ");
            Sum.Append("Общо");
            daysList.Add(Sum.ToString());
            foreach (KeyValuePair<string, int[,]> person in ReportSum)
            {
                Sum.Clear();
                Sum.Append(person.Key);
                Sum.Append(" | ");
                Sum.Append(sumStuff[monthIndex, 0].ToString().PadLeft(7));
                Sum.Append(" | ");
                Sum.Append(sumStuff[monthIndex, 1].ToString().PadLeft(8));
                Sum.Append(" | ");
                Sum.Append(sumStuff[monthIndex, 2].ToString().PadLeft(8));
                Sum.Append(" | ");
                Sum.Append(sumStuff[monthIndex, 6].ToString().PadLeft(4));
                Sum.Append(" | ");
                Sum.Append(sumStuff[monthIndex, 3].ToString().PadLeft(7));
                Sum.Append(" | ");
                Sum.Append(sumStuff[monthIndex, 4].ToString().PadLeft(7));
                Sum.Append(" | ");
                Sum.Append(sumStuff[monthIndex, 5].ToString().PadLeft(9));
                Sum.Append(" | ");
                Sum.Append(sumStuff[monthIndex, 7].ToString().PadLeft(4));
                Sum.Append(" | ");
                daysList.Add(Sum.ToString());
            }
            return daysList;
        }

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
                case "work": return 3;
                case "weekend": return 4;
                case "holliday": return 5;
                default: return 8;
            }
        }

        public static void GenerateReport()
        {
            foreach(Worker person in Worker.allWorkers)
            {
                Array.Clear(daylyStuff, 0, daylyStuff.Length);
                for(int i = 1; i <= 12; i++)
                {
                    for (int j = 1; j <= 31; j++)
                    {
                        daylyStuff[i, j] = ' ';
                    }
                    for(int j = 0; j <= 5; j++)
                    {
                        sumStuff[i, j] = 0;
                    }
                }
                foreach(WorkDay day in person.daysLeaves)
                {
                    DateTime startTime = DateTime.Parse(day.start);
                    for(int i = 0; i < day.period; i++)
                    {
                        daylyStuff[startTime.Month, startTime.Day] = GetSymbol(day.type);
                        sumStuff[startTime.Month, GetIndex(day.type)]++;
                        sumStuff[startTime.Month, 6]++;
                    }
                }
                foreach (ShiftDay day in person.daysShift)
                {
                    DateTime startTime = DateTime.Parse(day.date);
                    daylyStuff[startTime.Month, startTime.Day] = GetSymbol(day.type);
                    daylyStuff[startTime.Month, GetIndex(day.type)]++;
                }
                string key = person.id.PadLeft(4) + " | " + person.wholeName.PadLeft(55);
                Report[key] = daylyStuff;
                ReportSum[key] = sumStuff;
            }
        }
    }
}
