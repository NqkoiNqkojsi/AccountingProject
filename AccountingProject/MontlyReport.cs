using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void MakeTheList(int monthIndex)
        {
            if (isMonthly)
            {
                foreach (string stuff in MakingMonthlyReport.MakeMothlyList(1))
                {
                    listView.Items.Add(stuff);
                }
            }
            else
            {
                foreach (string stuff in MakingMonthlyReport.MakeSumList(1))
                {
                    listView.Items.Add(stuff);
                }
            }
        }

        private void MontlyReport_Load(object sender, EventArgs e)
        {
            MakeTheList(1);
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMonth.Text = comboBoxMonth.SelectedItem.ToString();
            MakeTheList(comboBoxMonth.SelectedIndex);
        }


        private void buttonMothly_Click(object sender, EventArgs e)
        {
            if (!isMonthly)
            {
                isMonthly = true;
                MakeTheList(comboBoxMonth.SelectedIndex);
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (isMonthly)
            {
                isMonthly = false;
                MakeTheList(comboBoxMonth.SelectedIndex);
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
