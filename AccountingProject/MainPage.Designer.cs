
namespace AccountingProject
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.buttonAddingPeople = new System.Windows.Forms.Button();
            this.buttonAddingShifts = new System.Windows.Forms.Button();
            this.buttonAddingLeave = new System.Windows.Forms.Button();
            this.buttonOpenMontlyReporter = new System.Windows.Forms.Button();
            this.listViewSummary = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Име = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Отпуска = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Болничен = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Семинар = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Общо = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Работни = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Почивни = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Празнични = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Общо2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSideBar.Controls.Add(this.buttonAddingPeople);
            this.panelSideBar.Controls.Add(this.buttonAddingShifts);
            this.panelSideBar.Controls.Add(this.buttonAddingLeave);
            this.panelSideBar.Controls.Add(this.buttonOpenMontlyReporter);
            this.panelSideBar.Location = new System.Drawing.Point(-1, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(213, 510);
            this.panelSideBar.TabIndex = 0;
            // 
            // buttonAddingPeople
            // 
            this.buttonAddingPeople.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddingPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddingPeople.Location = new System.Drawing.Point(12, 408);
            this.buttonAddingPeople.Name = "buttonAddingPeople";
            this.buttonAddingPeople.Size = new System.Drawing.Size(185, 60);
            this.buttonAddingPeople.TabIndex = 3;
            this.buttonAddingPeople.Text = "Добави Хора";
            this.buttonAddingPeople.UseVisualStyleBackColor = false;
            this.buttonAddingPeople.Click += new System.EventHandler(this.buttonAddingPeople_Click);
            // 
            // buttonAddingShifts
            // 
            this.buttonAddingShifts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddingShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddingShifts.Location = new System.Drawing.Point(12, 303);
            this.buttonAddingShifts.Name = "buttonAddingShifts";
            this.buttonAddingShifts.Size = new System.Drawing.Size(185, 60);
            this.buttonAddingShifts.TabIndex = 2;
            this.buttonAddingShifts.Text = "Добави Дежурства";
            this.buttonAddingShifts.UseVisualStyleBackColor = false;
            this.buttonAddingShifts.Click += new System.EventHandler(this.buttonAddingShifts_Click);
            // 
            // buttonAddingLeave
            // 
            this.buttonAddingLeave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddingLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddingLeave.Location = new System.Drawing.Point(12, 198);
            this.buttonAddingLeave.Name = "buttonAddingLeave";
            this.buttonAddingLeave.Size = new System.Drawing.Size(185, 60);
            this.buttonAddingLeave.TabIndex = 1;
            this.buttonAddingLeave.Text = "Добави Опуски";
            this.buttonAddingLeave.UseVisualStyleBackColor = false;
            this.buttonAddingLeave.Click += new System.EventHandler(this.buttonAddingLeave_Click);
            // 
            // buttonOpenMontlyReporter
            // 
            this.buttonOpenMontlyReporter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOpenMontlyReporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenMontlyReporter.Location = new System.Drawing.Point(12, 26);
            this.buttonOpenMontlyReporter.Name = "buttonOpenMontlyReporter";
            this.buttonOpenMontlyReporter.Size = new System.Drawing.Size(185, 60);
            this.buttonOpenMontlyReporter.TabIndex = 0;
            this.buttonOpenMontlyReporter.Text = "Месечен Репорт";
            this.buttonOpenMontlyReporter.UseVisualStyleBackColor = false;
            this.buttonOpenMontlyReporter.Click += new System.EventHandler(this.buttonOpenMontlyReporter_Click);
            // 
            // listViewSummary
            // 
            this.listViewSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Име,
            this.Отпуска,
            this.Болничен,
            this.Семинар,
            this.Общо,
            this.Работни,
            this.Почивни,
            this.Празнични,
            this.Общо2});
            this.listViewSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSummary.GridLines = true;
            this.listViewSummary.HideSelection = false;
            this.listViewSummary.Location = new System.Drawing.Point(218, 12);
            this.listViewSummary.Name = "listViewSummary";
            this.listViewSummary.Size = new System.Drawing.Size(922, 486);
            this.listViewSummary.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewSummary.TabIndex = 1;
            this.listViewSummary.UseCompatibleStateImageBehavior = false;
            this.listViewSummary.View = System.Windows.Forms.View.Details;
            this.listViewSummary.SelectedIndexChanged += new System.EventHandler(this.listViewSummary_SelectedIndexChanged);
            this.listViewSummary.DoubleClick += new System.EventHandler(this.listViewSummary_DoubleClick);
            this.listViewSummary.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewSummary_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Име
            // 
            this.Име.Text = "Име";
            this.Име.Width = 240;
            // 
            // Отпуска
            // 
            this.Отпуска.Text = "Отпуска";
            this.Отпуска.Width = 76;
            // 
            // Болничен
            // 
            this.Болничен.Text = "Болничен";
            this.Болничен.Width = 83;
            // 
            // Семинар
            // 
            this.Семинар.Text = "Семинар";
            this.Семинар.Width = 76;
            // 
            // Общо
            // 
            this.Общо.Text = "Общо";
            this.Общо.Width = 70;
            // 
            // Работни
            // 
            this.Работни.Text = "Работни";
            this.Работни.Width = 76;
            // 
            // Почивни
            // 
            this.Почивни.Text = "Почивни";
            this.Почивни.Width = 76;
            // 
            // Празнични
            // 
            this.Празнични.Text = "Празнични";
            this.Празнични.Width = 80;
            // 
            // Общо2
            // 
            this.Общо2.Text = "Общо";
            this.Общо2.Width = 70;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataSource = typeof(AccountingProject.Models.Worker);
            // 
            // workerBindingSource1
            // 
            this.workerBindingSource1.DataSource = typeof(AccountingProject.Models.Worker);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 510);
            this.Controls.Add(this.listViewSummary);
            this.Controls.Add(this.panelSideBar);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource workerBindingSource;
        private System.Windows.Forms.BindingSource workerBindingSource1;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button buttonOpenMontlyReporter;
        private System.Windows.Forms.ListView listViewSummary;
        private System.Windows.Forms.Button buttonAddingPeople;
        private System.Windows.Forms.Button buttonAddingShifts;
        private System.Windows.Forms.Button buttonAddingLeave;
        private System.Windows.Forms.ColumnHeader Име;
        private System.Windows.Forms.ColumnHeader Отпуска;
        private System.Windows.Forms.ColumnHeader Болничен;
        private System.Windows.Forms.ColumnHeader Семинар;
        private System.Windows.Forms.ColumnHeader Общо;
        private System.Windows.Forms.ColumnHeader Работни;
        private System.Windows.Forms.ColumnHeader Почивни;
        private System.Windows.Forms.ColumnHeader Празнични;
        private System.Windows.Forms.ColumnHeader Общо2;
        private System.Windows.Forms.ColumnHeader ID;
    }
}

