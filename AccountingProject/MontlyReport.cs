using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using AccountingProject.Controls;
using System.Windows.Forms;

namespace AccountingProject
{
    public partial class MontlyReport : Form
    {
        public MontlyReport()
        {
            InitializeComponent();
            panelInfo.Visible = false;
            panelInfo.Enabled = false;
            MakingMonthlyReport.GenerateReport();
        }
        bool isMonthly = true;
        CultureInfo culture = CultureInfo.CreateSpecificCulture("de-DE");

        private void MakeTheList(int monthIndex)
        {
            listView.Items.Clear();
            listView.Columns.Clear();
            listView.Columns.Add("ID", 30);
            listView.Columns.Add("Име", 180);
            if (isMonthly)
            {
                int m = DateTime.Today.Year, n;
                n = DateTime.DaysInMonth(m, monthIndex);
                string startMonth = "1." + monthIndex + "." + m;
                for (int i = 1; i <= n; i++)
                {
                    listView.Columns.Add(i.ToString(), 30);
                }
                foreach (MakingMonthlyReport target in MakingMonthlyReport.Report)
                {
                    ListViewItem item = new ListViewItem(target.id);
                    item.SubItems.Add(target.name);
                    DateTime dateTime = DateTime.ParseExact(startMonth, "d.M.yyyy", culture);
                    for (int i = 1; i <= n; i++)
                    {
                        if ((int)dateTime.DayOfWeek == 0 || (int)dateTime.DayOfWeek == 6)
                        {
                            item.SubItems.Add(target.dayly[monthIndex, i].ToString()).BackColor=Color.LightGreen;
                        }
                        else
                        {
                            item.SubItems.Add(target.dayly[monthIndex, i].ToString()).BackColor=Color.White;
                        }
                        dateTime.AddDays(1);
                    }
                    item.UseItemStyleForSubItems = false;
                    listView.Items.Add(item);
                }
            }
            else
            {
                listView.Columns.Add("Отпуски", 100);
                listView.Columns.Add("Болнични", 100);
                listView.Columns.Add("Семинар", 100);
                listView.Columns.Add("Общо", 100);
                listView.Columns.Add("Работни", 100);
                listView.Columns.Add("Почивни", 100);
                listView.Columns.Add("Празнични", 100);
                listView.Columns.Add("Общо", 100);
                Console.WriteLine("Reloading() Monthly Page\n");
                foreach (MakingMonthlyReport target in MakingMonthlyReport.Report)
                {
                    ListViewItem item = new ListViewItem(target.id);
                    item.SubItems.Add(target.name);
                    for (int i = 0; i < 8; i++)
                    {
                        item.SubItems.Add(target.sum[monthIndex,i].ToString());
                    }
                    listView.Items.Add(item);
                }
            }

        }

        private void MontlyReport_Load(object sender, EventArgs e)
        {
            MakeTheList(1);
            listView.FullRowSelect = true;
            // Display grid lines.
            listView.GridLines = true;
            // Sort the items in the list in ascending order.
            listView.Sorting = SortOrder.Ascending;
            listView.MultiSelect = false;
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMonth.Text = comboBoxMonth.SelectedItem.ToString();
            MakeTheList(comboBoxMonth.SelectedIndex+1);
        }


        private void buttonMothly_Click(object sender, EventArgs e)
        {
            if (!isMonthly)
            {
                isMonthly = true;
                MakeTheList(comboBoxMonth.SelectedIndex+1);
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (isMonthly)
            {
                isMonthly = false;
                MakeTheList(comboBoxMonth.SelectedIndex+1);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = true;
            panelInfo.Enabled = true;
        }

        private void buttonCloseInfo_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            panelInfo.Enabled = false;
        }


    }
}
