namespace WinFormSportSchool
{
    partial class AddInstructorForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.FIOInstructor_label = new System.Windows.Forms.Label();
            this.Qualification_label = new System.Windows.Forms.Label();
            this.PhoneNumberInstructor_label = new System.Windows.Forms.Label();
            this.Section_label = new System.Windows.Forms.Label();
            this.Add_Instructor_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Первая",
            "Вторая",
            "Высшая"});
            this.comboBox1.Location = new System.Drawing.Point(135, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Спортивный_туризм",
            "Скалолазание",
            "Гребля"});
            this.comboBox2.Location = new System.Drawing.Point(135, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // FIOInstructor_label
            // 
            this.FIOInstructor_label.AutoSize = true;
            this.FIOInstructor_label.Location = new System.Drawing.Point(82, 28);
            this.FIOInstructor_label.Name = "FIOInstructor_label";
            this.FIOInstructor_label.Size = new System.Drawing.Size(38, 16);
            this.FIOInstructor_label.TabIndex = 4;
            this.FIOInstructor_label.Text = "ФИО";
            // 
            // Qualification_label
            // 
            this.Qualification_label.AutoSize = true;
            this.Qualification_label.Location = new System.Drawing.Point(16, 65);
            this.Qualification_label.Name = "Qualification_label";
            this.Qualification_label.Size = new System.Drawing.Size(104, 16);
            this.Qualification_label.TabIndex = 5;
            this.Qualification_label.Text = "Квалификация";
            // 
            // PhoneNumberInstructor_label
            // 
            this.PhoneNumberInstructor_label.AutoSize = true;
            this.PhoneNumberInstructor_label.Location = new System.Drawing.Point(1, 104);
            this.PhoneNumberInstructor_label.Name = "PhoneNumberInstructor_label";
            this.PhoneNumberInstructor_label.Size = new System.Drawing.Size(119, 16);
            this.PhoneNumberInstructor_label.TabIndex = 6;
            this.PhoneNumberInstructor_label.Text = "Номер телефона";
            // 
            // Section_label
            // 
            this.Section_label.AutoSize = true;
            this.Section_label.Location = new System.Drawing.Point(66, 142);
            this.Section_label.Name = "Section_label";
            this.Section_label.Size = new System.Drawing.Size(54, 16);
            this.Section_label.TabIndex = 7;
            this.Section_label.Text = "Секция";
            // 
            // Add_Instructor_button
            // 
            this.Add_Instructor_button.Location = new System.Drawing.Point(39, 199);
            this.Add_Instructor_button.Name = "Add_Instructor_button";
            this.Add_Instructor_button.Size = new System.Drawing.Size(85, 30);
            this.Add_Instructor_button.TabIndex = 8;
            this.Add_Instructor_button.Text = "Добавить";
            this.Add_Instructor_button.UseVisualStyleBackColor = true;
            this.Add_Instructor_button.Click += new System.EventHandler(this.Add_Instructor_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(169, 199);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(85, 30);
            this.Cancel_button.TabIndex = 9;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // AddInstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 264);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Add_Instructor_button);
            this.Controls.Add(this.Section_label);
            this.Controls.Add(this.PhoneNumberInstructor_label);
            this.Controls.Add(this.Qualification_label);
            this.Controls.Add(this.FIOInstructor_label);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInstructorForm";
            this.Text = "AddInstructorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label FIOInstructor_label;
        private System.Windows.Forms.Label Qualification_label;
        private System.Windows.Forms.Label PhoneNumberInstructor_label;
        private System.Windows.Forms.Label Section_label;
        private System.Windows.Forms.Button Add_Instructor_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}