using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProject.Models
{
    class Counter
    {
        static public int counterWorker = 0;
        static public int counterWorkDays = 0;
        static public int counterShiftDays = 0;

        public int _counterWorker;
        public int _counterWorkDays;
        public int _counterShiftDays;

        public Counter(int a, int b, int c)
        {
            _counterWorker = a;
            _counterWorkDays = b;
            _counterShiftDays = c;
        }

        public static void  Increase(int select)
        {
            switch (select) { 
                case 1: counterWorker++;break;
                case 2: counterWorkDays++; break;
                case 3: counterShiftDays++; break;
            }
        }
    }
}
