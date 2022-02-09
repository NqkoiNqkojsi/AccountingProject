using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProject.Models
{
    class SettingModel
    {
        static public int year;//the year in the app
        static public int NewYear;//the year in the current time
        static public int lastUpdate;//when was the last backup


        public int _year;
        public int _NewYear;
        public int _lastUpdate;

        public SettingModel(int year, int NewYear, int lastUpdate)
        {
            _year = year;
            _NewYear = NewYear;
            _lastUpdate = lastUpdate;
        }
        public void SettingsSave()
        {
            year = _year;
            NewYear = _NewYear;
            lastUpdate = _lastUpdate;
        }
        static public SettingModel SettingsObj()
        {
            return new SettingModel(year, NewYear, lastUpdate);
        }
    }
}
