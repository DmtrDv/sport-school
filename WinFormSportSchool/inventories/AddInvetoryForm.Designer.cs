namespace WinFormSportSchool.inventories
{
    partial class AddInvetoryForm
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
            this.ok_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Count_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DateDelivery_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Count_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.ok_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ok_button.Location = new System.Drawing.Point(124, 108);
            this.ok_button.Margin = new System.Windows.Forms.Padding(2);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(70, 25);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "Добавить";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(212)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(212)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(258, 108);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата поставки";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_textBox.Location = new System.Drawing.Point(124, 11);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(204, 21);
            this.Name_textBox.TabIndex = 5;
            // 
            // Count_numericUpDown
            // 
            this.Count_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_numericUpDown.Location = new System.Drawing.Point(124, 37);
            this.Count_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.Count_numericUpDown.Name = "Count_numericUpDown";
            this.Count_numericUpDown.Size = new System.Drawing.Size(204, 21);
            this.Count_numericUpDown.TabIndex = 6;
            // 
            // DateDelivery_dateTimePicker
            // 
            this.DateDelivery_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateDelivery_dateTimePicker.Location = new System.Drawing.Point(124, 63);
            this.DateDelivery_dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DateDelivery_dateTimePicker.Name = "DateDelivery_dateTimePicker";
            this.DateDelivery_dateTimePicker.Size = new System.Drawing.Size(204, 21);
            this.DateDelivery_dateTimePicker.TabIndex = 7;
            // 
            // AddInvetoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 150);
            this.ControlBox = false;
            this.Controls.Add(this.DateDelivery_dateTimePicker);
            this.Controls.Add(this.Count_numericUpDown);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ok_button);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInvetoryForm";
            this.Text = "Добавить инвентарь";
            ((System.ComponentModel.ISupportInitialize)(this.Count_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.NumericUpDown Count_numericUpDown;
        private System.Windows.Forms.DateTimePicker DateDelivery_dateTimePicker;
    }
}