using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingProject.Models;

namespace AccountingProject.Controls
{
    class ConfrontingDates
    {
        public static List<WorkDay> workDays = new List<WorkDay>();
        public static List<ShiftDay> shiftDays = new List<ShiftDay>();
        public static WorkDay workNew;
        public static ShiftDay shiftNew;
        public static Worker worker;
        public static bool Delete = false;
        public static bool Complete = false;
        //public static ConfrontingDates datesSave;//use this in Confrontation form

        public static bool CheckLeave(WorkDay day)
        {
            shiftDays.Clear();
            workDays.Clear();
            Complete = false;
            bool isConfront = false;
            int start = WorkDay.ReturnDate(day.start).DayOfYear;
            int end = WorkDay.ReturnDate(day.end).DayOfYear;
            foreach (WorkDay work in worker.daysLeaves)
            {
                int startCheck = WorkDay.ReturnDate(work.start).DayOfYear;
                if (start <= startCheck && end >= startCheck) 
                {
                    workDays.Add(work);
                    isConfront = true;
                    continue;
                }
                int endCheck = WorkDay.ReturnDate(work.end).DayOfYear;
                if (start <= endCheck && end >= endCheck)
                {
                    workDays.Add(work);
                    isConfront = true;
                    continue;
                }
                if((startCheck<=start && end<=endCheck) || (startCheck >= start && end >= endCheck))
                {
                    workDays.Add(work);
                    isConfront = true;
                    continue;
                }
            }
            foreach(ShiftDay shift in worker.daysShift)
            {
                int dateCheck = shift.ReturnDate().DayOfYear;
                if(dateCheck>=start && dateCheck <= end)
                {
                    shiftDays.Add(shift);
                    isConfront = true;
                }
            }
            return isConfront;
        }

        public static bool CheckShift(ShiftDay day)
        {
            shiftDays.Clear();
            workDays.Clear();
            Complete = false;
            bool isConfront = false;
            int date = day.ReturnDate().DayOfYear;
            foreach (WorkDay work in worker.daysLeaves)
            {
                int startCheck = WorkDay.ReturnDate(work.start).DayOfYear;
                int endCheck= WorkDay.ReturnDate(work.end).DayOfYear;
                if (date >= startCheck && date <= endCheck)
                {
                    workDays.Add(work);
                    isConfront = true;
                }
            }
            foreach(ShiftDay shift in worker.daysShift)
            {
                int dateCheck = shift.ReturnDate().DayOfYear;
                if (dateCheck == date)
                {
                    shiftDays.Add(shift);
                    isConfront = true;
                }
            }
            return isConfront;
        }
        
        public static int ConfrontingDaysCount(WorkDay work)
        {
            int count = 0;
            int startOld = WorkDay.ReturnDate(work.start).DayOfYear;
            int endOld = WorkDay.ReturnDate(work.end).DayOfYear;
            int startNew = WorkDay.ReturnDate(workNew.start).DayOfYear;
            int endNew = WorkDay.ReturnDate(workNew.end).DayOfYear;
            if (startNew > startOld)
            {
                count = endOld - startNew;
            }
            else
            {
                count = endNew - startOld;
            }
            return count+1;
        }
    }
}
