using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingProject.Controls;
using AccountingProject.Models;

namespace AccountingProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WorkDay.Year = DateTime.Now.Year;
            if (LoadingDB.IsDBEmpty())
            {
                Application.Run(new MainPage(true));
            }
            else
            {
                //LoadingDB.MakeDBReady();
                Person.allPeople = LoadingDB.DeserializePeople();
                Worker.allWorkers = LoadingDB.DeserializeWorkers();
                WorkDay.allDays = LoadingDB.DeserializeWorkDays();
                ShiftDay.allDays = LoadingDB.DeserializeShiftDays();
                foreach (Worker worker in Worker.allWorkers)
                {
                    worker.MakeSummary();
                }
                Application.Run(new MainPage(false));
            }
        }
    }
}
