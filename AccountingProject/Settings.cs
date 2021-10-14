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
                ChangeYear.MakeNewDB();
                mainPage.Reload();
                this.Close();
            }
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            if (!LoadingDB.IsDBEmpty())
            {
                SettingModel.year = SettingModel.NewYear;
                ChangeYear.MakeNewDB();
                mainPage.Reload();
                this.Close();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            string startPath = @"..\..\Database";
            string zipPath = @"..\..\Backups\result-"+DateTime.Now.Day+"-"+DateTime.Now.Month+"-"+DateTime.Now.Year+"__"+ DateTime.Now.Hour+"-"+DateTime.Now.Minute+".zip";
            //string extractPath = @"..\..\Database";

            ZipFile.CreateFromDirectory(startPath, zipPath);

            //ZipFile.ExtractToDirectory(zipPath, extractPath);
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Provide path where to get the file:");

            openFileDialog.InitialDirectory = @"..\..\Backups";
            string filePath="";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
            }
            string extractPath = @"..\..\Database";

            //Delete Old Files
            System.IO.DirectoryInfo di = new DirectoryInfo(@"..\..\Database");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            ZipFile.ExtractToDirectory(filePath, extractPath);
            /*
            using (ZipArchive archive = ZipFile.OpenRead(filePath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    // Gets the full path to ensure that relative segments are removed.
                    string destinationPath = Path.GetFullPath(Path.Combine(extractPath, entry.FullName));

                    // Ordinal match is safest, case-sensitive volumes can be mounted within volumes that
                    // are case-insensitive.
                    if (destinationPath.StartsWith(extractPath, StringComparison.Ordinal))
                        entry.ExtractToFile(destinationPath);
                }
            }*/
        }
    }
}
