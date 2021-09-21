using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingProject.Models;

namespace AccountingProject.Controls
{
    class ResetYear
    {
        public void Reset(int year)
        {
            Worker.allWorkers.Clear();
            ShiftDay.allDays.Clear();
            WorkDay.allDays.Clear();
            Person.allPeople = LoadingDB.DeserializePeople();
            Worker.allWorkers = LoadingDB.DeserializeWorkers();
            WorkDay.allDays = LoadingDB.DeserializeWorkDays();
            ShiftDay.allDays = LoadingDB.DeserializeShiftDays();
        }
    }
}
