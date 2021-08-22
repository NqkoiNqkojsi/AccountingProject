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
using AccountingProject.Controls;
using AccountingProject.Models;

namespace AccountingProject
{
    public partial class Confrontation : Form
    {
        bool isLeaveNew=true;
        bool isLeaveOld = true;
        CultureInfo culture = CultureInfo.CreateSpecificCulture("de-DE");
        AddingDays addingDays;
        AddingShifts addingShifts;

        public Confrontation(bool isLeave, AddingDays addingDays)
        {
            InitializeComponent();
            isLeaveNew = isLeave;
            this.addingDays = addingDays;
            Reload();
        }

        public Confrontation(bool isLeave, AddingShifts addingShifts)
        {
            InitializeComponent();
            isLeaveNew = isLeave;
            this.addingShifts = addingShifts;
            Reload();
        }

        ShiftDay shiftDay = new ShiftDay("","",0);
        WorkDay workDay = new WorkDay("", "", "", "");
        Worker worker = ConfrontingDates.worker;

        private void Reload()
        {
            listViewLieve.Items.Clear();
            listViewShift.Items.Clear();
            if (isLeaveOld)
            {
                Calendar.MaxSelectionCount = 365;
                Calendar.SelectionStart = DateTime.Today;
                Calendar.SelectionEnd = DateTime.Today;
                textBoxEnd.Enabled = true;
                textBoxStart.Visible = true;
                label3.Visible = true;
                label4.Text = "start";
            }
            else
            {
                Calendar.MaxSelectionCount = 1;
                Calendar.SelectionStart = DateTime.Today;
                Calendar.SelectionEnd = DateTime.Today;
                textBoxEnd.Enabled = false;
                textBoxStart.Visible = false;
                label3.Visible = false;
                label4.Text = "date";
            }
            if (ConfrontingDates.workDays.Count>0)
            {
                foreach(WorkDay day in ConfrontingDates.workDays)
                {
                    ListViewItem item = new ListViewItem(day.Summary[0]);
                    for(int i = 1; i < 4; i++)
                    {
                        item.SubItems.Add(day.Summary[i]);
                    }
                    listViewLieve.Items.Add(item);
                }
            }
            if (ConfrontingDates.shiftDays.Count > 0)
            {
                foreach (ShiftDay day in ConfrontingDates.shiftDays)
                {
                    ListViewItem item = new ListViewItem(day.Summary[0]);
                    for (int i = 1; i < 4; i++)
                    {
                        item.SubItems.Add(day.Summary[i]);
                    }
                    listViewLieve.Items.Add(item);
                }
            }
        }

        private void CheckIsReady()
        {
            if (isLeaveNew)
            {
                if (ConfrontingDates.CheckLeave(ConfrontingDates.workNew))
                {
                    Reload();
                }
                else
                {
                    ConfrontingDates.Complete = true;
                    ConfrontingDates.Delete = false;
                    addingDays.Save(true);
                    this.Close();
                }
            }
            else
            {
                if (ConfrontingDates.CheckShift(ConfrontingDates.shiftNew))
                {
                    Reload();
                }
                else
                {
                    ConfrontingDates.Complete = true;
                    ConfrontingDates.Delete = false;
                    addingShifts.Save(true);
                    this.Close();
                }
            }

        }
        private void Confrontation_Load(object sender, EventArgs e)
        {
            if (isLeaveNew) {
                NewInfo.Text = ConfrontingDates.workNew.TranslateType() + ": " + ConfrontingDates.workNew.start + "-" + ConfrontingDates.workNew.end;
            }
            else
            {
                NewInfo.Text = ConfrontingDates.shiftNew.TranslateType() + ": " + ConfrontingDates.shiftNew.date;
            }
            listViewLieve.FullRowSelect = true;
            listViewLieve.GridLines = true;
            listViewLieve.Sorting = SortOrder.Ascending;
            listViewLieve.MultiSelect = false;
            listViewShift.FullRowSelect = true;
            listViewShift.GridLines = true;
            listViewShift.Sorting = SortOrder.Ascending;
            listViewShift.MultiSelect = false;
        }

        private void listViewLieve_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calendar.MaxSelectionCount = 365;
            Calendar.SelectionStart = DateTime.Today;
            Calendar.SelectionEnd = DateTime.Today;
            textBoxEnd.Enabled = true;
            textBoxStart.Visible = true;
            label3.Visible = true;
            label4.Text = "start";
            string SelectedDay = listViewLieve.SelectedItems[0].Text;
            workDay = worker.daysLeaves.Find(x => x.id == SelectedDay);
            isLeaveOld = true;
            Calendar.SelectionStart = WorkDay.ReturnDate(workDay.start);
            Calendar.SelectionEnd = WorkDay.ReturnDate(workDay.end);
            if (isLeaveNew)
            {
                labelDays.Text = "Пресичащи се дни:" + ConfrontingDates.ConfrontingDaysCount(workDay);
            }
            else
            {
                labelDays.Text = "Пресичащи се дни:" + 1;
            }
            OldInfo.Text = workDay.type + ": " + workDay.start + "-" + workDay.end;
        }

        private void listViewShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calendar.MaxSelectionCount = 1;
            Calendar.SelectionStart = DateTime.Today;
            Calendar.SelectionEnd = DateTime.Today;
            textBoxEnd.Enabled = false;
            textBoxStart.Visible = false;
            label3.Visible = false;
            label4.Text = "date";
            string SelectedDay = listViewShift.SelectedItems[0].Text;
            shiftDay = worker.daysShift.Find(x => x.id == SelectedDay);
            isLeaveOld = false;
            Calendar.SelectionStart = shiftDay.ReturnDate();
            Calendar.SelectionEnd = shiftDay.ReturnDate();
            labelDays.Text = "Пресичащи се дни:" + 1;
            OldInfo.Text = shiftDay.type + ": " + shiftDay.date;
        }

        private void textBoxStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            if (isLeaveOld)
            {
                WorkDay.allDays.Remove(workDay);
                worker.daysLeaves.Remove(workDay);
            }
            else
            {
                ShiftDay.allDays.Remove(shiftDay);
                worker.daysShift.Remove(shiftDay);
            }
            CheckIsReady();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (isLeaveOld)
            {
                WorkDay.allDays.Remove(workDay);
                worker.daysLeaves.Remove(workDay);
                workDay.start = textBoxStart.Text;
                workDay.end = textBoxEnd.Text;
                workDay.Period();
                workDay.MakeSummary();
                WorkDay.allDays.Add(workDay);
                worker.daysLeaves.Add(workDay);
                worker.MakeSummary();
            }
            else
            {
                
                ShiftDay.allDays.Remove(shiftDay);
                worker.daysShift.Remove(shiftDay);
                shiftDay.date = textBoxStart.Text;
                shiftDay.MakeSummary();
                ShiftDay.allDays.Add(shiftDay);
                worker.daysShift.Add(shiftDay);
                worker.MakeSummary();
            }
            CheckIsReady();
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxStart.Text = e.Start.ToString("d.M.yyy", culture);
            textBoxEnd.Text = e.End.ToString("d.M.yyy", culture);
        }

        private void button1_Click(object sender, EventArgs e)//Delete New
        {
            ConfrontingDates.Delete = true;
            ConfrontingDates.Complete = true;
            if (isLeaveNew)
            {
                addingDays.Save(true);
            }
            else
            {
                addingShifts.Save(true);
            }
            this.Close();
        }
    }
}
