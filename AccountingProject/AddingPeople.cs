using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingProject.Controls;
using AccountingProject.Models;

namespace AccountingProject
{
    public partial class AddingPeople : Form
    {
        private MainPage mainPage;
        public AddingPeople(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }
        bool isNew = false;
        bool isRedacting = false; //is it in mode redacting
        string workerString = "";
        List<Worker> newWorkers = new List<Worker>();
        List<Worker> oldWorkers = new List<Worker>();
        Worker worker=new Worker("", "", "", "");

        private void AddingPeople_Load(object sender, EventArgs e)
        {
            listViewPeople.MultiSelect = false;
            if (!LoadingDB.IsDBEmpty())
            {
                foreach (Person a in Person.allPeople)
                {
                    listViewPeople.Items.Add(a.wholeName+";"+a.id+";old");
                }
            }
        }

        private string GetName(string a)
        {
            string[] parts = new string[3];
            parts = a.Split(',', ' ');
            return parts[0];
        }
        private string GetId(string a)
        {
            string[] parts = new string[10];
            parts = a.Split(';');
            Console.WriteLine("a[2]="+a[1]);
            Console.WriteLine("a[4]="+a[2]);
            if (parts[2] == "new")
            {
                isNew = true;
            }
            else
            {
                isNew = false;
            }
            return parts[1];
        }

        private void SearchForWorker(string names)
        {
            worker = Worker.FindByID(GetId(names));
            if (isNew == true)
            {
                worker = Worker.FindByID(GetId(names), newWorkers);
            }
        }

        private void RedactComponents(bool f)
        {
            if (f)
            {
                textBoxFirstName.BackColor = Color.White;
                textBoxSecondName.BackColor = Color.White;
                textBoxLastName.BackColor = Color.White;
                textBoxPosition.BackColor = Color.White;
                buttonAddPerson.BackColor = Color.SeaGreen;
                textBoxFirstName.Text = "";
                textBoxSecondName.Text = "";
                textBoxLastName.Text = "";
                textBoxPosition.Text = "";
                isRedacting = false;
            }
            else
            {
                textBoxFirstName.BackColor = Color.LightSalmon;
                textBoxSecondName.BackColor = Color.LightSalmon;
                textBoxLastName.BackColor = Color.LightSalmon;
                textBoxPosition.BackColor = Color.LightSalmon;
                buttonAddPerson.BackColor = Color.LightYellow;
                Console.WriteLine("Workerstring="+workerString);
                SearchForWorker(workerString);
                textBoxFirstName.Text = worker.firstName;
                textBoxSecondName.Text = worker.secondName;
                textBoxLastName.Text = worker.lastName;
                textBoxPosition.Text = worker.position;
                isRedacting = true;
            }
        }

        private bool CheckTextBoxes()
        {
            if (textBoxFirstName.Text.Length < 1)
            {
                return false;
            }else if (textBoxLastName.Text.Length < 1)
            {
                return false;
            }else if (textBoxSecondName.Text.Length < 1)
            {
                return false;
            }else if (textBoxPosition.Text.Length < 1)
            {
                return false;
            }
            return true;
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                if (isRedacting == false)
                {
                    worker = new Worker(textBoxFirstName.Text, textBoxSecondName.Text, textBoxLastName.Text, textBoxPosition.Text);
                    newWorkers.Add(worker);
                    listViewPeople.Items.Add(worker.wholeName+";"+worker.id+";new");
                    RedactComponents(true);
                }
                else
                {
                    listViewPeople.SelectedItems[0].Remove();
                    oldWorkers.Add(worker);
                    worker.ChangeName(5, textBoxFirstName.Text, textBoxSecondName.Text, textBoxLastName.Text, textBoxPosition.Text);
                    newWorkers.Add(worker);
                    listViewPeople.Items.Add(worker.wholeName + ";" + worker.id + ";new");
                    RedactComponents(true);
                }
            }
        }

        private void buttonRedact_Click(object sender, EventArgs e)
        {
            if (isRedacting == false)
            {
                RedactComponents(false);
            }
            else
            {
                RedactComponents(true);
            }
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            SearchForWorker(listViewPeople.SelectedItems[0].Text);
            oldWorkers.Add(worker);
            RedactComponents(true);
            listViewPeople.Items.Remove(listViewPeople.SelectedItems[0]);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Worker.allWorkers.AddRange(newWorkers);
            foreach (Worker person in oldWorkers)
            {
                try
                {
                    Worker.allWorkers.Remove(person);
                }catch(Exception ex)
                {
                    Console.WriteLine("Remove Exception: "+ex);
                }
            }
            mainPage.Reload();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RedactComponents(true);
            try
            {
                workerString = listViewPeople.SelectedItems[0].Text;
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
