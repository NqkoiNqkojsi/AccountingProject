
namespace AccountingProject
{
    partial class PersonInfo
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
            this.label5 = new System.Windows.Forms.Label();
            this.listViewLeave = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Тип = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Начало = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Край = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Период = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewShift = new System.Windows.Forms.ListView();
            this.ID1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Тип2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Дата = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ДенОтСедмицата = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonCutLeave = new System.Windows.Forms.Button();
            this.buttonSaveLeave = new System.Windows.Forms.Button();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.comboBoxVacation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTypeLeave = new System.Windows.Forms.ComboBox();
            this.buttonCutShift = new System.Windows.Forms.Button();
            this.buttonSaveShift = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeShift = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxWeekDay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Отпуски";
            // 
            // listViewLeave
            // 
            this.listViewLeave.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Тип,
            this.Начало,
            this.Край,
            this.Период});
            this.listViewLeave.HideSelection = false;
            this.listViewLeave.Location = new System.Drawing.Point(12, 37);
            this.listViewLeave.Name = "listViewLeave";
            this.listViewLeave.Size = new System.Drawing.Size(564, 172);
            this.listViewLeave.TabIndex = 22;
            this.listViewLeave.UseCompatibleStateImageBehavior = false;
            this.listViewLeave.View = System.Windows.Forms.View.Details;
            this.listViewLeave.SelectedIndexChanged += new System.EventHandler(this.listViewLeave_SelectedIndexChanged);
            this.listViewLeave.DoubleClick += new System.EventHandler(this.listViewLeave_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Тип
            // 
            this.Тип.Text = "Тип";
            this.Тип.Width = 120;
            // 
            // Начало
            // 
            this.Начало.Text = "Начало";
            this.Начало.Width = 150;
            // 
            // Край
            // 
            this.Край.Text = "Край";
            this.Край.Width = 150;
            // 
            // Период
            // 
            this.Период.Text = "Период";
            this.Период.Width = 80;
            // 
            // listViewShift
            // 
            this.listViewShift.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID1,
            this.Тип2,
            this.Дата,
            this.ДенОтСедмицата});
            this.listViewShift.HideSelection = false;
            this.listViewShift.Location = new System.Drawing.Point(604, 37);
            this.listViewShift.Name = "listViewShift";
            this.listViewShift.Size = new System.Drawing.Size(564, 172);
            this.listViewShift.TabIndex = 24;
            this.listViewShift.UseCompatibleStateImageBehavior = false;
            this.listViewShift.View = System.Windows.Forms.View.Details;
            this.listViewShift.SelectedIndexChanged += new System.EventHandler(this.listViewShift_SelectedIndexChanged);
            this.listViewShift.DoubleClick += new System.EventHandler(this.listViewShift_DoubleClick);
            // 
            // ID1
            // 
            this.ID1.Text = "ID";
            // 
            // Тип2
            // 
            this.Тип2.Text = "Тип";
            this.Тип2.Width = 170;
            // 
            // Дата
            // 
            this.Дата.Text = "Дата";
            this.Дата.Width = 150;
            // 
            // ДенОтСедмицата
            // 
            this.ДенОтСедмицата.Text = "Ден От Седмицата";
            this.ДенОтСедмицата.Width = 180;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(604, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Дежурства";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-5, -2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelName);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCutLeave);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSaveLeave);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxEnd);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxStart);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.Calendar);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxVacation);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNote);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxTypeLeave);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel2.Controls.Add(this.buttonCutShift);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSaveShift);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxTypeShift);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxWeekDay);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1190, 594);
            this.splitContainer1.SplitterDistance = 594;
            this.splitContainer1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(240, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Вид отпуска";
            // 
            // buttonCutLeave
            // 
            this.buttonCutLeave.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCutLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCutLeave.Location = new System.Drawing.Point(451, 516);
            this.buttonCutLeave.Name = "buttonCutLeave";
            this.buttonCutLeave.Size = new System.Drawing.Size(130, 54);
            this.buttonCutLeave.TabIndex = 33;
            this.buttonCutLeave.Text = "Изтрий";
            this.buttonCutLeave.UseVisualStyleBackColor = false;
            this.buttonCutLeave.Click += new System.EventHandler(this.buttonCutLeave_Click);
            // 
            // buttonSaveLeave
            // 
            this.buttonSaveLeave.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSaveLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveLeave.Location = new System.Drawing.Point(451, 456);
            this.buttonSaveLeave.Name = "buttonSaveLeave";
            this.buttonSaveLeave.Size = new System.Drawing.Size(130, 51);
            this.buttonSaveLeave.TabIndex = 32;
            this.buttonSaveLeave.Text = "Запази";
            this.buttonSaveLeave.UseVisualStyleBackColor = false;
            this.buttonSaveLeave.Click += new System.EventHandler(this.buttonSaveLeave_Click);
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnd.Location = new System.Drawing.Point(264, 531);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(161, 24);
            this.textBoxEnd.TabIndex = 31;
            this.textBoxEnd.TextChanged += new System.EventHandler(this.textBoxEnd_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "край";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStart.Location = new System.Drawing.Point(264, 456);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(161, 24);
            this.textBoxStart.TabIndex = 29;
            this.textBoxStart.TextChanged += new System.EventHandler(this.textBoxStart_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(260, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "начало";
            // 
            // Calendar
            // 
            this.Calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.Calendar.Location = new System.Drawing.Point(25, 423);
            this.Calendar.MaxSelectionCount = 365;
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowToday = false;
            this.Calendar.ShowTodayCircle = false;
            this.Calendar.TabIndex = 27;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // comboBoxVacation
            // 
            this.comboBoxVacation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVacation.FormattingEnabled = true;
            this.comboBoxVacation.ItemHeight = 18;
            this.comboBoxVacation.Items.AddRange(new object[] {
            "отсъствие член 45",
            "отсъствие член 1"});
            this.comboBoxVacation.Location = new System.Drawing.Point(244, 268);
            this.comboBoxVacation.Name = "comboBoxVacation";
            this.comboBoxVacation.Size = new System.Drawing.Size(277, 26);
            this.comboBoxVacation.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Забележка";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNote.Location = new System.Drawing.Point(25, 343);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(496, 68);
            this.textBoxNote.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Тип отсъствие";
            // 
            // comboBoxTypeLeave
            // 
            this.comboBoxTypeLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeLeave.FormattingEnabled = true;
            this.comboBoxTypeLeave.Items.AddRange(new object[] {
            "отпуска",
            "болничен",
            "семинар",
            "командировка"});
            this.comboBoxTypeLeave.Location = new System.Drawing.Point(25, 268);
            this.comboBoxTypeLeave.Name = "comboBoxTypeLeave";
            this.comboBoxTypeLeave.Size = new System.Drawing.Size(169, 26);
            this.comboBoxTypeLeave.TabIndex = 10;
            this.comboBoxTypeLeave.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeLeave_SelectedIndexChanged);
            // 
            // buttonCutShift
            // 
            this.buttonCutShift.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCutShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCutShift.Location = new System.Drawing.Point(445, 355);
            this.buttonCutShift.Name = "buttonCutShift";
            this.buttonCutShift.Size = new System.Drawing.Size(119, 59);
            this.buttonCutShift.TabIndex = 23;
            this.buttonCutShift.Text = "Изтрий";
            this.buttonCutShift.UseVisualStyleBackColor = false;
            this.buttonCutShift.Click += new System.EventHandler(this.buttonCutShift_Click);
            // 
            // buttonSaveShift
            // 
            this.buttonSaveShift.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSaveShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveShift.Location = new System.Drawing.Point(320, 355);
            this.buttonSaveShift.Name = "buttonSaveShift";
            this.buttonSaveShift.Size = new System.Drawing.Size(119, 59);
            this.buttonSaveShift.TabIndex = 22;
            this.buttonSaveShift.Text = "Запази";
            this.buttonSaveShift.UseVisualStyleBackColor = false;
            this.buttonSaveShift.Click += new System.EventHandler(this.buttonSaveShift_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Тип дежурство";
            // 
            // comboBoxTypeShift
            // 
            this.comboBoxTypeShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeShift.FormattingEnabled = true;
            this.comboBoxTypeShift.Items.AddRange(new object[] {
            "Работен ден",
            "Почивен ден",
            "Празничен ден"});
            this.comboBoxTypeShift.Location = new System.Drawing.Point(67, 386);
            this.comboBoxTypeShift.Name = "comboBoxTypeShift";
            this.comboBoxTypeShift.Size = new System.Drawing.Size(229, 28);
            this.comboBoxTypeShift.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "d.M.yyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 307);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 20);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ден от седмицата";
            // 
            // comboBoxWeekDay
            // 
            this.comboBoxWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWeekDay.FormattingEnabled = true;
            this.comboBoxWeekDay.Items.AddRange(new object[] {
            "Понеделник",
            "Вторник",
            "Сряда",
            "Четвъртък",
            "Петък",
            "Събота",
            "Неделя"});
            this.comboBoxWeekDay.Location = new System.Drawing.Point(320, 301);
            this.comboBoxWeekDay.Name = "comboBoxWeekDay";
            this.comboBoxWeekDay.Size = new System.Drawing.Size(244, 26);
            this.comboBoxWeekDay.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(240, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 24);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "Име:";
            // 
            // PersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 590);
            this.Controls.Add(this.listViewShift);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listViewLeave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PersonInfo";
            this.Text = "PersonInfo";
            this.Load += new System.EventHandler(this.PersonInfo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewLeave;
        private System.Windows.Forms.ListView listViewShift;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxWeekDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTypeShift;
        private System.Windows.Forms.Button buttonCutShift;
        private System.Windows.Forms.Button buttonSaveShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxTypeLeave;
        private System.Windows.Forms.ComboBox comboBoxVacation;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonCutLeave;
        private System.Windows.Forms.Button buttonSaveLeave;
        private System.Windows.Forms.ColumnHeader Тип;
        private System.Windows.Forms.ColumnHeader Начало;
        private System.Windows.Forms.ColumnHeader Край;
        private System.Windows.Forms.ColumnHeader Период;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ID1;
        private System.Windows.Forms.ColumnHeader Тип2;
        private System.Windows.Forms.ColumnHeader Дата;
        private System.Windows.Forms.ColumnHeader ДенОтСедмицата;
        private System.Windows.Forms.Label labelName;
    }
}