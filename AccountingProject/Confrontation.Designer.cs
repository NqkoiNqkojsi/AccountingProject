
namespace AccountingProject
{
    partial class Confrontation
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
            this.listViewLieve = new System.Windows.Forms.ListView();
            this.ID1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.End = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewShift = new System.Windows.Forms.ListView();
            this.ID2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WeekDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCutNew = new System.Windows.Forms.Button();
            this.OldInfo = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.buttonCut = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.NewInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewLieve
            // 
            this.listViewLieve.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID1,
            this.Type1,
            this.Start,
            this.End});
            this.listViewLieve.HideSelection = false;
            this.listViewLieve.Location = new System.Drawing.Point(24, 303);
            this.listViewLieve.Name = "listViewLieve";
            this.listViewLieve.Size = new System.Drawing.Size(410, 118);
            this.listViewLieve.TabIndex = 0;
            this.listViewLieve.UseCompatibleStateImageBehavior = false;
            this.listViewLieve.View = System.Windows.Forms.View.Details;
            this.listViewLieve.SelectedIndexChanged += new System.EventHandler(this.listViewLieve_SelectedIndexChanged);
            // 
            // ID1
            // 
            this.ID1.Text = "ID";
            this.ID1.Width = 40;
            // 
            // Type1
            // 
            this.Type1.Text = "Type";
            this.Type1.Width = 105;
            // 
            // Start
            // 
            this.Start.Text = "Start";
            this.Start.Width = 130;
            // 
            // End
            // 
            this.End.Text = "End";
            this.End.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "LeaveDay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ShiftDay";
            // 
            // listViewShift
            // 
            this.listViewShift.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID2,
            this.Type2,
            this.Date,
            this.WeekDay});
            this.listViewShift.HideSelection = false;
            this.listViewShift.Location = new System.Drawing.Point(486, 303);
            this.listViewShift.Name = "listViewShift";
            this.listViewShift.Size = new System.Drawing.Size(410, 118);
            this.listViewShift.TabIndex = 2;
            this.listViewShift.UseCompatibleStateImageBehavior = false;
            this.listViewShift.View = System.Windows.Forms.View.Details;
            this.listViewShift.SelectedIndexChanged += new System.EventHandler(this.listViewShift_SelectedIndexChanged);
            // 
            // ID2
            // 
            this.ID2.Text = "ID";
            this.ID2.Width = 30;
            // 
            // Type2
            // 
            this.Type2.Text = "Type";
            this.Type2.Width = 130;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 130;
            // 
            // WeekDay
            // 
            this.WeekDay.Text = "WeekDay";
            this.WeekDay.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.buttonCutNew);
            this.panel1.Controls.Add(this.OldInfo);
            this.panel1.Controls.Add(this.labelDays);
            this.panel1.Controls.Add(this.buttonCut);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.textBoxEnd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxStart);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Calendar);
            this.panel1.Controls.Add(this.NewInfo);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 275);
            this.panel1.TabIndex = 6;
            // 
            // buttonCutNew
            // 
            this.buttonCutNew.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCutNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCutNew.Location = new System.Drawing.Point(771, 233);
            this.buttonCutNew.Name = "buttonCutNew";
            this.buttonCutNew.Size = new System.Drawing.Size(127, 39);
            this.buttonCutNew.TabIndex = 43;
            this.buttonCutNew.Text = "Изтрий Нов";
            this.buttonCutNew.UseVisualStyleBackColor = false;
            this.buttonCutNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // OldInfo
            // 
            this.OldInfo.AutoSize = true;
            this.OldInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldInfo.Location = new System.Drawing.Point(495, 99);
            this.OldInfo.Name = "OldInfo";
            this.OldInfo.Size = new System.Drawing.Size(61, 20);
            this.OldInfo.TabIndex = 42;
            this.OldInfo.Text = "OldInfo";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(495, 195);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(185, 24);
            this.labelDays.TabIndex = 41;
            this.labelDays.Text = "Пресичащи се дни: ";
            // 
            // buttonCut
            // 
            this.buttonCut.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCut.Location = new System.Drawing.Point(213, 189);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(182, 39);
            this.buttonCut.TabIndex = 40;
            this.buttonCut.Text = "Изтрий Стар";
            this.buttonCut.UseVisualStyleBackColor = false;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(16, 190);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 36);
            this.buttonSave.TabIndex = 39;
            this.buttonSave.Text = "Запази";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnd.Location = new System.Drawing.Point(259, 122);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(171, 24);
            this.textBoxEnd.TabIndex = 38;
            this.textBoxEnd.TextChanged += new System.EventHandler(this.textBoxEnd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "край";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStart.Location = new System.Drawing.Point(259, 72);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(171, 24);
            this.textBoxStart.TabIndex = 36;
            this.textBoxStart.TextChanged += new System.EventHandler(this.textBoxStart_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "начало";
            // 
            // Calendar
            // 
            this.Calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Location = new System.Drawing.Point(16, 9);
            this.Calendar.MaxSelectionCount = 365;
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowToday = false;
            this.Calendar.ShowTodayCircle = false;
            this.Calendar.TabIndex = 34;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // NewInfo
            // 
            this.NewInfo.AutoSize = true;
            this.NewInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewInfo.Location = new System.Drawing.Point(495, 49);
            this.NewInfo.Name = "NewInfo";
            this.NewInfo.Size = new System.Drawing.Size(68, 20);
            this.NewInfo.TabIndex = 0;
            this.NewInfo.Text = "NewInfo";
            // 
            // Confrontation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewShift);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewLieve);
            this.Name = "Confrontation";
            this.Text = "Confrontation";
            this.Load += new System.EventHandler(this.Confrontation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewLieve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewShift;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label NewInfo;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label OldInfo;
        private System.Windows.Forms.Button buttonCutNew;
        private System.Windows.Forms.ColumnHeader ID1;
        private System.Windows.Forms.ColumnHeader Type1;
        private System.Windows.Forms.ColumnHeader Start;
        private System.Windows.Forms.ColumnHeader End;
        private System.Windows.Forms.ColumnHeader ID2;
        private System.Windows.Forms.ColumnHeader Type2;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader WeekDay;
    }
}