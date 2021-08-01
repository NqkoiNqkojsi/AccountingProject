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
    public partial class AddingShifts : Form
    {
        private MainPage mainPage;
        public AddingShifts(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }
        CultureInfo culture = CultureInfo.CreateSpecificCulture("de-DE");

        private void AddNamesToSearch(List<string> people)//save the names to a list
        {
            int i = 1;
            foreach (string person in people)
            {
                if (i == 5) { break; }
                listViewNames.Items.Add(person);
                i++;
            }
        }
        private void RestartForm()
        {
            textBoxName.Text = "";
            comboBoxType.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Today;
            comboBoxWeekDay.SelectedIndex = (int)DateTime.Today.DayOfWeek - 1;
        }

        private string TranslateType(string type)
        {
            switch (type)
            {
                case "Работен ден": return "work";
                case "Почивен ден": return "weekend";
                case "Празничен ден": return "holliday";
                default: return "commandirovka";
            }
        }

        private void AddingShifts_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value= DateTime.Today;
            comboBoxWeekDay.SelectedIndex = (int)DateTime.Today.DayOfWeek - 1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Worker person = Worker.allWorkers.Find(x => x.GetWholeName() == textBoxName.Text);
            Worker.allWorkers.Remove(person);
            ShiftDay day = new ShiftDay(TranslateType(comboBoxType.SelectedItem.ToString()), dateTimePicker1.Text, comboBoxWeekDay.SelectedIndex);
            person.AddShiftDay(day);
            Worker.allWorkers.Add(person);
            mainPage.Reload();
            LoadingDB.SerializeWorkers(Worker.allWorkers);
            LoadingDB.SerializeShiftDays(ShiftDay.allDays);
            RestartForm();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBoxWeekDay.SelectedIndex = (int)dateTimePicker1.Value.DayOfWeek - 1;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (this.Text != "")
            {
                List<string> recommendedPeople = Searching.MakeRecommendation(this.Text);
                AddNamesToSearch(recommendedPeople);
                listViewNames.Visible = true;
                listViewNames.Enabled = true;
            }
        }

        private void listViewNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxName.Text = listViewNames.SelectedItems[0].ToString();
            listViewNames.Visible = false;
            listViewNames.Enabled = false;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
