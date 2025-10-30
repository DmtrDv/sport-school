namespace WinFormSportSchool
{
    partial class AddTraineeForm
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
            this.FIO_label = new System.Windows.Forms.Label();
            this.DateBirthday_label = new System.Windows.Forms.Label();
            this.Section_label = new System.Windows.Forms.Label();
            this.Category_label = new System.Windows.Forms.Label();
            this.FIOParent_label = new System.Windows.Forms.Label();
            this.PhoneNumberParent_label = new System.Windows.Forms.Label();
            this.DateBirthday_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Section_comboBox = new System.Windows.Forms.ComboBox();
            this.Category_comboBox = new System.Windows.Forms.ComboBox();
            this.FIO_textBox = new System.Windows.Forms.TextBox();
            this.FIOParent_textBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberParent_textBox = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIO_label
            // 
            this.FIO_label.AutoSize = true;
            this.FIO_label.Location = new System.Drawing.Point(91, 12);
            this.FIO_label.Name = "FIO_label";
            this.FIO_label.Size = new System.Drawing.Size(38, 16);
            this.FIO_label.TabIndex = 1;
            this.FIO_label.Text = "ФИО";
            // 
            // DateBirthday_label
            // 
            this.DateBirthday_label.AutoSize = true;
            this.DateBirthday_label.Location = new System.Drawing.Point(23, 37);
            this.DateBirthday_label.Name = "DateBirthday_label";
            this.DateBirthday_label.Size = new System.Drawing.Size(106, 16);
            this.DateBirthday_label.TabIndex = 2;
            this.DateBirthday_label.Text = "День рождения";
            // 
            // Section_label
            // 
            this.Section_label.AutoSize = true;
            this.Section_label.Location = new System.Drawing.Point(75, 68);
            this.Section_label.Name = "Section_label";
            this.Section_label.Size = new System.Drawing.Size(54, 16);
            this.Section_label.TabIndex = 3;
            this.Section_label.Text = "Секция";
            // 
            // Category_label
            // 
            this.Category_label.AutoSize = true;
            this.Category_label.Location = new System.Drawing.Point(74, 98);
            this.Category_label.Name = "Category_label";
            this.Category_label.Size = new System.Drawing.Size(55, 16);
            this.Category_label.TabIndex = 4;
            this.Category_label.Text = "Разряд";
            // 
            // FIOParent_label
            // 
            this.FIOParent_label.AutoSize = true;
            this.FIOParent_label.Location = new System.Drawing.Point(26, 125);
            this.FIOParent_label.Name = "FIOParent_label";
            this.FIOParent_label.Size = new System.Drawing.Size(103, 16);
            this.FIOParent_label.TabIndex = 5;
            this.FIOParent_label.Text = "ФИО родителя";
            // 
            // PhoneNumberParent_label
            // 
            this.PhoneNumberParent_label.AutoSize = true;
            this.PhoneNumberParent_label.Location = new System.Drawing.Point(-3, 156);
            this.PhoneNumberParent_label.Name = "PhoneNumberParent_label";
            this.PhoneNumberParent_label.Size = new System.Drawing.Size(132, 16);
            this.PhoneNumberParent_label.TabIndex = 6;
            this.PhoneNumberParent_label.Text = "Телефон родителя";
            // 
            // DateBirthday_dateTimePicker
            // 
            this.DateBirthday_dateTimePicker.Location = new System.Drawing.Point(135, 37);
            this.DateBirthday_dateTimePicker.Name = "DateBirthday_dateTimePicker";
            this.DateBirthday_dateTimePicker.Size = new System.Drawing.Size(166, 22);
            this.DateBirthday_dateTimePicker.TabIndex = 7;
            // 
            // Section_comboBox
            // 
            this.Section_comboBox.FormattingEnabled = true;
            this.Section_comboBox.Location = new System.Drawing.Point(135, 65);
            this.Section_comboBox.Name = "Section_comboBox";
            this.Section_comboBox.Size = new System.Drawing.Size(166, 24);
            this.Section_comboBox.TabIndex = 9;
            // 
            // Category_comboBox
            // 
            this.Category_comboBox.FormattingEnabled = true;
            this.Category_comboBox.Location = new System.Drawing.Point(135, 95);
            this.Category_comboBox.Name = "Category_comboBox";
            this.Category_comboBox.Size = new System.Drawing.Size(166, 24);
            this.Category_comboBox.TabIndex = 10;
            // 
            // FIO_textBox
            // 
            this.FIO_textBox.Location = new System.Drawing.Point(135, 9);
            this.FIO_textBox.Name = "FIO_textBox";
            this.FIO_textBox.Size = new System.Drawing.Size(166, 22);
            this.FIO_textBox.TabIndex = 11;
            // 
            // FIOParent_textBox
            // 
            this.FIOParent_textBox.Location = new System.Drawing.Point(135, 125);
            this.FIOParent_textBox.Name = "FIOParent_textBox";
            this.FIOParent_textBox.Size = new System.Drawing.Size(166, 22);
            this.FIOParent_textBox.TabIndex = 12;
            // 
            // PhoneNumberParent_textBox
            // 
            this.PhoneNumberParent_textBox.Location = new System.Drawing.Point(135, 153);
            this.PhoneNumberParent_textBox.Name = "PhoneNumberParent_textBox";
            this.PhoneNumberParent_textBox.Size = new System.Drawing.Size(166, 22);
            this.PhoneNumberParent_textBox.TabIndex = 13;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(29, 214);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(86, 23);
            this.Add_button.TabIndex = 14;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(135, 214);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 15;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // AddTraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 251);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.PhoneNumberParent_textBox);
            this.Controls.Add(this.FIOParent_textBox);
            this.Controls.Add(this.FIO_textBox);
            this.Controls.Add(this.Category_comboBox);
            this.Controls.Add(this.Section_comboBox);
            this.Controls.Add(this.DateBirthday_dateTimePicker);
            this.Controls.Add(this.PhoneNumberParent_label);
            this.Controls.Add(this.FIOParent_label);
            this.Controls.Add(this.Category_label);
            this.Controls.Add(this.Section_label);
            this.Controls.Add(this.DateBirthday_label);
            this.Controls.Add(this.FIO_label);
            this.Name = "AddTraineeForm";
            this.Text = "Добавление ученика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FIO_label;
        private System.Windows.Forms.Label DateBirthday_label;
        private System.Windows.Forms.Label Section_label;
        private System.Windows.Forms.Label Category_label;
        private System.Windows.Forms.Label FIOParent_label;
        private System.Windows.Forms.Label PhoneNumberParent_label;
        private System.Windows.Forms.DateTimePicker DateBirthday_dateTimePicker;
        private System.Windows.Forms.ComboBox Section_comboBox;
        private System.Windows.Forms.ComboBox Category_comboBox;
        private System.Windows.Forms.TextBox FIO_textBox;
        private System.Windows.Forms.TextBox FIOParent_textBox;
        private System.Windows.Forms.TextBox PhoneNumberParent_textBox;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}