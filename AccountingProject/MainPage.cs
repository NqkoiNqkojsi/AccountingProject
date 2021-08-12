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
            Worker.MakeSummary();
            listViewSummary.Items.Clear();
            Console.WriteLine("count= " + Worker.Summary.Count);
            Console.WriteLine("count 1= " + Worker.allWorkers.Count);
            foreach (string items in Worker.Summary)
            {
                listViewSummary.Items.Add(items);
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
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
    }
}
