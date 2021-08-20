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
using AccountingProject.Controls;

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
        private MainPage mainPage;

        private string TranslateTypeLeave(string type)
        {
            switch (type)
            {
                case "отпуска": return "vacation";
                case "болничен": return "ill";
                case "семинар": return "seminar";
                default: return "commandirovka";
            }
        }

        private string TranslateTypeShift(string type)
        {
            switch (type)
            {
                case "Работен ден": return "work";
                case "Почивен ден": return "weekend";
                case "Празничен ден": return "holliday";
                default: return "commandirovka";
            }
        }

        private void Reload()
        {
            comboBoxTypeLeave.SelectedIndex = 0;
            comboBoxTypeShift.SelectedIndex = 0;
            comboBoxVacation.SelectedIndex = 0;
            textBoxNote.Text = "";
            textBoxStart.Text = DateTime.Today.ToString("d.M.yyyy", culture);
            textBoxEnd.Text = DateTime.Today.ToString("d.M.yyyy", culture);
            dateTimePicker1.Value = DateTime.Today;
            listViewLeave.Items.Clear();
            listViewShift.Items.Clear();
            foreach (WorkDay row in worker.daysLeaves)
            {
                ListViewItem item = new ListViewItem(row.Summary[0]);
                for (int i = 1; i < 5; i++)
                {
                    item.SubItems.Add(row.Summary[i]);
                }
                listViewLeave.Items.Add(item);
            }
            foreach (ShiftDay row in worker.daysShift)
            {
                ListViewItem item = new ListViewItem(row.Summary[0]);
                for (int i = 1; i < 4; i++)
                {
                    item.SubItems.Add(row.Summary[i]);
                }
                listViewShift.Items.Add(item);
            }
        }

        public PersonInfo(string id, MainPage mainPage)
        {
            InitializeComponent();
            worker = Worker.allWorkers.Find(x => x.id == id);
            labelName.Text = "Име: " + worker.wholeName;
            this.mainPage = mainPage;
        }

        private void PersonInfo_Load(object sender, EventArgs e)
        {
            listViewLeave.FullRowSelect = true;
            listViewLeave.GridLines = true;
            listViewLeave.Sorting = SortOrder.Ascending;
            listViewLeave.MultiSelect = false;
            listViewShift.FullRowSelect = true;
            listViewShift.GridLines = true;
            listViewShift.Sorting = SortOrder.Ascending;
            listViewShift.MultiSelect = false;
            Reload();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBoxWeekDay.SelectedIndex = (int)dateTimePicker1.Value.DayOfWeek - 1;
        }

        private void buttonSaveShift_Click(object sender, EventArgs e)
        {
            worker.daysShift.Remove(shiftDay);
            ShiftDay.allDays.Remove(shiftDay);
            shiftDay.date = dateTimePicker1.Value.ToString("d.M.yyyy", culture);
            shiftDay.weekDay = comboBoxWeekDay.SelectedIndex;
            shiftDay.type = TranslateTypeShift(comboBoxTypeShift.SelectedItem.ToString());
            shiftDay.MakeSummary();
            worker.daysShift.Add(shiftDay);
            ShiftDay.allDays.Add(shiftDay);
            worker.MakeSummary();
            mainPage.Reload();
            LoadingDB.UpdateCounterDB();
            LoadingDB.SerializeWorkers(Worker.allWorkers);
            LoadingDB.SerializeShiftDays(ShiftDay.allDays);
            Reload();
        }

        private void buttonCutShift_Click(object sender, EventArgs e)
        {
            worker.daysShift.Remove(shiftDay);
            ShiftDay.allDays.Remove(shiftDay);
            Reload();
            worker.MakeSummary();
            mainPage.Reload();
            LoadingDB.SerializeWorkers(Worker.allWorkers);
            LoadingDB.SerializeShiftDays(ShiftDay.allDays);
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
            //Calendar.SelectionStart = DateTime.Parse(textBoxStart.Text);
        }

        private void textBoxEnd_TextChanged(object sender, EventArgs e)
        {
            //Calendar.SelectionEnd = DateTime.Parse(textBoxEnd.Text);
        }

        private void buttonSaveLeave_Click(object sender, EventArgs e)
        {
            worker.daysLeaves.Remove(workDay);
            WorkDay.allDays.Remove(workDay);
            workDay.type = TranslateTypeLeave(comboBoxTypeLeave.SelectedItem.ToString());
            workDay.vacationType = comboBoxVacation.SelectedItem.ToString();
            workDay.note = textBoxNote.Text;
            workDay.start = textBoxStart.Text;
            workDay.end = textBoxEnd.Text;
            workDay.Period();
            workDay.MakeSummary();
            worker.daysLeaves.Add(workDay);
            WorkDay.allDays.Add(workDay);
            worker.MakeSummary();
            mainPage.Reload();
            LoadingDB.UpdateCounterDB();
            LoadingDB.SerializeWorkers(Worker.allWorkers);
            LoadingDB.SerializeWorkDays(WorkDay.allDays);
            Reload();
        }

        private void buttonCutLeave_Click(object sender, EventArgs e)
        {
            worker.daysLeaves.Remove(workDay);
            WorkDay.allDays.Remove(workDay);
            Reload();
            worker.MakeSummary();
            mainPage.Reload();
            LoadingDB.SerializeWorkers(Worker.allWorkers);
            LoadingDB.SerializeWorkDays(WorkDay.allDays);
        }

        private void listViewLeave_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewShift_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewLeave_DoubleClick(object sender, EventArgs e)
        {
            string SelectedDay = listViewLeave.SelectedItems[0].Text;
            workDay = worker.daysLeaves.Find(x => x.id == SelectedDay);
            comboBoxTypeLeave.SelectedIndex = workDay.IndexType();
            comboBoxVacation.SelectedItem = workDay.vacationType;
            textBoxNote.Text = workDay.note;
            Calendar.SelectionStart = WorkDay.ReturnDate(workDay.start);
            Calendar.SelectionEnd = WorkDay.ReturnDate(workDay.end);
            textBoxStart.Text = workDay.start;
            textBoxEnd.Text = workDay.end;
        }

        private void listViewShift_DoubleClick(object sender, EventArgs e)
        {
            string SelectedDay = listViewShift.SelectedItems[0].Text;
            shiftDay = worker.daysShift.Find(x => x.id == SelectedDay);
            comboBoxTypeShift.SelectedIndex = shiftDay.IndexType();
            dateTimePicker1.Value =shiftDay.ReturnDate();
            comboBoxWeekDay.SelectedIndex = shiftDay.weekDay;
        }
    }
}
