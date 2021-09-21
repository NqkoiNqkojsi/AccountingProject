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

namespace AccountingProject
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            YearNumber.Value = WorkDay.Year;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            WorkDay.Year = (int)YearNumber.Value;
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            WorkDay.Year = DateTime.Now.Year;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            string startPath = @".\Database";
            string zipPath = @".\result-"+DateTime.Now.Day+"-"+DateTime.Now.Month+"-"+DateTime.Now.Year+"; "+ DateTime.Now.Hour+":"+DateTime.Now.Minute+".zip";
            string extractPath = @".\extract";

            ZipFile.CreateFromDirectory(startPath, zipPath);

            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {

        }
    }
}
