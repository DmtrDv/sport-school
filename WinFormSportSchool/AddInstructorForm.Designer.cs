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
            this.FIO_textBox = new System.Windows.Forms.TextBox();
            this.PhoneNumber_textBox = new System.Windows.Forms.MaskedTextBox();
            this.Qualification_comboBox = new System.Windows.Forms.ComboBox();
            this.Section_comboBox = new System.Windows.Forms.ComboBox();
            this.FIOInstructor_label = new System.Windows.Forms.Label();
            this.Qualification_label = new System.Windows.Forms.Label();
            this.PhoneNumberInstructor_label = new System.Windows.Forms.Label();
            this.Section_label = new System.Windows.Forms.Label();
            this.Add_Instructor_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIO_textBox
            // 
            this.FIO_textBox.Location = new System.Drawing.Point(101, 20);
            this.FIO_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FIO_textBox.Name = "FIO_textBox";
            this.FIO_textBox.Size = new System.Drawing.Size(134, 20);
            this.FIO_textBox.TabIndex = 0;
            // 
            // PhoneNumber_textBox
            // 
            this.PhoneNumber_textBox.Location = new System.Drawing.Point(101, 82);
            this.PhoneNumber_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhoneNumber_textBox.Name = "PhoneNumber_textBox";
            this.PhoneNumber_textBox.Size = new System.Drawing.Size(134, 20);
            this.PhoneNumber_textBox.TabIndex = 1;
            // 
            // Qualification_comboBox
            // 
            this.Qualification_comboBox.FormattingEnabled = true;
            this.Qualification_comboBox.Items.AddRange(new object[] {
            "Первая",
            "Вторая",
            "Высшая"});
            this.Qualification_comboBox.Location = new System.Drawing.Point(101, 50);
            this.Qualification_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Qualification_comboBox.Name = "Qualification_comboBox";
            this.Qualification_comboBox.Size = new System.Drawing.Size(134, 21);
            this.Qualification_comboBox.TabIndex = 2;
            // 
            // Section_comboBox
            // 
            this.Section_comboBox.FormattingEnabled = true;
            this.Section_comboBox.Location = new System.Drawing.Point(101, 115);
            this.Section_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Section_comboBox.Name = "Section_comboBox";
            this.Section_comboBox.Size = new System.Drawing.Size(134, 21);
            this.Section_comboBox.TabIndex = 3;
            // 
            // FIOInstructor_label
            // 
            this.FIOInstructor_label.AutoSize = true;
            this.FIOInstructor_label.Location = new System.Drawing.Point(62, 23);
            this.FIOInstructor_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FIOInstructor_label.Name = "FIOInstructor_label";
            this.FIOInstructor_label.Size = new System.Drawing.Size(34, 13);
            this.FIOInstructor_label.TabIndex = 4;
            this.FIOInstructor_label.Text = "ФИО";
            // 
            // Qualification_label
            // 
            this.Qualification_label.AutoSize = true;
            this.Qualification_label.Location = new System.Drawing.Point(12, 53);
            this.Qualification_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Qualification_label.Name = "Qualification_label";
            this.Qualification_label.Size = new System.Drawing.Size(82, 13);
            this.Qualification_label.TabIndex = 5;
            this.Qualification_label.Text = "Квалификация";
            // 
            // PhoneNumberInstructor_label
            // 
            this.PhoneNumberInstructor_label.AutoSize = true;
            this.PhoneNumberInstructor_label.Location = new System.Drawing.Point(1, 84);
            this.PhoneNumberInstructor_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneNumberInstructor_label.Name = "PhoneNumberInstructor_label";
            this.PhoneNumberInstructor_label.Size = new System.Drawing.Size(93, 13);
            this.PhoneNumberInstructor_label.TabIndex = 6;
            this.PhoneNumberInstructor_label.Text = "Номер телефона";
            // 
            // Section_label
            // 
            this.Section_label.AutoSize = true;
            this.Section_label.Location = new System.Drawing.Point(50, 115);
            this.Section_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Section_label.Name = "Section_label";
            this.Section_label.Size = new System.Drawing.Size(44, 13);
            this.Section_label.TabIndex = 7;
            this.Section_label.Text = "Секция";
            // 
            // Add_Instructor_button
            // 
            this.Add_Instructor_button.Location = new System.Drawing.Point(29, 162);
            this.Add_Instructor_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_Instructor_button.Name = "Add_Instructor_button";
            this.Add_Instructor_button.Size = new System.Drawing.Size(64, 24);
            this.Add_Instructor_button.TabIndex = 8;
            this.Add_Instructor_button.Text = "Добавить";
            this.Add_Instructor_button.UseVisualStyleBackColor = true;
            this.Add_Instructor_button.Click += new System.EventHandler(this.Add_Instructor_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(127, 162);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(64, 24);
            this.Cancel_button.TabIndex = 9;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // AddInstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 214);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Add_Instructor_button);
            this.Controls.Add(this.Section_label);
            this.Controls.Add(this.PhoneNumberInstructor_label);
            this.Controls.Add(this.Qualification_label);
            this.Controls.Add(this.FIOInstructor_label);
            this.Controls.Add(this.Section_comboBox);
            this.Controls.Add(this.Qualification_comboBox);
            this.Controls.Add(this.PhoneNumber_textBox);
            this.Controls.Add(this.FIO_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInstructorForm";
            this.Text = "Добавить тренера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FIO_textBox;
        private System.Windows.Forms.MaskedTextBox PhoneNumber_textBox;
        private System.Windows.Forms.ComboBox Qualification_comboBox;
        private System.Windows.Forms.ComboBox Section_comboBox;
        private System.Windows.Forms.Label FIOInstructor_label;
        private System.Windows.Forms.Label Qualification_label;
        private System.Windows.Forms.Label PhoneNumberInstructor_label;
        private System.Windows.Forms.Label Section_label;
        private System.Windows.Forms.Button Add_Instructor_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}