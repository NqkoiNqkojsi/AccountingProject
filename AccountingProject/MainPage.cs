using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingProject.Models;

namespace AccountingProject
{
    public partial class MainPage : Form
    {
        public  MainPage(bool f)
        {
            InitializeComponent();
            if (true)
            {
                AddingPeople addingPeople = new AddingPeople(this);
            }
        }

        public void Reload()
        {
            listViewSummary.Items.Clear();
            Console.WriteLine("Reloading()\n");
            if (Worker.allWorkers != null)
            {
                foreach (Worker per in Worker.allWorkers)
                {
                    ListViewItem item = new ListViewItem(per.Summary[0]);
                    for (int i = 1; i < 10; i++)
                    {
                        item.SubItems.Add(per.Summary[i]);
                    }
                    listViewSummary.Items.Add(item);
                }
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // Select the item and subitems when selection is made.
            listViewSummary.FullRowSelect = true;
            // Display grid lines.
            listViewSummary.GridLines = true;
            // Sort the items in the list in ascending order.
            listViewSummary.Sorting = SortOrder.Ascending;
            listViewSummary.MultiSelect = false;
            Reload();
        }

        private void buttonAddingPeople_Click(object sender, EventArgs e)
        {
            AddingPeople addingPeople = new AddingPeople(this);
            addingPeople.Show();
        }

        private void buttonAddingShifts_Click(object sender, EventArgs e)
        {
            AddingShifts addingShifts = new AddingShifts(this);
            addingShifts.Show();
        }

        private void buttonAddingLeave_Click(object sender, EventArgs e)
        {
            AddingDays addingDays = new AddingDays(this);
            addingDays.Show();
        }

        private void buttonOpenMontlyReporter_Click(object sender, EventArgs e)
        {
            MontlyReport montlyReport = new MontlyReport();
            montlyReport.Show();
        }

        private void listViewSummary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewSummary_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listViewSummary_DoubleClick(object sender, EventArgs e)
        {
            PersonInfo personInfo = new PersonInfo(listViewSummary.SelectedItems[0].Text, this);
            personInfo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.Show();
        }
    }
}
