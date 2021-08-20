
namespace AccountingProject
{
    partial class AddingDays
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonSaveWorker = new System.Windows.Forms.Button();
            this.panelVacationType = new System.Windows.Forms.Panel();
            this.buttonSaveVacation = new System.Windows.Forms.Button();
            this.buttonExitVacation = new System.Windows.Forms.Button();
            this.comboBoxVacation = new System.Windows.Forms.ComboBox();
            this.buttonOpenCalendar = new System.Windows.Forms.Button();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.buttonCloseCalendar = new System.Windows.Forms.Button();
            this.buttonSaveCalendar = new System.Windows.Forms.Button();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.listViewNames = new System.Windows.Forms.ListView();
            this.panelVacationType.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(42, 80);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(276, 26);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(38, 42);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(40, 20);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Име";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "отпуска",
            "болничен",
            "семинар",
            "командировка"});
            this.comboBoxType.Location = new System.Drawing.Point(428, 78);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(169, 28);
            this.comboBoxType.TabIndex = 4;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            this.comboBoxType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxType_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип отсъствие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Забележка";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNote.Location = new System.Drawing.Point(42, 207);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(276, 100);
            this.textBoxNote.TabIndex = 6;
            this.textBoxNote.TextChanged += new System.EventHandler(this.textBoxNote_TextChanged);
            // 
            // buttonSaveWorker
            // 
            this.buttonSaveWorker.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSaveWorker.Enabled = false;
            this.buttonSaveWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveWorker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSaveWorker.Location = new System.Drawing.Point(494, 241);
            this.buttonSaveWorker.Name = "buttonSaveWorker";
            this.buttonSaveWorker.Size = new System.Drawing.Size(107, 51);
            this.buttonSaveWorker.TabIndex = 8;
            this.buttonSaveWorker.Text = "Добави";
            this.buttonSaveWorker.UseVisualStyleBackColor = false;
            this.buttonSaveWorker.Click += new System.EventHandler(this.buttonSaveWorker_Click);
            // 
            // panelVacationType
            // 
            this.panelVacationType.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelVacationType.Controls.Add(this.buttonSaveVacation);
            this.panelVacationType.Controls.Add(this.buttonExitVacation);
            this.panelVacationType.Controls.Add(this.comboBoxVacation);
            this.panelVacationType.Enabled = false;
            this.panelVacationType.Location = new System.Drawing.Point(152, 142);
            this.panelVacationType.Name = "panelVacationType";
            this.panelVacationType.Size = new System.Drawing.Size(397, 79);
            this.panelVacationType.TabIndex = 9;
            this.panelVacationType.Visible = false;
            // 
            // buttonSaveVacation
            // 
            this.buttonSaveVacation.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSaveVacation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveVacation.Location = new System.Drawing.Point(314, 24);
            this.buttonSaveVacation.Name = "buttonSaveVacation";
            this.buttonSaveVacation.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveVacation.TabIndex = 2;
            this.buttonSaveVacation.Text = "Запази";
            this.buttonSaveVacation.UseVisualStyleBackColor = false;
            this.buttonSaveVacation.Click += new System.EventHandler(this.buttonSaveVacation_Click);
            // 
            // buttonExitVacation
            // 
            this.buttonExitVacation.BackColor = System.Drawing.Color.LightCoral;
            this.buttonExitVacation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExitVacation.Location = new System.Drawing.Point(314, 53);
            this.buttonExitVacation.Name = "buttonExitVacation";
            this.buttonExitVacation.Size = new System.Drawing.Size(75, 23);
            this.buttonExitVacation.TabIndex = 1;
            this.buttonExitVacation.Text = "Затвори";
            this.buttonExitVacation.UseVisualStyleBackColor = false;
            this.buttonExitVacation.Click += new System.EventHandler(this.buttonExitVacation_Click);
            // 
            // comboBoxVacation
            // 
            this.comboBoxVacation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVacation.FormattingEnabled = true;
            this.comboBoxVacation.ItemHeight = 18;
            this.comboBoxVacation.Items.AddRange(new object[] {
            "отсъствие член 45",
            "отсъствие член 1"});
            this.comboBoxVacation.Location = new System.Drawing.Point(3, 21);
            this.comboBoxVacation.Name = "comboBoxVacation";
            this.comboBoxVacation.Size = new System.Drawing.Size(277, 26);
            this.comboBoxVacation.TabIndex = 0;
            // 
            // buttonOpenCalendar
            // 
            this.buttonOpenCalendar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonOpenCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenCalendar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpenCalendar.Location = new System.Drawing.Point(360, 241);
            this.buttonOpenCalendar.Name = "buttonOpenCalendar";
            this.buttonOpenCalendar.Size = new System.Drawing.Size(107, 51);
            this.buttonOpenCalendar.TabIndex = 10;
            this.buttonOpenCalendar.Text = "Дати";
            this.buttonOpenCalendar.UseVisualStyleBackColor = false;
            this.buttonOpenCalendar.Click += new System.EventHandler(this.buttonOpenCalendar_Click);
            // 
            // panelCalendar
            // 
            this.panelCalendar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelCalendar.Controls.Add(this.buttonCloseCalendar);
            this.panelCalendar.Controls.Add(this.buttonSaveCalendar);
            this.panelCalendar.Controls.Add(this.textBoxEnd);
            this.panelCalendar.Controls.Add(this.label4);
            this.panelCalendar.Controls.Add(this.textBoxStart);
            this.panelCalendar.Controls.Add(this.label3);
            this.panelCalendar.Controls.Add(this.Calendar);
            this.panelCalendar.Enabled = false;
            this.panelCalendar.Location = new System.Drawing.Point(71, 94);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(526, 188);
            this.panelCalendar.TabIndex = 11;
            this.panelCalendar.Visible = false;
            // 
            // buttonCloseCalendar
            // 
            this.buttonCloseCalendar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCloseCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCloseCalendar.Location = new System.Drawing.Point(313, 148);
            this.buttonCloseCalendar.Name = "buttonCloseCalendar";
            this.buttonCloseCalendar.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseCalendar.TabIndex = 6;
            this.buttonCloseCalendar.Text = "Затвори";
            this.buttonCloseCalendar.UseVisualStyleBackColor = false;
            this.buttonCloseCalendar.Click += new System.EventHandler(this.buttonCloseCalendar_Click);
            // 
            // buttonSaveCalendar
            // 
            this.buttonSaveCalendar.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSaveCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveCalendar.Location = new System.Drawing.Point(394, 148);
            this.buttonSaveCalendar.Name = "buttonSaveCalendar";
            this.buttonSaveCalendar.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCalendar.TabIndex = 5;
            this.buttonSaveCalendar.Text = "Запази";
            this.buttonSaveCalendar.UseVisualStyleBackColor = false;
            this.buttonSaveCalendar.Click += new System.EventHandler(this.buttonSaveCalendar_Click);
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnd.Location = new System.Drawing.Point(273, 106);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(193, 26);
            this.textBoxEnd.TabIndex = 4;
            this.textBoxEnd.TextChanged += new System.EventHandler(this.textBoxEnd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "край";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStart.Location = new System.Drawing.Point(273, 41);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(193, 26);
            this.textBoxStart.TabIndex = 2;
            this.textBoxStart.TextChanged += new System.EventHandler(this.textBoxStart_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "начало";
            // 
            // Calendar
            // 
            this.Calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.Calendar.Location = new System.Drawing.Point(9, 9);
            this.Calendar.MaxSelectionCount = 365;
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowToday = false;
            this.Calendar.ShowTodayCircle = false;
            this.Calendar.TabIndex = 0;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // listViewNames
            // 
            this.listViewNames.Enabled = false;
            this.listViewNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewNames.HideSelection = false;
            this.listViewNames.Location = new System.Drawing.Point(42, 104);
            this.listViewNames.MultiSelect = false;
            this.listViewNames.Name = "listViewNames";
            this.listViewNames.Size = new System.Drawing.Size(276, 97);
            this.listViewNames.TabIndex = 12;
            this.listViewNames.UseCompatibleStateImageBehavior = false;
            this.listViewNames.View = System.Windows.Forms.View.List;
            this.listViewNames.Visible = false;
            this.listViewNames.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewNames_ItemSelectionChanged);
            this.listViewNames.SelectedIndexChanged += new System.EventHandler(this.listViewNames_SelectedIndexChanged);
            // 
            // AddingDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 360);
            this.Controls.Add(this.panelCalendar);
            this.Controls.Add(this.panelVacationType);
            this.Controls.Add(this.listViewNames);
            this.Controls.Add(this.buttonOpenCalendar);
            this.Controls.Add(this.buttonSaveWorker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxName);
            this.Name = "AddingDays";
            this.Text = "AddingDays";
            this.Load += new System.EventHandler(this.AddingPeople_Load);
            this.panelVacationType.ResumeLayout(false);
            this.panelCalendar.ResumeLayout(false);
            this.panelCalendar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button buttonSaveWorker;
        private System.Windows.Forms.Panel panelVacationType;
        private System.Windows.Forms.Button buttonSaveVacation;
        private System.Windows.Forms.Button buttonExitVacation;
        private System.Windows.Forms.ComboBox comboBoxVacation;
        private System.Windows.Forms.Button buttonOpenCalendar;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Button buttonCloseCalendar;
        private System.Windows.Forms.Button buttonSaveCalendar;
        private System.Windows.Forms.ListView listViewNames;
    }
}