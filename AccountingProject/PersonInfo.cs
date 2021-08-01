using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using AccountingProject.Models;

namespace AccountingProject
{
    public partial class PersonInfo : Form
    {
        CultureInfo culture = CultureInfo.CreateSpecificCulture("de-DE");
        Worker worker = new Worker("","","","");
        WorkDay workDay = new WorkDay("", "", "");
        WorkDay workDayOld = new WorkDay("", "", "");
        ShiftDay shiftDay = new ShiftDay("", "", 0);
        ShiftDay shiftDayOld = new ShiftDay("", "", 0);
        public PersonInfo(string id)
        {
            InitializeComponent();
            worker = Worker.allWorkers.Find(x => x.id == id);
        }

        private void PersonInfo_Load(object sender, EventArgs e)
        {
            foreach(string row in worker.MakeWorkDayList())
            {
                listViewLeave.Items.Add(row);
            }
            foreach(string row in worker.MakeShiftDayList())
            {
                listViewShift.Items.Add(row);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBoxWeekDay.SelectedIndex = (int)dateTimePicker1.Value.DayOfWeek - 1;
        }

        private void buttonSaveShift_Click(object sender, EventArgs e)
        {
            worker.daysShift.Remove(shiftDay);
            ShiftDay.allDays.Remove(shiftDay);
            shiftDay.date = dateTimePicker1.Value.ToString();
            shiftDay.weekDay = comboBoxWeekDay.SelectedIndex;
            shiftDay.type = comboBoxTypeShift.SelectedValue.ToString();
            worker.daysShift.Add(shiftDay);
            ShiftDay.allDays.Add(shiftDay);
        }

        private void buttonCutShift_Click(object sender, EventArgs e)
        {
            worker.daysShift.Remove(shiftDay);
            ShiftDay.allDays.Remove(shiftDay);
        }

        private void comboBoxTypeLeave_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxStart.Text = e.Start.ToString("d.M.yyy", culture);
            textBoxEnd.Text = e.End.ToString("d.M.yyy", culture);
        }

        private void textBoxStart_TextChanged(object sender, EventArgs e)
        {
            Calendar.SelectionStart = DateTime.Parse(textBoxStart.Text);
        }

        private void textBoxEnd_TextChanged(object sender, EventArgs e)
        {
            Calendar.SelectionEnd = DateTime.Parse(textBoxEnd.Text);
        }

        private void buttonSaveLeave_Click(object sender, EventArgs e)
        {
            worker.daysLeaves.Remove(workDay);
            WorkDay.allDays.Remove(workDay);
            workDay.type = comboBoxTypeLeave.SelectedItem.ToString();
            workDay.vacationType = comboBoxVacation.SelectedItem.ToString();
            workDay.note = textBoxNote.Text;
            workDay.start = textBoxStart.Text;
            workDay.end = textBoxEnd.Text;
            worker.daysLeaves.Add(workDay);
            WorkDay.allDays.Add(workDay);
        }

        private void buttonCutLeave_Click(object sender, EventArgs e)
        {
            worker.daysLeaves.Remove(workDay);
            WorkDay.allDays.Remove(workDay);
        }

        private void listViewLeave_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewShift_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewLeave_DoubleClick(object sender, EventArgs e)
        {
            string[] SelectedDay = listViewLeave.SelectedItems.ToString().Split(' ', '|');
            workDay = worker.daysLeaves.Find(x => x.id == SelectedDay[0]);
            comboBoxTypeLeave.SelectedItem = workDay.type;
            comboBoxVacation.SelectedItem = workDay.vacationType;
            textBoxNote.Text = workDay.note;
            Calendar.SelectionStart = DateTime.Parse(workDay.start);
            Calendar.SelectionEnd = DateTime.Parse(workDay.end);
            textBoxStart.Text = workDay.start;
            textBoxEnd.Text = workDay.end;
        }

        private void listViewShift_DoubleClick(object sender, EventArgs e)
        {
            string[] SelectedDay = listViewShift.SelectedItems.ToString().Split(' ', '|');
            shiftDay = worker.daysShift.Find(x => x.id == SelectedDay[0]);
            comboBoxTypeShift.SelectedItem = shiftDay.type;
            dateTimePicker1.Value = DateTime.Parse(shiftDay.date);
            comboBoxWeekDay.SelectedIndex = shiftDay.weekDay;
        }
    }
}
