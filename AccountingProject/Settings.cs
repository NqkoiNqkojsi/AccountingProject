using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using AccountingProject.Models;
using AccountingProject.Controls;

namespace AccountingProject
{
    public partial class Settings : Form
    {
        private MainPage mainPage;
        public Settings(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            YearNumber.Value = SettingModel.year;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!LoadingDB.IsDBEmpty())
            {
                SettingModel.year = Convert.ToInt32(YearNumber.Value);
                LoadingDB.MakeDBReady();
                mainPage.Reload();
                this.Close();
            }
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            if (!LoadingDB.IsDBEmpty())
            {
                SettingModel.year = SettingModel.NewYear;
                LoadingDB.MakeDBReady();
                mainPage.Reload();
                this.Close();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            BackupHandling.Export(true);
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Provide path where to get the file:");

            openFileDialog.InitialDirectory = @"..\..\Backups";
            string filePath = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
            }
            BackupHandling.Import(filePath);
        }
    }
}
