
namespace AccountingProject
{
    partial class AddingPeople
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.listViewPeople = new System.Windows.Forms.ListView();
            this.buttonRedact = new System.Windows.Forms.Button();
            this.buttonCut = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 53);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(232, 29);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecondName.Location = new System.Drawing.Point(250, 53);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(232, 29);
            this.textBoxSecondName.TabIndex = 1;
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPerson.Location = new System.Drawing.Point(726, 91);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(139, 53);
            this.buttonAddPerson.TabIndex = 2;
            this.buttonAddPerson.Text = "Добави човек";
            this.buttonAddPerson.UseVisualStyleBackColor = false;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // listViewPeople
            // 
            this.listViewPeople.AutoArrange = false;
            this.listViewPeople.HideSelection = false;
            this.listViewPeople.Location = new System.Drawing.Point(12, 201);
            this.listViewPeople.MultiSelect = false;
            this.listViewPeople.Name = "listViewPeople";
            this.listViewPeople.Size = new System.Drawing.Size(708, 238);
            this.listViewPeople.TabIndex = 3;
            this.listViewPeople.UseCompatibleStateImageBehavior = false;
            this.listViewPeople.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // buttonRedact
            // 
            this.buttonRedact.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonRedact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedact.Location = new System.Drawing.Point(726, 201);
            this.buttonRedact.Name = "buttonRedact";
            this.buttonRedact.Size = new System.Drawing.Size(89, 29);
            this.buttonRedact.TabIndex = 4;
            this.buttonRedact.Text = "Промени";
            this.buttonRedact.UseVisualStyleBackColor = false;
            this.buttonRedact.Click += new System.EventHandler(this.buttonRedact_Click);
            // 
            // buttonCut
            // 
            this.buttonCut.BackColor = System.Drawing.Color.Tomato;
            this.buttonCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCut.Location = new System.Drawing.Point(726, 236);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(89, 29);
            this.buttonCut.TabIndex = 5;
            this.buttonCut.Text = "Изрежи";
            this.buttonCut.UseVisualStyleBackColor = false;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(726, 381);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 58);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Запази";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(488, 53);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(232, 29);
            this.textBoxLastName.TabIndex = 7;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPosition.Location = new System.Drawing.Point(12, 115);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(402, 29);
            this.textBoxPosition.TabIndex = 8;
            this.textBoxPosition.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Позиция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Първо Име";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Второ Име";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Фамилно Име";
            // 
            // AddingPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 451);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.buttonRedact);
            this.Controls.Add(this.listViewPeople);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "AddingPeople";
            this.Text = "AddingPeople";
            this.Load += new System.EventHandler(this.AddingPeople_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.ListView listViewPeople;
        private System.Windows.Forms.Button buttonRedact;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}