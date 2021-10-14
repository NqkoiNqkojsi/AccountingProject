using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingProject.Models;

namespace AccountingProject.Controls
{
    class ChangeYear//change concurrent year
    {
        static public void PopulateDB()
        {
            foreach(Worker worker in Worker.allWorkers)
            {
                worker.daysShift = new List<ShiftDay>();
                worker.daysLeaves= new List<WorkDay>();
                worker.Summary = new string[11];
                worker.leftDays = worker.leftDaysPerm;
                worker.MakeSummary();
            }
            LoadingDB.SerializeWorkers(Worker.allWorkers);
        }

        static public void MakeNewDB()
        {
            Person.allPeople = LoadingDB.DeserializePeople();
            List<Worker> workers = LoadingDB.DeserializeWorkers();
            WorkDay.allDays = LoadingDB.DeserializeWorkDays();
            ShiftDay.allDays = LoadingDB.DeserializeShiftDays();
            if (workers != null)
            {
                foreach (Worker worker in workers)
                {
                    worker.MakeSummary();
                }
                Worker.allWorkers = workers;
            }
            else
            {
                PopulateDB();
            }
        }

        static public void Check()
        {
            if (SettingModel.NewYear != DateTime.Now.Year)
            {
                SettingModel.NewYear = DateTime.Now.Year;
                SettingModel.year = SettingModel.NewYear;
                MakeNewDB();
            }
        }
    }
}
