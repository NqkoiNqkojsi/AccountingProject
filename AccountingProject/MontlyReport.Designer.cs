
namespace AccountingProject
{
    partial class MontlyReport
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
            this.labelMonth = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonMothly = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonCloseInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.Location = new System.Drawing.Point(12, 9);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(86, 31);
            this.labelMonth.TabIndex = 0;
            this.labelMonth.Text = "label1";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "Януари",
            "Фебруари",
            "Март",
            "Април",
            "Май",
            "Юни",
            "Юли",
            "Август",
            "Септември",
            "Октомври",
            "Ноември",
            "Декември"});
            this.comboBoxMonth.Location = new System.Drawing.Point(209, 16);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(203, 28);
            this.comboBoxMonth.TabIndex = 1;
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged);
            // 
            // buttonSum
            // 
            this.buttonSum.BackColor = System.Drawing.Color.Wheat;
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSum.Location = new System.Drawing.Point(457, 16);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(92, 28);
            this.buttonSum.TabIndex = 2;
            this.buttonSum.Text = "Общо";
            this.buttonSum.UseVisualStyleBackColor = false;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonMothly
            // 
            this.buttonMothly.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonMothly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMothly.Location = new System.Drawing.Point(555, 16);
            this.buttonMothly.Name = "buttonMothly";
            this.buttonMothly.Size = new System.Drawing.Size(92, 28);
            this.buttonMothly.TabIndex = 3;
            this.buttonMothly.Text = "Месечно";
            this.buttonMothly.UseVisualStyleBackColor = false;
            this.buttonMothly.Click += new System.EventHandler(this.buttonMothly_Click);
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 62);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1156, 575);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Location = new System.Drawing.Point(1067, 15);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(92, 28);
            this.buttonInfo.TabIndex = 5;
            this.buttonInfo.Text = "Инфо";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.buttonCloseInfo);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Location = new System.Drawing.Point(486, 138);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(161, 190);
            this.panelInfo.TabIndex = 6;
            // 
            // buttonCloseInfo
            // 
            this.buttonCloseInfo.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCloseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseInfo.Location = new System.Drawing.Point(32, 164);
            this.buttonCloseInfo.Name = "buttonCloseInfo";
            this.buttonCloseInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseInfo.TabIndex = 4;
            this.buttonCloseInfo.Text = "Затвори";
            this.buttonCloseInfo.UseVisualStyleBackColor = false;
            this.buttonCloseInfo.Click += new System.EventHandler(this.buttonCloseInfo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Д - Дежурство";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "С - Семинар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Б - Болничен";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "О - Отпуска";
            // 
            // MontlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 649);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.buttonMothly);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.labelMonth);
            this.Name = "MontlyReport";
            this.Text = "MontlyReport";
            this.Load += new System.EventHandler(this.MontlyReport_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonMothly;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button buttonCloseInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}