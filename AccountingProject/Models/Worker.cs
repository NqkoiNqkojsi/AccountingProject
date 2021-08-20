﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProject.Models
{
    class Worker
    {
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string lastName { get; set; }
        public string wholeName { get; set; }
        public string id;
        public string position { get; set; }

        public string[] Summary = new string[11];//Summary of all the days as string for the main page; updated in Days pages

        public static List<Person> allPeople = new List<Person>();

        public List<WorkDay> daysLeaves = new List<WorkDay>();
        public List<ShiftDay> daysShift = new List<ShiftDay>();
        public static List<Worker> allWorkers = new List<Worker>();
        
        
        private void SaveName()
        {
            wholeName = firstName + " " + secondName + " " + lastName;
        }

        public Worker( string firstName, string secondName, string lastName, string position)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.secondName = secondName;
            this.position = position;
            SaveName();
            id = Counter.counterWorker.ToString();
            Counter.Increase(1);
            MakeSummary();
        }

        public void AddWorkDay(WorkDay day)
        {
            daysLeaves.Add(day);
            WorkDay.allDays.Add(day);
        }
        public void AddShiftDay(ShiftDay day)
        {
            daysShift.Add(day);
            ShiftDay.allDays.Add(day);
        }

        public void ChangeName(int a = 5, string name="", string name2 = "", string name3 = "", string position="")
        {
            if (a==1)
            {
                firstName = name;
            }
            else if(a==2)
            {
                secondName = name;
            }else if (a==3)
            {
                lastName = name;
            }
            else if(a==4)
            {
                firstName = name;
                secondName = name2;
                lastName = name3;
            }
            else
            {
                this.firstName = name;
                this.secondName = name2;
                this.lastName = name3;
                this.position = position;
            }
            
            SaveName();
        }

        public string GetWholeName()
        {
            return wholeName;
        }

        public static Worker FindByName(string name)
        {
            return allWorkers.Find(x => x.wholeName == name);
        }
        public static Worker FindByName(string name, List<Worker> list)
        {
            return list.Find(x => x.wholeName == name);
        }
        public static Worker FindByID(string id)
        {
            return allWorkers.Find(x => x.id == id);
        }
        public static Worker FindByID(string id, List<Worker> list)
        {
            return list.Find(x => x.id == id);
        }

        public static List<Worker> SortByPosition(string pos)
        {
            return allWorkers.FindAll(x => x.position == pos);
        }

        public void CountDaysLeave()
        {
            int[] br = new int[4];
            foreach(WorkDay vac in daysLeaves)
            {
                switch (vac.type)
                {
                    case "vacation":br[0]+=vac.period;break;
                    case "ill": br[1]+= vac.period; break;
                    case "seminar": br[2]+= vac.period; break;
                }
                br[3]+=vac.period;
            }
            Summary[2] = br[0].ToString();
            Summary[3] = br[1].ToString();
            Summary[4] = br[2].ToString();
            Summary[5] = br[3].ToString();

        }
        public void CountDaysShift()
        {
            int[] br = new int[4];
            foreach (ShiftDay vac in daysShift)
            {
                switch (vac.type)
                {
                    case "work": br[0]++; break;
                    case "weekend": br[1]++; break;
                    case "holliday": br[2]++; break;
                }
                br[3]++;
            }
            Summary[6] = br[0].ToString();
            Summary[7] = br[1].ToString();
            Summary[8] = br[2].ToString();
            Summary[9] = br[3].ToString();
        }

        public void  MakeSummary()
        {
            Summary[0] = id;
            Summary[1] = wholeName;
            CountDaysLeave();
            CountDaysShift();
        }

        public List<string> MakeWorkDayList()
        {
            List<string> daysList = new List<string>();
            StringBuilder Sum = new StringBuilder();
            Sum.Append("Тип".PadLeft(9));
            Sum.Append(" | ");
            Sum.Append("Начало".PadLeft(11));
            Sum.Append(" | ");
            Sum.Append("Край".PadLeft(11));
            Sum.Append(" | ");
            Sum.Append("Период");
            Sum.Append(" |");
            daysList.Add(Sum.ToString());
            foreach(WorkDay day in daysLeaves)
            {
                Sum.Clear();
                Sum.Append(day.type.PadLeft(9));
                Sum.Append(" | ");
                Sum.Append(day.start.PadLeft(11));
                Sum.Append(" | ");
                Sum.Append(day.end.PadLeft(11));
                Sum.Append(" | ");
                Sum.Append(day.period.ToString().PadLeft(6));
                Sum.Append(" |");
                daysList.Add(Sum.ToString());
            }
            return daysList;
        }
        public List<string> MakeShiftDayList()
        {
            List<string> daysList = new List<string>();
            StringBuilder Sum = new StringBuilder();
            Sum.Append("Id".PadLeft(4));
            Sum.Append(" | ");
            Sum.Append("Тип".PadLeft(13));
            Sum.Append(" | ");
            Sum.Append("Дата".PadLeft(11));
            Sum.Append(" | ");
            Sum.Append("Ден от седмицата".PadLeft(16));
            Sum.Append(" |");
            daysList.Add(Sum.ToString());
            foreach (ShiftDay day in daysShift)
            {
                Sum.Clear();
                Sum.Append(day.id.PadLeft(4));
                Sum.Append(" | ");
                Sum.Append(day.type.PadLeft(9));
                Sum.Append(" | ");
                Sum.Append(day.date.PadLeft(11));
                Sum.Append(" | ");
                Sum.Append(ShiftDay.GetWeekDay(day.weekDay).PadLeft(16));
                Sum.Append(" |");
                daysList.Add(Sum.ToString());
            }
            return daysList;
        }
    }
}
