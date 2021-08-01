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
            if (LoadingDB.IsDBEmpty())
            {
                Application.Run(new MainPage(true));
            }
            else
            {
                Person.allPeople = LoadingDB.DeserializePeople();
                Worker.allWorkers = LoadingDB.DeserializeWorkers();
                WorkDay.allDays = LoadingDB.DeserializeWorkDays();
                ShiftDay.allDays = LoadingDB.DeserializeShiftDays();
                Worker.MakeSummary();
                Application.Run(new MainPage(false));
            }
        }
    }
}
