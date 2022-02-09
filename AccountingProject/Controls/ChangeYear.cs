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
        static public void PopulateDB()//generates a list of all people completely striped
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

        static public void MakeNewYearDB()//outdated method don't know why I have kept it
        {
            foreach(Worker worker in Worker.allWorkers)//clear all the specific elements for a year
            {
                worker.leftDays += worker.leftDaysPerm;
                worker.daysShift.Clear();
                worker.daysLeaves.Clear();
                for(int i=0; i<worker.Summary.Count();i++)
                {
                    worker.Summary[i] = "";
                }
            }//save it to the new year DB
            LoadingDB.SerializeWorkers(Worker.allWorkers);
        }

        static public void Check()
        {
            LoadingDB.GetSettings();
            if (SettingModel.lastUpdate + 7 <= DateTime.Now.DayOfYear)//makes an automatic backup every 7 days
            {
                SettingModel.lastUpdate = DateTime.Now.DayOfYear;
                LoadingDB.SerializeSettings(SettingModel.SettingsObj());
                BackupHandling.Export(false);
            }
            if (SettingModel.NewYear != DateTime.Now.Year)//checks if its a new year
            {
                SettingModel.NewYear = DateTime.Now.Year;//updates the settings
                SettingModel.year = SettingModel.NewYear;
                if (Worker.allWorkers.Count() > 0)
                {
                    PopulateDB();
                }
                SettingModel.lastUpdate = DateTime.Now.DayOfYear;
                LoadingDB.SerializeSettings(SettingModel.SettingsObj());
            }
            LoadingDB.MakeDBReady();
        }
    }
}
