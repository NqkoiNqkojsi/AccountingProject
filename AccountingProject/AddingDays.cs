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
using System.Threading;
using System.Diagnostics;
using AccountingProject.Models;
using AccountingProject.Controls;

namespace AccountingProject
{
    public partial class AddingDays : Form
    {
        CultureInfo culture = CultureInfo.CreateSpecificCulture("de-DE");
        int savedVacation=0;
        string[] savedDates = new string[2];
        bool canOpenVacationPanel = true;
        private MainPage mainPage;

        public AddingDays(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }
        private void WhenUnready()
        {

        }

        private void AddNamesToSearch(List<string> people)//save the names to a list
        {
            int i = 1;
            foreach(string person in people) {
                if (i == 5) { break; }
                listViewNames.Items.Add(person);
                i++;
            }
        }
        
        private void AddingPeople_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxVacation.SelectedIndex = 0;
            textBoxStart.Text = DateTime.Today.ToString("d.M.yyy", culture);
            textBoxEnd.Text = DateTime.Today.ToString("d.M.yyy", culture);
            savedDates[0] = textBoxStart.Text;
            savedDates[1]= textBoxStart.Text;
            Calendar.MaxSelectionCount = 356;
        }

        private void CloseModals()//close all panels
        {
            listViewNames.Visible = false;
            listViewNames.Enabled = false;
            panelVacationType.Visible = false;
            panelVacationType.Enabled = false;
            panelCalendar.Visible = false;
            panelCalendar.Enabled = false;
        }


        private void RestartForm()
        {
            textBoxName.Text = "";
            textBoxNote.Text = "";
            comboBoxType.SelectedIndex = 0;
            comboBoxVacation.SelectedIndex = 0;
            textBoxStart.Text = DateTime.Today.ToString("d.M.yyy", culture);
            textBoxEnd.Text = DateTime.Today.ToString("d.M.yyy", culture);
            savedDates[0] = textBoxStart.Text;
            savedDates[1] = textBoxStart.Text;
        }

        private string TranslateType(string type)
        {
            switch (type)
            {
                case "отпуска":return "vacation";
                case "болничен":return "ill";
                case "семинар":return "seminar";
                default:return "commandirovka";
            }
        }

        private void buttonSaveWorker_Click(object sender, EventArgs e)
        {
            CloseModals();
            Worker person = Worker.allWorkers.Find(x => x.GetWholeName() == textBoxName.Text);
            Worker.allWorkers.Remove(person);
            WorkDay day = new WorkDay(TranslateType(comboBoxType.SelectedValue.ToString()), textBoxStart.Text, textBoxEnd.Text, textBoxNote.Text, comboBoxVacation.SelectedItem.ToString());
            person.AddWorkDay(day);
            Worker.allWorkers.Add(person);
            mainPage.Reload();
            LoadingDB.SerializeWorkers(Worker.allWorkers);
            LoadingDB.SerializeWorkDays(WorkDay.allDays);
            RestartForm();
        }

        private void buttonSaveVacation_Click(object sender, EventArgs e)
        {
            CloseModals();
            panelVacationType.Visible = false;
            panelVacationType.Enabled = false;
            buttonOpenCalendar.Enabled = true;
            buttonSaveWorker.Enabled = true;
            savedVacation = comboBoxVacation.SelectedIndex;
        }

        private void buttonExitVacation_Click(object sender, EventArgs e)
        {
            CloseModals();
            panelVacationType.Visible = false;
            panelVacationType.Enabled = false;
            buttonOpenCalendar.Enabled = true;
            buttonSaveWorker.Enabled = true;
            comboBoxVacation.SelectedIndex = savedVacation;
        }

        private void comboBoxType_MouseClick(object sender, MouseEventArgs e)
        {
            if (canOpenVacationPanel)
            {
                panelVacationType.Visible = true;
                panelVacationType.Enabled = true;
                buttonOpenCalendar.Enabled = false;
                buttonSaveWorker.Enabled = false;
            }
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

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (panelCalendar.Visible)
            {
                textBoxStart.Text = e.Start.ToString("d.M.yyy", culture);
                textBoxEnd.Text = e.End.ToString("d.M.yyy", culture);
            }
        }

        private void textBoxStart_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Calendar.SelectionStart = DateTime.Parse(textBoxStart.Text);
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void textBoxEnd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Calendar.SelectionEnd = DateTime.Parse(textBoxEnd.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void buttonOpenCalendar_Click(object sender, EventArgs e)
        {
            CloseModals();
            panelCalendar.Visible = true;
            panelCalendar.Enabled = true;
            buttonOpenCalendar.Enabled = false;
            buttonSaveWorker.Enabled = false;
        }

        private void buttonSaveCalendar_Click(object sender, EventArgs e)
        {
            panelCalendar.Visible = false;
            panelCalendar.Enabled = false;
            buttonOpenCalendar.Enabled = true;
            buttonSaveWorker.Enabled = true;
            savedDates[0] = textBoxStart.Text;
            savedDates[1] = textBoxEnd.Text;
        }

        private void buttonCloseCalendar_Click(object sender, EventArgs e)
        {
            panelCalendar.Visible = false;
            panelCalendar.Enabled = false;
            buttonOpenCalendar.Enabled = true;
            buttonSaveWorker.Enabled = true;
            textBoxStart.Text = savedDates[0];
            textBoxEnd.Text = savedDates[1];
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                canOpenVacationPanel = true;
            }
            else
            {
                canOpenVacationPanel = false;
                panelVacationType.Visible = false;
                panelVacationType.Enabled = false;
                buttonOpenCalendar.Enabled = true;
                buttonSaveWorker.Enabled = true;
                comboBoxVacation.SelectedIndex = savedVacation;
            }
        }

        private void listViewNames_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void listViewNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxName.Text = listViewNames.SelectedItems[0].ToString();
            listViewNames.Visible = false;
            listViewNames.Enabled = false;
        }

        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            CloseModals();
        }
    }
}
